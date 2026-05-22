using Microsoft.Data.Sqlite;

public sealed class DatabaseManager
{
    private static readonly Lazy<DatabaseManager> _instance =
        new(() => new DatabaseManager());

    public static DatabaseManager Instance => _instance.Value;

    private readonly SqliteConnection _connection;

    private DatabaseManager()
    {
        _connection = new SqliteConnection("Data Source=ma_base.db");
        _connection.Open();
        InitialiserBase();
    }

    public SqliteConnection Connection => _connection;

    private void InitialiserBase()
    {
        var cmd = _connection.CreateCommand();
        cmd.CommandText = """
        CREATE TABLE IF NOT EXISTS utilisateurs (
            id INTEGER PRIMARY KEY AUTOINCREMENT,
            nom TEXT NOT NULL,
            email TEXT NOT NULL UNIQUE,
            mot_de_passe TEXT NOT NULL
        );

        CREATE TABLE IF NOT EXISTS branches (
            id INTEGER PRIMARY KEY AUTOINCREMENT,
            nom TEXT NOT NULL
        );

        CREATE TABLE IF NOT EXISTS notes (
            id INTEGER PRIMARY KEY AUTOINCREMENT,
            utilisateur_id INTEGER NOT NULL,
            branche_id INTEGER NOT NULL,
            note REAL NOT NULL,
            coefficient REAL NOT NULL,
            FOREIGN KEY(utilisateur_id) REFERENCES utilisateurs(id),
            FOREIGN KEY(branche_id) REFERENCES branches(id)
        );
    """;
        
        cmd.ExecuteNonQuery();
    }

    public SqliteCommand CreerCommande(string sql)
    {
        var cmd = _connection.CreateCommand();
        cmd.CommandText = sql;
        return cmd;
    }

    public void Fermer()
    {
        _connection.Close();
        _connection.Dispose();
    }
}