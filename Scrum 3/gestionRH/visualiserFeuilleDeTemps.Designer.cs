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
            this.dgvFeuillesTempsVisual = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeuillesTempsVisual)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxVisualiser
            // 
            this.richTextBoxVisualiser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxVisualiser.Location = new System.Drawing.Point(130, 32);
            this.richTextBoxVisualiser.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.richTextBoxVisualiser.Name = "richTextBoxVisualiser";
            this.richTextBoxVisualiser.Size = new System.Drawing.Size(494, 170);
            this.richTextBoxVisualiser.TabIndex = 0;
            this.richTextBoxVisualiser.Text = "";
            // 
            // buttonModifier
            // 
            this.buttonModifier.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonModifier.Location = new System.Drawing.Point(27, 53);
            this.buttonModifier.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(74, 19);
            this.buttonModifier.TabIndex = 1;
            this.buttonModifier.Text = "modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // buttonSoumetre
            // 
            this.buttonSoumetre.Location = new System.Drawing.Point(27, 182);
            this.buttonSoumetre.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonSoumetre.Name = "buttonSoumetre";
            this.buttonSoumetre.Size = new System.Drawing.Size(74, 19);
            this.buttonSoumetre.TabIndex = 2;
            this.buttonSoumetre.Text = "soumettre";
            this.buttonSoumetre.UseVisualStyleBackColor = true;
            this.buttonSoumetre.Click += new System.EventHandler(this.buttonSoumetre_Click);
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(27, 119);
            this.buttonValider.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(74, 19);
            this.buttonValider.TabIndex = 3;
            this.buttonValider.Text = "valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // dgvFeuillesTempsVisual
            // 
            this.dgvFeuillesTempsVisual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFeuillesTempsVisual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeuillesTempsVisual.Location = new System.Drawing.Point(27, 236);
            this.dgvFeuillesTempsVisual.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvFeuillesTempsVisual.Name = "dgvFeuillesTempsVisual";
            this.dgvFeuillesTempsVisual.RowHeadersWidth = 36;
            this.dgvFeuillesTempsVisual.RowTemplate.Height = 31;
            this.dgvFeuillesTempsVisual.Size = new System.Drawing.Size(597, 173);
            this.dgvFeuillesTempsVisual.TabIndex = 4;
            // 
            // visualiserFeuilleDeTemps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 441);
            this.Controls.Add(this.dgvFeuillesTempsVisual);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.buttonSoumetre);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.richTextBoxVisualiser);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "visualiserFeuilleDeTemps";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualiser Feuille De Temps";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeuillesTempsVisual)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxVisualiser;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonSoumetre;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.DataGridView dgvFeuillesTempsVisual;
    }
}