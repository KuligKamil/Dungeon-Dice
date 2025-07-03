// See https://aka.ms/new-console-template for more information
// https://www.youtube.com/watch?v=4ro5UCqU0P4&list=PLdo4fOcmZ0oULFjxrOagaERVAMbmG20Xe&index=15
// short counter = 1;
// long counter = 1;
// int counter = 1;
// do
// {
//   Console.WriteLine($"counter: {counter}");
//   counter++;
// }
// while (counter > 0);

// for (int i = 0; i < 10; i++)
// {
//   Console.WriteLine($"Hello World {i + 1}");
// }

String text = "Hello World";
var text2 = "Hello World 2";

Console.WriteLine(text + " " + text2);
foreach (var item in text)
{
  Console.WriteLine(item);
}
var names2 = new string[] { "Alice", "Bob", "Charlie", "Kamil", "Ania" };

names2 = [.. names2, "Dave"]; // Destructor?

foreach (var name in names2)
{
  Console.WriteLine(name.ToLower());
}
var names = new List<string> { "Alice", "Bob", "Charlie", "Kamil", "Ania" };

names.Add("Dave");
names.Remove("John"); // This will not work, as 'John' is not in the list
names.Remove("Alice");
// list vs array
// new List<string> vs string[]
// string[] namesArray = { "Alice", "Bob", "Charlie", "Kamil", "Ania" };
// array can't be resized, but list can be resized
//  deafult for list if perfomrance use array -> string[]
foreach (var name in names)
{
  Console.WriteLine(name.ToLower());
}

for (int i = 0; i < names.Count; i++)
{
  Console.WriteLine($"Name {i + 1}: {names[i]}");
}

Console.WriteLine($"last {names[^1]}");

foreach (var name in names[2..])
{
  Console.WriteLine(name.ToUpper());
}

// var is local variable type inference
//  if right side is not explicit not use var
// what about performance?

Console.WriteLine($"Before sort, Kamil at {names.IndexOf("Kamil")}");
Console.WriteLine(names);
names.Sort(); // Sort in place
Console.WriteLine($"After sort, Kamil at {names.IndexOf("Kamil")}");
Console.WriteLine(names);
foreach (var name in names)
{
  Console.WriteLine(name.ToUpper());
}
// how generate rundom number C#
// Dice dice12 = new(12);
// Dice dice6 = new(6);

// Console.WriteLine($"Random number between 1 and 100: {dice6.Roll()}");



// http://127.0.0.1:11434/