Console.Write("quel jour de la semaine some nous ?");
string day = Console.ReadLine()?? "erreur";


switch (day){
  case "lundi":
  case "mardi":
  case "mercredi":
  case "jeudi":
  case "vendredi":
  Console.WriteLine("cest un jour de travail");
  break;
  case "samedi":
  case "dimanche":
  Console.WriteLine("c'est le weekend");
  break;
default: 
  Console.WriteLine("erreur de saisie");
  break;
}
