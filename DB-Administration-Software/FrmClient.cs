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
    public partial class FrmClient : Form
    {

        private int idSelected;

        public FrmClient()
        {
            InitializeComponent();
        }

        private void FrmListeCategorie_Load(object sender, EventArgs e)
        {
            this.Left = 0;
            this.Top = 0;

            refresh(); // Actualise les données affichées dans la fenêtre
            GestionInterface.coloriserDataGrid(DGVClient);
            GestionInterface.DelUpdColumnDataGrid(DGVClient);

            panelPopup.Visible = false;
            refresh();

        }

        private void refresh()
        {
            DGVClient.DataSource = GestionClient.getTuples();
            labelNbElements.Text = "Nombre d'éléments : " + GestionClient.getNbTuples();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            DGVClient.DataSource = GestionClient.searchClient(tbSearch.Text);

        }

        private void DGVClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Vérifier si la colonne cliquée est la colonne de boutons et que ce n'est pas la derniere ligne
            if (((e.ColumnIndex == 0) || (e.ColumnIndex == 1)) & (DGVClient.RowCount - 1 != e.RowIndex))
            {
                if (DGVClient.Columns[e.ColumnIndex].Name == "DELETE")
                {
                    try
                    {
                    GestionClient.supprimer((int)DGVClient.Rows[e.RowIndex].Cells["id"].Value);
                    refresh();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erreur sur la table client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    tbNom.Text = (string)DGVClient.Rows[e.RowIndex].Cells["nom"].Value;
                    tbPrenom.Text = (string)DGVClient.Rows[e.RowIndex].Cells["prenom"].Value;
                    tbRue.Text = (string)DGVClient.Rows[e.RowIndex].Cells["rue"].Value;
                    tbCP.Text = (string)DGVClient.Rows[e.RowIndex].Cells["codePostal"].Value.ToString();
                    tbVille.Text = (string)DGVClient.Rows[e.RowIndex].Cells["ville"].Value;
                    tbTel.Text = (string)DGVClient.Rows[e.RowIndex].Cells["tel"].Value;
                    tbEmail.Text = (string)DGVClient.Rows[e.RowIndex].Cells["email"].Value;

                    btnAction.Text = "Modifier";
                    this.idSelected = (int)DGVClient.Rows[e.RowIndex].Cells["id"].Value;
                    panelPopup.Visible = true;
                }
            }
        }

        private void btnClosePopup_Click(object sender, EventArgs e)
        {
            panelPopup.Visible = false;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAction.Text = "Ajouter";
            tbNom.Text = "";
            tbPrenom.Text = "";
            tbRue.Text = "";
            tbCP.Text = "";
            tbVille.Text = "";
            tbTel.Text = "";
            tbEmail.Text = "";
            panelPopup.Visible = true;
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnAction.Text == "Modifier")
                {
                    GestionClient.modifier(idSelected, tbNom.Text, tbPrenom.Text, tbRue.Text, string.IsNullOrEmpty(tbCP.Text) ? 12345 : int.Parse(tbCP.Text), tbVille.Text, tbTel.Text, tbEmail.Text);
                }
                else
                {
                    GestionClient.ajouter(tbNom.Text, tbPrenom.Text, tbRue.Text, string.IsNullOrEmpty(tbCP.Text) ? 12345 : int.Parse(tbCP.Text), tbVille.Text, tbTel.Text, tbEmail.Text);

                }
                panelPopup.Visible = false;
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur sur la table Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            GestionPDF.GeneratePdfFromDataTable(" Liste des Clients ", GestionClient.getTuples());

        }
    }
}
