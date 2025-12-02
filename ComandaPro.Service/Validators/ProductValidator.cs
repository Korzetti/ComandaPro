using ComandaPro.Domain.Entities;
using FluentValidation;

namespace ComandaPro.Service.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(n => n.Name)
                .NotEmpty().WithMessage("Product name is needed!!");
            RuleFor(p => p.Price)
                .NotEmpty().WithMessage("Product price is needed!");
            RuleFor(c => c.Category)
                .NotEmpty().WithMessage("Category is needed!");
        }
    }
}