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
    public partial class PageByciclette : Form
    {
        public PageByciclette()
        {
            InitializeComponent();
            // Configuration du minuteur
            timer.Interval = 2000; // Actualiser toutes les secondes
            timer.Tick += Timer_Tick;
            timer.Start(); // Démarrer le minuteur
        }

        public void cree(int idVelo, int idMag, string nom, int grandeur, int prixUnitaire, string dateIntro, string dateArret, int quantite)
        {
            string query = $"INSERT INTO Byciclette (idB, idMag, nom, grandeur, prix_unitaire, date_intro, date_arret, quantite) " +
                           $"VALUES ({idVelo}, {idMag}, '{nom}', {grandeur}, {prixUnitaire}, '{dateIntro}', '{dateArret}', {quantite});";
            Command requete = new Command(query, resultat);
            requete.exec();
        }

        public void supp(int idVelo)
        {

            string query1 = $"DELETE FROM Commande WHERE idB = {idVelo}";
            Command requete1 = new Command(query1, resultat);
            requete1.exec();


            string query = $"DELETE FROM Byciclette WHERE idB = {idVelo};";
            Command requete = new Command(query, resultat);
            requete.exec();
        }

        public void update(int idVelo, int idMag, string nom, int grandeur, int prixUnitaire, string dateIntro, string dateArret, int quantite)
        {
            string query = $"UPDATE Byciclette SET idMag = {idMag}, nom = '{nom}', grandeur = {grandeur}, prix_unitaire = {prixUnitaire}, " +
                           $"date_intro = '{dateIntro}', date_arret = '{dateArret}', quantite = {quantite} WHERE idB = {idVelo};";

            Command requete = new Command(query, resultat);
            requete.exec();
        }

        public void stock()
        {
            string query = $"SELECT nom, quantite FROM Byciclette;";
            Command requete = new Command(query, resultatStock);
            requete.exec();
        }

        public void stock_cate(string cat)
        {
            string query = $"SELECT nom, sum(quantite) FROM Byciclette WHERE nom = '{cat}';";
            Command requete = new Command(query, resultatc);
            requete.exec();
        }




        private void Timer_Tick(object sender, EventArgs e)
        {
            // Appeler votre fonction d'affichage pour rafraîchir la page
            RafraichirPage();
        }

        private void RafraichirPage()
        {
            resultat.Text = "";
            Command command = new Command("SELECT * FROM Byciclette;", resultat);
            command.exec();
        }
        private void PageByciclette_Load(object sender, EventArgs e)
        {
            resultat.Text = "";
            Command command = new Command("SELECT * FROM Byciclette;", resultat);
            command.exec();
        }

        private void resultat_piece_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void retour_button_Click(object sender, EventArgs e)
        {
            Form2 page = new Form2();
            page.Show();
            this.Hide();
        }

        private void ajouter_button_Click(object sender, EventArgs e)
        {
            this.cree(int.Parse(id_input.Text), int.Parse(idMag_input.Text), Cat_input.Text, int.Parse(grand_input.Text), int.Parse(prix_input.Text), 
                dateIntro_input.Text, dateArret_input.Text, int.Parse(quantite_input.Text));

            id_input.Text = "";
            idMag_input.Text = "";
            Cat_input.Text = "";
            grand_input.Text = "";
            prix_input.Text = "";
            dateIntro_input.Text = "";
            dateArret_input.Text = "";
            quantite_input.Text = "";
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            this.update(int.Parse(id_input.Text), int.Parse(idMag_input.Text), Cat_input.Text, int.Parse(grand_input.Text), int.Parse(prix_input.Text),
                dateIntro_input.Text, dateArret_input.Text, int.Parse(quantite_input.Text));

            id_input.Text = "";
            idMag_input.Text = "";
            Cat_input.Text = "";
            grand_input.Text = "";
            prix_input.Text = "";
            dateIntro_input.Text = "";
            dateArret_input.Text = "";
            quantite_input.Text = "";
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            this.supp(int.Parse(idSupp.Text));
            idSupp.Text = "";
        }

        private void stock_button_Click(object sender, EventArgs e)
        {
            resultatStock.Text = "";
            this.stock();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultatStock.Text = "";
            this.stock_cate(stockCate_input.Text);
        }
    }

     
}
