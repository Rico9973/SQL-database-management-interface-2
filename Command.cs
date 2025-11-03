using MySql.Data.MySqlClient;
using System;
using System.Security.Cryptography;
using System.Windows.Forms; // Ajout de cette référence pour accéder à des contrôles Windows Forms

namespace Projet
{
    internal class Command
    {
        private string requete;
        private TextBox textBox; // Référence à un TextBox où afficher les résultats

        public Command(string commande, TextBox textBox)
        {
            this.requete = commande;
            this.textBox = textBox;
        }

        public void exec()
        {
            try
            {
               
                string ConnexionString = "SERVER = localhost; PORT = 3306; " + "DATABASE = velomax;" + "UID = bozo; PASSWORD = bozo";
                MySqlConnection connection = new MySqlConnection(ConnexionString);
                connection.Open();

                MySqlCommand command = new MySqlCommand(requete, connection);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string resultLine = "";
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            resultLine += reader[i] + "\t";
                        }
                        // Afficher le résultat dans le TextBox (mise à jour depuis le thread d'interface utilisateur)
                        textBox.Invoke((MethodInvoker)(() => textBox.AppendText(resultLine + Environment.NewLine)));
                    }
                }
            }
            catch (MySqlException e)
            {
                // Afficher l'erreur dans le TextBox (mise à jour depuis le thread d'interface utilisateur)
                textBox.Invoke((MethodInvoker)(() => textBox.AppendText("ErreurConnexion : " + e.ToString() + Environment.NewLine)));
            }
        }
    }
}
