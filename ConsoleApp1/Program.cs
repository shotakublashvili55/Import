using ConsoleApp1.Models;
using System.Text.Json;
using ConsoleApp1.Library;
using System.Runtime.CompilerServices;



string filePathGeneral = @"d:\\tamta\general.json";
string filePathCosts = @"d:\\tamta\costs.json";
string filePathGood = @"d:\\tamta\goods.json";


List<General> generals = JsonSerializer.Deserialize<List<General>>(File.ReadAllText(filePathGeneral));
List<Cost> costs = JsonSerializer.Deserialize<List<Cost>>(File.ReadAllText(filePathCosts));
List<Good> products = JsonSerializer.Deserialize<List<Good>>(File.ReadAllText(filePathGood));


Calculate.Caltulate_(generals, costs, products);
Console.WriteLine("\n\n\n\n\n\n\n\n");


