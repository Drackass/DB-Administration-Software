namespace Boutique
{
    partial class FrmHome
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ResetDB = new System.Windows.Forms.Button();
            this.btnMLD = new System.Windows.Forms.Button();
            this.btnMCD = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnScriptSQL = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearchGlobal = new System.Windows.Forms.TextBox();
            this.labelNbElements = new System.Windows.Forms.Label();
            this.DGVGlobal = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVGlobal)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel4.Location = new System.Drawing.Point(13, 38);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(627, 1);
            this.panel4.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(239)))));
            this.panel2.Controls.Add(this.ResetDB);
            this.panel2.Controls.Add(this.btnMLD);
            this.panel2.Controls.Add(this.btnMCD);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnScriptSQL);
            this.panel2.Location = new System.Drawing.Point(12, 405);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(457, 51);
            this.panel2.TabIndex = 19;
            // 
            // ResetDB
            // 
            this.ResetDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(239)))));
            this.ResetDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetDB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(45)))));
            this.ResetDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetDB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(45)))));
            this.ResetDB.Location = new System.Drawing.Point(251, 11);
            this.ResetDB.Name = "ResetDB";
            this.ResetDB.Size = new System.Drawing.Size(177, 31);
            this.ResetDB.TabIndex = 10;
            this.ResetDB.Text = "⚠️ réinitialisation de la base ⚠️";
            this.ResetDB.UseVisualStyleBackColor = false;
            this.ResetDB.Click += new System.EventHandler(this.ResetDB_Click);
            // 
            // btnMLD
            // 
            this.btnMLD.BackColor = System.Drawing.Color.Black;
            this.btnMLD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMLD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(45)))));
            this.btnMLD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnMLD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMLD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnMLD.Location = new System.Drawing.Point(171, 11);
            this.btnMLD.Name = "btnMLD";
            this.btnMLD.Size = new System.Drawing.Size(58, 31);
            this.btnMLD.TabIndex = 9;
            this.btnMLD.Text = "MLD 📄";
            this.btnMLD.UseVisualStyleBackColor = false;
            this.btnMLD.Click += new System.EventHandler(this.btnMLD_Click);
            // 
            // btnMCD
            // 
            this.btnMCD.BackColor = System.Drawing.Color.Black;
            this.btnMCD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMCD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(45)))));
            this.btnMCD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnMCD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMCD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnMCD.Location = new System.Drawing.Point(104, 11);
            this.btnMCD.Name = "btnMCD";
            this.btnMCD.Size = new System.Drawing.Size(61, 31);
            this.btnMCD.TabIndex = 8;
            this.btnMCD.Text = "MCD 📄";
            this.btnMCD.UseVisualStyleBackColor = false;
            this.btnMCD.Click += new System.EventHandler(this.btnMCD_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(45)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 51);
            this.panel3.TabIndex = 7;
            // 
            // btnScriptSQL
            // 
            this.btnScriptSQL.BackColor = System.Drawing.Color.Black;
            this.btnScriptSQL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScriptSQL.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(45)))));
            this.btnScriptSQL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnScriptSQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScriptSQL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnScriptSQL.Location = new System.Drawing.Point(13, 11);
            this.btnScriptSQL.Name = "btnScriptSQL";
            this.btnScriptSQL.Size = new System.Drawing.Size(85, 31);
            this.btnScriptSQL.TabIndex = 0;
            this.btnScriptSQL.Text = "Script SQL 📜";
            this.btnScriptSQL.UseVisualStyleBackColor = false;
            this.btnScriptSQL.Click += new System.EventHandler(this.btnScriptSQL_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Rechercher dans la base:";
            // 
            // tbSearchGlobal
            // 
            this.tbSearchGlobal.Location = new System.Drawing.Point(211, 63);
            this.tbSearchGlobal.Name = "tbSearchGlobal";
            this.tbSearchGlobal.Size = new System.Drawing.Size(215, 20);
            this.tbSearchGlobal.TabIndex = 17;
            this.tbSearchGlobal.TextChanged += new System.EventHandler(this.tbSearchGlobal_TextChanged);
            // 
            // labelNbElements
            // 
            this.labelNbElements.AutoSize = true;
            this.labelNbElements.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNbElements.Location = new System.Drawing.Point(9, 1);
            this.labelNbElements.Name = "labelNbElements";
            this.labelNbElements.Size = new System.Drawing.Size(217, 31);
            this.labelNbElements.TabIndex = 16;
            this.labelNbElements.Text = "SAUZET SHOP";
            // 
            // DGVGlobal
            // 
            this.DGVGlobal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVGlobal.BackgroundColor = System.Drawing.Color.White;
            this.DGVGlobal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVGlobal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVGlobal.Location = new System.Drawing.Point(15, 95);
            this.DGVGlobal.Name = "DGVGlobal";
            this.DGVGlobal.Size = new System.Drawing.Size(643, 287);
            this.DGVGlobal.TabIndex = 15;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(667, 473);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSearchGlobal);
            this.Controls.Add(this.labelNbElements);
            this.Controls.Add(this.DGVGlobal);
            this.Name = "FrmHome";
            this.Text = "FrmHome";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVGlobal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ResetDB;
        private System.Windows.Forms.Button btnMLD;
        private System.Windows.Forms.Button btnMCD;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnScriptSQL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearchGlobal;
        private System.Windows.Forms.Label labelNbElements;
        private System.Windows.Forms.DataGridView DGVGlobal;
    }
}