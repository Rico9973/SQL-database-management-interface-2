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
    public partial class PageEntreprise : Form
    {
        public PageEntreprise()
        {
            InitializeComponent();
            // Configuration du minuteur
            timer.Interval = 2000; // Actualiser toutes les secondes
            timer.Tick += Timer_Tick;
            timer.Start(); // Démarrer le minuteur
        }

            public void cree(int idBC, string nomCompagnie, string rue, string ville, string codePostal, string province, string telephone, string courriel, string personneContact, int pourcentageRemise)
        {
            string query = $"INSERT INTO BoutiqueC (idBC, nom_compagnie, rue, ville, code_postal, province, telephone, courriel, personne_contact, pourcentage_remise) " +
                           $"VALUES ({idBC}, '{nomCompagnie}', '{rue}', '{ville}', '{codePostal}', '{province}', '{telephone}', '{courriel}', '{personneContact}', {pourcentageRemise});";
            Command requete = new Command(query, resultat);
            requete.exec();
        }

        public void supp(int idBC)
        {
            string query = $"DELETE FROM BoutiqueC WHERE idBC = {idBC};";
            Command requete = new Command(query, resultat);
            requete.exec();
        }

        public void update(int idBC, string nomCompagnie, string rue, string ville, string codePostal, string province, string telephone, string courriel, string personneContact, int pourcentageRemise)
        {
            string query = $"UPDATE BoutiqueC SET nom_compagnie = '{nomCompagnie}', rue = '{rue}', ville = '{ville}', code_postal = '{codePostal}', " +
                           $"province = '{province}', telephone = '{telephone}', courriel = '{courriel}', personne_contact = '{personneContact}', " +
                           $"pourcentage_remise = {pourcentageRemise} WHERE idBC = {idBC};";

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
            Command command = new Command("SELECT * FROM BoutiqueC;", resultat);
            command.exec();
        }

        private void PageClient_Load(object sender, EventArgs e)
        {
            resultat.Text = "";
            Command command = new Command("SELECT * FROM BoutiqueC;", resultat);
            command.exec();
        }
        private void PageEntreprise_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void retour_button_Click(object sender, EventArgs e)
        {
            Form2 page = new Form2();
            page.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void province_TextChanged(object sender, EventArgs e)
        {

        }

        private void idFidelio_TextChanged(object sender, EventArgs e)
        {

        }

        private void ajouter_button_Click(object sender, EventArgs e)
        {
            this.cree(int.Parse(idBC_input.Text), nom.Text, rue.Text, ville.Text, codeP.Text, province.Text,
                telephone.Text, courriel.Text, contact.Text, int.Parse(remise.Text));

            idBC_input.Text = "";
            nom.Text = "";
            rue.Text = "";
            ville.Text = "";
            codeP.Text = "";
            province.Text = "";
            telephone.Text = "";
            courriel.Text = "";
            contact.Text = "";
            remise.Text = "";
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            this.update(int.Parse(idBC_input.Text), nom.Text, rue.Text, ville.Text, codeP.Text, province.Text,
                telephone.Text, courriel.Text, contact.Text, int.Parse(remise.Text));

            idBC_input.Text = "";
            nom.Text = "";
            rue.Text = "";
            ville.Text = "";
            codeP.Text = "";
            province.Text = "";
            telephone.Text = "";
            courriel.Text = "";
            contact.Text = "";
            remise.Text = "";
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            this.supp(int.Parse(idSupp.Text));
            idSupp.Text = "";
        }
    }
}
