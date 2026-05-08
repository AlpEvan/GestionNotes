using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GestionNotes
{
    public partial class PageInscription : Form
    {
        private readonly SqliteConnection _db = DatabaseManager.Instance.Connection;
        private string nom = string.Empty;
        private string email = string.Empty;
        private string mdp = string.Empty;
        public PageInscription()
        {
            InitializeComponent();
        }

        private void btnConfirmerInscription_Click(object sender, EventArgs e)
        {
            nom = tbxNom.Text;
            email = tbxEmail.Text;
            mdp = tbxMdp.Text;
            AjouterUtilisateur(nom, email, mdp);
            GestionNotes Form = new GestionNotes();
            Form.Show();
            this.Close();
        }

        public void AjouterUtilisateur(string nom, string email, string mdp)
        {
            var cmd = _db.CreateCommand();
            cmd.CommandText = "INSERT INTO utilisateurs (nom, email, mot_de_passe) VALUES ($nom, $email, $mdp)";
            cmd.Parameters.AddWithValue("$nom", nom);
            cmd.Parameters.AddWithValue("$email", email);
            cmd.Parameters.AddWithValue("$mdp", mdp);
            cmd.ExecuteNonQuery();
        }
    }
}
