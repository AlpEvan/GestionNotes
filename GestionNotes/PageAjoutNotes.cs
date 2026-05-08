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
    public partial class PageAjoutNotes : Form
    {
        private readonly SqliteConnection _db = DatabaseManager.Instance.Connection;
        private double note = 0;
        private double coefficient = 0;
        public PageAjoutNotes()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            note = Convert.ToDouble(numNote.Value);
            coefficient = Convert.ToDouble(numCoefficient.Text);

            if (note > 6 || note < 1)
            {
                MessageBox.Show("Les notes sont de 1 a 6", "Champs invalide",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (coefficient < 0.5 || coefficient > 100)
            {
                MessageBox.Show("Le coefficient minimum est 1 et maximum 100", "Champs invalide",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                AjouterNote(note, coefficient);

                GestionNotes loginForm = new GestionNotes();
                loginForm.Show();
                this.Close();
            }
            catch (Microsoft.Data.Sqlite.SqliteException ex) when (ex.Message.Contains("UNIQUE"))
            {
                MessageBox.Show("Cet email est deja utilise.", "Erreur d'inscription",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
