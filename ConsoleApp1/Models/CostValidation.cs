using FluentValidation;

namespace ConsoleApp1.Models;

internal class CostValidation: AbstractValidator<Cost>
{
    public CostValidation() 
    {
      RuleFor(cost => cost.CostSum)
            .GreaterThan(0).WithMessage("Ammount must greater then 0"); ;
    }
}
