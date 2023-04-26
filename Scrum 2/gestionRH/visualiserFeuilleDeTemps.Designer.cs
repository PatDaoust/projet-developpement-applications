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
            this.richTextBoxVisualiser.Location = new System.Drawing.Point(174, 40);
            this.richTextBoxVisualiser.Name = "richTextBoxVisualiser";
            this.richTextBoxVisualiser.Size = new System.Drawing.Size(253, 491);
            this.richTextBoxVisualiser.TabIndex = 0;
            this.richTextBoxVisualiser.Text = "";
            this.richTextBoxVisualiser.TextChanged += new System.EventHandler(this.richTextBoxVisualiser_TextChanged);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonModifier.Location = new System.Drawing.Point(36, 65);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(98, 23);
            this.buttonModifier.TabIndex = 1;
            this.buttonModifier.Text = "modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // buttonSoumetre
            // 
            this.buttonSoumetre.Location = new System.Drawing.Point(36, 224);
            this.buttonSoumetre.Name = "buttonSoumetre";
            this.buttonSoumetre.Size = new System.Drawing.Size(98, 23);
            this.buttonSoumetre.TabIndex = 2;
            this.buttonSoumetre.Text = "soumettre";
            this.buttonSoumetre.UseVisualStyleBackColor = true;
            this.buttonSoumetre.Click += new System.EventHandler(this.buttonSoumetre_Click);
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(36, 146);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(98, 23);
            this.buttonValider.TabIndex = 3;
            this.buttonValider.Text = "valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // visualiserFeuilleDeTemps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 543);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.buttonSoumetre);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.richTextBoxVisualiser);
            this.Name = "visualiserFeuilleDeTemps";
            this.Text = "visualiserFeuilleDeTemps";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxVisualiser;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonSoumetre;
        private System.Windows.Forms.Button buttonValider;
    }
}