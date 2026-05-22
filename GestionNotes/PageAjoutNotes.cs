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
            ChargerBranches();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            note = Convert.ToDouble(numNote.Value);
            coefficient = Convert.ToDouble(numCoefficient.Value);

            if (note > 6 || note < 1)
            {
                MessageBox.Show("Les notes sont de 1 a 6", "Champs invalide",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (coefficient < 0.5 || coefficient > 100)
            {
                MessageBox.Show("Le coefficient minimum est 0.5 et maximum 100", "Champs invalide",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                AjouterNote(1, (int)cmbBranches.SelectedValue, note, coefficient);

                MainForm MainForm  = new MainForm();
                MainForm.Show();
                this.Close();
            }
            catch (Microsoft.Data.Sqlite.SqliteException ex) when (ex.Message.Contains("UNIQUE"))
            {
                MessageBox.Show("Erreur : Donnees invalides.", "Erreur de note",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        public void AjouterNote(int idUser,int brancheId, double note, double coefficient)
        {

            var cmd = _db.CreateCommand();

            var insert = _db.CreateCommand();
            insert.CommandText = "INSERT INTO notes (utilisateur_id, branche_id, note, coefficient) VALUES ($uid, $bid, $note, $coeff)";
            insert.Parameters.AddWithValue("$uid", idUser);
            insert.Parameters.AddWithValue("$bid", brancheId);
            insert.Parameters.AddWithValue("$note", note);
            insert.Parameters.AddWithValue("$coeff", coefficient);
            insert.ExecuteNonQuery();
        }

        private void ChargerBranches()
        {
            try
            {
                var cmd = _db.CreateCommand();
                cmd.CommandText = "SELECT id, nom FROM branches ORDER BY nom";
                using var reader = cmd.ExecuteReader();

                var table = new System.Data.DataTable();
                table.Columns.Add("id", typeof(int));
                table.Columns.Add("nom", typeof(string));

                while (reader.Read())
                {
                    var id = reader.GetInt32(0);
                    var nom = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                    table.Rows.Add(id, nom);
                }

                cmbBranches.DisplayMember = "nom";
                cmbBranches.ValueMember = "id";
                cmbBranches.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des branches : " + ex.Message, "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
