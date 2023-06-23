using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


// Espace de nom pour la classe GestionInterface
namespace Boutique
{
    // Définition de la classe GestionInterface
    internal class GestionInterface
    {
        // Méthode pour remplir une ComboBox avec les données d'une DataTable
        public static void remplirComboBox(ComboBox maComboBox, DataTable maDataTable, string displayMember, string valueMember)
        {
            maComboBox.DataSource = maDataTable; // Utilisation de la DataTable comme source de données
            maComboBox.DisplayMember = displayMember; // Le nom de la colonne à afficher dans la ComboBox
            maComboBox.ValueMember = valueMember; // Le nom de la colonne à utiliser comme valeur de la ComboBox
        }

        //changer la visibilitée d'un panel
        public static void switchVisPanel( Panel thePanel)
        {
            thePanel.Visible = !(thePanel.Visible);
        }

        // Méthode pour changer la couleur d'un DataGridView
        public static void coloriserDataGrid(DataGridView monDataDridView)
        {
            // Définition des styles des cellules du DataGridView
            monDataDridView.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10); // Police de caractères
            monDataDridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(240, 240, 240); // Couleur de fond de la cellule sélectionnée
            monDataDridView.DefaultCellStyle.SelectionForeColor = Color.FromArgb(165, 164, 161); // Couleur de texte de la cellule sélectionnée
            monDataDridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250); // Couleur de fond des lignes alternatives
        }

        // Cette méthode ajoute deux colonnes de boutons à un DataGridView
        public static void DelUpdColumnDataGrid(DataGridView monDataDridView)
        {
            // Création de nouvelles colonnes de boutons
            DataGridViewButtonColumn btnDELETE = new DataGridViewButtonColumn();
            DataGridViewButtonColumn btnUPDATE = new DataGridViewButtonColumn();

            // Paramétrage des colonnes de boutons
            btnDELETE.HeaderText = "";
            btnDELETE.Name = "DELETE";
            btnDELETE.Text = "❌";

            btnUPDATE.HeaderText = "";
            btnUPDATE.Name = "UPDATE";
            btnUPDATE.Text = "🖊";

            // Définition du style des cellules pour les colonnes de boutons (correction de l'affichage du texte)
            btnDELETE.DefaultCellStyle.NullValue = btnDELETE.Text;
            btnUPDATE.DefaultCellStyle.NullValue = btnUPDATE.Text;

            btnDELETE.Width = 25;
            btnDELETE.FlatStyle = FlatStyle.Flat;

            btnUPDATE.Width = 25;
            btnUPDATE.FlatStyle = FlatStyle.Flat;

            // Ajout des colonnes au DataGridView
            monDataDridView.Columns.Add(btnDELETE);
            monDataDridView.Columns.Add(btnUPDATE);
        }

        // Cette méthode vérifie si une chaîne de caractères contient uniquement des lettres majuscules et minuscules
        public static bool isChaineValide(string chaine)
        {
            Regex myRegex;
            myRegex = new Regex("[a-zA-Z]");

            // Vérification de la chaîne avec l'expression régulière
            return myRegex.IsMatch(chaine); // retourne true ou false selon la vérification
        }

        // Generer une requete insert avec l'ensemble des données actuelle
        public static string GenerateInsertSqlFromDataTable(DataTable dt, string tableName)
        {
            // Initialisation d'un objet StringBuilder pour construire la commande SQL
            StringBuilder sb = new StringBuilder();

            // Vérification que la table de données et le nom de la table sont valides
            if (dt != null && dt.Rows.Count > 0 && !string.IsNullOrEmpty(tableName))
            {
                // Ajout du nom de la table dans la commande SQL
                sb.AppendFormat("INSERT INTO {0} (", tableName);

                // Ajout des noms de colonnes dans la commande SQL
                foreach (DataColumn col in dt.Columns)
                {
                    sb.AppendFormat("{0},", col.ColumnName);
                }

                // Suppression de la virgule finale ajoutée dans la boucle précédente
                sb.Length--;

                // Ajout des valeurs des colonnes dans la commande SQL
                sb.Append(") VALUES ");
                foreach (DataRow row in dt.Rows)
                {
                    sb.Append("(");

                    // Ajout des valeurs de chaque colonne de la ligne
                    foreach (DataColumn col in dt.Columns)
                    {
                        // Si le type de la colonne est une chaîne de caractères ou une date, les caractères spéciaux sont échappés
                        if (col.DataType == typeof(string) || col.DataType == typeof(DateTime))
                        {
                            sb.AppendFormat("'{0}',", row[col.ColumnName].ToString().Replace("'", "''"));
                        }
                        // Si le type de la colonne est un booléen, la valeur est convertie en entier
                        else if (col.DataType == typeof(bool))
                        {
                            sb.AppendFormat("{0},", (bool)row[col.ColumnName] ? 1 : 0);
                        }
                        // Si le type de la colonne est un autre type, la valeur est ajoutée telle quelle
                        else
                        {
                            sb.AppendFormat("{0},", row[col.ColumnName]);
                        }
                    }

                    // Suppression de la virgule finale ajoutée dans la boucle précédente
                    sb.Length--;
                    sb.Append("),");
                }

                // Suppression de la virgule finale ajoutée dans la boucle précédente
                sb.Length--;
            }

            // Retourne la commande SQL construite
            return sb.ToString();
        }
    }
}
