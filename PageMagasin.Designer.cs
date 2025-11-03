namespace Interface
{
    partial class PageMagasin
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
            this.delete_button = new System.Windows.Forms.Button();
            this.idSupp = new System.Windows.Forms.TextBox();
            this.update_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.idB_label = new System.Windows.Forms.Label();
            this.gerant = new System.Windows.Forms.TextBox();
            this.idmag = new System.Windows.Forms.TextBox();
            this.ajouter_button = new System.Windows.Forms.Button();
            this.retour_button = new System.Windows.Forms.Button();
            this.resultat = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.resultatS = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.idMagStock = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.resultatS2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(139, 914);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(126, 36);
            this.delete_button.TabIndex = 97;
            this.delete_button.Text = "supprimer";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // idSupp
            // 
            this.idSupp.Location = new System.Drawing.Point(139, 866);
            this.idSupp.Name = "idSupp";
            this.idSupp.Size = new System.Drawing.Size(68, 31);
            this.idSupp.TabIndex = 96;
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(298, 807);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(126, 36);
            this.update_button.TabIndex = 95;
            this.update_button.Text = "update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 92;
            this.label1.Text = "gérant";
            // 
            // idB_label
            // 
            this.idB_label.AutoSize = true;
            this.idB_label.Location = new System.Drawing.Point(125, 46);
            this.idB_label.Name = "idB_label";
            this.idB_label.Size = new System.Drawing.Size(71, 25);
            this.idB_label.TabIndex = 91;
            this.idB_label.Text = "idMag";
            // 
            // gerant
            // 
            this.gerant.Location = new System.Drawing.Point(228, 756);
            this.gerant.Name = "gerant";
            this.gerant.Size = new System.Drawing.Size(149, 31);
            this.gerant.TabIndex = 90;
            // 
            // idmag
            // 
            this.idmag.Location = new System.Drawing.Point(139, 756);
            this.idmag.Name = "idmag";
            this.idmag.Size = new System.Drawing.Size(68, 31);
            this.idmag.TabIndex = 89;
            // 
            // ajouter_button
            // 
            this.ajouter_button.Location = new System.Drawing.Point(139, 807);
            this.ajouter_button.Name = "ajouter_button";
            this.ajouter_button.Size = new System.Drawing.Size(126, 36);
            this.ajouter_button.TabIndex = 88;
            this.ajouter_button.Text = "ajouter";
            this.ajouter_button.UseVisualStyleBackColor = true;
            this.ajouter_button.Click += new System.EventHandler(this.ajouter_button_Click);
            // 
            // retour_button
            // 
            this.retour_button.Location = new System.Drawing.Point(1433, 881);
            this.retour_button.Name = "retour_button";
            this.retour_button.Size = new System.Drawing.Size(92, 36);
            this.retour_button.TabIndex = 87;
            this.retour_button.Text = "retour";
            this.retour_button.UseVisualStyleBackColor = true;
            this.retour_button.Click += new System.EventHandler(this.retour_button_Click);
            // 
            // resultat
            // 
            this.resultat.Location = new System.Drawing.Point(137, 74);
            this.resultat.Multiline = true;
            this.resultat.Name = "resultat";
            this.resultat.ReadOnly = true;
            this.resultat.Size = new System.Drawing.Size(1400, 656);
            this.resultat.TabIndex = 86;
            // 
            // resultatS
            // 
            this.resultatS.BackColor = System.Drawing.SystemColors.ControlLight;
            this.resultatS.Location = new System.Drawing.Point(725, 74);
            this.resultatS.Multiline = true;
            this.resultatS.Name = "resultatS";
            this.resultatS.ReadOnly = true;
            this.resultatS.Size = new System.Drawing.Size(195, 656);
            this.resultatS.TabIndex = 98;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1337, 750);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 25);
            this.label7.TabIndex = 101;
            this.label7.Text = "idMag:";
            // 
            // idMagStock
            // 
            this.idMagStock.Location = new System.Drawing.Point(1420, 750);
            this.idMagStock.Name = "idMagStock";
            this.idMagStock.Size = new System.Drawing.Size(94, 31);
            this.idMagStock.TabIndex = 100;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1420, 787);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 36);
            this.button1.TabIndex = 99;
            this.button1.Text = "stock";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(734, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 102;
            this.label2.Text = "Piece";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(822, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 103;
            this.label3.Text = "Quantite";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(930, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 104;
            this.label5.Text = "Byciclette";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1041, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 25);
            this.label6.TabIndex = 106;
            this.label6.Text = "Quantite";
            // 
            // resultatS2
            // 
            this.resultatS2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.resultatS2.Location = new System.Drawing.Point(914, 74);
            this.resultatS2.Multiline = true;
            this.resultatS2.Name = "resultatS2";
            this.resultatS2.ReadOnly = true;
            this.resultatS2.Size = new System.Drawing.Size(195, 656);
            this.resultatS2.TabIndex = 107;
            // 
            // PageMagasin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1674, 1129);
            this.Controls.Add(this.resultatS2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.idMagStock);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultatS);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.idSupp);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idB_label);
            this.Controls.Add(this.gerant);
            this.Controls.Add(this.idmag);
            this.Controls.Add(this.ajouter_button);
            this.Controls.Add(this.retour_button);
            this.Controls.Add(this.resultat);
            this.Name = "PageMagasin";
            this.Text = "PageMagasin";
            this.Load += new System.EventHandler(this.PageMagasin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.TextBox idSupp;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label idB_label;
        private System.Windows.Forms.TextBox gerant;
        private System.Windows.Forms.TextBox idmag;
        private System.Windows.Forms.Button ajouter_button;
        private System.Windows.Forms.Button retour_button;
        public System.Windows.Forms.TextBox resultat;
        private System.Windows.Forms.Timer timer;
        public System.Windows.Forms.TextBox resultatS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox idMagStock;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox resultatS2;
    }
}