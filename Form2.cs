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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PagePiece page = new PagePiece();
            page.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1 nouvellepage = new Form1();
            nouvellepage.Show();
            this.Hide();
            MessageBox.Show("Vous avez été déconnecté avec succès", "Déconnexion réussie", MessageBoxButtons.OK);

        }

        private void byciclette_button_Click(object sender, EventArgs e)
        {
            PageByciclette page = new PageByciclette();
            page.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nom page = new nom();
            page.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PageEntreprise page = new PageEntreprise();
            page.Show();
            this.Hide();
        }

        

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void commandes_button_Click(object sender, EventArgs e)
        {
            PageCommande page = new PageCommande();
            page.Show();
            this.Hide();
        }

        private void fidelio_button_Click(object sender, EventArgs e)
        {
            PageFidelio page = new PageFidelio();
            page.Show();
            this.Hide();
        }

        private void fournisseur_button_Click(object sender, EventArgs e)
        {
            PageFournisseur page = new PageFournisseur();
            page.Show();
            this.Hide();
        }

        private void salarie_button_Click(object sender, EventArgs e)
        {
            PageSalarie page = new PageSalarie();
            page.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PageMagasin page = new PageMagasin();
            page.Show();
            this.Hide();
        }

        private void stat_button_Click(object sender, EventArgs e)
        {
            PageStatistique page = new PageStatistique();
            page.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            PageAlerte page = new PageAlerte();
            page.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PageAdhesion page = new PageAdhesion();
            page.Show();
            this.Hide();
        }
    }
}
