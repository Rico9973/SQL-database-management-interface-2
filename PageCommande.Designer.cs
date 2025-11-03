namespace Interface
{
    partial class PageCommande
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
            this.quantiteB_input = new System.Windows.Forms.TextBox();
            this.quantiteP_input = new System.Windows.Forms.TextBox();
            this.ids_input = new System.Windows.Forms.TextBox();
            this.idmag_input = new System.Windows.Forms.TextBox();
            this.idb_input = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idB_label = new System.Windows.Forms.Label();
            this.idPiece_input = new System.Windows.Forms.TextBox();
            this.idcommande_input = new System.Windows.Forms.TextBox();
            this.ajouter_button = new System.Windows.Forms.Button();
            this.retour_button = new System.Windows.Forms.Button();
            this.resultat = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(138, 914);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(126, 36);
            this.delete_button.TabIndex = 85;
            this.delete_button.Text = "supprimer";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // idSupp
            // 
            this.idSupp.Location = new System.Drawing.Point(138, 866);
            this.idSupp.Name = "idSupp";
            this.idSupp.Size = new System.Drawing.Size(68, 31);
            this.idSupp.TabIndex = 84;
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(297, 807);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(126, 36);
            this.update_button.TabIndex = 83;
            this.update_button.Text = "update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // quantiteB_input
            // 
            this.quantiteB_input.Location = new System.Drawing.Point(764, 756);
            this.quantiteB_input.Name = "quantiteB_input";
            this.quantiteB_input.Size = new System.Drawing.Size(97, 31);
            this.quantiteB_input.TabIndex = 82;
            // 
            // quantiteP_input
            // 
            this.quantiteP_input.Location = new System.Drawing.Point(625, 756);
            this.quantiteP_input.Name = "quantiteP_input";
            this.quantiteP_input.Size = new System.Drawing.Size(107, 31);
            this.quantiteP_input.TabIndex = 80;
            // 
            // ids_input
            // 
            this.ids_input.Location = new System.Drawing.Point(502, 756);
            this.ids_input.Name = "ids_input";
            this.ids_input.Size = new System.Drawing.Size(70, 31);
            this.ids_input.TabIndex = 79;
            // 
            // idmag_input
            // 
            this.idmag_input.Location = new System.Drawing.Point(405, 756);
            this.idmag_input.Name = "idmag_input";
            this.idmag_input.Size = new System.Drawing.Size(70, 31);
            this.idmag_input.TabIndex = 78;
            // 
            // idb_input
            // 
            this.idb_input.Location = new System.Drawing.Point(328, 756);
            this.idb_input.Name = "idb_input";
            this.idb_input.Size = new System.Drawing.Size(70, 31);
            this.idb_input.TabIndex = 77;
            this.idb_input.TextChanged += new System.EventHandler(this.Cat_input_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(703, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 25);
            this.label7.TabIndex = 75;
            this.label7.Text = "QuantiteB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(599, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 25);
            this.label6.TabIndex = 74;
            this.label6.Text = "QuantiteP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(497, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 73;
            this.label5.Text = "idSalarie";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 72;
            this.label3.Text = "idMag";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 25);
            this.label2.TabIndex = 71;
            this.label2.Text = "idB";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(218, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 70;
            this.label1.Text = "idPiece";
            // 
            // idB_label
            // 
            this.idB_label.AutoSize = true;
            this.idB_label.Location = new System.Drawing.Point(65, 46);
            this.idB_label.Name = "idB_label";
            this.idB_label.Size = new System.Drawing.Size(141, 25);
            this.idB_label.TabIndex = 69;
            this.idB_label.Text = "n°Commande";
            this.idB_label.Click += new System.EventHandler(this.idB_label_Click);
            // 
            // idPiece_input
            // 
            this.idPiece_input.Location = new System.Drawing.Point(223, 756);
            this.idPiece_input.Name = "idPiece_input";
            this.idPiece_input.Size = new System.Drawing.Size(70, 31);
            this.idPiece_input.TabIndex = 68;
            // 
            // idcommande_input
            // 
            this.idcommande_input.Location = new System.Drawing.Point(138, 756);
            this.idcommande_input.Name = "idcommande_input";
            this.idcommande_input.Size = new System.Drawing.Size(68, 31);
            this.idcommande_input.TabIndex = 67;
            // 
            // ajouter_button
            // 
            this.ajouter_button.Location = new System.Drawing.Point(138, 807);
            this.ajouter_button.Name = "ajouter_button";
            this.ajouter_button.Size = new System.Drawing.Size(126, 36);
            this.ajouter_button.TabIndex = 66;
            this.ajouter_button.Text = "ajouter";
            this.ajouter_button.UseVisualStyleBackColor = true;
            this.ajouter_button.Click += new System.EventHandler(this.ajouter_button_Click);
            // 
            // retour_button
            // 
            this.retour_button.Location = new System.Drawing.Point(1432, 881);
            this.retour_button.Name = "retour_button";
            this.retour_button.Size = new System.Drawing.Size(92, 36);
            this.retour_button.TabIndex = 65;
            this.retour_button.Text = "retour";
            this.retour_button.UseVisualStyleBackColor = true;
            this.retour_button.Click += new System.EventHandler(this.retour_button_Click);
            // 
            // resultat
            // 
            this.resultat.Location = new System.Drawing.Point(136, 74);
            this.resultat.Multiline = true;
            this.resultat.Name = "resultat";
            this.resultat.ReadOnly = true;
            this.resultat.Size = new System.Drawing.Size(1400, 656);
            this.resultat.TabIndex = 64;
            // 
            // PageCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1674, 1129);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.idSupp);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.quantiteB_input);
            this.Controls.Add(this.quantiteP_input);
            this.Controls.Add(this.ids_input);
            this.Controls.Add(this.idmag_input);
            this.Controls.Add(this.idb_input);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idB_label);
            this.Controls.Add(this.idPiece_input);
            this.Controls.Add(this.idcommande_input);
            this.Controls.Add(this.ajouter_button);
            this.Controls.Add(this.retour_button);
            this.Controls.Add(this.resultat);
            this.Name = "PageCommande";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.PageCommande_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.TextBox idSupp;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.TextBox quantiteB_input;
        private System.Windows.Forms.TextBox quantiteP_input;
        private System.Windows.Forms.TextBox ids_input;
        private System.Windows.Forms.TextBox idmag_input;
        private System.Windows.Forms.TextBox idb_input;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label idB_label;
        private System.Windows.Forms.TextBox idPiece_input;
        private System.Windows.Forms.TextBox idcommande_input;
        private System.Windows.Forms.Button ajouter_button;
        private System.Windows.Forms.Button retour_button;
        public System.Windows.Forms.TextBox resultat;
        private System.Windows.Forms.Timer timer;
    }
}