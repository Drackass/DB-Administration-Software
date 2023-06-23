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
    public partial class FrmLDC : Form
    {
        private int idCSelected;
        private int idPSelected;

        public FrmLDC()
        {
            InitializeComponent();
        }

        private void FrmListeLDC_Load(object sender, EventArgs e)
        {
            this.Left = 0;
            this.Top = 0;

            refresh();
            GestionInterface.DelUpdColumnDataGrid(DGVLDC);
            GestionInterface.coloriserDataGrid(DGVLDC);
            GestionInterface.remplirComboBox(cbIdCommande, GestionCommande.getTuples(), "id", "id");
            GestionInterface.remplirComboBox(cbIdProduit, GestionProduit.getTuples(), "nom", "id");

            panelPopup.Visible = false;




        }

        private void refresh()
        {
            DGVLDC.DataSource = GestionLDC.getTuplesDetails();
            labelNbElements.Text = "Nombre d'éléments : " + GestionLDC.getNbTuples();

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            DGVLDC.DataSource = GestionLDC.searchLDC(tbSearch.Text);

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            GestionPDF.GeneratePdfFromDataTable(" Liste des lignes de commande ", GestionLDC.getTuplesDetails());

        }

        private void btnClosePopup_Click(object sender, EventArgs e)
        {
            panelPopup.Visible = false;
        }

        private void tbQuantite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            cbIdCommande.Text = "";
            cbIdProduit.Text = "";
            tbQuantite.Text = "";
            panelPopup.Visible = true;
            btnAction.Text = "Ajouter";
        }

        private void DGVLDC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Vérifier si la colonne cliquée est la colonne de boutons et que ce n'est pas la derniere ligne
            if (((e.ColumnIndex == 0) || (e.ColumnIndex == 1)) & (DGVLDC.RowCount - 1 != e.RowIndex))
            {
                if (DGVLDC.Columns[e.ColumnIndex].Name == "DELETE")
                {
                    try
                    {
                    GestionLDC.supprimer((int)DGVLDC.Rows[e.RowIndex].Cells["idCommande"].Value, (int)DGVLDC.Rows[e.RowIndex].Cells["idProduit"].Value);
                    refresh();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erreur sur la table lignedecommande", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    cbIdCommande.SelectedValue = (int)DGVLDC.Rows[e.RowIndex].Cells["idCommande"].Value;
                    cbIdProduit.SelectedValue = (int)DGVLDC.Rows[e.RowIndex].Cells["idProduit"].Value;
                    tbQuantite.Text = (string)DGVLDC.Rows[e.RowIndex].Cells["quantite"].Value.ToString();
                    btnAction.Text = "Modifier";
                    this.idCSelected = (int)DGVLDC.Rows[e.RowIndex].Cells["idCommande"].Value;
                    this.idPSelected = (int)DGVLDC.Rows[e.RowIndex].Cells["idProduit"].Value;
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
                    GestionLDC.modifier(idCSelected, idPSelected, (int)cbIdCommande.SelectedValue, (int)cbIdProduit.SelectedValue, string.IsNullOrEmpty(tbQuantite.Text) ? 0 : int.Parse(tbQuantite.Text));
                }
                else
                {
                    GestionLDC.ajouter((int)cbIdCommande.SelectedValue, (int)cbIdProduit.SelectedValue, string.IsNullOrEmpty(tbQuantite.Text) ? 0 : int.Parse(tbQuantite.Text));

                }
                refresh();
                panelPopup.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur sur la table lignedecommande", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
