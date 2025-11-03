using Org.BouncyCastle.Crypto.Prng;
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
    public partial class PageAdhesion : Form
    {
        public PageAdhesion()
        {
            InitializeComponent();
            // Configuration du minuteur
            timer.Interval = 2000; // Actualiser toutes les secondes
            timer.Tick += Timer_Tick;
            timer.Start(); // Démarrer le minuteur
        }
        
        private void PageAdhesion_Load(object sender, EventArgs e)
        {
            resultat.Text = "";
            Command command = new Command("SELECT * FROM Adhesion;", resultat1);
            command.exec();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Appeler votre fonction d'affichage pour rafraîchir la page
            RafraichirPage();
        }

        private void RafraichirPage()
        {
            resultat1.Text = "";
            Command command = new Command("SELECT * FROM Adhesion;", resultat1);
            command.exec();
        }

      

        public void cree(int idFidelio, int idClient, string expiration)
        {
            string query = $"INSERT INTO Adhesion (idFidelio, idC, expiration) VALUES ({idFidelio}, {idClient}, '{expiration}');";
            Command requete = new Command(query, resultat1);
            requete.exec();
        }

        public void supp(int idFidelio, int idClient)
        {
            string query = $"DELETE FROM Adhesion WHERE idFidelio = {idFidelio} AND idC = {idClient};";
            Command requete = new Command(query, resultat1);
            requete.exec();
        }

        public void update(int idFidelio, int idClient, int newIdFidelio, int newIdClient, string expiration)
        {
            string query = $"UPDATE Adhesion SET idFidelio = {newIdFidelio}, idC = {newIdClient}, expiration = '{expiration}' " +
                           $"WHERE idFidelio = {idFidelio} AND idC = {idClient};";
            Command requete = new Command(query, resultat1);
            requete.exec();
        }

        private void retour_button_Click(object sender, EventArgs e)
        {
            Form2 page = new Form2();
            page.Show();
            this.Hide();
        }

        private void ajouter_button_Click(object sender, EventArgs e)
        {
            this.cree(int.Parse(idFidelio_input.Text), int.Parse(idC.Text), expiration.Text);
            idFidelio_input.Text = "";
            idC.Text = "";
            expiration.Text = "";
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            this.update(int.Parse(idFidelio2.Text), int.Parse(idC2.Text), int.Parse(NewidFidelio.Text), int.Parse(NewIdC.Text),expiration2.Text);
            idFidelio2.Text = "";
            idC2.Text = "";
            NewidFidelio.Text = "";
            NewIdC.Text = "";
            expiration2.Text = "";
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            this.supp(int.Parse(idSupp.Text), int.Parse(idCSupp.Text));
            idSupp.Text = "";
            idCSupp.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
