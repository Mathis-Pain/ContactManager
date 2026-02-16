Dictionary<string, string> contacts = new Dictionary<string, string>();
string option = "";
/* bool present = true; */

do {
Console.WriteLine("Choisissez parmi les options suivantes: ajouter, supprimer, rechercher, consulter et quitter");
 option = Console.ReadLine();
 switch (option) {
  case "quitter":
  Console.WriteLine("l'application est fermé");
  break;
  case "ajouter":
  Console.WriteLine("ajouter le nom");
  string name = Console.ReadLine();
    Console.WriteLine("entrer le numero");
    string numero = Console.ReadLine();
    contacts.Add(name,numero);
    break;
      case "supprimer":
  Console.WriteLine("choisissez le nom a suprimer");
    string namesup = Console.ReadLine();
  if(contacts.ContainsKey(namesup)){
    contacts.Remove(namesup);
     Console.WriteLine(namesup + " supprimé");
  }else {
     Console.WriteLine("contact introuvable");
  }
  break;
     case "consulter":
     if (contacts.Count==0){
  Console.WriteLine("liste vide");
     }else {
     foreach (var contact in contacts){
  Console.WriteLine(contact);
     }
     }
  break;
   case "rechercher":
  Console.WriteLine("entrer le nom du contact a rechercher");
  var recherche=Console.ReadLine();
  /* foreach (var contact in contacts){
    if (recherche==contact.Key){
      present=true;
      Console.WriteLine(contact.Value);
      Console.WriteLine("ok");
      break;
    }
    }
   present=false;
      Console.WriteLine("ce contact n'est pas present");  */
      if (contacts.ContainsKey(recherche)){
        Console.WriteLine(contacts[recherche]);
      } else {
        Console.WriteLine("contact introuvable");
      }
  break;
    default:
    Console.WriteLine("erreur relancer le programme");
    break;
 }
}while(option != "quitter");