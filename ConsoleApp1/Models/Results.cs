

namespace ConsoleApp1.Models;

internal class Results
{
    public string BarCode { get; set; }
    public string Description { get; set; }
    public int Quantity { get; set; }

    public decimal InvoicePrice { get; set; }

    public decimal TransportCost { get; set; }

    public decimal FinalPrice { get; set; }

    public Results(string barCode, string description, int quantity, decimal invoicePrice, decimal transportCost, decimal finalPrice)
    {
        BarCode = barCode;
        Description = description;
        Quantity = quantity;
        InvoicePrice = invoicePrice;
        TransportCost = transportCost;
        FinalPrice = finalPrice;
    }
}
