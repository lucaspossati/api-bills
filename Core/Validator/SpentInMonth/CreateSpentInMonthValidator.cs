using Application.VM;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Validator.SpentInMonth
{
    public class CreateSpentInMonthValidator : AbstractValidator<SpentInMonthVM>
    {
        public CreateSpentInMonthValidator()
        {
            RuleFor(p => p.IdMonth)
                .NotNull().WithMessage("IdMonth is required");

            RuleFor(p => p.IdUser)
                .NotNull().WithMessage("IdUser is required");

            RuleFor(p => p.SpendPercentageAbove)
                .NotNull().WithMessage("SpendPercentageAbove is required");

            RuleFor(p => p.Spent)
                .NotNull().WithMessage("Spent is required");
        }
    }
}
