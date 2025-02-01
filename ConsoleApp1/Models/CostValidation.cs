using FluentValidation;

namespace ConsoleApp1.Models;

internal class CostValidation: AbstractValidator<Cost>
{
    public CostValidation() 
    {
      RuleFor(cost => cost.CostSum)
            .GreaterThan(0).WithMessage("Ammount must greater then 0");

        RuleFor(cost => cost.PrepaymentCurrency1)
              .NotEmpty()
              .When(cost => cost.PrepaymentSum1 > 0).WithMessage("Invalid Currency Name");

        RuleFor(cost => cost.PrepaymentCurrency2)
      .NotEmpty()
      .When(cost => cost.PrepaymentSum2 > 0).WithMessage("Invalid Currency Name");

        RuleFor(cost => cost.PrepaymentCurrency3)
      .NotEmpty()
      .When(cost => cost.PrepaymentSum3 > 0).WithMessage("Invalid Currency Name");

    }

   
}
