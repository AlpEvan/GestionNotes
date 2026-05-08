using Microsoft.Data.Sqlite;

namespace GestionNotes
{
    public partial class GestionNotes : Form
    {
        private readonly SqliteConnection _db = DatabaseManager.Instance.Connection;
        private List<Utilisateur> users = new List<Utilisateur>();
        private string email = string.Empty;
        private string password = string.Empty;
        public GestionNotes()
        {
            InitializeComponent();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            users = RecupererUsers();
            email = tbxEmail.Text;
            password = tbxMdp.Text;
            foreach (Utilisateur user in users)
            {
                if (user.Email == email && user.MotDePasse == password)
                {
                    MainForm MainForm = new MainForm();
                    MainForm.Show();
                    this.Close();
                }
            }
        }

        public List<Utilisateur> RecupererUsers()
        {
            var utilisateurs = new List<Utilisateur>();

            var cmd = _db.CreateCommand();
            cmd.CommandText = "SELECT id, nom, email, mot_de_passe FROM utilisateurs";

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var user = new Utilisateur(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3)
                );

                utilisateurs.Add(user);
            }

            return utilisateurs;
        }

        private void btnInscription_Click(object sender, EventArgs e)
        {
            PageInscription Form = new PageInscription();
            Form.Show();
            this.Close();
        }
    }
}
