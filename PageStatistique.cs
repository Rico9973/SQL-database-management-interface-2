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
    public partial class PageStatistique : Form
    {
        public PageStatistique()
        {
            InitializeComponent();
        }

        public void venteGlobal()
        {
            resultat.Text += "[idPiece | Produit | Quantité vendue] \r\n";
            string query = $"SELECT P.idPiece, P.descriptions, SUM(C.quantiteP)FROM Commande C JOIN Piece P ON C.idPiece = P.idPiece GROUP BY P.idPiece ;";
            Command requete = new Command(query, resultat);
            requete.exec();

            string query1 = $"SELECT B.idB, B.nom, SUM(C.quantiteB)FROM Commande C JOIN Byciclette B ON C.idB = B.idB GROUP BY B.idB;";
            Command requete1 = new Command(query1, resultat);
            requete1.exec();



        }

        public void venteMagasin(int idMag)
        {
            resultat2.Text += "[idPiece | Produit | Quantité vendue] \r\n";
            string query1 = $"SELECT P.idPiece, P.descriptions, count(C.quantiteP)FROM Commande C JOIN Piece P ON C.idPiece = P.idPiece " +
                            $" WHERE C.idMag = {idMag} GROUP BY P.idPiece;";
            Command requete1 = new Command(query1, resultat2);
            requete1.exec();
            string query2 = $"SELECT B.idB, B.nom, SUM(C.quantiteB) FROM Commande C JOIN Byciclette B ON C.idB = B.idB WHERE C.idMag = {idMag} " +
                             $"GROUP BY B.idB;";
            Command requete2 = new Command(query2, resultat2);
            requete2.exec();
        }

        public void venteSalarie(int idSalarie)
        {
            resultat3.Text += "[idPiece | Produit | Quantité vendue] \r\n";
            string query1 = $"SELECT P.idPiece, P.descriptions, SUM(C.quantiteP) FROM Commande C JOIN Piece P ON C.idPiece = P.idPiece " +
                            $" WHERE C.idSalarie = {idSalarie} GROUP BY P.idPiece UNION SELECT B.idB, B.nom, SUM(C.quantiteB) FROM Commande C " +
                            $"JOIN Byciclette B ON C.idB = B.idB WHERE C.idSalarie = {idSalarie} GROUP BY B.idB;";
            Command requete1 = new Command(query1, resultat3);
            requete1.exec();

      
            //string query2 = $"SELECT B.idB, B.nom, SUM(C.quantiteB) FROM Commande C JOIN Byciclette B ON C.idB = B.idB " +
            //                $" WHERE C.idSalarie = {idSalarie} GROUP BY B.idB;";
            //Command requete2 = new Command(query2, resultat3);
            //requete2.exec();
        }

        public void MembrePerFidelio(int idFidelio)
        {
            resultat4.Text = "[Programme | ID Client | Nom | Prénom | Expiration] \r\n";
            string query1 = $"SELECT F.nomProgramme, C.idC, C.nom, C.prenom, A.expiration FROM Fidelio F JOIN Adhesion A ON A.idFidelio = F.idFidelio " +
                            $"JOIN Clients C ON C.idC = A.idC WHERE F.idFidelio = {idFidelio};";
            Command requete1 = new Command(query1, resultat4);
            requete1.exec();
        }

        public void MeilleurSalarie()
        {
            resultat5.Text += "\r\n\r\n[idSalarie \t | Nom \t | Prenom | CA genere] \r\n";
            string query1 = $"SELECT S.idSalarie, S.nom, S.prenom, sum(P.prix_unit*C.quantiteP) FROM Salarie S JOIN Commande C ON S.idSalarie = C.idSalarie " +
                            $"JOIN Piece P ON P.idPiece = C.idPiece GROUP BY idSalarie LIMIT 1;";
            Command requete1 = new Command(query1, resultat5);
            requete1.exec();

            resultat5.Text += "\r\n\r\n[idSalarie \t | Nom \t | Prenom | CA genere]\r\n";
            string query2 = $"SELECT S.idSalarie, S.nom, S.prenom, sum(B.prix_unitaire*C.quantiteB) FROM Salarie S JOIN Commande C ON S.idSalarie = C.idSalarie " +
                            $"JOIN Byciclette B ON B.idB = C.idB GROUP BY idSalarie LIMIT 1;";
            Command requete2 = new Command(query2, resultat5);
            requete2.exec();
        }

        public void Commande()
        {
            resultat6.Text += "[Moy Montant | Moy Nbr de Piece | Moy Nbr de Velo]\r\n";
            string query1 = $"SELECT SUM(C.quantiteP* P.prix_unit + C.quantiteB*B.prix_unitaire)/SUM(C.n°Commande), AVG(C.quantiteP), AVG(C.quantiteB)" +
                            $"FROM Commande C JOIN Piece P ON P.idPiece = C.idPiece " +
                            $"JOIN Byciclette B ON C.idB = B.idB; ";
            Command requete1 = new Command(query1, resultat6);
            requete1.exec();
        }

        public void Bonus()
        {
            resultat7.Text += "[idSalarie | bonus (en euros)]\r\n";
            string query1 = $"SELECT S.idSalarie, SUM(C.quantiteP* P.prix_unit + C.quantiteB*B.prix_unitaire) * 0.05 " +
                            $"FROM Commande C JOIN Piece P ON P.idPiece = C.idPiece " +
                            $"JOIN Byciclette B ON C.idB = B.idB JOIN Salarie S ON C.idSalarie = S.idSalarie GROUP By C.idSalarie; ";
            Command requete1 = new Command(query1, resultat7);
            requete1.exec();

            resultat7.Text += "\r\n \r\n";
            string query2 = $"SELECT AVG(CA * 0.05 ) FROM (SELECT SUM(C.quantiteP* P.prix_unit + C.quantiteB*B.prix_unitaire) AS CA " +
                $"FROM Commande C JOIN Piece P ON P.idPiece = C.idPiece JOIN byciclette B ON B.idB = C.idB " +
                $"JOIN Salarie S ON S.idSalarie = C.idSalarie GROUP BY C.idSalarie) AS subquery";

            Command requete2 = new Command(query2,resultat7);
            requete2.exec();


        }

        public void Comparaison()
        {
            resultat8.Text += "[Byciclette|Gérant1|Gérant2|Prix1|Prix2]\r\n";
            string query1 = "SELECT b1.nom AS NomBicyclette, m1.gerant AS GerantMagasin1,m2.gerant AS GerantMagasin2,b1.prix_unitaire AS PrixMagasin1," +
                "b2.prix_unitaire AS PrixMagasin2 FROM Byciclette b1 JOIN Byciclette b2 ON b1.nom = b2.nom AND b1.idB <> b2.idB JOIN Magasins m1 ON " +
                "b1.idMag = m1.idMag JOIN Magasins m2 ON b2.idMag = m2.idMag WHERE b1.prix_unitaire <> b2.prix_unitaire ORDER BY b1.nom;";
            Command requete1 = new Command(query1, resultat8);
            requete1.exec();
        }

        
        private void PageStatistique_Load(object sender, EventArgs e)
        {
            venteGlobal();
            MeilleurSalarie();
            Commande();
            Bonus();
            Comparaison();
        }

        private void retour_button_Click(object sender, EventArgs e)
        {
            Form2 page = new Form2();
            page.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultat2.Text = "";
            venteMagasin(int.Parse(idMag.Text));
            idMag.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resultat3.Text = "";
            venteSalarie(int.Parse(idS.Text));
            idS.Text = "";
        }

        private void lancer_Fidelio_Click(object sender, EventArgs e)
        {
            resultat4.Text = "";
            MembrePerFidelio(int.Parse(idFidelio.Text));
            idFidelio.Text = "";
        }

        private void resultat4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
