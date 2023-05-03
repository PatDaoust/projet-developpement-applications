namespace gestionRH {
    partial class EntreeFeuilleDeTemps {
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
            this.labelnumeroEmployee = new System.Windows.Forms.Label();
            this.labelMois = new System.Windows.Forms.Label();
            this.labelJourDuMois = new System.Windows.Forms.Label();
            this.labelJour1 = new System.Windows.Forms.Label();
            this.labelJour1Projet = new System.Windows.Forms.Label();
            this.labelJour1Minutes = new System.Windows.Forms.Label();
            this.panelID = new System.Windows.Forms.Panel();
            this.textBoxNumeroEmployee = new System.Windows.Forms.TextBox();
            this.comboBoxJourDuMois = new System.Windows.Forms.ComboBox();
            this.comboBoxMois = new System.Windows.Forms.ComboBox();
            this.panelJour1 = new System.Windows.Forms.Panel();
            this.comboBoxJours = new System.Windows.Forms.ComboBox();
            this.buttonAjouterJour1 = new System.Windows.Forms.Button();
            this.textBoxJour1Minutes = new System.Windows.Forms.TextBox();
            this.textBoxJour1Projet = new System.Windows.Forms.TextBox();
            this.buttonVisualiser = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxSuprimerProjet = new System.Windows.Forms.ComboBox();
            this.comboBoxSupprimerJour = new System.Windows.Forms.ComboBox();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAutofill = new System.Windows.Forms.Button();
            this.panelID.SuspendLayout();
            this.panelJour1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelnumeroEmployee
            // 
            this.labelnumeroEmployee.AutoSize = true;
            this.labelnumeroEmployee.Location = new System.Drawing.Point(23, 20);
            this.labelnumeroEmployee.Name = "labelnumeroEmployee";
            this.labelnumeroEmployee.Size = new System.Drawing.Size(130, 16);
            this.labelnumeroEmployee.TabIndex = 0;
            this.labelnumeroEmployee.Text = "Numero D\'employe: ";
            // 
            // labelMois
            // 
            this.labelMois.AutoSize = true;
            this.labelMois.Location = new System.Drawing.Point(23, 52);
            this.labelMois.Name = "labelMois";
            this.labelMois.Size = new System.Drawing.Size(42, 16);
            this.labelMois.TabIndex = 1;
            this.labelMois.Text = "Mois: ";
            // 
            // labelJourDuMois
            // 
            this.labelJourDuMois.AutoSize = true;
            this.labelJourDuMois.Location = new System.Drawing.Point(23, 84);
            this.labelJourDuMois.Name = "labelJourDuMois";
            this.labelJourDuMois.Size = new System.Drawing.Size(89, 16);
            this.labelJourDuMois.TabIndex = 2;
            this.labelJourDuMois.Text = "Jour du mois: ";
            // 
            // labelJour1
            // 
            this.labelJour1.AutoSize = true;
            this.labelJour1.Location = new System.Drawing.Point(23, 28);
            this.labelJour1.Name = "labelJour1";
            this.labelJour1.Size = new System.Drawing.Size(42, 16);
            this.labelJour1.TabIndex = 3;
            this.labelJour1.Text = "Jour:  ";
            // 
            // labelJour1Projet
            // 
            this.labelJour1Projet.AutoSize = true;
            this.labelJour1Projet.Location = new System.Drawing.Point(23, 67);
            this.labelJour1Projet.Name = "labelJour1Projet";
            this.labelJour1Projet.Size = new System.Drawing.Size(48, 16);
            this.labelJour1Projet.TabIndex = 4;
            this.labelJour1Projet.Text = "Projet: ";
            // 
            // labelJour1Minutes
            // 
            this.labelJour1Minutes.AutoSize = true;
            this.labelJour1Minutes.Location = new System.Drawing.Point(21, 101);
            this.labelJour1Minutes.Name = "labelJour1Minutes";
            this.labelJour1Minutes.Size = new System.Drawing.Size(59, 16);
            this.labelJour1Minutes.TabIndex = 5;
            this.labelJour1Minutes.Text = "Minutes: ";
            // 
            // panelID
            // 
            this.panelID.BackColor = System.Drawing.Color.Silver;
            this.panelID.Controls.Add(this.textBoxNumeroEmployee);
            this.panelID.Controls.Add(this.comboBoxJourDuMois);
            this.panelID.Controls.Add(this.comboBoxMois);
            this.panelID.Controls.Add(this.labelnumeroEmployee);
            this.panelID.Controls.Add(this.labelMois);
            this.panelID.Controls.Add(this.labelJourDuMois);
            this.panelID.Location = new System.Drawing.Point(42, 31);
            this.panelID.Name = "panelID";
            this.panelID.Size = new System.Drawing.Size(348, 123);
            this.panelID.TabIndex = 6;
            // 
            // textBoxNumeroEmployee
            // 
            this.textBoxNumeroEmployee.Enabled = false;
            this.textBoxNumeroEmployee.Location = new System.Drawing.Point(188, 19);
            this.textBoxNumeroEmployee.Name = "textBoxNumeroEmployee";
            this.textBoxNumeroEmployee.Size = new System.Drawing.Size(121, 22);
            this.textBoxNumeroEmployee.TabIndex = 8;
            this.textBoxNumeroEmployee.Leave += new System.EventHandler(this.textBoxNumeroEmployee_Leave);
            // 
            // comboBoxJourDuMois
            // 
            this.comboBoxJourDuMois.FormattingEnabled = true;
            this.comboBoxJourDuMois.Location = new System.Drawing.Point(188, 82);
            this.comboBoxJourDuMois.Name = "comboBoxJourDuMois";
            this.comboBoxJourDuMois.Size = new System.Drawing.Size(121, 24);
            this.comboBoxJourDuMois.TabIndex = 7;
            this.comboBoxJourDuMois.SelectedIndexChanged += new System.EventHandler(this.comboBoxJourDuMois_SelectedIndexChanged);
            // 
            // comboBoxMois
            // 
            this.comboBoxMois.FormattingEnabled = true;
            this.comboBoxMois.Items.AddRange(new object[] {
            "Janvier",
            "Février",
            "Mars",
            "Avril",
            "Mai",
            "Juin",
            "Juillet",
            "Août",
            "Septembre",
            "Octobre",
            "Novembre",
            "Décembre"});
            this.comboBoxMois.Location = new System.Drawing.Point(188, 52);
            this.comboBoxMois.Name = "comboBoxMois";
            this.comboBoxMois.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMois.TabIndex = 3;
            this.comboBoxMois.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panelJour1
            // 
            this.panelJour1.BackColor = System.Drawing.Color.Silver;
            this.panelJour1.Controls.Add(this.comboBoxJours);
            this.panelJour1.Controls.Add(this.buttonAjouterJour1);
            this.panelJour1.Controls.Add(this.textBoxJour1Minutes);
            this.panelJour1.Controls.Add(this.textBoxJour1Projet);
            this.panelJour1.Controls.Add(this.labelJour1);
            this.panelJour1.Controls.Add(this.labelJour1Projet);
            this.panelJour1.Controls.Add(this.labelJour1Minutes);
            this.panelJour1.Location = new System.Drawing.Point(42, 178);
            this.panelJour1.Name = "panelJour1";
            this.panelJour1.Size = new System.Drawing.Size(348, 194);
            this.panelJour1.TabIndex = 7;
            // 
            // comboBoxJours
            // 
            this.comboBoxJours.FormattingEnabled = true;
            this.comboBoxJours.Items.AddRange(new object[] {
            "jour1",
            "jour2",
            "jour3",
            "jour4",
            "jour5",
            "weekend1",
            "weekend2"});
            this.comboBoxJours.Location = new System.Drawing.Point(188, 28);
            this.comboBoxJours.Name = "comboBoxJours";
            this.comboBoxJours.Size = new System.Drawing.Size(121, 24);
            this.comboBoxJours.TabIndex = 11;
            // 
            // buttonAjouterJour1
            // 
            this.buttonAjouterJour1.Location = new System.Drawing.Point(98, 150);
            this.buttonAjouterJour1.Name = "buttonAjouterJour1";
            this.buttonAjouterJour1.Size = new System.Drawing.Size(129, 23);
            this.buttonAjouterJour1.TabIndex = 10;
            this.buttonAjouterJour1.Text = "Ajouter";
            this.buttonAjouterJour1.UseVisualStyleBackColor = true;
            this.buttonAjouterJour1.Click += new System.EventHandler(this.buttonAjouterJour1_Click);
            // 
            // textBoxJour1Minutes
            // 
            this.textBoxJour1Minutes.Location = new System.Drawing.Point(188, 101);
            this.textBoxJour1Minutes.Name = "textBoxJour1Minutes";
            this.textBoxJour1Minutes.Size = new System.Drawing.Size(121, 22);
            this.textBoxJour1Minutes.TabIndex = 8;
            this.textBoxJour1Minutes.Leave += new System.EventHandler(this.textBoxJour1Projet_Leave);
            // 
            // textBoxJour1Projet
            // 
            this.textBoxJour1Projet.Location = new System.Drawing.Point(188, 67);
            this.textBoxJour1Projet.Name = "textBoxJour1Projet";
            this.textBoxJour1Projet.Size = new System.Drawing.Size(121, 22);
            this.textBoxJour1Projet.TabIndex = 9;
            this.textBoxJour1Projet.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBoxJour1Projet.Leave += new System.EventHandler(this.textBoxJour1Minutes_Leave);
            // 
            // buttonVisualiser
            // 
            this.buttonVisualiser.Location = new System.Drawing.Point(230, 634);
            this.buttonVisualiser.Name = "buttonVisualiser";
            this.buttonVisualiser.Size = new System.Drawing.Size(129, 64);
            this.buttonVisualiser.TabIndex = 8;
            this.buttonVisualiser.Text = "Visualiser votre feuille de temps";
            this.buttonVisualiser.UseVisualStyleBackColor = true;
            this.buttonVisualiser.Click += new System.EventHandler(this.buttonVisualiser_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.comboBoxSuprimerProjet);
            this.panel1.Controls.Add(this.comboBoxSupprimerJour);
            this.panel1.Controls.Add(this.buttonSupprimer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(42, 405);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 170);
            this.panel1.TabIndex = 9;
            // 
            // comboBoxSuprimerProjet
            // 
            this.comboBoxSuprimerProjet.FormattingEnabled = true;
            this.comboBoxSuprimerProjet.Location = new System.Drawing.Point(188, 67);
            this.comboBoxSuprimerProjet.Name = "comboBoxSuprimerProjet";
            this.comboBoxSuprimerProjet.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSuprimerProjet.TabIndex = 12;
            // 
            // comboBoxSupprimerJour
            // 
            this.comboBoxSupprimerJour.FormattingEnabled = true;
            this.comboBoxSupprimerJour.Items.AddRange(new object[] {
            "jour1",
            "jour2",
            "jour3",
            "jour4",
            "jour5",
            "weekend1",
            "weekend2"});
            this.comboBoxSupprimerJour.Location = new System.Drawing.Point(188, 28);
            this.comboBoxSupprimerJour.Name = "comboBoxSupprimerJour";
            this.comboBoxSupprimerJour.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSupprimerJour.TabIndex = 11;
            this.comboBoxSupprimerJour.SelectedIndexChanged += new System.EventHandler(this.comboBoxSupprimerJour_SelectedIndexChanged);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(98, 121);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(129, 23);
            this.buttonSupprimer.TabIndex = 10;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Jour:  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Projet: ";
            // 
            // buttonAutofill
            // 
            this.buttonAutofill.Location = new System.Drawing.Point(66, 634);
            this.buttonAutofill.Name = "buttonAutofill";
            this.buttonAutofill.Size = new System.Drawing.Size(129, 64);
            this.buttonAutofill.TabIndex = 10;
            this.buttonAutofill.Text = "Auto-remplir comme lundi";
            this.buttonAutofill.UseVisualStyleBackColor = true;
            this.buttonAutofill.Click += new System.EventHandler(this.buttonAutofill_Click);
            // 
            // EntreeFeuilleDeTemps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(445, 851);
            this.Controls.Add(this.buttonAutofill);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonVisualiser);
            this.Controls.Add(this.panelJour1);
            this.Controls.Add(this.panelID);
            this.MinimumSize = new System.Drawing.Size(463, 675);
            this.Name = "EntreeFeuilleDeTemps";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EntreeFeuilleDeTemps";
            this.panelID.ResumeLayout(false);
            this.panelID.PerformLayout();
            this.panelJour1.ResumeLayout(false);
            this.panelJour1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelnumeroEmployee;
        private System.Windows.Forms.Label labelMois;
        private System.Windows.Forms.Label labelJourDuMois;
        private System.Windows.Forms.Label labelJour1;
        private System.Windows.Forms.Label labelJour1Projet;
        private System.Windows.Forms.Label labelJour1Minutes;
        private System.Windows.Forms.Panel panelID;
        private System.Windows.Forms.TextBox textBoxNumeroEmployee;
        private System.Windows.Forms.ComboBox comboBoxJourDuMois;
        private System.Windows.Forms.ComboBox comboBoxMois;
        private System.Windows.Forms.Panel panelJour1;
        private System.Windows.Forms.TextBox textBoxJour1Minutes;
        private System.Windows.Forms.TextBox textBoxJour1Projet;
        private System.Windows.Forms.Button buttonAjouterJour1;
        private System.Windows.Forms.Button buttonVisualiser;
        private System.Windows.Forms.ComboBox comboBoxJours;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxSuprimerProjet;
        private System.Windows.Forms.ComboBox comboBoxSupprimerJour;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAutofill;
    }
}