using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace GestionNotes
{
    public partial class PageVoirNotes : Form
    {
        private readonly SqliteConnection _db = DatabaseManager.Instance.Connection;
        private Utilisateur _user;

        public PageVoirNotes(Utilisateur user)
        {
            _user = user;
            InitializeComponent();
            ChargerNotes();
        }

        private void ChargerNotes()
        {
            try
            {
                var cmd = _db.CreateCommand();
                cmd.CommandText = @"SELECT n.id, b.nom as branche, n.note, n.coefficient
                                     FROM notes n
                                     JOIN branches b ON n.branche_id = b.id
                                     WHERE n.utilisateur_id = $uid
                                     ORDER BY b.nom";
                cmd.Parameters.AddWithValue("$uid", _user.Id);

                using var reader = cmd.ExecuteReader();
                var table = new DataTable();
                table.Columns.Add("id", typeof(int));
                table.Columns.Add("Branche", typeof(string));
                table.Columns.Add("Note", typeof(double));
                table.Columns.Add("Coefficient", typeof(double));

                while (reader.Read())
                {
                    var id = reader.GetInt32(0);
                    var branche = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                    var note = reader.IsDBNull(2) ? 0.0 : reader.GetDouble(2);
                    var coeff = reader.IsDBNull(3) ? 0.0 : reader.GetDouble(3);
                    table.Rows.Add(id, branche, note, coeff);
                }

                dgvNotes.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des notes : " + ex.Message, "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm(_user);
            main.Show();
            this.Close();
        }
    }
}
