namespace Interface
{
    partial class PageEntreprise
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
            this.remise = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.Button();
            this.idSupp = new System.Windows.Forms.TextBox();
            this.update_button = new System.Windows.Forms.Button();
            this.province = new System.Windows.Forms.TextBox();
            this.courriel = new System.Windows.Forms.TextBox();
            this.telephone = new System.Windows.Forms.TextBox();
            this.codeP = new System.Windows.Forms.TextBox();
            this.ville = new System.Windows.Forms.TextBox();
            this.rue = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idPiece_label = new System.Windows.Forms.Label();
            this.idBC_input = new System.Windows.Forms.TextBox();
            this.ajouter_button = new System.Windows.Forms.Button();
            this.retour_button = new System.Windows.Forms.Button();
            this.resultat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.nom = new System.Windows.Forms.TextBox();
            this.contact = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // remise
            // 
            this.remise.Location = new System.Drawing.Point(1496, 732);
            this.remise.Name = "remise";
            this.remise.Size = new System.Drawing.Size(90, 31);
            this.remise.TabIndex = 96;
            this.remise.TextChanged += new System.EventHandler(this.idFidelio_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1483, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 25);
            this.label11.TabIndex = 95;
            this.label11.Text = "%Remise";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(729, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 25);
            this.label10.TabIndex = 94;
            this.label10.Text = "province";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(41, 900);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(126, 36);
            this.delete_button.TabIndex = 93;
            this.delete_button.Text = "supprimer";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // idSupp
            // 
            this.idSupp.Location = new System.Drawing.Point(41, 843);
            this.idSupp.Name = "idSupp";
            this.idSupp.Size = new System.Drawing.Size(68, 31);
            this.idSupp.TabIndex = 92;
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(209, 783);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(126, 36);
            this.update_button.TabIndex = 91;
            this.update_button.Text = "update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // province
            // 
            this.province.Location = new System.Drawing.Point(734, 732);
            this.province.Name = "province";
            this.province.Size = new System.Drawing.Size(145, 31);
            this.province.TabIndex = 90;
            this.province.TextChanged += new System.EventHandler(this.province_TextChanged);
            // 
            // courriel
            // 
            this.courriel.Location = new System.Drawing.Point(1119, 732);
            this.courriel.Name = "courriel";
            this.courriel.Size = new System.Drawing.Size(173, 31);
            this.courriel.TabIndex = 89;
            // 
            // telephone
            // 
            this.telephone.Location = new System.Drawing.Point(923, 732);
            this.telephone.Name = "telephone";
            this.telephone.Size = new System.Drawing.Size(169, 31);
            this.telephone.TabIndex = 88;
            // 
            // codeP
            // 
            this.codeP.Location = new System.Drawing.Point(623, 732);
            this.codeP.Name = "codeP";
            this.codeP.Size = new System.Drawing.Size(90, 31);
            this.codeP.TabIndex = 87;
            // 
            // ville
            // 
            this.ville.Location = new System.Drawing.Point(511, 732);
            this.ville.Name = "ville";
            this.ville.Size = new System.Drawing.Size(95, 31);
            this.ville.TabIndex = 86;
            // 
            // rue
            // 
            this.rue.Location = new System.Drawing.Point(277, 732);
            this.rue.Name = "rue";
            this.rue.Size = new System.Drawing.Size(227, 31);
            this.rue.TabIndex = 85;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1114, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 25);
            this.label9.TabIndex = 82;
            this.label9.Text = "courriel";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(918, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 25);
            this.label8.TabIndex = 81;
            this.label8.Text = "téléphone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(578, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 25);
            this.label7.TabIndex = 80;
            this.label7.Text = "cPostale";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(506, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 25);
            this.label6.TabIndex = 79;
            this.label6.Text = "ville";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 25);
            this.label5.TabIndex = 78;
            this.label5.Text = "rue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 76;
            this.label3.Text = "nom";
            // 
            // idPiece_label
            // 
            this.idPiece_label.AutoSize = true;
            this.idPiece_label.Location = new System.Drawing.Point(37, 22);
            this.idPiece_label.Name = "idPiece_label";
            this.idPiece_label.Size = new System.Drawing.Size(58, 25);
            this.idPiece_label.TabIndex = 74;
            this.idPiece_label.Text = "idBC";
            // 
            // idBC_input
            // 
            this.idBC_input.Location = new System.Drawing.Point(41, 732);
            this.idBC_input.Name = "idBC_input";
            this.idBC_input.Size = new System.Drawing.Size(68, 31);
            this.idBC_input.TabIndex = 72;
            // 
            // ajouter_button
            // 
            this.ajouter_button.Location = new System.Drawing.Point(41, 783);
            this.ajouter_button.Name = "ajouter_button";
            this.ajouter_button.Size = new System.Drawing.Size(126, 36);
            this.ajouter_button.TabIndex = 71;
            this.ajouter_button.Text = "ajouter";
            this.ajouter_button.UseVisualStyleBackColor = true;
            this.ajouter_button.Click += new System.EventHandler(this.ajouter_button_Click);
            // 
            // retour_button
            // 
            this.retour_button.Location = new System.Drawing.Point(1413, 857);
            this.retour_button.Name = "retour_button";
            this.retour_button.Size = new System.Drawing.Size(92, 36);
            this.retour_button.TabIndex = 70;
            this.retour_button.Text = "retour";
            this.retour_button.UseVisualStyleBackColor = true;
            this.retour_button.Click += new System.EventHandler(this.retour_button_Click);
            // 
            // resultat
            // 
            this.resultat.Location = new System.Drawing.Point(41, 50);
            this.resultat.Multiline = true;
            this.resultat.Name = "resultat";
            this.resultat.ReadOnly = true;
            this.resultat.Size = new System.Drawing.Size(1525, 656);
            this.resultat.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1335, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 97;
            this.label1.Text = "contact";
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(129, 732);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(104, 31);
            this.nom.TabIndex = 84;
            // 
            // contact
            // 
            this.contact.Location = new System.Drawing.Point(1328, 732);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(121, 31);
            this.contact.TabIndex = 98;
            // 
            // PageEntreprise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1674, 1129);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.remise);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.idSupp);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.province);
            this.Controls.Add(this.courriel);
            this.Controls.Add(this.telephone);
            this.Controls.Add(this.codeP);
            this.Controls.Add(this.ville);
            this.Controls.Add(this.rue);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idPiece_label);
            this.Controls.Add(this.idBC_input);
            this.Controls.Add(this.ajouter_button);
            this.Controls.Add(this.retour_button);
            this.Controls.Add(this.resultat);
            this.Name = "PageEntreprise";
            this.Text = "PageEntreprise";
            this.Load += new System.EventHandler(this.PageEntreprise_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox remise;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.TextBox idSupp;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.TextBox province;
        private System.Windows.Forms.TextBox courriel;
        private System.Windows.Forms.TextBox telephone;
        private System.Windows.Forms.TextBox codeP;
        private System.Windows.Forms.TextBox ville;
        private System.Windows.Forms.TextBox rue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label idPiece_label;
        private System.Windows.Forms.TextBox idBC_input;
        private System.Windows.Forms.Button ajouter_button;
        private System.Windows.Forms.Button retour_button;
        public System.Windows.Forms.TextBox resultat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.TextBox contact;
    }
}