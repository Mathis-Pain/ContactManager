
int result;
int count = 0;
Random random = new Random();
int nombre = random.Next(1, 11);
do {
  Console.WriteLine("Devinez le nombre (entre 1 et 10)");
 result = int.Parse(Console.ReadLine()??"");

 if (result == nombre){
  Console.WriteLine("Bravo");
 } else {
   Console.WriteLine("Perdu essaye encore");
   count++;
 }
} while(result != nombre && count <3);

if (count >= 3){
  Console.WriteLine("perdu");
}else{
Console.WriteLine("gagné");
}