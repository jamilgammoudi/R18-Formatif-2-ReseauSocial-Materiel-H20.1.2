using System;
using System.Collections.Generic;
using System.Drawing;

namespace AppReseauSocial
{
    /// ===============================================================================================
    /// <summary>
    /// Représente un membre dans un réseau social.
    /// </summary>
    public class Membre
    {
        #region Propriétés

        /// <summary>
        /// Obtient le genre du  membre (H ou F).
        /// </summary>
        public char Genre { get; }

        /// <summary>
        /// Obtient la valeur de m_estCélibataire (true/false) du  membre
        /// </summary>
        public bool EstCélibataire { get; }

        /// <summary>
        /// Obtient le nom d'un  membre.
        /// </summary>
        public string Nom { get; }

        /// <summary>
        /// Obtient la date de naissance d'un  membre.
        /// </summary>
        public DateTime DateNaissance { get; }

        /// <summary>
        /// Obtient la photo d'un  membre.
        /// </summary>
        public Image Photo { get; }

        /// <summary>
        /// Obtient l'age d'un  membre.
        /// </summary>
        public int Age
        {
            get
            {
                return (int)((DateTime.Now - DateNaissance).TotalDays / 365.25);
            }
        }

        /// <summary>
        /// Obtient la collection des amis/amies du membre
        /// </summary>
        public List<Membre> ColAmis { get; }

        #endregion

        #region champs privé temporaire
        //Chaine composée des noms des amis/amies du membre
        private string m_chaineAmis = "";
        public string ChaineAmis { get { return m_chaineAmis;  } }
        #endregion

        #region Constructeurs
        /// ===============================================================================================
        /// <summary>
        /// Initialise un membre avec  la chaîne passée en paramètre.
        /// Les données sont séparées par une "|" voici un exemple:
        ///              F|Alexandra Daddario|1986-03-16|True|Aaron Eckhart,Ali Astin,Anne Hathaway
        /// La dernière chaine est composée des noms des amis/amies du membre            
        /// </summary>
        /// <param name="pChaineLue">chaine des données séparées par une "|"</param>
        public Membre(string pChaineLue)
        {
            string[] tabInfos = pChaineLue.Split('|');
            Genre = tabInfos[0][0];
            Nom = tabInfos[1];
            DateNaissance = DateTime.Parse(tabInfos[2]);
            Photo = Image.FromFile("Images\\" + Nom + ".jpg");
            EstCélibataire = bool.Parse(tabInfos[3]);
            m_chaineAmis = tabInfos[4];
            ColAmis = new List<Membre>();
        }
        #endregion

        #region ToString
        /// ===============================================================================================
        /// <summary>
        /// Obtient une chaine composée des informations du membre
        /// </summary>
        /// <returns>Une chaine comprenant toutes les information du membre séparées par une | </returns>
        public override string ToString()
        {
            // On commence par générer une chaîne contenant la liste des amis/amies du membre
            string chaineAmis = "";
            foreach (Membre membre in ColAmis)
            {
                chaineAmis += membre.Nom + ",";
            }
            //Supprimer la dernière virgule
            if (ColAmis.Count > 0)
                chaineAmis = chaineAmis.Substring(0, chaineAmis.Length - 1);

            return Genre + "|" + Nom + "|" + DateNaissance.ToString("yyyy-MM-dd") + "|" + EstCélibataire
                + "|" + chaineAmis;
        }
        #endregion

    }
}
