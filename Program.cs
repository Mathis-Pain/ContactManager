List<string> fruit = new List<string>();
string item = "";
List<string> items = new List<string>();
do {
  Console.WriteLine("ajoute un item");
  item = Console.ReadLine()??"";
  if (item != "fin"){
items.Add(item);
  }
}while(item != "fin");

foreach(string i in items){
  Console.WriteLine(i);
}
Console.WriteLine(items.Count);