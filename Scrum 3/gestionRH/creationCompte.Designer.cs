namespace gestionRH {
    partial class creationCompte {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelNumeroEmployee = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxNumeroEmployee = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.buttonCreeCompte = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelMDP1 = new System.Windows.Forms.Label();
            this.labelMDP2 = new System.Windows.Forms.Label();
            this.textBoxMDP1 = new System.Windows.Forms.TextBox();
            this.textBoxMDP2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Creation de Compe";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(130, 27);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(36, 16);
            this.labelNom.TabIndex = 1;
            this.labelNom.Text = "Nom";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(113, 71);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(54, 16);
            this.labelPrenom.TabIndex = 2;
            this.labelPrenom.Text = "Prenom";
            // 
            // labelNumeroEmployee
            // 
            this.labelNumeroEmployee.AutoSize = true;
            this.labelNumeroEmployee.Location = new System.Drawing.Point(37, 120);
            this.labelNumeroEmployee.Name = "labelNumeroEmployee";
            this.labelNumeroEmployee.Size = new System.Drawing.Size(130, 16);
            this.labelNumeroEmployee.TabIndex = 3;
            this.labelNumeroEmployee.Text = "Numero d\'employee";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(183, 23);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(115, 22);
            this.textBoxNom.TabIndex = 4;
            // 
            // textBoxNumeroEmployee
            // 
            this.textBoxNumeroEmployee.Location = new System.Drawing.Point(183, 120);
            this.textBoxNumeroEmployee.Name = "textBoxNumeroEmployee";
            this.textBoxNumeroEmployee.Size = new System.Drawing.Size(115, 22);
            this.textBoxNumeroEmployee.TabIndex = 5;
            this.textBoxNumeroEmployee.Leave += new System.EventHandler(this.textBoxNumeroEmployee_Leave);
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(183, 71);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(115, 22);
            this.textBoxPrenom.TabIndex = 6;
            // 
            // buttonCreeCompte
            // 
            this.buttonCreeCompte.Location = new System.Drawing.Point(119, 391);
            this.buttonCreeCompte.Name = "buttonCreeCompte";
            this.buttonCreeCompte.Size = new System.Drawing.Size(170, 36);
            this.buttonCreeCompte.TabIndex = 7;
            this.buttonCreeCompte.Text = "Cree Mon Compte";
            this.buttonCreeCompte.UseVisualStyleBackColor = true;
            this.buttonCreeCompte.Click += new System.EventHandler(this.buttonCreeCompte_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.textBoxMDP2);
            this.panel1.Controls.Add(this.textBoxMDP1);
            this.panel1.Controls.Add(this.labelMDP2);
            this.panel1.Controls.Add(this.labelMDP1);
            this.panel1.Controls.Add(this.labelNom);
            this.panel1.Controls.Add(this.labelPrenom);
            this.panel1.Controls.Add(this.textBoxPrenom);
            this.panel1.Controls.Add(this.labelNumeroEmployee);
            this.panel1.Controls.Add(this.textBoxNumeroEmployee);
            this.panel1.Controls.Add(this.textBoxNom);
            this.panel1.Location = new System.Drawing.Point(27, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 263);
            this.panel1.TabIndex = 8;
            // 
            // labelMDP1
            // 
            this.labelMDP1.AutoSize = true;
            this.labelMDP1.Location = new System.Drawing.Point(76, 167);
            this.labelMDP1.Name = "labelMDP1";
            this.labelMDP1.Size = new System.Drawing.Size(90, 16);
            this.labelMDP1.TabIndex = 7;
            this.labelMDP1.Text = "Mot de Passe";
            // 
            // labelMDP2
            // 
            this.labelMDP2.AutoSize = true;
            this.labelMDP2.Location = new System.Drawing.Point(16, 209);
            this.labelMDP2.Name = "labelMDP2";
            this.labelMDP2.Size = new System.Drawing.Size(150, 16);
            this.labelMDP2.TabIndex = 8;
            this.labelMDP2.Text = "Confirmer Mot de Passe";
            // 
            // textBoxMDP1
            // 
            this.textBoxMDP1.Location = new System.Drawing.Point(183, 167);
            this.textBoxMDP1.Name = "textBoxMDP1";
            this.textBoxMDP1.PasswordChar = '*';
            this.textBoxMDP1.Size = new System.Drawing.Size(115, 22);
            this.textBoxMDP1.TabIndex = 9;
            this.textBoxMDP1.UseSystemPasswordChar = true;
            // 
            // textBoxMDP2
            // 
            this.textBoxMDP2.Location = new System.Drawing.Point(183, 209);
            this.textBoxMDP2.Name = "textBoxMDP2";
            this.textBoxMDP2.PasswordChar = '*';
            this.textBoxMDP2.Size = new System.Drawing.Size(115, 22);
            this.textBoxMDP2.TabIndex = 10;
            this.textBoxMDP2.UseSystemPasswordChar = true;
            // 
            // creationCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 478);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonCreeCompte);
            this.Controls.Add(this.label1);
            this.Name = "creationCompte";
            this.Text = "creationCompte";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelNumeroEmployee;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxNumeroEmployee;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.Button buttonCreeCompte;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelMDP2;
        private System.Windows.Forms.Label labelMDP1;
        private System.Windows.Forms.TextBox textBoxMDP2;
        private System.Windows.Forms.TextBox textBoxMDP1;
    }
}