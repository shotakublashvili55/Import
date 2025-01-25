

namespace ConsoleApp1.Models;

internal class General
{

    public string Date { get; set; }
    public string DeclarationANumber { get; set; }
    public string DeclarationCNumber { get; set; }
    public string Supplier { get; set; }
    public string InvoiceDate { get; set; }
    public string InvoiceCurrency { get; set; }
    public decimal InvoiceExchangeRate { get; set; }
    public decimal TotalInvoiceSum { get; set; }
    public decimal Discount { get; set; }
    public decimal TotalSumWithDiscount { get; set; }
    public string Incoterms { get; set; }
    public decimal ExchangeRateManual { get; set; }
    public decimal ExchangeRateAutomatic { get; set; }

    public decimal PrepaymentSum1 { get; set; }
    public string PrepaymentCurrency1 { get; set; }
    public string PrepaymentDate1 { get; set; }
    public decimal PrepaymentExchangeRate1 { get; set; }

    public decimal PrepaymentSum2 { get; set; }
    public string PrepaymentCurrency2 { get; set; }
    public string PrepaymentDate2 { get; set; }
    public decimal PrepaymentExchangeRate2 { get; set; }

    public decimal PrepaymentSum3 { get; set; }
    public string PrepaymentCurrency3 { get; set; }
    public string PrepaymentDate3 { get; set; }
    public decimal PrepaymentExchangeRate3 { get; set; }

    public General(string date, string declarationANumber, string declarationCNumber, string supplier, string invoiceDate, string invoiceCurrency, decimal invoiceExchangeRate, decimal totalInvoiceSum, decimal discount, decimal totalSumWithDiscount, string incoterms, decimal exchangeRateManual, decimal exchangeRateAutomatic, decimal prepaymentSum1, string prepaymentCurrency1, string prepaymentDate1, decimal prepaymentExchangeRate1, decimal prepaymentSum2, string prepaymentCurrency2, string prepaymentDate2, decimal prepaymentExchangeRate2, decimal prepaymentSum3, string prepaymentCurrency3, string prepaymentDate3, decimal prepaymentExchangeRate3)
    {
        Date = date;
        DeclarationANumber = declarationANumber;
        DeclarationCNumber = declarationCNumber;
        Supplier = supplier;
        InvoiceDate = invoiceDate;
        InvoiceCurrency = invoiceCurrency;
        InvoiceExchangeRate = invoiceExchangeRate;
        TotalInvoiceSum = totalInvoiceSum;
        Discount = discount;
        TotalSumWithDiscount = totalSumWithDiscount;
        Incoterms = incoterms;
        ExchangeRateManual = exchangeRateManual;
        ExchangeRateAutomatic = exchangeRateAutomatic;
        PrepaymentSum1 = prepaymentSum1;
        PrepaymentCurrency1 = prepaymentCurrency1;
        PrepaymentDate1 = prepaymentDate1;
        PrepaymentExchangeRate1 = prepaymentExchangeRate1;
        PrepaymentSum2 = prepaymentSum2;
        PrepaymentCurrency2 = prepaymentCurrency2;
        PrepaymentDate2 = prepaymentDate2;
        PrepaymentExchangeRate2 = prepaymentExchangeRate2;
        PrepaymentSum3 = prepaymentSum3;
        PrepaymentCurrency3 = prepaymentCurrency3;
        PrepaymentDate3 = prepaymentDate3;
        PrepaymentExchangeRate3 = prepaymentExchangeRate3;
    }
}
