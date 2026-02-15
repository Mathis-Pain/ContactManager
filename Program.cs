Console.Write("quelle est ton age?");
int age = int.Parse(Console.ReadLine() ?? "0");
if (age<18){
  Console.WriteLine("tu es mineur");
}else if (age>65){
Console.WriteLine("tu es senior");
}else{ 
  Console.WriteLine("tu es majeur");
  }