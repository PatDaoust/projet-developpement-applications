namespace gestionRH
{
    partial class FeuilleTempsGRH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeuilleTempsGRH));
            this.txbNumUtilisateur = new System.Windows.Forms.TextBox();
            this.txbFichierOuvert = new System.Windows.Forms.TextBox();
            this.btnOuvrir = new System.Windows.Forms.Button();
            this.rtbAffiche = new System.Windows.Forms.RichTextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnRapport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvFeuillesTempsAdmin = new System.Windows.Forms.DataGridView();
            this.btnRafraichir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeuillesTempsAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // txbNumUtilisateur
            // 
            this.txbNumUtilisateur.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNumUtilisateur.Enabled = false;
            this.txbNumUtilisateur.Location = new System.Drawing.Point(323, 37);
            this.txbNumUtilisateur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbNumUtilisateur.Name = "txbNumUtilisateur";
            this.txbNumUtilisateur.Size = new System.Drawing.Size(233, 29);
            this.txbNumUtilisateur.TabIndex = 0;
            // 
            // txbFichierOuvert
            // 
            this.txbFichierOuvert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbFichierOuvert.Enabled = false;
            this.txbFichierOuvert.Location = new System.Drawing.Point(323, 92);
            this.txbFichierOuvert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbFichierOuvert.Name = "txbFichierOuvert";
            this.txbFichierOuvert.Size = new System.Drawing.Size(516, 29);
            this.txbFichierOuvert.TabIndex = 1;
            // 
            // btnOuvrir
            // 
            this.btnOuvrir.Location = new System.Drawing.Point(172, 233);
            this.btnOuvrir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOuvrir.Name = "btnOuvrir";
            this.btnOuvrir.Size = new System.Drawing.Size(117, 37);
            this.btnOuvrir.TabIndex = 2;
            this.btnOuvrir.Text = "Ouvrir";
            this.btnOuvrir.UseVisualStyleBackColor = true;
            this.btnOuvrir.Click += new System.EventHandler(this.btnOuvrir_Click);
            // 
            // rtbAffiche
            // 
            this.rtbAffiche.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbAffiche.Location = new System.Drawing.Point(323, 196);
            this.rtbAffiche.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbAffiche.Name = "rtbAffiche";
            this.rtbAffiche.Size = new System.Drawing.Size(516, 262);
            this.rtbAffiche.TabIndex = 3;
            this.rtbAffiche.Text = "";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(172, 316);
            this.btnValider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(117, 37);
            this.btnValider.TabIndex = 4;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnRapport
            // 
            this.btnRapport.Location = new System.Drawing.Point(172, 399);
            this.btnRapport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRapport.Name = "btnRapport";
            this.btnRapport.Size = new System.Drawing.Size(117, 63);
            this.btnRapport.TabIndex = 5;
            this.btnRapport.Text = "Exporter Rapport";
            this.btnRapport.UseVisualStyleBackColor = true;
            this.btnRapport.Click += new System.EventHandler(this.btnRapport_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(178, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenue:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(110, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fichier sélectionné:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Feuille de temps chargée:";
            // 
            // dgvFeuillesTempsAdmin
            // 
            this.dgvFeuillesTempsAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFeuillesTempsAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeuillesTempsAdmin.Location = new System.Drawing.Point(38, 504);
            this.dgvFeuillesTempsAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvFeuillesTempsAdmin.Name = "dgvFeuillesTempsAdmin";
            this.dgvFeuillesTempsAdmin.RowHeadersWidth = 36;
            this.dgvFeuillesTempsAdmin.RowTemplate.Height = 31;
            this.dgvFeuillesTempsAdmin.Size = new System.Drawing.Size(803, 489);
            this.dgvFeuillesTempsAdmin.TabIndex = 9;
            this.dgvFeuillesTempsAdmin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFeuillesTempsAdmin_CellClick);
            // 
            // btnRafraichir
            // 
            this.btnRafraichir.Location = new System.Drawing.Point(172, 155);
            this.btnRafraichir.Margin = new System.Windows.Forms.Padding(4);
            this.btnRafraichir.Name = "btnRafraichir";
            this.btnRafraichir.Size = new System.Drawing.Size(117, 37);
            this.btnRafraichir.TabIndex = 10;
            this.btnRafraichir.Text = "Rafraichir";
            this.btnRafraichir.UseVisualStyleBackColor = true;
            this.btnRafraichir.Click += new System.EventHandler(this.btnRafraichir_Click);
            // 
            // FeuilleTempsGRH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 1036);
            this.Controls.Add(this.btnRafraichir);
            this.Controls.Add(this.dgvFeuillesTempsAdmin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRapport);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.rtbAffiche);
            this.Controls.Add(this.btnOuvrir);
            this.Controls.Add(this.txbFichierOuvert);
            this.Controls.Add(this.txbNumUtilisateur);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MinimumSize = new System.Drawing.Size(805, 1054);
            this.Name = "FeuilleTempsGRH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FeuilleTempsGRH";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeuillesTempsAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNumUtilisateur;
        private System.Windows.Forms.TextBox txbFichierOuvert;
        private System.Windows.Forms.Button btnOuvrir;
        private System.Windows.Forms.RichTextBox rtbAffiche;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnRapport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvFeuillesTempsAdmin;
        private System.Windows.Forms.Button btnRafraichir;
    }
}