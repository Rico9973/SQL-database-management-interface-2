using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string identifiant = id_input.Text;
            string motDePasse = mdp_input.Text;
            

            // Cacher la page de connexion
            this.Hide();

           
            if (identifiant == "Legrand" && motDePasse == "1234")
            {
                // Ouverture de la nouvelle page
                Form2 nouvellePage = new Form2();
                nouvellePage.Show();

                // Cacher la page de connexion
                this.Hide();
            }
            else
            {
                // Afficher un message d'erreur si les informations sont incorrectes
                MessageBox.Show("Identifiant ou mot de passe incorrect.", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
