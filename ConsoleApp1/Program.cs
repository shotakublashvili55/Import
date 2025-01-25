using ConsoleApp1.Models;
using System.Text.Json;


//Read from Json
string filePathGeneral = @"d:\\tamta\general.json";
string filePathCosts = @"d:\\tamta\costs.json";
string filePathGood = @"d:\\tamta\goods.json";

List<General> generals = JsonSerializer.Deserialize<List<General>>(File.ReadAllText(filePathGeneral));
List<Cost> costs = JsonSerializer.Deserialize<List<Cost>>(File.ReadAllText(filePathCosts));
List<Good> products = JsonSerializer.Deserialize<List<Good>>(File.ReadAllText(filePathGood));


var general = generals.FirstOrDefault();
decimal TotalInvoiceAmmount = 0;
decimal RateUsed = 0;
decimal Prepayment = general.PrepaymentSum1+general.PrepaymentSum2+general.PrepaymentSum3;
decimal Coefficient = 0;
decimal TotalSumWithDiscountGel = 0;


foreach (var product in products)
{
       TotalInvoiceAmmount += product.Ammount;

}


if  (Math.Abs(general.TotalSumWithDiscount - TotalInvoiceAmmount ) >0.1m)
{
    Console.WriteLine( "Check the Ammounts" );
    Environment.Exit(0);
}


if (Prepayment <= 0)
    {
    TotalSumWithDiscountGel = general.TotalSumWithDiscount * general.ExchangeRateManual;;
    }

    else if (Prepayment >= general.TotalSumWithDiscount)
    {
        TotalSumWithDiscountGel = general.PrepaymentSum1 * general.PrepaymentExchangeRate1 + general.PrepaymentSum2 * general.PrepaymentExchangeRate2 + general.PrepaymentSum3 * general.PrepaymentExchangeRate3;
    }

    else if (Prepayment < general.TotalSumWithDiscount && Prepayment>0)
    {
        TotalSumWithDiscountGel = general.PrepaymentSum1 * general.PrepaymentExchangeRate1 + general.PrepaymentSum2 * general.PrepaymentExchangeRate2 + general.PrepaymentSum3 * general.PrepaymentExchangeRate3 + (general.TotalSumWithDiscount - Prepayment) * general.ExchangeRateManual;
    }

    else
    {
        Console.WriteLine("Check the Ammounts");
        Environment.Exit(0);

    }







    foreach (var product in products)
{

 
    Coefficient =   product.Ammount / general.TotalSumWithDiscount;


    decimal invoicePrice = TotalSumWithDiscountGel * Coefficient;


    Console.WriteLine($"{product.Description}...... {invoicePrice}  ");

    foreach (var cost in costs)
    {
        if (cost.International = true)
           
        {
            decimal TotalCostGel = 0;
            decimal CostPrepayment = cost.PrepaymentSum1 + cost.PrepaymentSum2 + cost.PrepaymentSum3;

            if (CostPrepayment <= 0)
            {
                 TotalCostGel = cost.CostSum * cost.CostExchangeRate;
            }

            else if (CostPrepayment >= cost.CostSum)
            {
                 TotalCostGel = cost.PrepaymentSum1 * cost.PrepaymentExchangeRate1 + cost.PrepaymentSum2 * cost.PrepaymentExchangeRate2 + cost.PrepaymentSum3 * cost.PrepaymentExchangeRate3;
            }

            else if (CostPrepayment < cost.CostSum && CostPrepayment > 0)
            {
                 TotalCostGel = cost.PrepaymentSum1 * cost.PrepaymentExchangeRate1 + cost.PrepaymentSum2 * cost.PrepaymentExchangeRate2 + cost.PrepaymentSum3 * cost.PrepaymentExchangeRate3 + (cost.CostSum - CostPrepayment) * cost.CostExchangeRate;
            }

            else
            {
                Console.WriteLine("Check the Ammounts");
                Environment.Exit(0);

            }
 
            decimal costPrice = TotalCostGel * Coefficient;
            Console.WriteLine($"______________{cost.Description}...... {costPrice} ");

        }

    }



}








