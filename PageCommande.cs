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
    public partial class PageCommande : Form
    {
        public PageCommande()
        {
            InitializeComponent();
            // Configuration du minuteur
            timer.Interval = 2000; // Actualiser toutes les secondes
            timer.Tick += Timer_Tick;
            timer.Start(); // Démarrer le minuteur
        }

        public void cree(int numeroCommande, int idPiece, int idB, int idMag, int idSalarie, int quantiteP, int quantiteB)
        {
            string query = $"INSERT INTO Commande (n°Commande, idPiece, idB, idMag, idSalarie, quantiteP, quantiteB) " +
                           $"VALUES ({numeroCommande}, {idPiece}, {idB}, {idMag}, '{idSalarie}', {quantiteP}, {quantiteB});";
            Command requete = new Command(query, resultat);
            requete.exec();
        }

        public void supp(int numeroCommande)
        {
            string query = $"DELETE FROM Commande WHERE n°Commande = {numeroCommande};";
            Command requete = new Command(query, resultat);
            requete.exec();
        }

        public void update(int numeroCommande, int idPiece, int idB, int idMag, int idSalarie, int quantiteP, int quantiteB)
        {
            string query = $"UPDATE Commande SET idPiece = {idPiece}, idB = {idB}, idMag = {idMag}, idSalarie = '{idSalarie}', " +
                           $"quantiteP = {quantiteP}, quantiteB = {quantiteB} " +
                           $"WHERE n°Commande = {numeroCommande};";

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
            Command command = new Command("SELECT * FROM Commande;", resultat);
            command.exec();
        }
      
        private void PageCommande_Load(object sender, EventArgs e)
        {
            resultat.Text = "";
            Command command = new Command("SELECT * FROM Commande;", resultat);
            command.exec();
        }

        private void retour_button_Click(object sender, EventArgs e)
        {
            Form2 page = new Form2();
            page.Show();
            this.Hide();
        }

        private void idB_label_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Cat_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void ajouter_button_Click(object sender, EventArgs e)
        {
            this.cree(int.Parse(idcommande_input.Text), int.Parse(idPiece_input.Text), int.Parse(idb_input.Text), int.Parse(idmag_input.Text),
                int.Parse(ids_input.Text), int.Parse(quantiteP_input.Text), int.Parse(quantiteB_input.Text));

            idcommande_input.Text = "";
            idPiece_input.Text = "";
            idb_input.Text = "";
            idmag_input.Text = "";
            ids_input.Text = "";
            quantiteP_input.Text = "";
            quantiteB_input.Text = "";
           
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            this.update(int.Parse(idcommande_input.Text), int.Parse(idPiece_input.Text), int.Parse(idb_input.Text), int.Parse(idmag_input.Text),
                int.Parse(ids_input.Text), int.Parse(quantiteP_input.Text), int.Parse(quantiteB_input.Text));

            idcommande_input.Text = "";
            idPiece_input.Text = "";
            idb_input.Text = "";
            idmag_input.Text = "";
            ids_input.Text = "";
            quantiteP_input.Text = "";
            quantiteB_input.Text = "";
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            this.supp(int.Parse(idSupp.Text));
            idSupp.Text = "";
        }
    }
}
