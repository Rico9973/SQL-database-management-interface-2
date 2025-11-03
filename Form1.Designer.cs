namespace Interface
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.connexion = new System.Windows.Forms.Button();
            this.id_input = new System.Windows.Forms.TextBox();
            this.mdp_input = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.mdp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // connexion
            // 
            this.connexion.Location = new System.Drawing.Point(755, 614);
            this.connexion.Name = "connexion";
            this.connexion.Size = new System.Drawing.Size(202, 64);
            this.connexion.TabIndex = 0;
            this.connexion.Text = "SE CONNECTER";
            this.connexion.UseVisualStyleBackColor = true;
            this.connexion.Click += new System.EventHandler(this.button1_Click);
            // 
            // id_input
            // 
            this.id_input.Location = new System.Drawing.Point(654, 406);
            this.id_input.Name = "id_input";
            this.id_input.Size = new System.Drawing.Size(450, 31);
            this.id_input.TabIndex = 1;
            // 
            // mdp_input
            // 
            this.mdp_input.Location = new System.Drawing.Point(654, 488);
            this.mdp_input.Name = "mdp_input";
            this.mdp_input.Size = new System.Drawing.Size(450, 31);
            this.mdp_input.TabIndex = 2;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(495, 409);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(117, 25);
            this.id.TabIndex = 3;
            this.id.Text = "Identifiant: ";
            // 
            // mdp
            // 
            this.mdp.AutoSize = true;
            this.mdp.Location = new System.Drawing.Point(470, 488);
            this.mdp.Name = "mdp";
            this.mdp.Size = new System.Drawing.Size(156, 25);
            this.mdp.TabIndex = 4;
            this.mdp.Text = "Mot de Passe: ";
            this.mdp.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1674, 1129);
            this.Controls.Add(this.mdp);
            this.Controls.Add(this.id);
            this.Controls.Add(this.mdp_input);
            this.Controls.Add(this.id_input);
            this.Controls.Add(this.connexion);
            this.Name = "Form1";
            this.Text = "Velomax ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connexion;
        private System.Windows.Forms.TextBox id_input;
        private System.Windows.Forms.TextBox mdp_input;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label mdp;
    }
}

