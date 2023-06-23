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
using System.Diagnostics;

namespace Boutique
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
            GestionInterface.coloriserDataGrid(DGVGlobal);
            //GestionBoutique.seConnecter();
            DGVGlobal.DataSource = GestionBoutique.searchGlobal(tbSearchGlobal.Text);
        }

        private void tbSearchGlobal_TextChanged(object sender, EventArgs e)
        {
            DGVGlobal.DataSource = GestionBoutique.searchGlobal(tbSearchGlobal.Text);

        }

        private void btnScriptSQL_Click(object sender, EventArgs e)
        {
            string theCommande = GestionInterface.GenerateInsertSqlFromDataTable(GestionCategorie.getTuples(), "categorie") + "\r\n\n" + GestionInterface.GenerateInsertSqlFromDataTable(GestionClient.getTuples(), "client") + "\r\n\n" + GestionInterface.GenerateInsertSqlFromDataTable(GestionCommande.getTuples(), "commande") + "\r\n\n" + GestionInterface.GenerateInsertSqlFromDataTable(GestionFournisseur.getTuples(), "fournisseur") + "\r\n\n" + GestionInterface.GenerateInsertSqlFromDataTable(GestionLDC.getTuples(), "lignedecommande") + "\r\n\n" + GestionInterface.GenerateInsertSqlFromDataTable(GestionProduit.getTuples(), "produit");
            Clipboard.SetText(theCommande);
            MessageBox.Show("Les scripts insert contenants les données des tables de la base actuelle ont bien étés copier dans le presse-papiers.", "Presse-papiers", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnMCD_Click(object sender, EventArgs e)
        {
            string filePath = Application.StartupPath + "\\MCD.png";
            Process.Start(filePath);
        }

        private void btnMLD_Click(object sender, EventArgs e)
        {
            string filePath = Application.StartupPath + "\\MLD.png";
            Process.Start(filePath);
        }

        private void ResetDB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ete vous sur de bien vouloir réinitialiser l'ensemble des données de la base ?", "Attention: réinitialisation de la base de données", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        }
    }
}
