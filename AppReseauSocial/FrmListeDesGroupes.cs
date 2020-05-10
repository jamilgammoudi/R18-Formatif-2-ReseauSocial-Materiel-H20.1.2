using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

namespace AppReseauSocial
{
    public partial class FrmListeDesGroupes : Form
    {
        private List<Membre> m_colMembresNonAbonné;
        private RéseauSocial m_réseauSocial;

        #region Constructeur
        //=====================================================================================
        public FrmListeDesGroupes(RéseauSocial pRéseauSocial)
        {
            InitializeComponent();
            
            m_réseauSocial = pRéseauSocial;
            PeuplerLeComboDesGroupes();

            cboGroupes.SelectedIndex = 0;
            cboGroupes.Select();
        }
        #endregion

        #region PeuplerLeComboDesGroupes
        //=====================================================================================
        /// <summary>
        /// Peupler le cboGroupes avec les noms des groupes du réseau social
        /// </summary>
        private void PeuplerLeComboDesGroupes()
        {
            foreach(Groupe groupe in m_réseauSocial.ColGroupes)
            {
                cboGroupes.Items.Add(groupe.Nom);
            }
        }
        #endregion

        #region Événement : cboGroupes_SelectedIndexChanged
        //=====================================================================================
        /// <summary>
        /// TODO FG01 : Sélectionne un groupe
        /// Affiche les informations du groupe
        /// Affiche les membres du groupe
        /// Affiche les membres qui ne sont pas dans le groupe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboGroupes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // À COMPLÉTER...

        }
        #endregion

        #region Événement : lsvMembres_DoubleClick (Ajoute le membre sélectionné au groupe courant)
        //=====================================================================================
        /// <summary>
        /// TODO FG02 : Ajoute le membre sélectionné au groupe courant
        /// Affiche les membres du groupe sélectionné
        /// Affiche les membres du réseau social qui ne sont pas dans ce groupe courant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lsvMembres_DoubleClick(object sender, EventArgs e)
        {
            if (lsvMembres.SelectedIndices.Count > 0)
            {
                // À COMPLÉTER...

            }
        }
        #endregion

        #region AfficherLesMembresQuiNeSontPasAbonné
        //=====================================================================================
        /// <summary>
        /// TODO FG03 : Affiche les membres du réseau social qui ne sont pas dans le groupe passé en paramétre
        /// </summary>
        /// <param name="pGroupe">Le groupe </param>
        private void AfficherLesMembresQuiNeSontPasAbonné(Groupe pGroupe)
        {
            // À COMPLÉTER...

        }
        #endregion

        #region Événement : lsvMembresDuGroupe_DoubleClick (Supprime un membre du groupe)
        //=====================================================================================
        /// <summary>
        /// TODO FG04 : Supprime le membre sélectionné du groupe courant
        /// Affiche les membres du groupe sélectionné
        /// Affiche les membres du réseau social qui ne sont pas dans ce groupe courant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lsvMembresDuGroupe_DoubleClick(object sender, EventArgs e)
        {
            if (lsvMembresDuGroupe.SelectedIndices.Count > 0)
            {
                // À COMPLÉTER...

            }
        }
        #endregion

    }
}