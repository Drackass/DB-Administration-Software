using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBD.MySQL
{
    public class GestionCategorie
    {
        
        /// <summary>
        /// Retourne la liste de toutes les categories
        /// </summary>
        /// <returns></returns>
        public static DataTable getTuples()
        {
            return GestionBoutique.getTuplesRequeteSelect("CALL GetCategorie();", "GetCategorie");    
        }


        /// <summary>
        /// Retourne le nombre de categorie
        /// </summary>
        /// <returns></returns>
        public static int getNbTuples()
        {
            return Convert.ToInt16(GestionBoutique.getResultatRequeteScalaire("select count(*) from categorie"));
        }

        public static void ajouter(string libelle)
        {
            GestionBoutique.executerRequeteAction("INSERT INTO categorie (libelle) VALUES ('"+libelle+"');");
        }

        /// <summary>
        /// Modifier une categorie
        /// </summary>
        /// <param name="id">identifiant de la categorie a modifier</param>
        /// <param name="libelle">libelle de la categorie</param>
        public static void modifier(int id, string libelle)
        {
            GestionBoutique.executerRequeteAction("UPDATE categorie SET libelle = '"+libelle+"' WHERE id = " + id);
        }

        /// <summary>
        /// Supprimer une categorie
        /// </summary>
        /// <param name="id">Identifiant de la categorie à supprimer</param>
        public static void supprimer(int id)
        {
            // Remarque : Si l'on veut que la suppression supprime aussi les commandes et lignesCommandes associées
            // Il faut alors ajouter sur les clés étrangères "ON DELETE CASCADE"

            GestionBoutique.executerRequeteAction("DELETE FROM categorie WHERE id =" + id);
        }

        /// <summary>
        /// Recherche de mot dans la table
        /// </summary>
        /// <param name="mot">mot a rechercher dans la table</param>
        /// <returns></returns>
        public static DataTable searchCategorie(string mot)
        {
            return GestionBoutique.getTuplesRequeteSelect("CALL RechercheCategorie('"+mot+"');", "RechercheCategorie");
        }

    }
}
