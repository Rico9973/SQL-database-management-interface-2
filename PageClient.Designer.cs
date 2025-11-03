namespace Interface
{
    partial class nom
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
            this.province = new System.Windows.Forms.TextBox();
            this.courriel = new System.Windows.Forms.TextBox();
            this.telephone = new System.Windows.Forms.TextBox();
            this.codeP = new System.Windows.Forms.TextBox();
            this.ville = new System.Windows.Forms.TextBox();
            this.rue = new System.Windows.Forms.TextBox();
            this.prenom = new System.Windows.Forms.TextBox();
            this.nom_input = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idPiece_label = new System.Windows.Forms.Label();
            this.Type_input = new System.Windows.Forms.TextBox();
            this.idC_input = new System.Windows.Forms.TextBox();
            this.ajouter_button = new System.Windows.Forms.Button();
            this.retour_button = new System.Windows.Forms.Button();
            this.resultat_piece = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.idFidelio = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(40, 907);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(126, 36);
            this.delete_button.TabIndex = 63;
            this.delete_button.Text = "supprimer";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // idSupp
            // 
            this.idSupp.Location = new System.Drawing.Point(40, 850);
            this.idSupp.Name = "idSupp";
            this.idSupp.Size = new System.Drawing.Size(68, 31);
            this.idSupp.TabIndex = 62;
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(208, 790);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(126, 36);
            this.update_button.TabIndex = 61;
            this.update_button.Text = "update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // province
            // 
            this.province.Location = new System.Drawing.Point(879, 739);
            this.province.Name = "province";
            this.province.Size = new System.Drawing.Size(145, 31);
            this.province.TabIndex = 60;
            // 
            // courriel
            // 
            this.courriel.Location = new System.Drawing.Point(1254, 739);
            this.courriel.Name = "courriel";
            this.courriel.Size = new System.Drawing.Size(173, 31);
            this.courriel.TabIndex = 59;
            // 
            // telephone
            // 
            this.telephone.Location = new System.Drawing.Point(1050, 739);
            this.telephone.Name = "telephone";
            this.telephone.Size = new System.Drawing.Size(169, 31);
            this.telephone.TabIndex = 58;
            // 
            // codeP
            // 
            this.codeP.Location = new System.Drawing.Point(746, 739);
            this.codeP.Name = "codeP";
            this.codeP.Size = new System.Drawing.Size(90, 31);
            this.codeP.TabIndex = 57;
            // 
            // ville
            // 
            this.ville.Location = new System.Drawing.Point(633, 739);
            this.ville.Name = "ville";
            this.ville.Size = new System.Drawing.Size(70, 31);
            this.ville.TabIndex = 56;
            // 
            // rue
            // 
            this.rue.Location = new System.Drawing.Point(453, 739);
            this.rue.Name = "rue";
            this.rue.Size = new System.Drawing.Size(143, 31);
            this.rue.TabIndex = 55;
            this.rue.TextChanged += new System.EventHandler(this.idMag_input_TextChanged);
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(349, 739);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(70, 31);
            this.prenom.TabIndex = 54;
            // 
            // nom_input
            // 
            this.nom_input.Location = new System.Drawing.Point(237, 739);
            this.nom_input.Name = "nom_input";
            this.nom_input.Size = new System.Drawing.Size(70, 31);
            this.nom_input.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1237, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 25);
            this.label9.TabIndex = 52;
            this.label9.Text = "courriel";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1045, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 25);
            this.label8.TabIndex = 51;
            this.label8.Text = "téléphone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(719, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 25);
            this.label7.TabIndex = 50;
            this.label7.Text = "cPostale";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(628, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 25);
            this.label6.TabIndex = 49;
            this.label6.Text = "ville";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(506, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 25);
            this.label5.TabIndex = 48;
            this.label5.Text = "rue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 47;
            this.label4.Text = "prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 46;
            this.label3.Text = "nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 44;
            this.label1.Text = "Type";
            // 
            // idPiece_label
            // 
            this.idPiece_label.AutoSize = true;
            this.idPiece_label.Location = new System.Drawing.Point(51, 29);
            this.idPiece_label.Name = "idPiece_label";
            this.idPiece_label.Size = new System.Drawing.Size(44, 25);
            this.idPiece_label.TabIndex = 43;
            this.idPiece_label.Text = "idC";
            // 
            // Type_input
            // 
            this.Type_input.Location = new System.Drawing.Point(130, 739);
            this.Type_input.Name = "Type_input";
            this.Type_input.Size = new System.Drawing.Size(70, 31);
            this.Type_input.TabIndex = 42;
            // 
            // idC_input
            // 
            this.idC_input.Location = new System.Drawing.Point(40, 739);
            this.idC_input.Name = "idC_input";
            this.idC_input.Size = new System.Drawing.Size(68, 31);
            this.idC_input.TabIndex = 41;
            // 
            // ajouter_button
            // 
            this.ajouter_button.Location = new System.Drawing.Point(40, 790);
            this.ajouter_button.Name = "ajouter_button";
            this.ajouter_button.Size = new System.Drawing.Size(126, 36);
            this.ajouter_button.TabIndex = 40;
            this.ajouter_button.Text = "ajouter";
            this.ajouter_button.UseVisualStyleBackColor = true;
            this.ajouter_button.Click += new System.EventHandler(this.ajouter_button_Click);
            // 
            // retour_button
            // 
            this.retour_button.Location = new System.Drawing.Point(1412, 864);
            this.retour_button.Name = "retour_button";
            this.retour_button.Size = new System.Drawing.Size(92, 36);
            this.retour_button.TabIndex = 39;
            this.retour_button.Text = "retour";
            this.retour_button.UseVisualStyleBackColor = true;
            this.retour_button.Click += new System.EventHandler(this.retour_button_Click);
            // 
            // resultat_piece
            // 
            this.resultat_piece.Location = new System.Drawing.Point(30, 57);
            this.resultat_piece.Multiline = true;
            this.resultat_piece.Name = "resultat_piece";
            this.resultat_piece.ReadOnly = true;
            this.resultat_piece.Size = new System.Drawing.Size(1616, 656);
            this.resultat_piece.TabIndex = 38;
            this.resultat_piece.TextChanged += new System.EventHandler(this.resultat_piece_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(856, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 25);
            this.label10.TabIndex = 64;
            this.label10.Text = "province";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1520, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 25);
            this.label11.TabIndex = 65;
            this.label11.Text = "idFidelio";
            // 
            // idFidelio
            // 
            this.idFidelio.Location = new System.Drawing.Point(1511, 739);
            this.idFidelio.Name = "idFidelio";
            this.idFidelio.Size = new System.Drawing.Size(90, 31);
            this.idFidelio.TabIndex = 66;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(662, 790);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 36);
            this.button1.TabIndex = 68;
            this.button1.Text = "update avec Fidelio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(373, 790);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(263, 36);
            this.button2.TabIndex = 67;
            this.button2.Text = "ajouter avec Fidelio";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1674, 1129);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.idFidelio);
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
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.nom_input);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idPiece_label);
            this.Controls.Add(this.Type_input);
            this.Controls.Add(this.idC_input);
            this.Controls.Add(this.ajouter_button);
            this.Controls.Add(this.retour_button);
            this.Controls.Add(this.resultat_piece);
            this.Name = "nom";
            this.Text = "PageClient";
            this.Load += new System.EventHandler(this.PageClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.TextBox idSupp;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.TextBox province;
        private System.Windows.Forms.TextBox courriel;
        private System.Windows.Forms.TextBox telephone;
        private System.Windows.Forms.TextBox codeP;
        private System.Windows.Forms.TextBox ville;
        private System.Windows.Forms.TextBox rue;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.TextBox nom_input;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label idPiece_label;
        private System.Windows.Forms.TextBox Type_input;
        private System.Windows.Forms.TextBox idC_input;
        private System.Windows.Forms.Button ajouter_button;
        private System.Windows.Forms.Button retour_button;
        public System.Windows.Forms.TextBox resultat_piece;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox idFidelio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}