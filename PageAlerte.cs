using MySql.Data.MySqlClient;
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
    public partial class PageAlerte : Form
    {
        public PageAlerte()
        {
            InitializeComponent();
        }

        public void GererAlertePieces(int seuilAlerte)
        {
            string ConnexionString = "SERVER=localhost;PORT=3306;DATABASE=velomax;UID=bozo;PASSWORD=bozo";
            MySqlConnection connection = new MySqlConnection(ConnexionString);
            connection.Open();

            string query = $"SELECT idPiece, descriptions, quantite FROM Piece;";

            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();


            string description = "";
            int quantite = 0;
            int idPiece = 0;
            while (reader.Read())
            {
                description = reader["descriptions"].ToString();
                quantite = Convert.ToInt32(reader["quantite"]);
                idPiece = Convert.ToInt32(reader["idPiece"]);

                if (quantite < seuilAlerte)
                {
                    resultat.Text = $"Alerte : La pièce {description} d'id: {idPiece} n'a plus que {quantite} unité en stock !";

                }

            }
            reader.Close();
            string query1 = $"SELECT F.idF, F.nom FROM Piece P JOIN Fournisseur F ON P.idF = F.idF WHERE descriptions = '{description}';";
            MySqlCommand command1 = new MySqlCommand(query1, connection);
            MySqlDataReader reader1 = command1.ExecuteReader();


            while (reader1.Read())
            {
                int idFournisseur = Convert.ToInt32(reader1["idF"]);
                string nomFournisseur = reader1["nom"].ToString();
                resultat.Text += $"Suggestion de fournisseur : {nomFournisseur}, id: {idFournisseur}";

            }
            reader1.Close();

        }

        public void GererAlerteBycicle(int seuilAlerte)
        {
            string ConnexionString = "SERVER=localhost;PORT=3306;DATABASE=velomax;UID=bozo;PASSWORD=bozo";
            MySqlConnection connection = new MySqlConnection(ConnexionString);
            connection.Open();

            string query = $"SELECT nom, quantite FROM Byciclette;";

            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string description = reader["nom"].ToString();
                int quantite = Convert.ToInt32(reader["quantite"]);

                if (quantite < seuilAlerte)
                {
                    resultat2.Text = $"Alerte : La byciclette {description} n'a plus que {quantite} unité en stock ";

                }
            }

            reader.Close();
        }

        public void MagasinSousStocke()
        {
            resultat8.Text += "[Byciclette|Gérant1|Gérant2|Prix1|Prix2]\r\n";
            string query1 = "SELECT m.idMag, m.gerant, SUM(b.quantite) AS TotalStock FROM Magasins m JOIN Byciclette b ON m.idMag = b.idMag GROUP BY m.idMag, " +
                "m.gerant HAVING SUM(b.quantite) < (SELECT AVG(TotalStock) FROM (SELECT SUM(b2.quantite) AS TotalStock FROM Byciclette b2 GROUP BY b2.idMag) " +
                "AS AvgStock);";
            Command requete1 = new Command(query1, resultat8);
            requete1.exec();
        }
        private void retour_button_Click(object sender, EventArgs e)
        {
            Form2 page = new Form2();
            page.Show();
            this.Hide();
        }

        private void PageAlerte_Load(object sender, EventArgs e)
        {
            this.GererAlertePieces(200);
            this.GererAlerteBycicle(200);
            this.MagasinSousStocke();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
