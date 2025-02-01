
using FluentValidation;
using ConsoleApp1.Models;
namespace ConsoleApp1.Validators;

internal class GoodValidation: AbstractValidator<Good>
{
    public GoodValidation()
    {
        RuleFor(good => good.BarCode)
            .NotEmpty().WithMessage("BarCode is empty")
            .Length(3,20).WithMessage("BarCode must have 3 or more character");

        RuleFor(good => good.Description)
             .NotEmpty().WithMessage("Description is empty")
            .Length(3,255).WithMessage("Description must have 5 or more character");

        RuleFor(good => good.Quantity)
            .NotNull().WithMessage("Quantity is Null")
            .GreaterThan(0).WithMessage("Quantity must greater then 0");

        RuleFor(good => good.Ammount)
            .NotNull().WithMessage("Ammount is Null")
            .GreaterThan(0).WithMessage("Ammount must greater then 0");



    }
}
