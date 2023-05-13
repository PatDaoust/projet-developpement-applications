namespace gestionRH {
    partial class visualiserFeuilleDeTemps {
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
            this.richTextBoxVisualiser = new System.Windows.Forms.RichTextBox();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonSoumetre = new System.Windows.Forms.Button();
            this.buttonValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxVisualiser
            // 
            this.richTextBoxVisualiser.Location = new System.Drawing.Point(239, 60);
            this.richTextBoxVisualiser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBoxVisualiser.Name = "richTextBoxVisualiser";
            this.richTextBoxVisualiser.Size = new System.Drawing.Size(347, 735);
            this.richTextBoxVisualiser.TabIndex = 0;
            this.richTextBoxVisualiser.Text = "";
            // 
            // buttonModifier
            // 
            this.buttonModifier.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonModifier.Location = new System.Drawing.Point(50, 98);
            this.buttonModifier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(135, 35);
            this.buttonModifier.TabIndex = 1;
            this.buttonModifier.Text = "modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // buttonSoumetre
            // 
            this.buttonSoumetre.Location = new System.Drawing.Point(50, 336);
            this.buttonSoumetre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSoumetre.Name = "buttonSoumetre";
            this.buttonSoumetre.Size = new System.Drawing.Size(135, 35);
            this.buttonSoumetre.TabIndex = 2;
            this.buttonSoumetre.Text = "soumettre";
            this.buttonSoumetre.UseVisualStyleBackColor = true;
            this.buttonSoumetre.Click += new System.EventHandler(this.buttonSoumetre_Click);
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(50, 219);
            this.buttonValider.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(135, 35);
            this.buttonValider.TabIndex = 3;
            this.buttonValider.Text = "valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // visualiserFeuilleDeTemps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 814);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.buttonSoumetre);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.richTextBoxVisualiser);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "visualiserFeuilleDeTemps";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualiser Feuille De Temps";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxVisualiser;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonSoumetre;
        private System.Windows.Forms.Button buttonValider;
    }
}