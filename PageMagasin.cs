using Projet;
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
    public partial class PageMagasin : Form
    {
        public PageMagasin()
        {
            InitializeComponent();
            // Configuration du minuteur
            timer.Interval = 2000; // Actualiser toutes les secondes
            timer.Tick += Timer_Tick;
            timer.Start(); // Démarrer le minuteur
        }

        private void retour_button_Click(object sender, EventArgs e)
        {
            Form2 page = new Form2();
            page.Show();
            this.Hide();
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            // Appeler votre fonction d'affichage pour rafraîchir la page
            RafraichirPage();
        }

        private void RafraichirPage()
        {
            resultat.Text = "";
            Command command = new Command("SELECT * FROM Magasins;", resultat);
            command.exec();
        }
        

        private void PageMagasin_Load(object sender, EventArgs e)
        {
            resultat.Text = "";
            Command command = new Command("SELECT * FROM Magasins;", resultat);
            command.exec();
        }

        public void cree(int idMag, string gerant)
        {
            string query = $"INSERT INTO Magasins (idMag, gerant) VALUES ({idMag}, '{gerant}');";
            Command requete = new Command(query, resultat);
            requete.exec();
        }

        public void supp(int idMag)
        {
            string query = $"DELETE FROM Magasins WHERE idMag = {idMag};";
            Command requete = new Command(query, resultat);
            requete.exec();
        }

        public void update(int idMag, string gerant)
        {
            string query = $"UPDATE Magasins SET gerant = '{gerant}' WHERE idMag = {idMag};";
            Command requete = new Command(query, resultat);
            requete.exec();
        }

        public void stock(int idMag)
        {
            string query = $"SELECT descriptions, quantite FROM Piece WHERE idMag = {idMag};";
            Command requete = new Command(query, resultatS);
            requete.exec();

            string query1 = $"SELECT nom, quantite FROM Byciclette WHERE idMag = {idMag};";
            Command requete1 = new Command(query1, resultatS2);
            requete1.exec();

        }

        private void ajouter_button_Click(object sender, EventArgs e)
        {
            this.cree(int.Parse(idmag.Text), gerant.Text);
            idmag.Text = "";
            gerant.Text = "";
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            this.update(int.Parse(idmag.Text), gerant.Text);
            idmag.Text = "";
            gerant.Text = "";
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            this.supp(int.Parse(idSupp.Text));
            idSupp.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultatS.Text = "";
            this.stock(int.Parse(idMagStock.Text));
            idMagStock.Text = "";
        }
    }
}
