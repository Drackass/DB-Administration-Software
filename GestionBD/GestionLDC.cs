using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBD.MySQL
{
    public class GestionLDC
    {
        
        /// <summary>
        /// Retourne la liste de tous les lignes de commande
        /// </summary>
        /// <returns></returns>
        public static DataTable getTuples()
        {
            return GestionBoutique.getTuplesRequeteSelect("CALL GetLDC();", "GetLDC");    
        }

        /// <summary>
        /// Retourne la liste de tous les lignes de commande avec les details
        /// </summary>
        /// <returns></returns>
        public static DataTable getTuplesDetails()
        {
            return GestionBoutique.getTuplesRequeteSelect("SELECT idCommande,DATE AS dateCommande,CONCAT(UPPER(client.nom),' ',client.prenom) AS PatronymeClient,idProduit,produit.nom AS nomProduit,quantite FROM lignedecommande,produit,commande,client WHERE (lignedecommande.idProduit = produit.id) AND (lignedecommande.idCommande = commande.id) AND (commande.idClient = client.id)","lignedecommande");
        }

        /// <summary>
        /// Retourne le nombre de clients
        /// </summary>
        /// <returns></returns>
        public static int getNbTuples()
        {
            return Convert.ToInt16(GestionBoutique.getResultatRequeteScalaire("select count(*) from lignedecommande"));
        }


        /// <summary>
        /// Ajouter une ligne de commande
        /// </summary>
        /// <param name="idCommande">idantifiant de commande</param>
        /// <param name="idProduit">idantifiant de produit</param>
        /// <param name="quantite">quantite de produit pour la commande</param>
        public static void ajouter(int idCommande, int idProduit, int quantite)
        {
            GestionBoutique.executerRequeteAction("INSERT INTO lignedecommande (idCommande,idProduit,quantite) VALUES (" + idCommande + "," + idProduit + "," + quantite + ");");
        }

        /// <summary>
        /// Modifier une ligne de commande
        /// </summary>
        /// <param name="idCommande">ancien identifiant de commande</param>
        /// <param name="idProduit">ancien identifiant de client</param>
        /// <param name="NewidCommande">nouveau identifiant de commande</param>
        /// <param name="NewidProduit">nouveau identifiant de produit</param>
        /// <param name="quantite">quantite de produit pour la commande</param>
        public static void modifier(int idCommande,int idProduit, int NewidCommande, int NewidProduit, int quantite)
        {
            GestionBoutique.executerRequeteAction("UPDATE lignedecommande SET idCommande = " + NewidCommande + ",idProduit = " + NewidProduit + ",quantite = " + quantite + " WHERE idCommande = "+idCommande+" AND idProduit = "+ idProduit);
        }

        /// <summary>
        /// Supprimer une ligne de commande
        /// </summary>
        /// <param name="idCommande">idantifiant de commande</param>
        /// <param name="idProduit">idantifiant de produit</param>
        public static void supprimer(int idCommande, int idProduit)
        {
            GestionBoutique.executerRequeteAction("DELETE FROM lignedecommande WHERE idCommande = " + idCommande + " AND idProduit = " + idProduit);
        }

        /// <summary>
        /// Recherche de mot dans la table
        /// </summary>
        /// <param name="mot">mot a rechercher dans la table</param>
        /// <returns></returns>
        public static DataTable searchLDC(string mot)
        {
            return GestionBoutique.getTuplesRequeteSelect("CALL RechercheLDC('" + mot + "');", "RechercheLDC");
        }
    }
}
