namespace gestionRH
{
    partial class LoginGRH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginGRH));
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnConnection = new System.Windows.Forms.Button();
            this.txbMotPasse = new System.Windows.Forms.TextBox();
            this.lblMotPasse = new System.Windows.Forms.Label();
            this.txbNumUtilisateur = new System.Windows.Forms.TextBox();
            this.lblNumEmploye = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(193, 185);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(6);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(150, 46);
            this.btnAnnuler.TabIndex = 4;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnConnection
            // 
            this.btnConnection.Location = new System.Drawing.Point(463, 185);
            this.btnConnection.Margin = new System.Windows.Forms.Padding(6);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(150, 46);
            this.btnConnection.TabIndex = 3;
            this.btnConnection.Text = "Connection";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // txbMotPasse
            // 
            this.txbMotPasse.Location = new System.Drawing.Point(413, 105);
            this.txbMotPasse.Margin = new System.Windows.Forms.Padding(6);
            this.txbMotPasse.Name = "txbMotPasse";
            this.txbMotPasse.PasswordChar = '*';
            this.txbMotPasse.Size = new System.Drawing.Size(196, 31);
            this.txbMotPasse.TabIndex = 2;
            // 
            // lblMotPasse
            // 
            this.lblMotPasse.AutoSize = true;
            this.lblMotPasse.Location = new System.Drawing.Point(187, 111);
            this.lblMotPasse.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMotPasse.Name = "lblMotPasse";
            this.lblMotPasse.Size = new System.Drawing.Size(148, 25);
            this.lblMotPasse.TabIndex = 1;
            this.lblMotPasse.Text = "Mot de passe:";
            // 
            // txbNumUtilisateur
            // 
            this.txbNumUtilisateur.Enabled = false;
            this.txbNumUtilisateur.Location = new System.Drawing.Point(413, 51);
            this.txbNumUtilisateur.Margin = new System.Windows.Forms.Padding(6);
            this.txbNumUtilisateur.Name = "txbNumUtilisateur";
            this.txbNumUtilisateur.Size = new System.Drawing.Size(196, 31);
            this.txbNumUtilisateur.TabIndex = 1;
            // 
            // lblNumEmploye
            // 
            this.lblNumEmploye.AutoSize = true;
            this.lblNumEmploye.Location = new System.Drawing.Point(187, 57);
            this.lblNumEmploye.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNumEmploye.Name = "lblNumEmploye";
            this.lblNumEmploye.Size = new System.Drawing.Size(196, 25);
            this.lblNumEmploye.TabIndex = 0;
            this.lblNumEmploye.Text = "Numéro d\'employé:";
            // 
            // LoginGRH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 283);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnConnection);
            this.Controls.Add(this.txbMotPasse);
            this.Controls.Add(this.lblMotPasse);
            this.Controls.Add(this.txbNumUtilisateur);
            this.Controls.Add(this.lblNumEmploye);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginGRH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Ressouces Humaines";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.TextBox txbMotPasse;
        private System.Windows.Forms.Label lblMotPasse;
        private System.Windows.Forms.TextBox txbNumUtilisateur;
        private System.Windows.Forms.Label lblNumEmploye;
    }
}

