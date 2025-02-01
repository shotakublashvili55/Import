

using ConsoleApp1.Models;
using ConsoleApp1.Validators;
namespace ConsoleApp1.Library;

internal class Validate
{
    public static int Validate_(List<General> generals, List<Cost> costs, List<Good> products)
    {
        int errorQuantity = 0;

        foreach (var general in generals)
        {
            var generalValidator = new GeneralValidation();
            var generalValidatorResults = generalValidator.Validate(general);
            if (!generalValidatorResults.IsValid)
            {
                foreach (var error in generalValidatorResults.Errors)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
                errorQuantity++;
            }

        }
        foreach (var cost in costs)
        {
            var costValidator = new CostValidation();
            var costValidatorResults = costValidator.Validate(cost);
            if (!costValidatorResults.IsValid)
            {
                foreach (var error in costValidatorResults.Errors)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
                errorQuantity++;
            }

        }

        foreach (var product in products)
        {
            var goodValidator = new GoodValidation();
            var goodValidatorResults = goodValidator.Validate(product);
            if (!goodValidatorResults.IsValid)
            {
                foreach (var error in goodValidatorResults.Errors)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
                errorQuantity++;
            }

        }

        return errorQuantity;

    }
}
