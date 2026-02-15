

var isValide = false;
int count = 0;
 do { 
  Console.WriteLine("quel jour de la semaine somme nous ?");
string day = Console.ReadLine()?? "erreur";
  switch (day){
  case "lundi":
  case "mardi":
  case "mercredi":
  case "jeudi":
  case "vendredi":
  isValide = true;
  Console.Write("cest un jour de travail");
  break;
  case "samedi":
  case "dimanche":
  isValide = true;
  Console.Write("c'est le weekend");
  break;
  default: 
  isValide = false;
  count++;
  Console.Write("erreur de saisie");
  break;
  }
 }while(!isValide&&count <3);
 
