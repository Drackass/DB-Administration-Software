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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            hideSubMenu();
            enableMenu(false);

            // Popup btnMore
            panelLog.Parent = this;
            panelLog.BringToFront();
            panelLog.Location = new Point(765, 57);
            panelLog.Visible = false;
        }

        // Fermer tout les submenu quand on click sur le logo
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        //evenement de clique sur les menus pour Férmer/ouvrir les submenu
        private void btnCategorie_Click(object sender, EventArgs e)
        {
            GestionInterface.switchVisPanel(this.panelCategorie);
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            GestionInterface.switchVisPanel(this.panelClient);

        }

        private void btnCommande_Click(object sender, EventArgs e)
        {
            GestionInterface.switchVisPanel(this.panelCommande);

        }

        private void btnFournisseur_Click(object sender, EventArgs e)
        {
            GestionInterface.switchVisPanel(this.panelFournisseur);

        }

        private void btnLDC_Click(object sender, EventArgs e)
        {
            GestionInterface.switchVisPanel(this.panelLDC);

        }

        private void btnProduit_Click(object sender, EventArgs e)
        {
            GestionInterface.switchVisPanel(this.panelProduit);

        }


        // clique sur le chemin pour retourner a la page admin
        private void btnPath_Click(object sender, EventArgs e)
        {
            this.openChildFormInPanel(new FrmHome(), "Home /");
        }

        // Categorie
        private void btnTableCategorie_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FrmCategorie(), "Home / Categorie / Table");
        }

        // Client
        private void btnTableClient_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FrmClient(), "Home / Client / Table");
        }

        // Commande
        private void btnTableCommande_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FrmCommande(), "Home / Commande / Table");
        }

        // Fournisseur
        private void btnTableFournisseur_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FrmFournisseur(), "Home / Fournisseur / Table");
        }

        // Ligne de commande
        private void btnTableLDC_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FrmLDC(), "Home / Ligne de commande / Table");
        }

        // Produit
        private void btnTableProduit_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FrmProduit(), "Home / Produit / Table");
        }

        // A Propos
        private void btnAPropos_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FrmAPropos(), "Home / A Propos");
        }

        // bouton pour férmer l'application
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Bouton de Connexion/Déconnexion
        private void btnLog_Click(object sender, EventArgs e)
        {
            if(btnLog.Text == "👤 Connexion")
            {
                openChildFormInPanel(new FrmConnexion(this), "Formulaire de connexion");
                panelLog.Visible = false;
            }
            else
            {

                hideSubMenu();
                enableMenu(false);

                btnPath.Text = "";

                btnLog.Text = "👤 Connexion";
                panelLog.Visible = false;

                activeForm.Close();
                GestionBoutique.seDeconnecter();
            }
        }

        //bouton more
        private void btnMore_Click(object sender, EventArgs e)
        {
            GestionInterface.switchVisPanel(this.panelLog);

        }

        /// <summary>
        ///  Set l'etat des menus
        /// </summary>
        /// <param name="value">Etat des menu</param>
        private void enableMenu(bool value)
        {
            btnCategorie.Enabled = value;
            btnClient.Enabled = value;
            btnCommande.Enabled = value;
            btnFournisseur.Enabled = value;
            btnLDC.Enabled = value;
            btnProduit.Enabled = value;
            btnPath.Enabled = value;
        }

        // set la visibilitée de chaque submenu a false
        private void hideSubMenu()
        {
            panelCategorie.Visible = false;
            panelClient.Visible = false;
            panelCommande.Visible = false;
            panelFournisseur.Visible = false;
            panelLDC.Visible = false;
            panelProduit.Visible = false;
        }

        // mise a jour apres la connexion
        public void updateAdmin()
        {
            if (GestionBoutique.isConnected())
            {
                enableMenu(true);
                openChildFormInPanel(new FrmHome(), "Home /");
                btnLog.Text = "➡️ Déconnexion";
            }
        }

        // Méthode d'ouverture de form dans l'element parent
        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm, string path)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            btnPath.Text = path;
        }
    }
}