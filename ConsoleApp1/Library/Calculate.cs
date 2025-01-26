

using ConsoleApp1.Models;
using System.Collections.Generic;

namespace ConsoleApp1.Library;

internal class Calculate
{

    public static void Caltulate_(List<General> generals, List<Cost> costs, List<Good> products)
    {
        var general = generals.FirstOrDefault();
        decimal TotalInvoiceAmmount = 0;
        decimal RateNBG = 0;
        decimal Prepayment = general.PrepaymentSum1 + general.PrepaymentSum2 + general.PrepaymentSum3;
        decimal Coefficient = 0;
        decimal TotalSumWithDiscountGel = 0;
        decimal vatCoef= 1;
        decimal incomeTax = 0;
        decimal pensionTax = 0;

        foreach (var product in products)
        {
            TotalInvoiceAmmount += product.Ammount;

        }


        if (Math.Abs(general.TotalSumWithDiscount - TotalInvoiceAmmount) > 0.1m)
        {
            Console.Clear();
            Console.WriteLine("Check the Ammounts");
             string keep = Console.ReadLine();

          //  Environment.Exit(0);
        }


        if (Prepayment <= 0)
        {

            TotalSumWithDiscountGel = general.TotalSumWithDiscount * NBG.NBG_(general.DocumentDate, general.DocumentCurrency);// general.ExchangeRateManual; ;
        }

        else if (Prepayment >= general.TotalSumWithDiscount)
        {
            TotalSumWithDiscountGel = general.PrepaymentSum1 * NBG.NBG_(general.PrepaymentDate1, general.PrepaymentCurrency1) + general.PrepaymentSum2 * NBG.NBG_(general.PrepaymentDate2, general.PrepaymentCurrency2) + general.PrepaymentSum3 * NBG.NBG_(general.PrepaymentDate3, general.PrepaymentCurrency3);
        }

        else if (Prepayment < general.TotalSumWithDiscount && Prepayment > 0)
        {
            TotalSumWithDiscountGel = general.PrepaymentSum1 * NBG.NBG_(general.PrepaymentDate1, general.PrepaymentCurrency1) + general.PrepaymentSum2 * NBG.NBG_(general.PrepaymentDate2, general.PrepaymentCurrency2) + general.PrepaymentSum3 * NBG.NBG_(general.PrepaymentDate3, general.PrepaymentCurrency3) + (general.TotalSumWithDiscount - Prepayment) * NBG.NBG_(general.DocumentDate, general.DocumentCurrency);
        }

        else
        {

            Console.Clear();
            Console.WriteLine("Check the Ammounts");
         
            string keep = Console.ReadLine();
          //  Environment.Exit(0);

        }



        foreach (var product in products)
        {


            Coefficient = product.Ammount / general.TotalSumWithDiscount;


            decimal invoicePrice = TotalSumWithDiscountGel * Coefficient;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"......{product.Description}...... ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{"Invoice Price".PadRight(30)}{Math.Round(invoicePrice, 2)} ");
            decimal SumOfCosts = invoicePrice;

            foreach (var cost in costs)
            {
            
       
                    decimal TotalCostGel = 0;
                    decimal CostPrepayment = cost.PrepaymentSum1 + cost.PrepaymentSum2 + cost.PrepaymentSum3;

                    if (CostPrepayment <= 0)
                    {

                        TotalCostGel = cost.CostSum * NBG.NBG_(cost.CostDate, cost.CostCurrency);
                    }

                    else if (CostPrepayment >= cost.CostSum)
                    {
                        TotalCostGel = cost.PrepaymentSum1 * NBG.NBG_(cost.PrepaymentDate1, cost.PrepaymentCurrency1) + cost.PrepaymentSum2 * NBG.NBG_(cost.PrepaymentDate2, cost.PrepaymentCurrency2) + cost.PrepaymentSum3 * NBG.NBG_(cost.PrepaymentDate3, cost.PrepaymentCurrency3);
                    }

                    else if (CostPrepayment < cost.CostSum && CostPrepayment > 0)
                    {
                        TotalCostGel = cost.PrepaymentSum1 * NBG.NBG_(cost.PrepaymentDate1, cost.PrepaymentCurrency1) + cost.PrepaymentSum2 * NBG.NBG_(cost.PrepaymentDate2, cost.PrepaymentCurrency2) + cost.PrepaymentSum3 * NBG.NBG_(cost.PrepaymentDate3, cost.PrepaymentCurrency3) + (cost.CostSum - CostPrepayment) * NBG.NBG_(cost.CostDate, cost.CostCurrency);
                    }

                    else
                    {
                    Console.Clear();
                    Console.WriteLine("Check the Ammounts");
            
                    string keep = Console.ReadLine();
                   // Environment.Exit(0);

                    }



                    if (cost.VAT)
                    {
                        vatCoef = 1.18m;
                    }
                    else
                    {
                        vatCoef = 1m;
                    }

                    if (cost.SupplierTaxType == "1")
                    {
                        incomeTax = 0; pensionTax = 0;

                    }

                    else if (cost.SupplierTaxType == "2")
                    {
                        incomeTax = (TotalCostGel / vatCoef )/4; pensionTax = 0;
                    }

                    else if (cost.SupplierTaxType == "3")
                    {
                        incomeTax = (TotalCostGel / vatCoef) / 4; pensionTax = ((TotalCostGel / vatCoef) / 0.784m) *0.04m;
                    }

                    else if (cost.SupplierTaxType == "4")
                    {
                        incomeTax =0; pensionTax = 0;
                    }

                    else if (cost.SupplierTaxType == "5")
                    {
                        incomeTax = ((TotalCostGel / vatCoef) / 0.9m)*0.1m ; pensionTax = 0;
                    }





                    decimal costPrice = ((TotalCostGel /vatCoef)+incomeTax+pensionTax) * Coefficient;
                    SumOfCosts += costPrice;
                    Console.WriteLine($"{cost.Description.PadRight(30)}{Math.Round(costPrice, 2)} ");


            }
            decimal UnitPrice = 0;
            if (product.Quantity != 0)
            {
                 UnitPrice = SumOfCosts / product.Quantity;
            }
            else {
                 UnitPrice = 0;
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"{"Total Price".PadRight(30)}{Math.Round(SumOfCosts, 2)} ");
            Console.WriteLine($"{"Quantity".PadRight(30)}{product.Quantity} ");
            Console.WriteLine($"{"Unit Price".PadRight(30)}{Math.Round(UnitPrice, 2)} \n\n");
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
