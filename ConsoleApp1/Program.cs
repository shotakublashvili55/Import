using ConsoleApp1.Models;
using System.Text.Json;
using ConsoleApp1.Library;
using System.Runtime.CompilerServices;


string folderURL=Directory.GetCurrentDirectory();

string filePathGeneral =@$"{folderURL}\general.json";   
string filePathCosts = @$"{folderURL}\costs.json";                                
string filePathGood = @$"{folderURL}\goods.json";                              

Console.WriteLine(folderURL  );

List<General> generals = JsonSerializer.Deserialize<List<General>>(File.ReadAllText(filePathGeneral));
List<Cost> costs = JsonSerializer.Deserialize<List<Cost>>(File.ReadAllText(filePathCosts));
List<Good> products = JsonSerializer.Deserialize<List<Good>>(File.ReadAllText(filePathGood));


Calculate.Caltulate_(generals, costs, products);
Console.WriteLine("\n\n\n\n\n\n\n\n");


Thread.Sleep(15000);