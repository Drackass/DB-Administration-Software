using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionBD.MySQL;

namespace Boutique
{
    public partial class FrmProduit : Form
    {
        private int idSelected;

        public FrmProduit()
        {
            InitializeComponent();
        }

        private void FrmListeProduit_Load(object sender, EventArgs e)
        {
            this.Left = 0;
            this.Top = 0;

            refresh();
            GestionInterface.DelUpdColumnDataGrid(DGVProduit);
            GestionInterface.coloriserDataGrid(DGVProduit);
            GestionInterface.remplirComboBox(cbCategorie, GestionCategorie.getTuples(), "libelle", "id");
            GestionInterface.remplirComboBox(cbFournisseur, GestionFournisseur.getTuples(), "nom", "id");

            panelPopup.Visible = false;
        }

        private void refresh()
        {
            DGVProduit.DataSource = GestionProduit.getTuplesDetails();
            labelNbElements.Text = "Nombre d'éléments : " + GestionProduit.getNbTuples();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            DGVProduit.DataSource = GestionProduit.searchProduit(tbSearch.Text);

        }

        private void btnClosePopup_Click(object sender, EventArgs e)
        {
            panelPopup.Visible = false;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            GestionPDF.GeneratePdfFromDataTable(" Liste des produits ", GestionProduit.getTuplesDetails());

        }

        private void tbPrix_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Vérifier si le caractère saisi est un chiffre ou un point ou
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                // Si ce n'est pas le cas, ignorer la saisie
                e.Handled = true;
            }

            // Vérifier si un point a déjà été saisi deux fois
            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains("."))
            {
                // Si c'est le cas, ignorer la saisie
                e.Handled = true;
            }

            // Vérifier si un point a été saisi et si deux chiffres ont déjà été saisis après le point ou si le caractère saisi est une touche de suppression
            if (((TextBox)sender).Text.Contains("."))
            {
                string[] parts = ((TextBox)sender).Text.Split('.');
                if (parts.Length == 2 && parts[1].Length >= 2 && e.KeyChar != '\b')
                {
                    // Si c'est le cas, ignorer la saisie
                    e.Handled = true;
                }
            }

        }

        private void DGVProduit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Vérifier si la colonne cliquée est la colonne de boutons et que ce n'est pas la derniere ligne
            if (((e.ColumnIndex == 0) || (e.ColumnIndex == 1)) & (DGVProduit.RowCount - 1 != e.RowIndex))
            {
                if (DGVProduit.Columns[e.ColumnIndex].Name == "DELETE")
                {
                    try
                    {
                    GestionProduit.supprimer((int)DGVProduit.Rows[e.RowIndex].Cells["id"].Value);
                    refresh();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erreur sur la table produit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    tbNom.Text = (string)DGVProduit.Rows[e.RowIndex].Cells["nom"].Value;
                    tbDescription.Text = (string)DGVProduit.Rows[e.RowIndex].Cells["description"].Value;
                    tbPrix.Text = (string)DGVProduit.Rows[e.RowIndex].Cells["prix"].Value.ToString();
                    tbLienIMG.Text = (string)DGVProduit.Rows[e.RowIndex].Cells["image"].Value;
                    cbCategorie.SelectedValue = (int)DGVProduit.Rows[e.RowIndex].Cells["idCategorie"].Value;
                    cbFournisseur.SelectedValue = (int)DGVProduit.Rows[e.RowIndex].Cells["idFournisseur"].Value;
                    btnAction.Text = "Modifier";
                    this.idSelected = (int)DGVProduit.Rows[e.RowIndex].Cells["id"].Value;
                    panelPopup.Visible = true;
                }
            }
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            tbNom.Text = "";
            tbDescription.Text = "";
            tbPrix.Text = "";
            tbLienIMG.Text = "";
            cbCategorie.Text = "";
            cbFournisseur.Text = "";
            panelPopup.Visible = true;
            btnAction.Text = "Ajouter";
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnAction.Text == "Modifier")
                {
                    GestionProduit.modifier(idSelected, tbNom.Text, tbDescription.Text, string.IsNullOrEmpty(tbPrix.Text) ? "0" : tbPrix.Text, tbLienIMG.Text, (int)cbCategorie.SelectedValue, (int)cbFournisseur.SelectedValue);
                }
                else
                {
                    GestionProduit.ajouter(tbNom.Text, tbDescription.Text, string.IsNullOrEmpty(tbPrix.Text) ? "0" : tbPrix.Text, tbLienIMG.Text, (int)cbCategorie.SelectedValue, (int)cbFournisseur.SelectedValue);

                }
                panelPopup.Visible = false;
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur sur la table produit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
