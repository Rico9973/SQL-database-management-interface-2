namespace Interface
{
    partial class PageSalarie
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
            this.idMag = new System.Windows.Forms.TextBox();
            this.prime = new System.Windows.Forms.TextBox();
            this.salaire = new System.Windows.Forms.TextBox();
            this.typeContrat = new System.Windows.Forms.TextBox();
            this.prenom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idB_label = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.TextBox();
            this.idS = new System.Windows.Forms.TextBox();
            this.ajouter_button = new System.Windows.Forms.Button();
            this.resultat = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.retour_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(142, 909);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(126, 36);
            this.delete_button.TabIndex = 84;
            this.delete_button.Text = "supprimer";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // idSupp
            // 
            this.idSupp.Location = new System.Drawing.Point(142, 861);
            this.idSupp.Name = "idSupp";
            this.idSupp.Size = new System.Drawing.Size(68, 31);
            this.idSupp.TabIndex = 83;
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(301, 802);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(126, 36);
            this.update_button.TabIndex = 82;
            this.update_button.Text = "update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // idMag
            // 
            this.idMag.Location = new System.Drawing.Point(848, 751);
            this.idMag.Name = "idMag";
            this.idMag.Size = new System.Drawing.Size(117, 31);
            this.idMag.TabIndex = 81;
            // 
            // prime
            // 
            this.prime.Location = new System.Drawing.Point(708, 751);
            this.prime.Name = "prime";
            this.prime.Size = new System.Drawing.Size(112, 31);
            this.prime.TabIndex = 79;
            // 
            // salaire
            // 
            this.salaire.Location = new System.Drawing.Point(564, 751);
            this.salaire.Name = "salaire";
            this.salaire.Size = new System.Drawing.Size(102, 31);
            this.salaire.TabIndex = 78;
            // 
            // typeContrat
            // 
            this.typeContrat.Location = new System.Drawing.Point(426, 751);
            this.typeContrat.Name = "typeContrat";
            this.typeContrat.Size = new System.Drawing.Size(108, 31);
            this.typeContrat.TabIndex = 77;
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(335, 751);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(70, 31);
            this.prenom.TabIndex = 76;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(804, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 25);
            this.label7.TabIndex = 74;
            this.label7.Text = "idMag";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(693, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 25);
            this.label6.TabIndex = 73;
            this.label6.Text = "prime";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(591, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 25);
            this.label5.TabIndex = 72;
            this.label5.Text = "salaire";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 71;
            this.label3.Text = "typeContrat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 70;
            this.label2.Text = "prenom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 69;
            this.label1.Text = "nom";
            // 
            // idB_label
            // 
            this.idB_label.AutoSize = true;
            this.idB_label.Location = new System.Drawing.Point(123, 41);
            this.idB_label.Name = "idB_label";
            this.idB_label.Size = new System.Drawing.Size(43, 25);
            this.idB_label.TabIndex = 68;
            this.idB_label.Text = "idS";
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(249, 751);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(70, 31);
            this.nom.TabIndex = 67;
            // 
            // idS
            // 
            this.idS.Location = new System.Drawing.Point(142, 751);
            this.idS.Name = "idS";
            this.idS.Size = new System.Drawing.Size(68, 31);
            this.idS.TabIndex = 66;
            // 
            // ajouter_button
            // 
            this.ajouter_button.Location = new System.Drawing.Point(142, 802);
            this.ajouter_button.Name = "ajouter_button";
            this.ajouter_button.Size = new System.Drawing.Size(126, 36);
            this.ajouter_button.TabIndex = 65;
            this.ajouter_button.Text = "ajouter";
            this.ajouter_button.UseVisualStyleBackColor = true;
            this.ajouter_button.Click += new System.EventHandler(this.ajouter_button_Click);
            // 
            // resultat
            // 
            this.resultat.Location = new System.Drawing.Point(140, 69);
            this.resultat.Multiline = true;
            this.resultat.Name = "resultat";
            this.resultat.ReadOnly = true;
            this.resultat.Size = new System.Drawing.Size(1400, 656);
            this.resultat.TabIndex = 64;
            // 
            // retour_button
            // 
            this.retour_button.Location = new System.Drawing.Point(1414, 887);
            this.retour_button.Name = "retour_button";
            this.retour_button.Size = new System.Drawing.Size(126, 36);
            this.retour_button.TabIndex = 85;
            this.retour_button.Text = "retour";
            this.retour_button.UseVisualStyleBackColor = true;
            this.retour_button.Click += new System.EventHandler(this.retour_button_Click);
            // 
            // PageSalarie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1674, 1129);
            this.Controls.Add(this.retour_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.idSupp);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.idMag);
            this.Controls.Add(this.prime);
            this.Controls.Add(this.salaire);
            this.Controls.Add(this.typeContrat);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idB_label);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.idS);
            this.Controls.Add(this.ajouter_button);
            this.Controls.Add(this.resultat);
            this.Name = "PageSalarie";
            this.Text = "PageSalarie";
            this.Load += new System.EventHandler(this.PageSalarie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.TextBox idSupp;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.TextBox idMag;
        private System.Windows.Forms.TextBox prime;
        private System.Windows.Forms.TextBox salaire;
        private System.Windows.Forms.TextBox typeContrat;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label idB_label;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.TextBox idS;
        private System.Windows.Forms.Button ajouter_button;
        public System.Windows.Forms.TextBox resultat;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button retour_button;
    }
}