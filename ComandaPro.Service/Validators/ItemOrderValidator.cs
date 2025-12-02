using ComandaPro.Domain.Entities;
using FluentValidation;

namespace ComandaPro.Service.Validators
{
    public class ItemOrderValidator : AbstractValidator<ItemOrder>
    {
        public ItemOrderValidator()
        {
            RuleFor(or => or.Order)
                .NotEmpty().WithMessage("Order must not be empty!");
            RuleFor(prod => prod.Product)
                .NotEmpty().WithMessage("Product must not be empty!");
            RuleFor(qnt => qnt.Quantity)
                .GreaterThan(0).WithMessage("Quantity must be greater than 0!")
                .NotEmpty().WithMessage("Quantity must not be empty!");
            RuleFor(up => up.UnitPrice)
                .NotEmpty().WithMessage("Price must not be empty");
        }
    }
}