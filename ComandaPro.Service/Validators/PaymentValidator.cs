using ComandaPro.Domain.Entities;
using FluentValidation;

namespace ComandaPro.Service.Validators
{
    public class PaymentValidator : AbstractValidator<Payment>
    {
        public PaymentValidator()
        {
            RuleFor(m => m.PaymentMethod)
                .NotEmpty().WithMessage("Payment method must not be empty!");
            RuleFor(o => o.Order)
                .NotEmpty().WithMessage("Order must not be empty!");
            RuleFor(v => v.ValuePaid)
                .NotEmpty().WithMessage("Value paid must not be empty!");
            RuleFor(d => d.PaymentDate)
                .NotEmpty().WithMessage("Payment date must not be empty!");
        }
    }
}