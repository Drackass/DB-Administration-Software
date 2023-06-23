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
    public partial class FrmConnexion : Form
    {
         private readonly FrmMain  parentform;
        public FrmConnexion(FrmMain parentform)
        {
            InitializeComponent();
            this.parentform = parentform;
            tbMDP.UseSystemPasswordChar = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbServeur.Text = "";
            tbBase.Text = "";
            tbId.Text = "";
            tbMDP.Text = "";
        }

        private void btnPreSet_Click(object sender, EventArgs e)
        {
            tbServeur.Text = "localhost";
            tbBase.Text = "sauzet_boutique"; //A adapter bien entendu...
            tbId.Text = "root";
            tbMDP.Text = "";
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            try
            {
                GestionBoutique.seConnecter(tbServeur.Text, tbBase.Text, tbId.Text, tbMDP.Text);
                parentform.updateAdmin();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Erreur de connexion",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

    }
}
