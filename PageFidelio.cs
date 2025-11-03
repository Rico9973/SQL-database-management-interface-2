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
    public partial class PageFidelio : Form
    {
        public PageFidelio()
        {
            InitializeComponent();
            // Configuration du minuteur
            timer.Interval = 2000; // Actualiser toutes les secondes
            timer.Tick += Timer_Tick;
            timer.Start(); // Démarrer le minuteur
        }

        public void cree(int idFidelio, string nomProgramme, int pourcentageRemise)
        {
            string query = $"INSERT INTO Fidelio (idFidelio, nomProgramme, pourcentage_remise) " +
                           $"VALUES ({idFidelio}, '{nomProgramme}', {pourcentageRemise});";
            Command requete = new Command(query, resultat);
            requete.exec();
        }

        public void supp(int idFidelio)
        {
            string query1 = $"DELETE FROM Clients WHERE idFidelio = {idFidelio}";
            Command requete1 = new Command(query1, resultat);
            requete1.exec();



            string query2 = $"DELETE FROM Adhesion WHERE idFidelio = {idFidelio};";
            Command requete2 = new Command(query2, resultat);
            requete2.exec();


            string query = $"DELETE FROM Fidelio WHERE idFidelio = {idFidelio};";
            Command requete = new Command(query, resultat);
            requete.exec();
        }

        public void update(int idFidelio, string nomProgramme, int pourcentageRemise)
        {
            string query = $"UPDATE Fidelio SET nomProgramme = '{nomProgramme}', pourcentage_remise = {pourcentageRemise} " +
                           $"WHERE idFidelio = {idFidelio};";

            Command requete = new Command(query, resultat);
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
            Command command = new Command("SELECT * FROM Fidelio;", resultat);
            command.exec();
        }
        private void retour_button_Click(object sender, EventArgs e)
        {
            Form2 page = new Form2();
            page.Show();
            this.Hide();
        }

        private void PageFidelio_Load(object sender, EventArgs e)
        {
            resultat.Text = "";
            Command command = new Command("SELECT * FROM Fidelio;", resultat);
            command.exec();
        }

        private void ajouter_button_Click(object sender, EventArgs e)
        {
            this.cree(int.Parse(idFidelio_input.Text), programme_input.Text, int.Parse(remise_input.Text));
            idFidelio_input.Text = "";
            programme_input.Text = "";
            remise_input.Text = "";
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            this.update(int.Parse(idFidelio_input.Text), programme_input.Text, int.Parse(remise_input.Text));
            idFidelio_input.Text = "";
            programme_input.Text = "";
            remise_input.Text = "";
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            this.supp(int.Parse(idSupp.Text));
            idSupp.Text = "";
        }
    }
}
