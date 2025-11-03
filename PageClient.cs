using MySqlX.XDevAPI.Common;
using Projet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Interface
{
    public partial class nom : Form
    {
        public nom()
        {
            InitializeComponent();
            // Configuration du minuteur
            timer.Interval = 2000; // Actualiser toutes les secondes
            timer.Tick += Timer_Tick;
            timer.Start(); // Démarrer le minuteur
        }

        public void cree(int idClient, string TypeCLient, string nom, string prenom, string rue, string ville, string codePostal, string province, string telephone, string courriel)
        {
            string query = $"INSERT INTO Clients (idC, TypeClient, nom, prenom, rue, ville, code_postal, province, telephone, courriel, idFidelio) " +
                           $"VALUES ({idClient}, '{TypeCLient}','{nom}', '{prenom}', '{rue}', '{ville}', '{codePostal}', '{province}', '{telephone}', '{courriel}', NULL);";
            Command requete = new Command(query, resultat_piece);
            requete.exec();
        }

        public void creeAvecFidelio(int idClient, string TypeClient, string nom, string prenom, string rue, string ville, string codePostal, string province, string telephone, string courriel, int idFidelio)
        {
            string query = $"INSERT INTO Clients (idC,TypeClient, nom, prenom, rue, ville, code_postal, province, telephone, courriel, idFidelio) " +
                           $"VALUES ({idClient}, '{TypeClient}','{nom}', '{prenom}', '{rue}', '{ville}', '{codePostal}', '{province}', '{telephone}', '{courriel}', {idFidelio});";
            Command requete = new Command(query, resultat_piece);
            requete.exec();
        }

        public void supp(int idClient)
        {
            string query1 = $"DELETE FROM Adhesion WHERE idC = {idClient}";
            Command requete1 = new Command(query1, resultat_piece);
            requete1.exec();


            string query = $"DELETE FROM Clients WHERE idC = {idClient};";
            Command requete = new Command(query, resultat_piece);
            requete.exec();
        }

        public void update(int idClient, string TypeClient, string nom, string prenom, string rue, string ville, string codePostal, string province, string telephone, string courriel)
        {
            string query = $"UPDATE Clients SET  TypeCLient = '{TypeClient}',nom = '{nom}', prenom = '{prenom}', rue = '{rue}', " +
                           $"ville = '{ville}', code_postal = '{codePostal}', province = '{province}', telephone = '{telephone}', " +
                           $"courriel = '{courriel}', idFidelio = NULL WHERE idC = {idClient};";

            Command requete = new Command(query, resultat_piece);
            requete.exec();
        }

        public void updateAvecFidelio(int idClient, string TypeClient, string nom, string prenom, string rue, string ville, string codePostal, string province, string telephone, string courriel, int idFidelio)
        {
            string query = $"UPDATE Clients SET   TypeCLient = '{TypeClient}',nom = '{nom}', prenom = '{prenom}', rue = '{rue}', " +
                           $"ville = '{ville}', code_postal = '{codePostal}', province = '{province}', telephone = '{telephone}', " +
                           $"courriel = '{courriel}', idFidelio = {idFidelio} WHERE idC = {idClient};";

            Command requete = new Command(query, resultat_piece);
            requete.exec();
        }
        private void resultat_piece_TextChanged(object sender, EventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Appeler votre fonction d'affichage pour rafraîchir la page
            RafraichirPage();
        }

        private void RafraichirPage()
        {
            resultat_piece.Text = "";
            Command command = new Command("SELECT * FROM Clients;", resultat_piece);
            command.exec();
        }
        
        private void PageClient_Load(object sender, EventArgs e)
        {
            resultat_piece.Text = "";
            Command command = new Command("SELECT * FROM Clients;", resultat_piece);
            command.exec();
        }

        private void retour_button_Click(object sender, EventArgs e)
        {
            Form2 page = new Form2();
            page.Show();
            this.Hide();
        }

        private void idMag_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void ajouter_button_Click(object sender, EventArgs e)
        {
            this.cree(int.Parse(idC_input.Text), Type_input.Text, nom_input.Text, prenom.Text, rue.Text, ville.Text, codeP.Text, province.Text,
                telephone.Text, courriel.Text);

            idC_input.Text = "";
            Type_input.Text = "";
            nom_input.Text = "";
            prenom.Text = "";
            rue.Text = "";
            ville.Text = "";
            codeP.Text = "";
            province.Text = "";
            telephone.Text = "";
            courriel.Text = "";
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            this.update(int.Parse(idC_input.Text), Type_input.Text, nom_input.Text, prenom.Text, rue.Text, ville.Text, codeP.Text, province.Text,
                telephone.Text, courriel.Text);

            idC_input.Text = "";
            Type_input.Text = "";
            nom_input.Text = "";
            prenom.Text = "";
            rue.Text = "";
            ville.Text = "";
            codeP.Text = "";
            province.Text = "";
            telephone.Text = "";
            courriel.Text = "";
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            this.supp(int.Parse(idSupp.Text));
            idSupp.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.creeAvecFidelio(int.Parse(idC_input.Text), Type_input.Text, nom_input.Text, prenom.Text, rue.Text, ville.Text, codeP.Text, province.Text,
                telephone.Text, courriel.Text, int.Parse(idFidelio.Text));
            idC_input.Text = "";
            Type_input.Text = "";
            nom_input.Text = "";
            prenom.Text = "";
            rue.Text = "";
            ville.Text = "";
            codeP.Text = "";
            province.Text = "";
            telephone.Text = "";
            courriel.Text = "";
            idFidelio.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.updateAvecFidelio(int.Parse(idC_input.Text), Type_input.Text, nom_input.Text, prenom.Text, rue.Text, ville.Text, codeP.Text, province.Text,
                telephone.Text, courriel.Text, int.Parse(idFidelio.Text));

            idC_input.Text = "";
            Type_input.Text = "";
            nom_input.Text = "";
            prenom.Text = "";
            rue.Text = "";
            ville.Text = "";
            codeP.Text = "";
            province.Text = "";
            telephone.Text = "";
            courriel.Text = "";
            idFidelio.Text = "";
        }
    }
}
