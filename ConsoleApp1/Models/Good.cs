
namespace ConsoleApp1.Models;

internal class Good
{

        public string BarCode { get; set; }
        public string ScuCode { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Ammount { get; set; }
        public double Weight { get; set; }
        public string Unit { get; set; }
        public bool IndVat { get; set; }
        public bool IndExcuse { get; set; }
        public bool IndImportTax { get; set; }

    public Good(string barCode, string scuCode, string image1, string image2, string image3, string description, int quantity, decimal ammount, double weight, string unit, bool indVat, bool indExcuse, bool indImportTax)
    {
        BarCode = barCode;
        ScuCode = scuCode;
        Image1 = image1;
        Image2 = image2;
        Image3 = image3;
        Description = description;
        Quantity = quantity;
        Ammount = ammount;
        Weight = weight;
        Unit = unit;
        IndVat = indVat;
        IndExcuse = indExcuse;
        IndImportTax = indImportTax;
    }
}

