using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ajout des namespaces nécessaires pour les classes utiles avec la gestion de BD
using MySql.Data.MySqlClient;

namespace GestionBD.MySQL
{
    public static class GestionBoutique
    {
        #region champs statiques

        private static MySqlConnection maConnexion = new MySqlConnection();
        private static MySqlCommand maCommandeSpecialRequete = new MySqlCommand();
        private static MySqlDataAdapter monRemplisseur = new MySqlDataAdapter();
        private static DataSet monJeuDeDonnees = new DataSet();
        private static string maRequete;

        #endregion

        #region Méthodes statiques

        /// <summary>
        /// Permet de se connecter avec les infos de connexions de la classe MysqlConfig
        /// </summary>
        public static void seConnecter()
        {
            if (maConnexion.State == ConnectionState.Closed)
            {
                string maChaine = "Server=" + MysqlConfig.SERVEUR + ";Database=" + MysqlConfig.BASE + "; Uid=" + MysqlConfig.UTILISATEUR + "; Pwd=" + MysqlConfig.MOT_DE_PASSE + ";";
                //Site de référence pour toutes les chaines de connexion : http://www.connectionstrings.com/

                maConnexion.ConnectionString = maChaine;

                maConnexion.Open();

                monJeuDeDonnees = new DataSet("dsBoutique");//On  nomme le DataSet
                monJeuDeDonnees.Clear();
                maCommandeSpecialRequete.CommandType = CommandType.Text;
                maCommandeSpecialRequete.Connection = maConnexion;

            }
        }

        /// <summary>
        /// Permet de se connecter à partir des infos fournies en paramètres
        /// (provenant d'un formulaire de Connexion par exemple...)
        /// </summary>
        /// <param name="nomServeur">Nom du serveur</param>
        /// <param name="nomBase">Nom de la base de données</param>
        /// <param name="nomUtilisateur">Nom de l'utilisateur</param>
        /// <param name="motDePasse">Mot de passe</param>
        public static void seConnecter(string nomServeur, string nomBase, string nomUtilisateur, string motDePasse)
        {
            if (maConnexion.State == ConnectionState.Closed)
            {
                string maChaine = "Server=" + nomServeur + ";Database=" + nomBase + "; Uid=" + nomUtilisateur + "; Pwd=" + motDePasse + ";";
                //Exemple de valeur correspondante pour maChaine : "Server=localhost;Database=votrenom_boutique;Uid=root;Pwd=;";
                //Site de référence pour toutes les chaines de connexion : http://www.connectionstrings.com/

                maConnexion.ConnectionString = maChaine;

                maConnexion.Open();

                monJeuDeDonnees = new DataSet("dsBoutique");//On  nomme le DataSet
                monJeuDeDonnees.Clear();
                maCommandeSpecialRequete.CommandType = CommandType.Text;
                maCommandeSpecialRequete.Connection = maConnexion;
            }
        }

        /// <summary>
        /// Tester si il y a une connexion existante
        /// </summary>
        /// <returns></returns>
        public static bool isConnected()
        {
            return (maConnexion.State == ConnectionState.Open);
        }

        /// <summary>
        /// Permet de se déconnecter de la base de données.
        /// </summary>
        public static void seDeconnecter()
        {
            if (maConnexion.State == ConnectionState.Open)
            {
                maConnexion.Close();
                maConnexion.Dispose();
            }
        }


        /// <summary>
        /// Permet de vider le DataSet en mémoire
        /// </summary>
        public static void viderJeuDonnees()
        {
            monJeuDeDonnees.Clear();
        }


        #region FACTORISATION pour les requêtes de CONSULTATION, requêtes SCALAIRES et d'ACTION

        /// <summary>
        /// Récupère le résultat d'une requête SELECT
        /// </summary>
        /// <param name="texteRequete">Texte de la requête SQL</param>
        /// <param name="nomDataTable">Nom de la DataTable contenue dans le DataSet</param>
        /// <returns>DataTable retournée avec les tules renvoyés par le SELECT</returns>
        public static DataTable getTuplesRequeteSelect(string texteRequete, string nomDataTable)
        {
            GestionBoutique.maRequete = texteRequete;
            GestionBoutique.maCommandeSpecialRequete.CommandText = GestionBoutique.maRequete;
            GestionBoutique.monRemplisseur.SelectCommand = GestionBoutique.maCommandeSpecialRequete;
            if (GestionBoutique.monJeuDeDonnees.Tables.Contains(nomDataTable))
            {
                monJeuDeDonnees.Tables[nomDataTable].Clear();
            }
            GestionBoutique.monRemplisseur.Fill(GestionBoutique.monJeuDeDonnees, nomDataTable);
            return GestionBoutique.monJeuDeDonnees.Tables[nomDataTable];
        }

