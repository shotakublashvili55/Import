using FluentValidation;
namespace ConsoleApp1.Models;

internal class GeneralValidation: AbstractValidator<General>
{
    public GeneralValidation ()
    {
        RuleFor(general => general.DeclarationANumber)
            .NotEmpty().WithMessage("Declaraction ''A'' Numner is empty");
        RuleFor(general => general.TotalSumWithDiscount)
            .GreaterThan(0).WithMessage("Total Sum With Discount must greater then 0");
    }
}
