namespace gestionRH
{
    partial class InterfaceAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfaceAdmin));
            this.btnMenuEmploye = new System.Windows.Forms.Button();
            this.btnMenuAdmin = new System.Windows.Forms.Button();
            this.txbLoginUtilisateur = new System.Windows.Forms.TextBox();
            this.lblNumEmploye = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMenuEmploye
            // 
            this.btnMenuEmploye.Location = new System.Drawing.Point(190, 159);
            this.btnMenuEmploye.Margin = new System.Windows.Forms.Padding(6);
            this.btnMenuEmploye.Name = "btnMenuEmploye";
            this.btnMenuEmploye.Size = new System.Drawing.Size(174, 72);
            this.btnMenuEmploye.TabIndex = 2;
            this.btnMenuEmploye.Text = "  Menu   Employé";
            this.btnMenuEmploye.UseVisualStyleBackColor = true;
            this.btnMenuEmploye.Click += new System.EventHandler(this.btnMenuEmploye_Click);
            // 
            // btnMenuAdmin
            // 
            this.btnMenuAdmin.Location = new System.Drawing.Point(435, 159);
            this.btnMenuAdmin.Margin = new System.Windows.Forms.Padding(6);
            this.btnMenuAdmin.Name = "btnMenuAdmin";
            this.btnMenuAdmin.Size = new System.Drawing.Size(174, 72);
            this.btnMenuAdmin.TabIndex = 1;
            this.btnMenuAdmin.Text = "Menu Administration";
            this.btnMenuAdmin.UseVisualStyleBackColor = true;
            this.btnMenuAdmin.Click += new System.EventHandler(this.btnMenuAdmin_Click);
            // 
            // txbLoginUtilisateur
            // 
            this.txbLoginUtilisateur.Location = new System.Drawing.Point(413, 51);
            this.txbLoginUtilisateur.Margin = new System.Windows.Forms.Padding(6);
            this.txbLoginUtilisateur.Name = "txbLoginUtilisateur";
            this.txbLoginUtilisateur.Size = new System.Drawing.Size(196, 31);
            this.txbLoginUtilisateur.TabIndex = 0;
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
            // InterfaceAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 283);
            this.Controls.Add(this.btnMenuEmploye);
            this.Controls.Add(this.btnMenuAdmin);
            this.Controls.Add(this.txbLoginUtilisateur);
            this.Controls.Add(this.lblNumEmploye);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InterfaceAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu de sélection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenuEmploye;
        private System.Windows.Forms.Button btnMenuAdmin;
        private System.Windows.Forms.TextBox txbLoginUtilisateur;
        private System.Windows.Forms.Label lblNumEmploye;
    }
}