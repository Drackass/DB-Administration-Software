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
    public partial class FrmCommande : Form
    {

        private int idSelected;

        public FrmCommande()
        {
            InitializeComponent();
        }

        private void FrmListeCommande_Load(object sender, EventArgs e)
        {
            this.Left = 0;
            this.Top = 0;

            refresh(); // Actualise les données affichées dans la fenêtre
            GestionInterface.DelUpdColumnDataGrid(DGVCommande);
            GestionInterface.coloriserDataGrid(DGVCommande);
            GestionInterface.remplirComboBox(cbidClient,GestionClient.getPatronymes(), "Patronyme", "id");

            panelPopup.Visible = false;

        }

        private void refresh()
        {
            labelNbElements.Text = "Nombre d'éléments : " + GestionCommande.getNbTuples();
            DGVCommande.DataSource = GestionCommande.getTuplesWithPatronymes();

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            DGVCommande.DataSource = GestionCommande.searchCommande(tbSearch.Text);

        }

        private void btnClosePopup_Click(object sender, EventArgs e)
        {
            panelPopup.Visible = false;
        }

        private void DGVCommande_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Vérifier si la colonne cliquée est la colonne de boutons et que ce n'est pas la derniere ligne
            if (((e.ColumnIndex == 0) || (e.ColumnIndex == 1)) & (DGVCommande.RowCount - 1 != e.RowIndex))
            {
                if (DGVCommande.Columns[e.ColumnIndex].Name == "DELETE")
                {
                    try
                    {
                    GestionCommande.supprimer((int)DGVCommande.Rows[e.RowIndex].Cells["id"].Value);
                    refresh();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erreur sur la table commande", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    dtpDate.Value = (DateTime)DGVCommande.Rows[e.RowIndex].Cells["date"].Value;
                    cbidClient.SelectedValue = (int)DGVCommande.Rows[e.RowIndex].Cells["idClient"].Value;

                    btnAction.Text = "Modifier";
                    this.idSelected = (int)DGVCommande.Rows[e.RowIndex].Cells["id"].Value;
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
                    GestionCommande.modifier(idSelected, dtpDate.Value, (int)cbidClient.SelectedValue);
                }
                else
                {
                    GestionCommande.ajouter(dtpDate.Value, (int)cbidClient.SelectedValue);

                }
                refresh();
                panelPopup.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur sur la table Commande", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            cbidClient.Text = "";
            dtpDate.Value = DateTime.Today;
            panelPopup.Visible =true;
            btnAction.Text = "Ajouter";

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            GestionPDF.GeneratePdfFromDataTable(" Liste des Commandes ", GestionCommande.getTuplesWithPatronymes());

        }
    }
}
