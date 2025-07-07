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
// // }
// public class Post
// {
//   public int UserId { get; set; }
//   public int Id { get; set; }
//   public string Title { get; set; } = string.Empty;
//   public string Body { get; set; } = string.Empty;
// }

// publ
using System.Text.Json;
using System.Text;
HttpClient httpClient = new HttpClient();
httpClient.BaseAddress = new Uri("http://localhost:11434/api/generate");
var post = new
{
  model = "llama2:latest",
  prompt = "Why is the sky blue?",
  stream = false
};
var json = JsonSerializer.Serialize(post);
var content = new StringContent(json, Encoding.UTF8, "application/json");
var response = await httpClient.PostAsync("", content);
response.EnsureSuccessStatusCode();
json = await response.Content.ReadAsStringAsync();
Console.WriteLine(json);


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

// TODO: Did C# have hoisting? 

var word = new Word
(
"public",
"scope word",
 "C#"

);

Console.WriteLine(word.Text);
class Word(string text, string description, string language)
{
  public string Text { get; set; } = text;
  public string Description { get; set; } = description;
  public string Language { get; set; } = language;
  public List<string> Tags { get; set; } = [];
  public DateTime Created { get; } = DateTime.Now;
  private DateTime _updatedAt = DateTime.Now;
}

// what is the deafult value visibility/scope in class whichout public/private/protected/internal?
class GuineaPig(string name)
{
  public string Name { get; } = name;
  public static string Sound() => "squeak";
}

// public abstract class Word 
// ovverride 
// ToString() => $"{Text} ({Language}) - {Description}";
// Implement ToString to classes
// magic class Object in C#

// http://127.0.0.1:11434/

//  curl --location 'http://localhost:11434/api/generate' \
// --data '{
//   "model": "llama2:latest",
//   "prompt": "Why is the sky blue?",
//   "stream": false
// }' 

// var response = await httpClient.PostAsync("posts", content);
// response.EnsureSuccessStatusCode();

// var responseJson = await response.Content.ReadAsStringAsync();
// return JsonSerializer.Deserialize<Post>(responseJson);