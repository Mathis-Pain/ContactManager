using Microsoft.Data.Sqlite;


class Database {
  public static void Init() {
// verification si fichier deja existant
var isPresent = File.Exists("Data/contacts.db") ;
if (!isPresent){ 
// connexion avec le fichier de db et creation de celui ci si il n'existe pas 
var connection = new SqliteConnection("Data Source=Data/contacts.db");
// recuperation du contenu de schema.sql
string contenu = File.ReadAllText("Data/schema.sql");
// preparation de la commande
var command = new SqliteCommand(contenu, connection);
// ouverture de la connexion
connection.Open();
// execution de la commande qui n'est pas une requete juste un ordre
command.ExecuteNonQuery();
// fermer la bdd 
connection.Close();
} else {
  Console.WriteLine("Base deja existante");
}
  }
}
