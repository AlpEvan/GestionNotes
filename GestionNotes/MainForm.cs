using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestionNotes
{
    public partial class MainForm : Form
    {
        private Utilisateur _currentUser;

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(Utilisateur user) : this()
        {
            _currentUser = user;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            PageAjoutNotes form = new PageAjoutNotes();
            form.Show();
            this.Hide();
        }

        private void btnConsulter_Click(object sender, EventArgs e)
        {
            if (_currentUser == null)
            {
                MessageBox.Show("Aucun utilisateur connecté.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PageVoirNotes form = new PageVoirNotes(_currentUser);
            form.Show();
            this.Hide();
        }
    }
}
