using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBD.MySQL
{
    public class GestionFournisseur
    {
        
        /// <summary>
        /// Retourne la liste de tous les fournisseur
        /// </summary>
        /// <returns></returns>
        public static DataTable getTuples()
        {
            return GestionBoutique.getTuplesRequeteSelect("CALL GetFournisseur();", "GetFournisseur");    
        }


        /// <summary>
        /// Retourne le nombre de fournisseur
        /// </summary>
        /// <returns></returns>
        public static int getNbTuples()
        {
            return Convert.ToInt16(GestionBoutique.getResultatRequeteScalaire("select count(*) from fournisseur"));
        }


        /// <summary>
        /// Ajouter un fournisseur
        /// </summary>
        /// <param name="nom">Nom du fournisseur</param>
        /// <param name="rue">Rue du fournisseur</param>
        /// <param name="cp">Code postal du fournisseur</param>
        /// <param name="ville">Ville du fournisseur</param>
        /// <param name="tel">Telephone du fournisseur</param>
        /// <param name="email">email du fournisseur</param>
        public static void ajouter(string nom, string rue,int cp,string ville, string tel, string email)
        {
            GestionBoutique.executerRequeteAction("INSERT INTO fournisseur (nom, rue, codePostal, ville, tel, email) VALUES ('"+nom+"', '"+rue+"', "+cp+", '"+ville+"', '"+tel+"', '"+email+"');");
        }

        /// <summary>
        /// Modifier un fournisseur
        /// </summary>
        /// <param name="id">Idantifiant du fournisseur</param>
        /// <param name="nom">Nom du fournisseur</param>
        /// <param name="rue">Rue du fournisseur</param>
        /// <param name="cp">Code postal du fournisseur</param>
        /// <param name="ville">Ville du fournisseur</param>
        /// <param name="tel">Telephone du fournisseur</param>
        /// <param name="email">email du fournisseur</param>
        public static void modifier(int id, string nom, string rue, int cp, string ville, string tel, string email)
        {
            GestionBoutique.executerRequeteAction("UPDATE fournisseur SET nom = '" + nom + "',rue = '" + rue + "',codePostal = " + cp + ",ville='" + ville + "',tel='" + tel + "',email='" + email + "' WHERE id =" + id);
        }

        /// <summary>
        /// Supprimer un fournisseur
        /// </summary>
        /// <param name="id">Identifiant du fournisseur à supprimer</param>
        public static void supprimer(int id)
        {
            GestionBoutique.executerRequeteAction("DELETE FROM fournisseur WHERE id =" + id);
        }

        /// <summary>
        /// Recherche de mot dans la table
        /// </summary>
        /// <param name="mot">mot a rechercher dans la table</param>
        /// <returns></returns>
        public static DataTable searchFournisseur(string mot)
        {
            return GestionBoutique.getTuplesRequeteSelect("CALL RechercheFournisseur('" + mot + "');", "RechercheFournisseur");
        }
    }
}
