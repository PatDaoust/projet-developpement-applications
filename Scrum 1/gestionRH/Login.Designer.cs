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
            this.lblNumEmploye = new System.Windows.Forms.Label();
            this.txbNumUtilisateur = new System.Windows.Forms.TextBox();
            this.btnConnection = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumEmploye
            // 
            this.lblNumEmploye.AutoSize = true;
            this.lblNumEmploye.Location = new System.Drawing.Point(88, 43);
            this.lblNumEmploye.Name = "lblNumEmploye";
            this.lblNumEmploye.Size = new System.Drawing.Size(97, 13);
            this.lblNumEmploye.TabIndex = 0;
            this.lblNumEmploye.Text = "Numéro d\'employé:";
            // 
            // txbNumEmploye
            // 
            this.txbNumUtilisateur.Location = new System.Drawing.Point(201, 40);
            this.txbNumUtilisateur.Name = "txbNumEmploye";
            this.txbNumUtilisateur.Size = new System.Drawing.Size(100, 20);
            this.txbNumUtilisateur.TabIndex = 1;
            // 
            // btnConnection
            // 
            this.btnConnection.Location = new System.Drawing.Point(226, 89);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(75, 23);
            this.btnConnection.TabIndex = 2;
            this.btnConnection.Text = "Connection";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(91, 89);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 3;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // LoginGRH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 147);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnConnection);
            this.Controls.Add(this.txbNumUtilisateur);
            this.Controls.Add(this.lblNumEmploye);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginGRH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Ressouces Humaines";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumEmploye;
        private System.Windows.Forms.TextBox txbNumUtilisateur;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.Button btnAnnuler;
    }
}

