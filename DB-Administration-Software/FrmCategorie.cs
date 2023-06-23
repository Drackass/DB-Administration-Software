using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionBD.MySQL; // Importation de la bibliothèque GestionBD.MySQL

namespace Boutique
{
    public partial class FrmCategorie : Form // Définition de la classe FrmListeCategorie qui hérite de la classe Form
    {
        private int idSelected; // Déclaration d'une variable privée de type int appelée idSelected

        public FrmCategorie() // Définition du constructeur de la classe FrmListeCategorie
        {
            InitializeComponent(); // Initialise les composants de la fenêtre
        }

        private void FrmListeCategorie_Load(object sender, EventArgs e) // Définition de la méthode FrmListeCategorie_Load qui est appelée lorsque la fenêtre est chargée
        {

            this.Left = 0; // Définit la position horizontale de la fenêtre à 0
            this.Top = 0; // Définit la position verticale de la fenêtre à 0

            refresh(); // Actualise les données affichées dans la fenêtre
            GestionInterface.DelUpdColumnDataGrid(DGVCategorie); // Met à jour les données du DataGridView
            GestionInterface.coloriserDataGrid(DGVCategorie); // Change la couleur du DataGridView

            panelPopup.Visible = false; // Masque le panneau pop-up
        }

        private void refresh() // Définition de la méthode refresh qui actualise les données affichées dans la fenêtre
        {
            DGVCategorie.DataSource = GestionCategorie.getTuples(); // Charge les données de la table Catégorie dans le DataGridView
            labelNbElements.Text = "Nombre d'éléments : " + GestionCategorie.getNbTuples(); // Affiche le nombre d'éléments dans la fenêtre
        }

        // Détecter le clic sur une cellule du DataGridView (DGV) pour gérer les actions correspondantes
        private void DGVCategorie_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Vérifier si la colonne cliquée est la colonne de boutons et que ce n'est pas la derniere ligne
            if (((e.ColumnIndex == 0) || (e.ColumnIndex == 1)) & (DGVCategorie.RowCount-1 != e.RowIndex))
            {
                if(DGVCategorie.Columns[e.ColumnIndex].Name == "DELETE")
                {
                    try
                    {
                    // Supprimer la catégorie correspondante dans la base de données
                    GestionCategorie.supprimer((int)DGVCategorie.Rows[e.RowIndex].Cells["id"].Value);
                    // Rafraîchir le DGV avec les données mises à jour
                    refresh();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erreur sur la table categorie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Pré-remplir le champ de texte avec la valeur de la catégorie sélectionnée
                    tbLibelle.Text = (string)DGVCategorie.Rows[e.RowIndex].Cells["libelle"].Value;
                    // Changer le texte du bouton pour indiquer que l'action à effectuer est une modification
                    btnAction.Text = "Modifier";
                    // Conserver l'identifiant de la catégorie sélectionnée pour la modification ultérieure
                    this.idSelected = (int)DGVCategorie.Rows[e.RowIndex].Cells["id"].Value;
                    // Afficher le panneau de modification
                    panelPopup.Visible = true;
                }
            }
        }

        // Cette méthode est appelée chaque fois que le texte est modifié dans la boîte de recherche
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            // La source de données du DataGridView est mise à jour avec les résultats de la recherche
            DGVCategorie.DataSource = GestionCategorie.searchCategorie(tbSearch.Text);
        }

        // Cette méthode est appelée lorsque le bouton "Ajouter" est cliqué
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Le texte du bouton "Action" est changé pour indiquer qu'il s'agit d'une action d'ajout
            btnAction.Text = "Ajouter";
            // Le champ de texte est effacé
            tbLibelle.Text = "";
            // Le panneau popup est rendu visible pour permettre l'ajout d'une nouvelle catégorie
            panelPopup.Visible = true;
        }

        // Cette méthode est appelée lorsque le bouton "Action" est cliqué
        private void btnAction_Click(object sender, EventArgs e)
        {
            try
            {
                // Si le texte du bouton "Action" est "Modifier", la catégorie existante est modifiée
                if (btnAction.Text == "Modifier")
                {
                    // La catégorie est modifiée en utilisant l'identifiant de la catégorie sélectionnée et le nouveau libellé
                    GestionCategorie.modifier(idSelected, tbLibelle.Text);
                }
                // Sinon, une nouvelle catégorie est ajoutée
                else
                {
                    // Une nouvelle catégorie est ajoutée en utilisant le libellé saisi dans le champ de texte
                    GestionCategorie.ajouter(tbLibelle.Text);
                }
                // Le panneau popup est masqué après la modification ou l'ajout de la catégorie
                panelPopup.Visible = false;
                // Le DataGridView est actualisé pour afficher la liste mise à jour des catégories
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur sur la table categorie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Cette méthode est appelée lorsque le bouton "ClosePopup" est cliqué
        private void btnClosePopup_Click(object sender, EventArgs e)
        {
            // Le panneau popup est masqué
            panelPopup.Visible = false;
        }

        // Cette méthode est appelée lorsque le bouton "btnPrint" est cliqué
        private void btnPrint_Click(object sender, EventArgs e)
        {
            // un pdf est generé puis afficher contenant les données de la table catégorie
            GestionPDF.GeneratePdfFromDataTable(" Liste des Categories ", GestionCategorie.getTuples());

        }
    }
}
