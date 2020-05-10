using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

namespace AppReseauSocial
{
    public partial class FrmPrincipal : Form
    {
        public const string APP_INFOS = "Nom et prénom";

        public List<Membre> ColNonAmi { get; private set; } // collection des membres qui ne sont pas encore amis avec le membre courant

        public RéseauSocial LeRéseauSocial { get; }

        #region Propriété
        //=====================================================================================
        //Obtient le membre courant
        public Membre MembreCourant
        {
            get
            {
                if (cboMembres.SelectedIndex != -1 && cboMembres.SelectedIndex < LeRéseauSocial.ColMembres.Count)
                    return LeRéseauSocial.ColMembres[cboMembres.SelectedIndex];
                else
                    return null;
            }
        }
        #endregion 

         #region Constructeur
        //=====================================================================================
        public FrmPrincipal()
        {
            InitializeComponent();
            //-------------------------------
            Text += APP_INFOS;

            LeRéseauSocial = new RéseauSocial();

            PeuplerComboMembres();
            PeuplerCheckListBoxGroupes();

            cboMembres.SelectedIndex = 0;
        }
        #endregion

        #region PeuplerComboMembres et PeuplerCheckListBoxGroupes();
        //=====================================================================================
        /// <summary>
        /// Peuple cboMembres avec les noms des membres du réseau social
        /// </summary>
        private void PeuplerComboMembres()
        {
            cboMembres.Items.Clear();
            foreach (Membre membre in LeRéseauSocial.ColMembres)
            {
                cboMembres.Items.Add(membre.Nom);
            }
        }
        //=====================================================================================
        /// <summary>
        /// TODO FP01 : Peuple la checkedListBox clbGroupes avec les noms des groupes du réseau social
        /// </summary>
        private void PeuplerCheckListBoxGroupes()
        {
            // À COMPLÉTER...

        }
        #endregion

        #region AfficherAmisNonAmi
        //=====================================================================================
        private void AfficherAmisNonAmis()
        {
            // Affiche la liste des amis et la liste des non amis
            btnSupprimerAmi.Enabled = false;
            RéseauSocial.AfficherUneListeDeMembres(lsvAmis, MembreCourant.ColAmis);

            ColNonAmi = LeRéseauSocial.ObtenirLesNonAmi(MembreCourant);
            RéseauSocial.AfficherUneListeDeMembres(lsvNonAmi, ColNonAmi);
        }
        #endregion

        #region Événement : cboMembres_SelectedIndexChanged
        //=====================================================================================
        /// <summary>
        /// Affiche les informations du membre courant
        /// Affiche les membres qui ne sont pas des amis/amies du membre courant
        /// Affiche les groupes auxquels appartient le membre en cochant l'item de clbGroupes(la CheckedListBox)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboMembres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMembres.SelectedIndex != -1)
            {
                // Affiche les information du membre courant
                picMembreCourant.Image = MembreCourant.Photo;
                lblAge.Text = MembreCourant.Age.ToString();
                lblGroupes.Text = MembreCourant.Nom + " est membre des groupes :";
                AfficherAmisNonAmis();
                AfficherLesGroupesDuMembreCourant();
            }
            else
            {
                picMembreCourant.Image = null;
                lblAge.Text = "";
            }
        }
        #endregion

        #region Événement : lsvNonAmis_DoubleClick (ajoute d'amis)
        //=====================================================================================
        /// <summary>
        /// TODO FP02 : Ajoute le membre sélectionné aux amis/amies du membre courant
        /// Ajoute le membre courant aux amis/amies du membre sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lsvNonAmis_DoubleClick(object sender, EventArgs e)
        {
            if (MembreCourant != null)
            {
                // À COMPLÉTER...

            }
        }
        #endregion

        #region Événement : lsvAmis_DoubleClick (change le membre courant)
        //=====================================================================================
        /// <summary>
        /// Le membre sélectionné devient le membre courant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lsvAmis_DoubleClick(object sender, EventArgs e)
        {
            btnSupprimerAmi.Enabled = false;
            string nomDuMembre = lsvAmis.SelectedItems[0].Text.Split('\n')[0];
            cboMembres.Text = nomDuMembre;
        }
        #endregion

        #region Événement : lsvAmis_SelectedIndexChanged (Active/désactive btnSupprimerAmi)
        //=====================================================================================

