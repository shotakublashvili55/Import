using ConsoleApp1.Models;
using System.Text.Json;
using ConsoleApp1.Library;
using System.Runtime.CompilerServices;
using FluentValidation;


string folderURL=Directory.GetCurrentDirectory();

string filePathGeneral =@$"{folderURL}\general.json";   
string filePathCosts = @$"{folderURL}\costs.json";                                
string filePathGood = @$"{folderURL}\goods.json";





List<General> generals = JsonSerializer.Deserialize<List<General>>(File.ReadAllText(filePathGeneral));
List<Cost> costs = JsonSerializer.Deserialize<List<Cost>>(File.ReadAllText(filePathCosts));
List<Good> products = JsonSerializer.Deserialize<List<Good>>(File.ReadAllText(filePathGood));
int errorQuantity= Validate.Validate_(generals, costs, products);







if (errorQuantity==0)
{

    Calculate.Calculate_(generals, costs, products);

}
else
{

    Console.WriteLine($"\n Data is invalid, errors {errorQuantity}");

}


Console.WriteLine("\n\n\n\n\n\n\n\n");

string keep = Console.ReadLine();


