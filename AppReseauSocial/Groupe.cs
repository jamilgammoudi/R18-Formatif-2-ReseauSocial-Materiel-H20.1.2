using System;
using System.Collections.Generic;

namespace AppReseauSocial
{
    /// <summary>
    /// Réprésente un groupe de membres abonnés pour un sujet donné
    /// </summary>
    public class Groupe
    {
        #region Propriétés
 
        /// <summary>
        /// Obtient le nom du groupe.
        /// </summary>
        public string Nom { get; }

        /// <summary>
        /// Obtient la date de création du groupe.
        /// </summary>
        public DateTime DateDeCréation { get; }

        /// <summary>
        /// Obtient la collection des membres du groupe
        /// </summary>
        public List<Membre> ColMembres { get; }

        #endregion

        #region champs privé temporaire
        /// ===============================================================================================
        //Chaine composée des noms des membres faisant partie du groupe séparés par des virgules
        private string m_chaineMembres = "";
        public string ChaineMembres { get { return m_chaineMembres; } }
        #endregion

        #region Constructeurs
        /// <summary>
        /// Initialise un groupe avec  la chaîne passée en paramètre.
        /// Les données sont séparées par une "|" voici un exemple:
        ///              Cuisine|2010-01-12 22:25:30|Ali Astin,Ana de Armas,Anne Hathaway
        /// La dernière chaine est composée des noms des membres du groupe            
        /// </summary>
        /// <param name="pChaineLue">chaine des données séparées par une |</param>
        public Groupe (string pInfosLigneLue)
        {
            string[] tabInfos = pInfosLigneLue.Split('|');
            Nom = tabInfos[0];
            DateDeCréation = DateTime.Parse(tabInfos[1]);
            m_chaineMembres = tabInfos[2];
            ColMembres = new List<Membre>();
        }
        ///===============================================================================================
        /// <summary>
        /// Initialise un groupe 
        /// </summary>
        /// <param name="pNom">nom du groupe</param>
        /// <param name="pDateCréation">date de création du groupe</param>
        public Groupe(string pNom,DateTime pDateCréation)
        {
            Nom = pNom;
            DateDeCréation = pDateCréation;
            m_chaineMembres = "";
            ColMembres = new List<Membre>();                        
        }
        #endregion

        #region ToString
        ///===============================================================================================
        /// <summary>
        /// Obtient une chaine composée des informations du groupe
        /// </summary>
        /// <returns>Une chaine comprenant toutes les information du groupe séparées par une | </returns>
        public override string ToString()
        {
            string chaineMembres = "";
            foreach (Membre membre in ColMembres)
            {
                chaineMembres += membre.Nom + ",";
            }
            if (ColMembres.Count > 0)
                chaineMembres = chaineMembres.Substring(0, chaineMembres.Length - 1);

            return Nom + "|" + DateDeCréation.ToString("yyyy-MM-dd HH:mm:ss") + "|" + chaineMembres;
        }
        #endregion

    }
}