        /// <summary>
        /// Récupère le résultat d'une requête scalaire
        /// (Contenant un agrégat de type COUNT, SUM, AVG, MIN, MAX...
        /// </summary>
        /// <param name="texteRequete">Texte de la requête SQL</param>
        /// <returns>Résultat retourné de type DOUBLE</returns>
        public static double getResultatRequeteScalaire(string texteRequete)
        {
            GestionBoutique.maRequete = texteRequete;
            GestionBoutique.maCommandeSpecialRequete.CommandText = GestionBoutique.maRequete;
            return Convert.ToDouble(GestionBoutique.maCommandeSpecialRequete.ExecuteScalar());

        }

        /// <summary>
        /// Exécute une requête de type ACTION
        /// (c'est à dire de type INSERT, UPDATE, DELETE)
        /// </summary>
        /// <param name="texteRequete">Texte de la requête SQL</param>
        public static void executerRequeteAction(string texteRequete)
        {
            GestionBoutique.maRequete = texteRequete;
            GestionBoutique.maCommandeSpecialRequete.CommandText = GestionBoutique.maRequete;
            GestionBoutique.maCommandeSpecialRequete.ExecuteNonQuery();
        }

        #endregion


        #region Autres méthodes utiles
        /// <summary>
        /// Permet de générer une valeur de clé primaire pour une table donnée en paramètre
        /// (sorte d'AUTO-INCREMENT pour une table créé sans) 
        /// La clé primaire est nommée id dans toutes les tables
        /// (sinon ajouter un paramètre contenant le nom de la clé)
        /// </summary>
        /// <param name="nomtable">Nom de la table</param>
        /// <returns>Valeur de clé primaire généré</returns>
        public static int getNouvelleClePrimaire(string nomTable)
        {
            int Cle = Convert.ToInt32(GestionBoutique.getResultatRequeteScalaire("SELECT Max(id) FROM " + nomTable));
            return (Cle + 1);
        }

        /// <summary>
        /// Execute une recherche sur l'ensemble des éléments de la base est renvoie en une table les résultats et leur table de provenance
        /// </summary>
        /// <param name="mot">Mot a rechercher dans toute la base</param>
        /// <returns></returns>
        public static DataTable searchGlobal(string mot)
        {
            return getTuplesRequeteSelect("SELECT '' as 'Table','' as 'A','' as 'B','' as 'C','' as 'D','' as 'E','' as 'F','' as 'G','' as 'H' UNION SELECT 'categorie' as source, id, libelle,'','','','','','' FROM categorie WHERE libelle LIKE '%" + mot + "%' UNION SELECT 'client' as source, id, nom, prenom, rue, codePostal, ville, tel, email FROM client WHERE nom LIKE '%" + mot + "%' OR prenom LIKE '%" + mot + "%' OR rue LIKE '%" + mot + "%' OR ville LIKE '%" + mot + "%' OR tel LIKE '%" + mot + "%' OR email LIKE '%" + mot + "%' UNION SELECT 'commande' as source, id, date, idClient, '', '', '', '', '' FROM commande WHERE date LIKE '%" + mot + "%' UNION SELECT 'fournisseur' as source, id, nom, rue, codePostal, ville, tel, email, '' FROM fournisseur WHERE nom LIKE '%" + mot + "%' OR rue LIKE '%" + mot + "%' OR ville LIKE '%" + mot + "%' OR tel LIKE '%" + mot + "%' OR email LIKE '%" + mot + "%' UNION SELECT 'lignedecommande' as source, idCommande, idProduit, quantite, '', '', '', '', '' FROM lignedecommande WHERE idCommande LIKE '%" + mot + "%' OR idProduit LIKE '%" + mot + "%' OR quantite LIKE '%" + mot + "%' UNION SELECT 'produit' as source, id, nom, description, prix, image, idCategorie, idFournisseur, '' FROM produit WHERE nom LIKE '%" + mot + "%' OR description LIKE '%" + mot + "%' OR prix LIKE '%" + mot + "%' OR image LIKE '%" + mot + "%' OR idCategorie LIKE '%" + mot + "%' OR idFournisseur LIKE '%" + mot + "%'", "searchGlobal");
        }

        #endregion

        #endregion

    }
}
