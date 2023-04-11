namespace gestionRH
{
    partial class FeuilleTempsGRH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeuilleTempsGRH));
            this.txbNumEmploye = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnOuvrir = new System.Windows.Forms.Button();
            this.rtbAffiche = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txbNumEmploye
            // 
            this.txbNumEmploye.Enabled = false;
            this.txbNumEmploye.Location = new System.Drawing.Point(188, 64);
            this.txbNumEmploye.Name = "txbNumEmploye";
            this.txbNumEmploye.Size = new System.Drawing.Size(205, 31);
            this.txbNumEmploye.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(188, 144);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(205, 31);
            this.textBox2.TabIndex = 1;
            // 
            // btnOuvrir
            // 
            this.btnOuvrir.Location = new System.Drawing.Point(188, 243);
            this.btnOuvrir.Name = "btnOuvrir";
            this.btnOuvrir.Size = new System.Drawing.Size(129, 38);
            this.btnOuvrir.TabIndex = 2;
            this.btnOuvrir.Text = "Ouvrir";
            this.btnOuvrir.UseVisualStyleBackColor = true;
            this.btnOuvrir.Click += new System.EventHandler(this.btnOuvrir_Click);
            // 
            // rtbAffiche
            // 
            this.rtbAffiche.Location = new System.Drawing.Point(351, 204);
            this.rtbAffiche.Name = "rtbAffiche";
            this.rtbAffiche.Size = new System.Drawing.Size(554, 304);
            this.rtbAffiche.TabIndex = 3;
            this.rtbAffiche.Text = "";
            // 
            // FeuilleTempsGRH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 552);
            this.Controls.Add(this.rtbAffiche);
            this.Controls.Add(this.btnOuvrir);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txbNumEmploye);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FeuilleTempsGRH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FeuilleTempsGRH";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNumEmploye;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnOuvrir;
        private System.Windows.Forms.RichTextBox rtbAffiche;
    }
}