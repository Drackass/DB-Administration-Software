using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBD.MySQL
{
    public class GestionCommande
    {
        
        /// <summary>
        /// Retourne la liste de toutes les commandes
        /// </summary>
        /// <returns></returns>
        public static DataTable getTuples()
        {
            return GestionBoutique.getTuplesRequeteSelect("CALL GetCommande();", "GetCommande");    
        }

        /// <summary>
        /// Retourne la liste de toutes les categories avec la traduction en patronyme des clients
        /// </summary>
        /// <returns></returns>
        public static DataTable getTuplesWithPatronymes()
        {
            return GestionBoutique.getTuplesRequeteSelect("SELECT commande.id,commande.date,commande.idClient, CONCAT(UPPER(nom),' ',prenom) AS Patronyme FROM commande,client WHERE(commande.idClient = client.id)", "commande");
        }


        /// <summary>
        /// Retourne le nombre de commande
        /// </summary>
        /// <returns></returns>
        public static int getNbTuples()
        {
            return Convert.ToInt16(GestionBoutique.getResultatRequeteScalaire("select count(*) from commande"));
        }

        /// <summary>
        /// Ajouter une commande
        /// </summary>
        /// <param name="date">Date de la commande</param>
        /// <param name="idClient">idantifiant du client</param>
        public static void ajouter(DateTime date, int idClient)
        {
            GestionBoutique.executerRequeteAction("INSERT INTO commande (date, idClient) VALUES ('"+date.ToString("yyyy-MM-dd") + "', "+idClient+");");
        }

        /// <summary>
        /// Modifier une commande
        /// </summary>
        /// <param name="id">idantifiant de la commande a modifier</param>
        /// <param name="date">date de la commande</param>
        /// <param name="idClient">idantifiant du client</param>
        public static void modifier(int id, DateTime date, int idClient)
        {
            GestionBoutique.executerRequeteAction("UPDATE commande SET date = '"+date.ToString("yyyy-MM-dd") + "', idClient = "+idClient+" WHERE id ="+id);
        }

        /// <summary>
        /// Supprimer une commande
        /// </summary>
        /// <param name="id">Identifiant de la commande à supprimer</param>
        public static void supprimer(int id)
        {
            // Remarque : Si l'on veut que la suppression supprime aussi les commandes et lignesCommandes associées
            // Il faut alors ajouter sur les clés étrangères "ON DELETE CASCADE"

            GestionBoutique.executerRequeteAction("DELETE FROM commande WHERE id =" + id);
        }

        /// <summary>
        /// Recherche de mot dans la table
        /// </summary>
        /// <param name="mot">mot a rechercher dans la table</param>
        /// <returns></returns>
        public static DataTable searchCommande(string mot)
        {
            return GestionBoutique.getTuplesRequeteSelect("CALL RechercheCommande('" + mot + "');", "RechercheCommande");
        }

    }
}
