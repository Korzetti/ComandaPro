using ComandaPro.Domain.Entities;
using FluentValidation;

namespace ComandaPro.Service.Validators
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Category name is needed!!");
        }
    }
}