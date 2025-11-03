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
    public partial class PageSalarie : Form
    {
        public PageSalarie()
        {
            InitializeComponent();
            // Configuration du minuteur
            timer.Interval = 2000; // Actualiser toutes les secondes
            timer.Tick += Timer_Tick;
            timer.Start(); // Démarrer le minuteur
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Appeler votre fonction d'affichage pour rafraîchir la page
            RafraichirPage();
        }

        private void RafraichirPage()
        {
            resultat.Text = "";
            Command command = new Command("SELECT * FROM Salarie;", resultat);
            command.exec();
        }
   
        private void PageSalarie_Load(object sender, EventArgs e)
        {
            resultat.Text = "";
            Command command = new Command("SELECT * FROM Salarie;", resultat);
            command.exec();
        }

        public void cree(int idSalarie, string nom, string prenom, string typeContrat, int salaireFixe, int prime, int idMag)
        {
            string query = $"INSERT INTO Salarie (idSalarie, nom, prenom, typeContrat, salaireFixe, prime, idMag) " +
                           $"VALUES ({idSalarie}, '{nom}', '{prenom}', '{typeContrat}', {salaireFixe}, {prime}, {idMag});";
            Command requete = new Command(query, resultat);
            requete.exec();
        }

        public void supp(int idSalarie)
        {
            string query1 = $"DELETE FROM Commande WHERE idSalarie = {idSalarie}";
            Command requete1 = new Command(query1, resultat);
            requete1.exec();


            string query = $"DELETE FROM Salarie WHERE idSalarie = {idSalarie};";
            Command requete = new Command(query, resultat);
            requete.exec();
        }

        public void update(int idSalarie, string nom, string prenom, string typeContrat, int salaireFixe, int prime, int idMag)
        {
            string query = $"UPDATE Salarie SET nom = '{nom}', prenom = '{prenom}', typeContrat = '{typeContrat}', " +
                           $"salaireFixe = {salaireFixe}, prime = {prime}, idMag = {idMag} WHERE idSalarie = {idSalarie};";

            Command requete = new Command(query, resultat);
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
            this.cree(int.Parse(idS.Text), nom.Text, prenom.Text, typeContrat.Text,
                int.Parse(salaire.Text), int.Parse(prime.Text), int.Parse(idMag.Text));

            idS.Text = "";
            nom.Text = "";
            prenom.Text = "";
            typeContrat.Text = "";
            salaire.Text = "";
            prime.Text = "";
            idMag.Text = "";
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            this.update(int.Parse(idS.Text), nom.Text, prenom.Text, typeContrat.Text,
                int.Parse(salaire.Text), int.Parse(prime.Text), int.Parse(idMag.Text));

            idS.Text = "";
            nom.Text = "";
            prenom.Text = "";
            typeContrat.Text = "";
            salaire.Text = "";
            prime.Text = "";
            idMag.Text = "";
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            this.supp(int.Parse(idSupp.Text));
            idSupp.Text = "";
        }
    }
}
