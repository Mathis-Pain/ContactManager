// On importe la bibliothèque SQLite
using Microsoft.Data.Sqlite;

// Déclaration de la classe Request
class DbRequest
{
    // Méthode statique Post
    // Elle permet d'insérer un contact dans la base
    public static void Post(string name, string num)
    {
        //  using = crée une connexion ET la ferme automatiquement à la fin du bloc

        using (var connection = new SqliteConnection("Data Source=contacts.db"))
        {
            // On ouvre la connexion à la base de données
            connection.Open();

            // On prépare la requête SQL avec des paramètres
            string sql = "INSERT INTO users (user, num) VALUES (@name, @num)";

            //  On crée une commande SQL liée à la connexion
            using (var command = new SqliteCommand(sql, connection))
            {
                // On remplace les paramètres @name et @num
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@num", num);

                // On exécute la commande (INSERT dans ce cas)
                command.ExecuteNonQuery();
            } //  Ici la commande est automatiquement détruite

        } //  Ici la connexion est automatiquement fermée

        Console.WriteLine("Contact ajouté !");
    }
    public static void Delete(string name){
        using (var connection = new SqliteConnection("Data source=contacts.db"))
        {
            connection.Open();
         string sql = "DELETE FROM users WHERE user = @name";
            using(var command = new SqliteCommand(sql,connection))
            {
            command.Parameters.AddWithValue("@name", name);
            command.ExecuteNonQuery();
            }
        }

    Console.WriteLine("Contact supprimé");
    }
public static List<Contact> Get()
{
    var contacts = new List<Contact>();
    using (var connection = new SqliteConnection("Data source=contacts.db"))
    {
        connection.Open();
        string sql = "SELECT * FROM users";
        using (var command = new SqliteCommand(sql, connection))
        {
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    contacts.Add(new Contact
                    {
                        name = reader.GetString(1),  // colonne 2
                        num = reader.GetString(2)     // colonne 3
                    });
                }
            }
        }
    }

    return contacts;
}
}
