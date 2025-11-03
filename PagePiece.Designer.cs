namespace Interface
{
    partial class PagePiece
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
            this.resultat_piece = new System.Windows.Forms.TextBox();
            this.retour_button = new System.Windows.Forms.Button();
            this.ajouter_button = new System.Windows.Forms.Button();
            this.idPiece_input = new System.Windows.Forms.TextBox();
            this.desc_input = new System.Windows.Forms.TextBox();
            this.idPiece_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.idCat_input = new System.Windows.Forms.TextBox();
            this.idF_input = new System.Windows.Forms.TextBox();
            this.idMag_input = new System.Windows.Forms.TextBox();
            this.prix_input = new System.Windows.Forms.TextBox();
            this.dateIntro_input = new System.Windows.Forms.TextBox();
            this.delai_input = new System.Windows.Forms.TextBox();
            this.quantite_input = new System.Windows.Forms.TextBox();
            this.dateArret_input = new System.Windows.Forms.TextBox();
            this.update_button = new System.Windows.Forms.Button();
            this.idSupp = new System.Windows.Forms.TextBox();
            this.delete_button = new System.Windows.Forms.Button();
            this.timerPiece = new System.Windows.Forms.Timer(this.components);
            this.resultatStock = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.stock_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultat_piece
            // 
            this.resultat_piece.Location = new System.Drawing.Point(118, 47);
            this.resultat_piece.Multiline = true;
            this.resultat_piece.Name = "resultat_piece";
            this.resultat_piece.ReadOnly = true;
            this.resultat_piece.Size = new System.Drawing.Size(1400, 656);
            this.resultat_piece.TabIndex = 0;
            this.resultat_piece.TextChanged += new System.EventHandler(this.resultat_piece_TextChanged);
            // 
            // retour_button
            // 
            this.retour_button.Location = new System.Drawing.Point(1688, 873);
            this.retour_button.Name = "retour_button";
            this.retour_button.Size = new System.Drawing.Size(92, 36);
            this.retour_button.TabIndex = 1;
            this.retour_button.Text = "retour";
            this.retour_button.UseVisualStyleBackColor = true;
            this.retour_button.Click += new System.EventHandler(this.retour_button_Click);
            // 
            // ajouter_button
            // 
            this.ajouter_button.Location = new System.Drawing.Point(120, 780);
            this.ajouter_button.Name = "ajouter_button";
            this.ajouter_button.Size = new System.Drawing.Size(126, 36);
            this.ajouter_button.TabIndex = 2;
            this.ajouter_button.Text = "ajouter";
            this.ajouter_button.UseVisualStyleBackColor = true;
            this.ajouter_button.Click += new System.EventHandler(this.ajouter_button_Click);
            // 
            // idPiece_input
            // 
            this.idPiece_input.Location = new System.Drawing.Point(120, 729);
            this.idPiece_input.Name = "idPiece_input";
            this.idPiece_input.Size = new System.Drawing.Size(68, 31);
            this.idPiece_input.TabIndex = 3;
            // 
            // desc_input
            // 
            this.desc_input.Location = new System.Drawing.Point(217, 729);
            this.desc_input.Name = "desc_input";
            this.desc_input.Size = new System.Drawing.Size(70, 31);
            this.desc_input.TabIndex = 5;
            // 
            // idPiece_label
            // 
            this.idPiece_label.AutoSize = true;
            this.idPiece_label.Location = new System.Drawing.Point(113, 19);
            this.idPiece_label.Name = "idPiece_label";
            this.idPiece_label.Size = new System.Drawing.Size(83, 25);
            this.idPiece_label.TabIndex = 7;
            this.idPiece_label.Text = "idPiece";
            this.idPiece_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "desc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "idCat";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "idF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(495, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "idMag";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(610, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "prix_unit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(775, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "date_intro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1012, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "date_arret";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1245, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "delai_appro";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1376, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "quantite";
            // 
            // idCat_input
            // 
            this.idCat_input.Location = new System.Drawing.Point(293, 729);
            this.idCat_input.Name = "idCat_input";
            this.idCat_input.Size = new System.Drawing.Size(70, 31);
            this.idCat_input.TabIndex = 17;
            // 
            // idF_input
            // 
            this.idF_input.Location = new System.Drawing.Point(387, 729);
            this.idF_input.Name = "idF_input";
            this.idF_input.Size = new System.Drawing.Size(70, 31);
            this.idF_input.TabIndex = 18;
            // 
            // idMag_input
            // 
            this.idMag_input.Location = new System.Drawing.Point(481, 729);
            this.idMag_input.Name = "idMag_input";
            this.idMag_input.Size = new System.Drawing.Size(70, 31);
            this.idMag_input.TabIndex = 19;
            // 
            // prix_input
            // 
            this.prix_input.Location = new System.Drawing.Point(597, 729);
            this.prix_input.Name = "prix_input";
            this.prix_input.Size = new System.Drawing.Size(70, 31);
            this.prix_input.TabIndex = 20;
            this.prix_input.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // dateIntro_input
            // 
            this.dateIntro_input.Location = new System.Drawing.Point(709, 729);
            this.dateIntro_input.Name = "dateIntro_input";
            this.dateIntro_input.Size = new System.Drawing.Size(145, 31);
            this.dateIntro_input.TabIndex = 21;
            // 
            // delai_input
            // 
            this.delai_input.Location = new System.Drawing.Point(1291, 729);
            this.delai_input.Name = "delai_input";
            this.delai_input.Size = new System.Drawing.Size(70, 31);
            this.delai_input.TabIndex = 22;
            // 
            // quantite_input
            // 
            this.quantite_input.Location = new System.Drawing.Point(1414, 729);
            this.quantite_input.Name = "quantite_input";
            this.quantite_input.Size = new System.Drawing.Size(70, 31);
            this.quantite_input.TabIndex = 23;
            // 
            // dateArret_input
            // 
            this.dateArret_input.Location = new System.Drawing.Point(996, 729);
            this.dateArret_input.Name = "dateArret_input";
            this.dateArret_input.Size = new System.Drawing.Size(145, 31);
            this.dateArret_input.TabIndex = 24;
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(279, 780);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(126, 36);
            this.update_button.TabIndex = 25;
            this.update_button.Text = "update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // idSupp
            // 
            this.idSupp.Location = new System.Drawing.Point(120, 839);
            this.idSupp.Name = "idSupp";
            this.idSupp.Size = new System.Drawing.Size(68, 31);
            this.idSupp.TabIndex = 36;
            this.idSupp.TextChanged += new System.EventHandler(this.textBox21_TextChanged);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(120, 887);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(126, 36);
            this.delete_button.TabIndex = 37;
            this.delete_button.Text = "supprimer";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // resultatStock
            // 
            this.resultatStock.Location = new System.Drawing.Point(1548, 47);
            this.resultatStock.Multiline = true;
            this.resultatStock.Name = "resultatStock";
            this.resultatStock.ReadOnly = true;
            this.resultatStock.Size = new System.Drawing.Size(232, 656);
            this.resultatStock.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1669, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 25);
            this.label10.TabIndex = 40;
            this.label10.Text = "Quantite";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1569, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 25);
            this.label11.TabIndex = 39;
            this.label11.Text = "Piece";
            // 
            // stock_button
            // 
            this.stock_button.AutoSize = true;
            this.stock_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.stock_button.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.stock_button.Location = new System.Drawing.Point(1636, 729);
            this.stock_button.Name = "stock_button";
            this.stock_button.Size = new System.Drawing.Size(73, 35);
            this.stock_button.TabIndex = 41;
            this.stock_button.Text = "stock";
            this.stock_button.UseVisualStyleBackColor = true;
            this.stock_button.Click += new System.EventHandler(this.stock_button_Click);
            // 
            // PagePiece
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1844, 1329);
            this.Controls.Add(this.stock_button);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.resultatStock);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.idSupp);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.dateArret_input);
            this.Controls.Add(this.quantite_input);
            this.Controls.Add(this.delai_input);
            this.Controls.Add(this.dateIntro_input);
            this.Controls.Add(this.prix_input);
            this.Controls.Add(this.idMag_input);
            this.Controls.Add(this.idF_input);
            this.Controls.Add(this.idCat_input);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idPiece_label);
            this.Controls.Add(this.desc_input);
            this.Controls.Add(this.idPiece_input);
            this.Controls.Add(this.ajouter_button);
            this.Controls.Add(this.retour_button);
            this.Controls.Add(this.resultat_piece);
            this.Name = "PagePiece";
            this.Text = "PagePiece";
            this.Load += new System.EventHandler(this.PagePiece_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox resultat_piece;
        private System.Windows.Forms.Button retour_button;
        private System.Windows.Forms.Button ajouter_button;
        private System.Windows.Forms.TextBox idPiece_input;
        private System.Windows.Forms.TextBox desc_input;
        private System.Windows.Forms.Label idPiece_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox idCat_input;
        private System.Windows.Forms.TextBox idF_input;
        private System.Windows.Forms.TextBox idMag_input;
        private System.Windows.Forms.TextBox prix_input;
        private System.Windows.Forms.TextBox dateIntro_input;
        private System.Windows.Forms.TextBox delai_input;
        private System.Windows.Forms.TextBox quantite_input;
        private System.Windows.Forms.TextBox dateArret_input;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.TextBox idSupp;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Timer timerPiece;
        public System.Windows.Forms.TextBox resultatStock;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button stock_button;
    }
}