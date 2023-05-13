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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(97, 96);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 24);
            this.btnAnnuler.TabIndex = 4;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnConnection
            // 
            this.btnConnection.Location = new System.Drawing.Point(232, 96);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(75, 24);
            this.btnConnection.TabIndex = 3;
            this.btnConnection.Text = "Connection";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // txbMotPasse
            // 
            this.txbMotPasse.Location = new System.Drawing.Point(206, 54);
            this.txbMotPasse.Name = "txbMotPasse";
            this.txbMotPasse.PasswordChar = '*';
            this.txbMotPasse.Size = new System.Drawing.Size(100, 20);
            this.txbMotPasse.TabIndex = 2;
            // 
            // lblMotPasse
            // 
            this.lblMotPasse.AutoSize = true;
            this.lblMotPasse.Location = new System.Drawing.Point(94, 58);
            this.lblMotPasse.Name = "lblMotPasse";
            this.lblMotPasse.Size = new System.Drawing.Size(74, 13);
            this.lblMotPasse.TabIndex = 1;
            this.lblMotPasse.Text = "Mot de passe:";
            // 
            // txbNumUtilisateur
            // 
            this.txbNumUtilisateur.Enabled = false;
            this.txbNumUtilisateur.Location = new System.Drawing.Point(206, 27);
            this.txbNumUtilisateur.Name = "txbNumUtilisateur";
            this.txbNumUtilisateur.Size = new System.Drawing.Size(100, 20);
            this.txbNumUtilisateur.TabIndex = 1;
            // 
            // lblNumEmploye
            // 
            this.lblNumEmploye.AutoSize = true;
            this.lblNumEmploye.Location = new System.Drawing.Point(94, 29);
            this.lblNumEmploye.Name = "lblNumEmploye";
            this.lblNumEmploye.Size = new System.Drawing.Size(97, 13);
            this.lblNumEmploye.TabIndex = 0;
            this.lblNumEmploye.Text = "Numéro d\'employé:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 140);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ajouter un employé";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LoginGRH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 203);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnConnection);
            this.Controls.Add(this.txbMotPasse);
            this.Controls.Add(this.lblMotPasse);
            this.Controls.Add(this.txbNumUtilisateur);
            this.Controls.Add(this.lblNumEmploye);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginGRH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des Ressouces Humaines";
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
        private System.Windows.Forms.Button button1;
    }
}

