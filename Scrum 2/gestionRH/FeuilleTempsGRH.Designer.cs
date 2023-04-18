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
            this.SuspendLayout();
            // 
            // txbNumEmploye
            // 
            this.txbNumUtilisateur.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNumUtilisateur.Enabled = false;
            this.txbNumUtilisateur.Location = new System.Drawing.Point(176, 20);
            this.txbNumUtilisateur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbNumUtilisateur.Name = "txbNumEmploye";
            this.txbNumUtilisateur.Size = new System.Drawing.Size(129, 20);
            this.txbNumUtilisateur.TabIndex = 0;
            // 
            // txbFichierOuvert
            // 
            this.txbFichierOuvert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbFichierOuvert.Enabled = false;
            this.txbFichierOuvert.Location = new System.Drawing.Point(176, 50);
            this.txbFichierOuvert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbFichierOuvert.Name = "txbFichierOuvert";
            this.txbFichierOuvert.Size = new System.Drawing.Size(283, 20);
            this.txbFichierOuvert.TabIndex = 1;
            // 
            // btnOuvrir
            // 
            this.btnOuvrir.Location = new System.Drawing.Point(94, 126);
            this.btnOuvrir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOuvrir.Name = "btnOuvrir";
            this.btnOuvrir.Size = new System.Drawing.Size(64, 20);
            this.btnOuvrir.TabIndex = 2;
            this.btnOuvrir.Text = "Ouvrir";
            this.btnOuvrir.UseVisualStyleBackColor = true;
            this.btnOuvrir.Click += new System.EventHandler(this.btnOuvrir_Click);
            // 
            // rtbAffiche
            // 
            this.rtbAffiche.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbAffiche.Location = new System.Drawing.Point(176, 106);
            this.rtbAffiche.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbAffiche.Name = "rtbAffiche";
            this.rtbAffiche.Size = new System.Drawing.Size(283, 584);
            this.rtbAffiche.TabIndex = 3;
            this.rtbAffiche.Text = "";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(94, 171);
            this.btnValider.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(64, 20);
            this.btnValider.TabIndex = 4;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnRapport
            // 
            this.btnRapport.Location = new System.Drawing.Point(94, 216);
            this.btnRapport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRapport.Name = "btnRapport";
            this.btnRapport.Size = new System.Drawing.Size(64, 34);
            this.btnRapport.TabIndex = 5;
            this.btnRapport.Text = "Exporter Rapport";
            this.btnRapport.UseVisualStyleBackColor = true;
            this.btnRapport.Click += new System.EventHandler(this.btnRapport_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(97, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenue:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(60, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fichier sélectionné:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Feuille de temps chargée:";
            // 
            // FeuilleTempsGRH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 711);
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
            this.MinimumSize = new System.Drawing.Size(450, 600);
            this.Name = "FeuilleTempsGRH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FeuilleTempsGRH";
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
    }
}