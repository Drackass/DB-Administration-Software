using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBD.MySQL
{
    public class GestionProduit
    {

        /// <summary>
        /// Retourne la liste de tous les produit
        /// </summary>
        /// <returns></returns>
        public static DataTable getTuples()
        {
            return GestionBoutique.getTuplesRequeteSelect("CALL GetProduit();", "GetProduit");
        }


        /// <summary>
        /// Retourne la liste de tous les produit avec les details
        /// </summary>
        /// <returns></returns>
        public static DataTable getTuplesDetails()
        {
            return GestionBoutique.getTuplesRequeteSelect("select produit.id,produit.nom,produit.description,produit.prix,produit.image,produit.idCategorie,categorie.libelle,produit.idFournisseur,fournisseur.nom AS nomFournisseur from produit,categorie,fournisseur WHERE (produit.idCategorie = categorie.id) AND (produit.idFournisseur = fournisseur.id)", "TousLesProduit");

        }

        /// <summary>
        /// Retourne le nombre de produits
        /// </summary>
        /// <returns></returns>
        public static int getNbTuples()
        {
            return Convert.ToInt16(GestionBoutique.getResultatRequeteScalaire("select count(*) from produit"));
        }

        /// <summary>
        /// Ajouter un produit
        /// </summary>
        /// <param name="nom">Nom du produit</param>
        /// <param name="description">Description du produit</param>
        /// <param name="prix">Prix du produit</param>
        /// <param name="image">lien d'image du produit</param>
        /// <param name="idCategorie">id de la categorie du produit</param>
        /// <param name="idFournisseur">id du fournisseur du produit</param>
        public static void ajouter(string nom, string description, string prix, string image, int idCategorie, int idFournisseur)
        {
            GestionBoutique.executerRequeteAction("INSERT INTO produit (nom,description,prix,image,idCategorie,idFournisseur) VALUES ('" + nom + "','" + description + "'," + prix.Replace(",", ".") + ",'" + image + "'," + idCategorie + "," + idFournisseur + ");");
        }

        /// <summary>
        /// Modifier un produit
        /// </summary>
        /// <param name="id">Idantifiant du produit</param>
        /// <param name="nom">Nom du produit</param>
        /// <param name="description">Description du produit</param>
        /// <param name="prix">Prix du produit</param>
        /// <param name="image">lien d'image du produit</param>
        /// <param name="idCategorie">id de la categorie du produit</param>
        /// <param name="idFournisseur">id du fournisseur du produit</param>
        public static void modifier(int id,string nom, string description, string prix, string image, int idCategorie, int idFournisseur)
        {
            GestionBoutique.executerRequeteAction("UPDATE produit SET nom = '" + nom + "',description = '" + description + "',prix = " + prix.Replace(",", ".") + ",image = '" + image + "',idCategorie = " + idCategorie + ",idFournisseur = " + idFournisseur + " WHERE id = " + id);
        }

        /// <summary>
        /// Supprimer un produit
        /// </summary>
        /// <param name="id">Identifiant du produit à supprimer</param>
        public static void supprimer(int id)
        {
            GestionBoutique.executerRequeteAction("DELETE FROM produit WHERE id = " + id);
        }

        /// <summary>
        /// Recherche de mot dans la table
        /// </summary>
        /// <param name="mot">mot a rechercher dans la table</param>
        /// <returns></returns>
        public static DataTable searchProduit(string mot)
        {
            return GestionBoutique.getTuplesRequeteSelect("CALL RechercheProduit('" + mot + "');", "RechercheProduit");

        }
    }
}
