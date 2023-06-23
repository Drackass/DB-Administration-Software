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
    public partial class FrmFournisseur : Form
    {
        private int idSelected;

        public FrmFournisseur()
        {
            InitializeComponent();
        }

        private void FrmListeFournisseur_Load(object sender, EventArgs e)
        {
            this.Left = 0;
            this.Top = 0;

            refresh();
            GestionInterface.DelUpdColumnDataGrid(DGVFournisseur);
            GestionInterface.coloriserDataGrid(DGVFournisseur);

            panelPopup.Visible = false;


        }

        private void refresh()
        {
            DGVFournisseur.DataSource = GestionFournisseur.getTuples();
            labelNbElements.Text = "Nombre d'éléments : " + GestionFournisseur.getNbTuples();


        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            DGVFournisseur.DataSource = GestionFournisseur.searchFournisseur(tbSearch.Text);

        }

        private void btnClosePopup_Click(object sender, EventArgs e)
        {
            panelPopup.Visible = false;
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            tbNom.Text = "";
            tbRue.Text = "";
            tbCP.Text = "";
            tbVille.Text = "";
            tbTel.Text = "";
            tbEmail.Text = "";
            panelPopup.Visible = true;
            btnAction.Text = "Ajouter";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            GestionPDF.GeneratePdfFromDataTable(" Liste des Fournisseur ", GestionFournisseur.getTuples());

        }

        private void DGVFournisseur_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Vérifier si la colonne cliquée est la colonne de boutons et que ce n'est pas la derniere ligne
            if (((e.ColumnIndex == 0) || (e.ColumnIndex == 1)) & (DGVFournisseur.RowCount - 1 != e.RowIndex))
            {
                if (DGVFournisseur.Columns[e.ColumnIndex].Name == "DELETE")
                {
                    try
                    {
                    GestionFournisseur.supprimer((int)DGVFournisseur.Rows[e.RowIndex].Cells["id"].Value);
                    refresh();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erreur sur la table fournisseur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    tbNom.Text = (string)DGVFournisseur.Rows[e.RowIndex].Cells["nom"].Value;
                    tbRue.Text = (string)DGVFournisseur.Rows[e.RowIndex].Cells["rue"].Value;
                    tbCP.Text = (string)DGVFournisseur.Rows[e.RowIndex].Cells["codePostal"].Value.ToString();
                    tbVille.Text = (string)DGVFournisseur.Rows[e.RowIndex].Cells["ville"].Value;
                    tbTel.Text = (string)DGVFournisseur.Rows[e.RowIndex].Cells["tel"].Value;
                    tbEmail.Text = (string)DGVFournisseur.Rows[e.RowIndex].Cells["email"].Value;

                    btnAction.Text = "Modifier";
                    this.idSelected = (int)DGVFournisseur.Rows[e.RowIndex].Cells["id"].Value;
                    panelPopup.Visible = true;
                }
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnAction.Text == "Modifier")
                {
                    GestionFournisseur.modifier(idSelected, tbNom.Text, tbRue.Text, string.IsNullOrEmpty(tbCP.Text) ? 12345 : int.Parse(tbCP.Text), tbVille.Text, tbTel.Text, tbEmail.Text);
                }
                else
                {
                    GestionFournisseur.ajouter(tbNom.Text, tbRue.Text, string.IsNullOrEmpty(tbCP.Text) ? 12345 : int.Parse(tbCP.Text), tbVille.Text, tbTel.Text, tbEmail.Text);

                }
                refresh();
                panelPopup.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur sur la table fournisseur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
