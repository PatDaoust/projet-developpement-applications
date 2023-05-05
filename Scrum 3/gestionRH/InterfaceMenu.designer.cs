namespace gestionRH
{
    partial class InterfaceMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfaceMenu));
            this.btnMenuEmploye = new System.Windows.Forms.Button();
            this.btnMenuAdmin = new System.Windows.Forms.Button();
            this.txbLoginUtilisateur = new System.Windows.Forms.TextBox();
            this.lblNumEmploye = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // btnMenuEmploye
            // 
            this.btnMenuEmploye.Location = new System.Drawing.Point(127, 102);
            this.btnMenuEmploye.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenuEmploye.Name = "btnMenuEmploye";
            this.btnMenuEmploye.Size = new System.Drawing.Size(116, 46);
            this.btnMenuEmploye.TabIndex = 2;
            this.btnMenuEmploye.Text = "  Menu   Employé";
            this.btnMenuEmploye.UseVisualStyleBackColor = true;
            this.btnMenuEmploye.Click += new System.EventHandler(this.btnMenuEmploye_Click);
            // 
            // btnMenuAdmin
            // 
            this.btnMenuAdmin.Location = new System.Drawing.Point(290, 102);
            this.btnMenuAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenuAdmin.Name = "btnMenuAdmin";
            this.btnMenuAdmin.Size = new System.Drawing.Size(116, 46);
            this.btnMenuAdmin.TabIndex = 3;
            this.btnMenuAdmin.Text = "Menu Administration";
            this.btnMenuAdmin.UseVisualStyleBackColor = true;
            this.btnMenuAdmin.Click += new System.EventHandler(this.btnMenuAdmin_Click);
            // 
            // txbLoginUtilisateur
            // 
            this.txbLoginUtilisateur.Location = new System.Drawing.Point(275, 33);
            this.txbLoginUtilisateur.Margin = new System.Windows.Forms.Padding(4);
            this.txbLoginUtilisateur.Name = "txbLoginUtilisateur";
            this.txbLoginUtilisateur.Size = new System.Drawing.Size(132, 22);
            this.txbLoginUtilisateur.TabIndex = 1;
            // 
            // lblNumEmploye
            // 
            this.lblNumEmploye.AutoSize = true;
            this.lblNumEmploye.Location = new System.Drawing.Point(125, 36);
            this.lblNumEmploye.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumEmploye.Name = "lblNumEmploye";
            this.lblNumEmploye.Size = new System.Drawing.Size(125, 16);
            this.lblNumEmploye.TabIndex = 0;
            this.lblNumEmploye.Text = "Numéro d\'employé:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 62);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(278, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ajouter un employé";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // InterfaceMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 299);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMenuEmploye);
            this.Controls.Add(this.btnMenuAdmin);
            this.Controls.Add(this.txbLoginUtilisateur);
            this.Controls.Add(this.lblNumEmploye);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InterfaceMenu";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}