        private void lsvAmis_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSupprimerAmi.Enabled = lsvAmis.SelectedIndices.Count > 0;
        }
        #endregion

        #region Événement : btnSupprimerAmi_Click (suppression d'amis/amies)
        //=====================================================================================
        /// <summary>
        /// Supprime le membre sélelectionné des amis/amies du membre courant
        /// Supprime le membre courant des amis/amies du membre sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimerAmi_Click(object sender, EventArgs e)
        {
            if (MembreCourant != null)
            {
                int selectedIndex = lsvAmis.SelectedIndices[0];

                Membre membreAmi = MembreCourant.ColAmis[selectedIndex];
                MembreCourant.ColAmis.Remove(membreAmi);
                membreAmi.ColAmis.Remove(MembreCourant);

                AfficherAmisNonAmis();
            }
        }
        #endregion

        #region Événements : FrmPrincipal_FormClosing,mnuFichierQuitter_Click et mnuAdminListeAmitiés_Click
        //=====================================================================================
        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            LeRéseauSocial.Enregistrer();
        }
        //=====================================================================================
        private void mnuFichierQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
        //=====================================================================================
        /// <summary>
        /// TODO FP04 : Instancie le formulaire FrmListeDesGroupes en passant m_réseauSocial en paramétre
        /// Affiche le formulaire
        /// Affiche les groupes du membre courant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuAdminGestionGroupes_Click(object sender, EventArgs e)
        {
            // À COMPLÉTER...

        }
        #endregion

        #region AfficherLesGroupesDuMembreCourant
        //=====================================================================================
        /// <summary>
        /// TODO FP03 : Utilise clbGroupes (CheckedListBox) pour marquer (cocher) les groupes auxquels appartient le membre courant
        /// </summary>
        private void AfficherLesGroupesDuMembreCourant()
        {
            if (MembreCourant != null)
            {
                // À COMPLÉTER...

            }
        }
        #endregion

        #region Événement : clbGroupes_SelectedIndexChanged
        //=====================================================================================
        /// <summary>
        /// Ajoute/supprime un membre du groupe sélectionné dans la clbGroupes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clbGroupes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 
            if (clbGroupes.SelectedIndex != -1 && MembreCourant != null)
            {
                string nomDuGroupe = clbGroupes.SelectedItem.ToString();
                bool actuellementMembreDuGroupe = LeRéseauSocial.MembreEstDansGroupe(MembreCourant, nomDuGroupe);
                bool etatCaseACocher = clbGroupes.GetItemChecked(clbGroupes.SelectedIndex);
                Groupe groupeSélectionné = LeRéseauSocial.ColGroupes[clbGroupes.SelectedIndex];

                // la case est cochée actuellement et le membre n'est pas dans le groupe
                if (etatCaseACocher && !actuellementMembreDuGroupe) 
                { // dans ce cas il faut ajouter le membre dans le groupe
                    groupeSélectionné.ColMembres.Add(MembreCourant);
                }
                if (!etatCaseACocher && actuellementMembreDuGroupe)
                {
                    groupeSélectionné.ColMembres.Remove(MembreCourant);
                }
            }

        }
        #endregion

        #region Questions
        private void mnuQuestionsQ1_Click(object sender, EventArgs e)
        {
            // TODO Q01: Afficher le nombre de membres dans le réseau social
            // À compléter
        }

        private void mnuQuestionsQ2_Click(object sender, EventArgs e)
        {
            // TODO Q02: Afficher le nombre de groupes dans le réseau social
            // À compléter
        }

        private void mnuQuestionsQ3_Click(object sender, EventArgs e)
        {
            // TODO Q03: Afficher le nombre de membres femme dans le réseau social
            // À compléter

        }

        private void mnuQuestionsQ4_Click(object sender, EventArgs e)
        {
            // TODO Q04: Afficher le nombre de membres nés entre 1980 et 1990 inclusivement
            // À compléter

        }

        private void mnuQuestionsQ5_Click(object sender, EventArgs e)
        {
            // TODO Q05: Afficher par programmation les noms des groupes du réseau social
            // À compléter

        }

        private void mnuQuestionsQ6_Click(object sender, EventArgs e)
        {
            // TODO Q06: Afficher le nom de tous les membres du groupe "Hockey"
            // Vous devez utiliser la méthode ObtenirUnGroupeParSonNom
            // À compléter

        }

        private void mnuQuestionsQ7_Click(object sender, EventArgs e)
        {
            // TODO Q007: Afficher le nom des 5 premières femmes membres du réseau social
            // À compléter

        }

        private void mnuQuestionsQ8_Click(object sender, EventArgs e)
        {
            // TODO Q08: Afficher le nom et la date de naissance du membre le plus agé du groupe "Hockey"
            // Vous devez utiliser la méthode ObtenirUnGroupeParSonNom(...)
            // À compléter

        }

        private void mnuQuestionsQ9_Click(object sender, EventArgs e)
        {
            // TODO Q09: Afficher les noms des amis du dernier membre du réseau social
            // À compléter

        }

        private void mnuQuestionsQ10_Click(object sender, EventArgs e)
        {
            // TODO Q10: Afficher les noms des amis du premier membre du groupe "Hockey"
            //Vous devez utiliser la méthode ObtenirUnGroupeParSonNom(...)
            // À compléter

        }

        private void mnuQuestionsQ11_Click(object sender, EventArgs e)
        {
            // TODO Q11: Afficher les noms et dates de création des groupes auquel appartient le membre courant
            // À compléter

        }

        private void mnuQuestionsQ12_Click(object sender, EventArgs e)
        {
            // TODO Q12: Afficher les noms des amis communs de "Brad Pitt" et "Ali Astin"
            // Vous devez utiliser la méthode ObtenirUnMembreParSonNom(...)
            // À compléter

        }
        #endregion 
    }
}