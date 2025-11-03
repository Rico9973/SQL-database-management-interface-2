namespace Interface
{
    partial class PageAlerte
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
            this.resultat = new System.Windows.Forms.TextBox();
            this.resultat2 = new System.Windows.Forms.TextBox();
            this.retour_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resultat8 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // resultat
            // 
            this.resultat.Location = new System.Drawing.Point(123, 104);
            this.resultat.Multiline = true;
            this.resultat.Name = "resultat";
            this.resultat.ReadOnly = true;
            this.resultat.Size = new System.Drawing.Size(1400, 221);
            this.resultat.TabIndex = 39;
            // 
            // resultat2
            // 
            this.resultat2.Location = new System.Drawing.Point(123, 402);
            this.resultat2.Multiline = true;
            this.resultat2.Name = "resultat2";
            this.resultat2.ReadOnly = true;
            this.resultat2.Size = new System.Drawing.Size(1400, 221);
            this.resultat2.TabIndex = 40;
            // 
            // retour_button
            // 
            this.retour_button.Location = new System.Drawing.Point(1447, 988);
            this.retour_button.Name = "retour_button";
            this.retour_button.Size = new System.Drawing.Size(92, 36);
            this.retour_button.TabIndex = 66;
            this.retour_button.Text = "retour";
            this.retour_button.UseVisualStyleBackColor = true;
            this.retour_button.Click += new System.EventHandler(this.retour_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 67;
            this.label1.Text = "ALERTE: PIECE ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 25);
            this.label2.TabIndex = 68;
            this.label2.Text = "ALERTE: BYCICLETTE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 661);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(365, 25);
            this.label3.TabIndex = 70;
            this.label3.Text = "ALERTE: MAGASIN SOUS STOCKE ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // resultat8
            // 
            this.resultat8.Location = new System.Drawing.Point(123, 701);
            this.resultat8.Multiline = true;
            this.resultat8.Name = "resultat8";
            this.resultat8.ReadOnly = true;
            this.resultat8.Size = new System.Drawing.Size(1400, 221);
            this.resultat8.TabIndex = 69;
            // 
            // PageAlerte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1674, 1129);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultat8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.retour_button);
            this.Controls.Add(this.resultat2);
            this.Controls.Add(this.resultat);
            this.Name = "PageAlerte";
            this.Text = "PageAlerte";
            this.Load += new System.EventHandler(this.PageAlerte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox resultat;
        public System.Windows.Forms.TextBox resultat2;
        private System.Windows.Forms.Button retour_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox resultat8;
    }
}