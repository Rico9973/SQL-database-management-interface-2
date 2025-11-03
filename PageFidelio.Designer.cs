namespace Interface
{
    partial class PageFidelio
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
            this.remise_input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idB_label = new System.Windows.Forms.Label();
            this.programme_input = new System.Windows.Forms.TextBox();
            this.idFidelio_input = new System.Windows.Forms.TextBox();
            this.ajouter_button = new System.Windows.Forms.Button();
            this.retour_button = new System.Windows.Forms.Button();
            this.resultat = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(140, 891);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(126, 36);
            this.delete_button.TabIndex = 85;
            this.delete_button.Text = "supprimer";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // idSupp
            // 
            this.idSupp.Location = new System.Drawing.Point(140, 843);
            this.idSupp.Name = "idSupp";
            this.idSupp.Size = new System.Drawing.Size(68, 31);
            this.idSupp.TabIndex = 84;
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(299, 784);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(126, 36);
            this.update_button.TabIndex = 83;
            this.update_button.Text = "update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // remise_input
            // 
            this.remise_input.Location = new System.Drawing.Point(399, 733);
            this.remise_input.Name = "remise_input";
            this.remise_input.Size = new System.Drawing.Size(70, 31);
            this.remise_input.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 72;
            this.label3.Text = "% Remise";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 70;
            this.label1.Text = "Programme";
            // 
            // idB_label
            // 
            this.idB_label.AutoSize = true;
            this.idB_label.Location = new System.Drawing.Point(103, 23);
            this.idB_label.Name = "idB_label";
            this.idB_label.Size = new System.Drawing.Size(93, 25);
            this.idB_label.TabIndex = 69;
            this.idB_label.Text = "idFidelio";
            // 
            // programme_input
            // 
            this.programme_input.Location = new System.Drawing.Point(229, 733);
            this.programme_input.Name = "programme_input";
            this.programme_input.Size = new System.Drawing.Size(149, 31);
            this.programme_input.TabIndex = 68;
            // 
            // idFidelio_input
            // 
            this.idFidelio_input.Location = new System.Drawing.Point(140, 733);
            this.idFidelio_input.Name = "idFidelio_input";
            this.idFidelio_input.Size = new System.Drawing.Size(68, 31);
            this.idFidelio_input.TabIndex = 67;
            // 
            // ajouter_button
            // 
            this.ajouter_button.Location = new System.Drawing.Point(140, 784);
            this.ajouter_button.Name = "ajouter_button";
            this.ajouter_button.Size = new System.Drawing.Size(126, 36);
            this.ajouter_button.TabIndex = 66;
            this.ajouter_button.Text = "ajouter";
            this.ajouter_button.UseVisualStyleBackColor = true;
            this.ajouter_button.Click += new System.EventHandler(this.ajouter_button_Click);
            // 
            // retour_button
            // 
            this.retour_button.Location = new System.Drawing.Point(1434, 858);
            this.retour_button.Name = "retour_button";
            this.retour_button.Size = new System.Drawing.Size(92, 36);
            this.retour_button.TabIndex = 65;
            this.retour_button.Text = "retour";
            this.retour_button.UseVisualStyleBackColor = true;
            this.retour_button.Click += new System.EventHandler(this.retour_button_Click);
            // 
            // resultat
            // 
            this.resultat.Location = new System.Drawing.Point(138, 51);
            this.resultat.Multiline = true;
            this.resultat.Name = "resultat";
            this.resultat.ReadOnly = true;
            this.resultat.Size = new System.Drawing.Size(1400, 656);
            this.resultat.TabIndex = 64;
            // 
            // PageFidelio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1674, 1129);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.idSupp);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.remise_input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idB_label);
            this.Controls.Add(this.programme_input);
            this.Controls.Add(this.idFidelio_input);
            this.Controls.Add(this.ajouter_button);
            this.Controls.Add(this.retour_button);
            this.Controls.Add(this.resultat);
            this.Name = "PageFidelio";
            this.Text = "PageFidelio";
            this.Load += new System.EventHandler(this.PageFidelio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.TextBox idSupp;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.TextBox remise_input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label idB_label;
        private System.Windows.Forms.TextBox programme_input;
        private System.Windows.Forms.TextBox idFidelio_input;
        private System.Windows.Forms.Button ajouter_button;
        private System.Windows.Forms.Button retour_button;
        public System.Windows.Forms.TextBox resultat;
        private System.Windows.Forms.Timer timer;
    }
}