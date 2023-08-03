using api.Models;
using FluentValidation;

namespace api.Validator
{
    public class TranslateRequestValidation : AbstractValidator<TranslateRequest>
    {
        public TranslateRequestValidation()
        {
            RuleFor(t => t.Text).MaximumLength(100)
                .WithMessage("Cannot exceed 100 characters.");
        }
    }
}