

namespace ConsoleApp1.Models;

internal class Cost
{
    public bool International { get; set; }
    public string Description { get; set; }
    public string CostCompanyId { get; set; }
    public string CostCompanyName { get; set; }
    public decimal CostSum { get; set; }
    public string CostCurrency { get; set; }
    public string CostDate { get; set; }
    public decimal CostExchangeRate { get; set; }
    public bool VAT { get; set; }
    public string SupplierTaxType { get; set; }
    public bool WeightProportion { get; set; }

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

    public Cost(bool international, string description, string costCompanyId, string costCompanyName, decimal costSum, string costCurrency, string costDate, decimal costExchangeRate, bool vAT, string supplierTaxType, bool weightProportion, decimal prepaymentSum1, string prepaymentCurrency1, string prepaymentDate1, decimal prepaymentExchangeRate1, decimal prepaymentSum2, string prepaymentCurrency2, string prepaymentDate2, decimal prepaymentExchangeRate2, decimal prepaymentSum3, string prepaymentCurrency3, string prepaymentDate3, decimal prepaymentExchangeRate3)
    {
        International = international;
        Description = description;
        CostCompanyId = costCompanyId;
        CostCompanyName = costCompanyName;
        CostSum = costSum;
        CostCurrency = costCurrency;
        CostDate = costDate;
        CostExchangeRate = costExchangeRate;
        VAT = vAT;
        SupplierTaxType = supplierTaxType;
        WeightProportion = weightProportion;
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
