using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AppReseauSocial
{
    /// <summary>
    /// Modélise un petit réseau social. Soit une liste de membres avec des amis/amies
    /// ainsi qu'une liste de groupes auxquels les membres peuvent s'abonner.
    /// </summary>
    public class RéseauSocial
    {
        #region Propriétés
        /// <summary>
        /// Obtient la collection de tous les membres du réseau social
        /// </summary>
        public List<Membre> ColMembres { get; }

        /// <summary>
        /// Obtient la collection des groupes du réseau social
        /// </summary>
        public List<Groupe> ColGroupes { get; }
        #endregion

        #region Constructeur
        /// <summary>
        /// Initialise un RéseauSocial en peuplant les collections m_colMembres et m_colGroupes
        /// Ajoute les références aux amis de chaque membre de m_colMembres
        /// Ajoute les références aux membres (abonnés) de chaque groupe de m_colGroupes
        /// </summary>
        public RéseauSocial()
        {
            ColMembres = new List<Membre>();
            ChargerMembres();
            
            ColGroupes = new List<Groupe>();
            ChargerGroupes();

            foreach (Membre membre in ColMembres)
                RéférencerLesAmisDunMembre(membre);

            foreach (Groupe groupe in ColGroupes)
                RéférencerLesMembresDuGroupe(groupe);
        }
        #endregion

        #region ChargerMembres et ChargerGroupes
        //=====================================================================================
        /// <summary>
        /// Peuple la collection m_colMembres de membres instantiés à partir de données lues dans le fichier "Membres.txt"
        /// </summary>
        private void ChargerMembres()
        {
            StreamReader objFichier = new StreamReader("Membres.txt");
            while (!objFichier.EndOfStream)
            {
                Membre membre = new Membre(objFichier.ReadLine());
                ColMembres.Add(membre);
            }
            objFichier.Close();
        }
        //=====================================================================================
        /// <summary>
        /// Peuple la collection m_colGroupes de groupes instantiés à partir de données lues dans le fichier "Groupes.txt"
        /// </summary>

        private void ChargerGroupes()
        {
            ColGroupes.Clear();
            StreamReader objFichier = new StreamReader("Groupes.txt");
            while (!objFichier.EndOfStream)
            {
                Groupe groupe = new Groupe(objFichier.ReadLine());
                ColGroupes.Add(groupe);
            }
            objFichier.Close();
        }
        #endregion

        #region Enregistrer les Membres et les Groupes
        //=====================================================================================
        /// <summary>
        /// Enregistre toutes les informations nécessaires au fonctionnement du RéseauSocial
        /// </summary>
        public void Enregistrer()
        {
            EnregistrerMembres();
            EnregistrerGroupes();
        }
        //=====================================================================================
        /// <summary>
        /// Enregistre chacun des membres du réseau social
        /// </summary>
        private void EnregistrerMembres()
        {
            StreamWriter objFichier = new StreamWriter("Membres.txt");
            foreach (Membre membre in ColMembres)
                objFichier.WriteLine(membre.ToString());
            objFichier.Close();
        }
        //=====================================================================================
        /// <summary>
        /// Enregistre chacun des groupes du réseau social
        /// </summary>
        private void EnregistrerGroupes()
        {
            StreamWriter objFichier = new StreamWriter("Groupes.txt");
            foreach (Groupe groupe in ColGroupes)
                objFichier.WriteLine(groupe.ToString());
            objFichier.Close();
        }
        #endregion

        #region MembreEstDansGroupe
        //=====================================================================================
        /// <summary>
        /// Obtient un groupe par son nom dans la collection m_colGroupes
        /// </summary>
        /// <param name="pNomDuGroupe">nom du groupe recherché</param>
        /// <returns></returns>
        public Groupe ObtenirUnGroupeParSonNom(string pNomDuGroupe)
        {
            foreach (Groupe groupe in ColGroupes)
            {
                if (groupe.Nom == pNomDuGroupe)
                    return groupe;
            }
            return null;
        }
        //=====================================================================================
        /// <summary>
        /// TODO RS01 : Vérifie si un membre est abonné à un groupe donné
        /// </summary>
        /// <param name="pMembre">membre rechercher</param>
        /// <param name="pNomDuGroupe">nom du groupe dans lequel on recherche le membre</param>
        /// <returns>True si le membre est abonné au groupe, false autrement</returns>
        public bool MembreEstDansGroupe(Membre pMembre, string pNomDuGroupe)
        {
            // À COMPLÉTER...

            return false;
        }
        #endregion

        #region ObtenirLesNonAmi
        //=====================================================================================
        /// <summary>
        /// TODO RS02 : Obtient la collection des membres du réseau social qui ne sont pas des amis d'un membre passé en paramétre
        /// </summary>
        /// <param name="pMembre">un membre </param>
        /// <returns></returns>
        public List<Membre> ObtenirLesNonAmi(Membre pMembre)
        {
            // À COMPLÉTER...

            return null;
        }
        #endregion

        #region ObtenirUnMembreParSonNom
        //=====================================================================================
        /// <summary>
        /// Obtient par son nom, un membre du réseau social.
        /// </summary>
        /// <param name="pNomDuMembre">nom du membre à obtenir</param>
        /// <returns></returns>
        public Membre ObtenirUnMembreParSonNom(string pNomDuMembre)
        {
            foreach (Membre membre in ColMembres)
                if (membre.Nom == pNomDuMembre)
                    return membre;
            return null;
        }
        #endregion 

        #region RéférencerLesMembres et RéférencerLesAmis
        /// <summary>
        /// Référence les membres du groupe passé en paramètre
        /// </summary>
        /// <param name="pGroupe">Groupe à traiter</param>
        public void RéférencerLesMembresDuGroupe(Groupe pGroupe)
        {
            if (pGroupe.ChaineMembres.Length == 0) return;

            string[] tabChaineMembres = pGroupe.ChaineMembres.Split(',');
            foreach (string nomMembre in tabChaineMembres)
            {
                Membre unMembreDansCeGroupe = ObtenirUnMembreParSonNom(nomMembre);
                pGroupe.ColMembres.Add(unMembreDansCeGroupe);
            }
        }
        /// <summary>
        /// Référence les membres amis du membre passé en paramètre
        /// </summary>
        /// <param name="pMembre">Membre à traiter</param>
        public void RéférencerLesAmisDunMembre(Membre pMembre)
        {
            if (pMembre.ChaineAmis.Length == 0) return;

            string[] tabChaineAmis = pMembre.ChaineAmis.Split(',');
            foreach (string nomMembre in tabChaineAmis)
            {
                Membre unMembreDansMesAmis = ObtenirUnMembreParSonNom(nomMembre);
                pMembre.ColAmis.Add(unMembreDansMesAmis);
            }
        }
        #endregion

        #region Méthode utilitaire pour les formulaires : AfficherUneListeDeMembres
        //=====================================================================================
        /// <summary>
        /// Affiche une collection de membre dans un ListView
        /// </summary>
        /// <param name="pListView"></param>
        /// <param name="pListeMembres"></param>
        public static void AfficherUneListeDeMembres(ListView pListView, List<Membre> pListeMembres)
        {
            if (pListeMembres == null) return;

            pListView.BeginUpdate();
            pListView.Items.Clear();

            ImageList imageListLarge = new ImageList();
            imageListLarge.ImageSize = new Size(64, 96);
            imageListLarge.ColorDepth = ColorDepth.Depth32Bit;

            for (int index = 0; index < pListeMembres.Count; index++)
            {
                Membre membreCourant = pListeMembres[index];
                imageListLarge.Images.Add(membreCourant.Photo);
                pListView.Items.Add(new ListViewItem(membreCourant.Nom + "\n" + membreCourant.Age, index));
            }

            pListView.LargeImageList = imageListLarge;
            pListView.EndUpdate();
        }
        #endregion
    }
}
