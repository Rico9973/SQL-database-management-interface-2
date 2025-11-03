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
    public partial class PagePiece : Form
    {
        
        public PagePiece()
        {
            InitializeComponent();
            // Configuration du minuteur
            timerPiece.Interval = 2000; // Actualiser toutes les secondes
            timerPiece.Tick += TimerPiece_Tick;
            timerPiece.Start(); // Démarrer le minuteur
        }

        private void TimerPiece_Tick(object sender, EventArgs e)
        {
            // Appeler votre fonction d'affichage pour rafraîchir la page
            RafraichirPage();
        }

        private void RafraichirPage()
        {
            resultat_piece.Text = "";
            Command command = new Command("SELECT * FROM Piece;", resultat_piece);
            command.exec();
        }




        public void cree(int idPiece, string description, int idCatalogueF, int idF, int idMag, int prixUnit, string dateIntro, string dateArret, int delaiApro, int quantite)
        {
            string query = $"INSERT INTO Piece (idPiece, descriptions, idCatalogueF, idF, idMag, prix_unit, date_intro, date_arret, delai_apro, quantite) " +
                           $"VALUES ({idPiece},'{description}',{idCatalogueF},{idF}, {idMag}, {prixUnit},'{dateIntro}','{dateArret}',{delaiApro}, {quantite});";
            Command requete = new Command(query, resultat_piece);
            requete.exec();
        }

        public void supp(int idPiece)
        {
            string query1 = $"DELETE FROM Commande WHERE idPiece = {idPiece}";
            Command requete1 = new Command(query1, resultat_piece);
            requete1.exec();


            string query = $"DELETE FROM Piece WHERE idPiece = {idPiece};";
            Command requete = new Command(query, resultat_piece);
            requete.exec();
        }

        public void update(int idPiece, string description, int idCatalogueF, int idF, int idMag, int prixUnit, string dateIntro, string dateArret, int delaiApro, int quantite)
        {
            string query = $"UPDATE Piece SET descriptions = '{description}', idCatalogueF = {idCatalogueF}, " +
                           $"idF = {idF}, idMag = {idMag}, prix_unit = {prixUnit}, date_intro = '{dateIntro}', date_arret = '{dateArret}'," +
                           $"delai_apro = {delaiApro}, quantite = {quantite} WHERE idPiece = {idPiece};";

            Command requete = new Command(query, resultat_piece);
            requete.exec();

        }

        public void stock()
        {
            string query = $"SELECT descriptions, quantite FROM Piece;";
            Command requete = new Command(query, resultatStock);
            requete.exec();
        }

        private void PagePiece_Load(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM Piece;";
            Command requete = new Command(query, resultat_piece);
            requete.exec();
        }

        private void ajouter_button_Click(object sender, EventArgs e)
        {
            this.cree(int.Parse(idPiece_input.Text), desc_input.Text, int.Parse(idCat_input.Text), int.Parse(idF_input.Text), int.Parse(idMag_input.Text),
                int.Parse(prix_input.Text), dateIntro_input.Text, dateArret_input.Text, int.Parse(delai_input.Text), int.Parse(quantite_input.Text));

            idPiece_input.Text = "";
            desc_input.Text = "";
            idCat_input.Text = "";
            idF_input.Text = "";
            idMag_input.Text = "";
            prix_input.Text = "";
            dateIntro_input.Text = "";
            dateArret_input.Text = "";
            delai_input.Text = "";
            quantite_input.Text = "";
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            this.update(int.Parse(idPiece_input.Text), desc_input.Text, int.Parse(idCat_input.Text), int.Parse(idF_input.Text), int.Parse(idMag_input.Text),
                int.Parse(prix_input.Text), dateIntro_input.Text, dateArret_input.Text, int.Parse(delai_input.Text), int.Parse(quantite_input.Text));

            idPiece_input.Text = "";
            desc_input.Text = "";
            idCat_input.Text = "";
            idF_input.Text = "";
            idMag_input.Text = "";
            prix_input.Text = "";
            dateIntro_input.Text = "";
            dateArret_input.Text = "";
            delai_input.Text = "";
            quantite_input.Text = "";
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            this.supp(int.Parse(idSupp.Text));
            idSupp.Text = "";
        }

        private void retour_button_Click(object sender, EventArgs e)
        {
            Form2 nouvellePage = new Form2();
            nouvellePage.Show();
            this.Hide();
        }

        private void resultat_piece_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void stock_button_Click(object sender, EventArgs e)
        {
            resultatStock.Text = "";
            this.stock();
        }
    }

   
}
