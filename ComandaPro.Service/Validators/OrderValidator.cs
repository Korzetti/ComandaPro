using ComandaPro.Domain.Entities;
using FluentValidation;

namespace ComandaPro.Service.Validators
{
    public class OrderValidator : AbstractValidator<Order>
    {
        public OrderValidator()
        {
            RuleFor(u => u.User)
                .NotEmpty().WithMessage("Customer name must not be empty!");
            RuleFor(s => s.Status)
                .NotEmpty().WithMessage("Status must not be empty!");
            RuleFor(v => v.TotalValue)
                .NotEmpty().WithMessage("Total value must not be empty!");
        }
    }
}