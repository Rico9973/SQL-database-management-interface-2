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
    public partial class PageFournisseur : Form
    {
        public PageFournisseur()
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

        public void cree(int idF, string nom, string adresse, string contact, int libelle)
        {
            string query = $"INSERT INTO Fournisseur (idF, nom, adresse, contact, libelle) " +
                           $"VALUES ({idF}, '{nom}', '{adresse}', '{contact}', {libelle});";
            Command requete = new Command(query, resultat);
            requete.exec();
        }

        public void supp(int idF)
        {


            string query2 = $"DELETE C FROM Commande C JOIN Piece P ON C.idPiece = P.idPiece " +
                             $"JOIN Fournisseur F ON F.idF = P.idF WHERE F.idF = {idF};";
            Command requete2 = new Command(query2, resultat);
            requete2.exec();

            string query1 = $"DELETE FROM Piece WHERE idF = {idF}";
            Command requete1 = new Command(query1, resultat);
            requete1.exec();


            string query = $"DELETE FROM Fournisseur WHERE idF = {idF};";
            Command requete = new Command(query, resultat);
            requete.exec();
        }

        public void update(int idF, string nom, string adresse, string contact, int libelle)
        {
            string query = $"UPDATE Fournisseur SET nom = '{nom}', adresse = '{adresse}', contact = '{contact}', libelle = {libelle} " +
                           $"WHERE idF = {idF};";

            Command requete = new Command(query, resultat);
            requete.exec();
        }

        public void stock(int idF)
        {
            string query = $"SELECT descriptions, quantite FROM Piece WHERE idF = {idF};";

            Command requete = new Command(query, resultatStock);
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
            Command command = new Command("SELECT * FROM Fournisseur;", resultat);
            command.exec();
        }
        private void PageFournisseur_Load(object sender, EventArgs e)
        {
            resultat.Text = "";
            Command command = new Command("SELECT * FROM Fournisseur;", resultat);
            command.exec();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ajouter_button_Click(object sender, EventArgs e)
        {
            this.cree(int.Parse(idF.Text), nom.Text, Adresse.Text, contact.Text, int.Parse(libelle.Text));

            idF.Text = "";
            nom.Text = "";
            Adresse.Text = "";
            contact.Text = "";
            libelle.Text = "";
          

        }

        private void update_button_Click(object sender, EventArgs e)
        {
            this.update(int.Parse(idF.Text), nom.Text, Adresse.Text, contact.Text, int.Parse(libelle.Text));

            idF.Text = "";
            nom.Text = "";
            Adresse.Text = "";
            contact.Text = "";
            libelle.Text = "";
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            this.supp(int.Parse(idSupp.Text));
            idSupp.Text = "";
        }

        private void resultat_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultatStock.Text = "";
            this.stock(int.Parse(idfStock.Text));
            idfStock.Text = "";
        }
    }
}
