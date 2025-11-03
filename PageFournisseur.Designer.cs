namespace Interface
{
    partial class PageFournisseur
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
            this.libelle = new System.Windows.Forms.TextBox();
            this.contact = new System.Windows.Forms.TextBox();
            this.Adresse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idB_label = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.TextBox();
            this.idF = new System.Windows.Forms.TextBox();
            this.ajouter_button = new System.Windows.Forms.Button();
            this.retour_button = new System.Windows.Forms.Button();
            this.resultat = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.resultatStock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.idfStock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(142, 904);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(126, 36);
            this.delete_button.TabIndex = 85;
            this.delete_button.Text = "supprimer";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // idSupp
            // 
            this.idSupp.Location = new System.Drawing.Point(142, 856);
            this.idSupp.Name = "idSupp";
            this.idSupp.Size = new System.Drawing.Size(68, 31);
            this.idSupp.TabIndex = 84;
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(301, 797);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(126, 36);
            this.update_button.TabIndex = 83;
            this.update_button.Text = "update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // libelle
            // 
            this.libelle.Location = new System.Drawing.Point(946, 746);
            this.libelle.Name = "libelle";
            this.libelle.Size = new System.Drawing.Size(70, 31);
            this.libelle.TabIndex = 79;
            // 
            // contact
            // 
            this.contact.Location = new System.Drawing.Point(820, 746);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(70, 31);
            this.contact.TabIndex = 78;
            // 
            // Adresse
            // 
            this.Adresse.Location = new System.Drawing.Point(423, 746);
            this.Adresse.Name = "Adresse";
            this.Adresse.Size = new System.Drawing.Size(281, 31);
            this.Adresse.TabIndex = 77;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(897, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 73;
            this.label5.Text = "libelle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(739, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 72;
            this.label3.Text = "contact";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(470, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 71;
            this.label2.Text = "Adresse";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 70;
            this.label1.Text = "nom";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // idB_label
            // 
            this.idB_label.AutoSize = true;
            this.idB_label.Location = new System.Drawing.Point(123, 36);
            this.idB_label.Name = "idB_label";
            this.idB_label.Size = new System.Drawing.Size(42, 25);
            this.idB_label.TabIndex = 69;
            this.idB_label.Text = "idF";
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(249, 746);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(129, 31);
            this.nom.TabIndex = 68;
            // 
            // idF
            // 
            this.idF.Location = new System.Drawing.Point(142, 746);
            this.idF.Name = "idF";
            this.idF.Size = new System.Drawing.Size(68, 31);
            this.idF.TabIndex = 67;
            // 
            // ajouter_button
            // 
            this.ajouter_button.Location = new System.Drawing.Point(142, 797);
            this.ajouter_button.Name = "ajouter_button";
            this.ajouter_button.Size = new System.Drawing.Size(126, 36);
            this.ajouter_button.TabIndex = 66;
            this.ajouter_button.Text = "ajouter";
            this.ajouter_button.UseVisualStyleBackColor = true;
            this.ajouter_button.Click += new System.EventHandler(this.ajouter_button_Click);
            // 
            // retour_button
            // 
            this.retour_button.Location = new System.Drawing.Point(1436, 871);
            this.retour_button.Name = "retour_button";
            this.retour_button.Size = new System.Drawing.Size(92, 36);
            this.retour_button.TabIndex = 65;
            this.retour_button.Text = "retour";
            this.retour_button.UseVisualStyleBackColor = true;
            this.retour_button.Click += new System.EventHandler(this.retour_button_Click);
            // 
            // resultat
            // 
            this.resultat.Location = new System.Drawing.Point(140, 64);
            this.resultat.Multiline = true;
            this.resultat.Name = "resultat";
            this.resultat.ReadOnly = true;
            this.resultat.Size = new System.Drawing.Size(1400, 656);
            this.resultat.TabIndex = 64;
            this.resultat.TextChanged += new System.EventHandler(this.resultat_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1417, 783);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 36);
            this.button1.TabIndex = 86;
            this.button1.Text = "stock";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultatStock
            // 
            this.resultatStock.BackColor = System.Drawing.SystemColors.ControlLight;
            this.resultatStock.Location = new System.Drawing.Point(1314, 77);
            this.resultatStock.Multiline = true;
            this.resultatStock.Name = "resultatStock";
            this.resultatStock.ReadOnly = true;
            this.resultatStock.Size = new System.Drawing.Size(214, 630);
            this.resultatStock.TabIndex = 87;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1422, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 88;
            this.label4.Text = "quantite";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1318, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 25);
            this.label6.TabIndex = 89;
            this.label6.Text = "Piece";
            // 
            // idfStock
            // 
            this.idfStock.Location = new System.Drawing.Point(1417, 746);
            this.idfStock.Name = "idfStock";
            this.idfStock.Size = new System.Drawing.Size(94, 31);
            this.idfStock.TabIndex = 90;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1363, 752);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 25);
            this.label7.TabIndex = 91;
            this.label7.Text = "idF:";
            // 
            // PageFournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1674, 1129);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.idfStock);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resultatStock);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.idSupp);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.libelle);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.Adresse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idB_label);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.idF);
            this.Controls.Add(this.ajouter_button);
            this.Controls.Add(this.retour_button);
            this.Controls.Add(this.resultat);
            this.Name = "PageFournisseur";
            this.Text = "PageFournisseur";
            this.Load += new System.EventHandler(this.PageFournisseur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.TextBox idSupp;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.TextBox libelle;
        private System.Windows.Forms.TextBox contact;
        private System.Windows.Forms.TextBox Adresse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label idB_label;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.TextBox idF;
        private System.Windows.Forms.Button ajouter_button;
        private System.Windows.Forms.Button retour_button;
        public System.Windows.Forms.TextBox resultat;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox resultatStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox idfStock;
        private System.Windows.Forms.Label label7;
    }
}