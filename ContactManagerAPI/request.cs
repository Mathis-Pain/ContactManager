// On importe la bibliothèque SQLite
using Microsoft.Data.Sqlite;

// Déclaration de la classe Request
class Request
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
            string sql = "INSERT INTO Contacts (Name, Num) VALUES (@name, @num)";

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
}
