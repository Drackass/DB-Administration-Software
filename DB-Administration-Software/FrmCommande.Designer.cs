namespace Boutique
{
    partial class FrmCommande
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.labelNbElements = new System.Windows.Forms.Label();
            this.DGVCommande = new System.Windows.Forms.DataGridView();
            this.btnADD = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelPopup = new System.Windows.Forms.Panel();
            this.btnClosePopup = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cbidClient = new System.Windows.Forms.ComboBox();
            this.btnAction = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCommande)).BeginInit();
            this.panelPopup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Rechercher :";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(121, 72);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(125, 20);
            this.tbSearch.TabIndex = 16;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // labelNbElements
            // 
            this.labelNbElements.AutoSize = true;
            this.labelNbElements.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNbElements.Location = new System.Drawing.Point(9, 10);
            this.labelNbElements.Name = "labelNbElements";
            this.labelNbElements.Size = new System.Drawing.Size(281, 31);
            this.labelNbElements.TabIndex = 15;
            this.labelNbElements.Text = "Nombre d\'éléments :";
            // 
            // DGVCommande
            // 
            this.DGVCommande.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVCommande.BackgroundColor = System.Drawing.Color.White;
            this.DGVCommande.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCommande.Location = new System.Drawing.Point(15, 104);
            this.DGVCommande.Name = "DGVCommande";
            this.DGVCommande.Size = new System.Drawing.Size(643, 358);
            this.DGVCommande.TabIndex = 14;
            this.DGVCommande.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCommande_CellClick);
            // 
            // btnADD
            // 
            this.btnADD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnADD.BackColor = System.Drawing.Color.White;
            this.btnADD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnADD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(45)))));
            this.btnADD.FlatAppearance.BorderSize = 0;
            this.btnADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(83)))), ((int)(((byte)(78)))));
            this.btnADD.Location = new System.Drawing.Point(591, 10);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(30, 30);
            this.btnADD.TabIndex = 19;
            this.btnADD.Text = "➕";
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel4.Location = new System.Drawing.Point(18, 56);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(627, 1);
            this.panel4.TabIndex = 18;
            // 
            // panelPopup
            // 
            this.panelPopup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPopup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(239)))));
            this.panelPopup.Controls.Add(this.btnClosePopup);
            this.panelPopup.Controls.Add(this.label2);
            this.panelPopup.Controls.Add(this.label8);
            this.panelPopup.Controls.Add(this.dtpDate);
            this.panelPopup.Controls.Add(this.cbidClient);
            this.panelPopup.Controls.Add(this.btnAction);
            this.panelPopup.Controls.Add(this.panel8);
            this.panelPopup.Location = new System.Drawing.Point(440, 269);
            this.panelPopup.Name = "panelPopup";
            this.panelPopup.Size = new System.Drawing.Size(181, 159);
            this.panelPopup.TabIndex = 20;
            // 
            // btnClosePopup
            // 
            this.btnClosePopup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClosePopup.BackColor = System.Drawing.Color.Transparent;
            this.btnClosePopup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClosePopup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(45)))));
            this.btnClosePopup.FlatAppearance.BorderSize = 0;
            this.btnClosePopup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClosePopup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClosePopup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(83)))), ((int)(((byte)(78)))));
            this.btnClosePopup.Location = new System.Drawing.Point(156, 0);
            this.btnClosePopup.Name = "btnClosePopup";
            this.btnClosePopup.Size = new System.Drawing.Size(25, 25);
            this.btnClosePopup.TabIndex = 27;
            this.btnClosePopup.Text = "❌";
            this.btnClosePopup.UseVisualStyleBackColor = false;
            this.btnClosePopup.Click += new System.EventHandler(this.btnClosePopup_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(83)))), ((int)(((byte)(78)))));
            this.label2.Location = new System.Drawing.Point(19, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Date :";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(83)))), ((int)(((byte)(78)))));
            this.label8.Location = new System.Drawing.Point(19, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "idClient :";
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDate.Location = new System.Drawing.Point(22, 38);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(138, 20);
            this.dtpDate.TabIndex = 21;
            // 
            // cbidClient
            // 
            this.cbidClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbidClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbidClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbidClient.FormattingEnabled = true;
            this.cbidClient.Location = new System.Drawing.Point(22, 80);
            this.cbidClient.Name = "cbidClient";
            this.cbidClient.Size = new System.Drawing.Size(138, 21);
            this.cbidClient.TabIndex = 9;
            // 
            // btnAction
            // 
            this.btnAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAction.BackColor = System.Drawing.Color.Black;
            this.btnAction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(45)))));
            this.btnAction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnAction.Location = new System.Drawing.Point(22, 107);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(138, 31);
            this.btnAction.TabIndex = 8;
            this.btnAction.Text = "Modifier";
            this.btnAction.UseVisualStyleBackColor = false;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(45)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(3, 159);
            this.panel8.TabIndex = 7;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.White;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(45)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(83)))), ((int)(((byte)(78)))));
            this.btnPrint.Location = new System.Drawing.Point(589, 65);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(30, 30);
            this.btnPrint.TabIndex = 21;
            this.btnPrint.Text = "🖨️";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // FrmCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(667, 473);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.panelPopup);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.labelNbElements);
            this.Controls.Add(this.DGVCommande);
            this.Name = "FrmCommande";
            this.Text = "FrmListeCategorie";
            this.Load += new System.EventHandler(this.FrmListeCommande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCommande)).EndInit();
            this.panelPopup.ResumeLayout(false);
            this.panelPopup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label labelNbElements;
        private System.Windows.Forms.DataGridView DGVCommande;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelPopup;
        private System.Windows.Forms.ComboBox cbidClient;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnClosePopup;
    }
}