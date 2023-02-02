using API.Domain.VM;
using FluentValidation;

namespace Core.Validator.User
{
    public class UpdateUserValidator : AbstractValidator<UserVM>
    {
        public UpdateUserValidator()
        {
            RuleFor(p => p.Id)
                .NotNull().WithMessage("Id is required");

            RuleFor(p => p.Name)
                .NotNull().WithMessage("Name is required")
                .MinimumLength(2).WithMessage("Name needs to have more than 1 character")
                .MaximumLength(100).WithMessage("Name can't have more than 100 characters");

            RuleFor(p => p.Email)
                .NotNull().WithMessage("Email is required")
                .MinimumLength(2).WithMessage("Email needs to have more than 1 character")
                .MaximumLength(100).WithMessage("Email can't have more than 100 characters");

            RuleFor(p => p.Password)
                .NotNull().WithMessage("Password is required")
                .MinimumLength(2).WithMessage("Password needs to have more than 1 character")
                .MaximumLength(200).WithMessage("Password can't have more than 200 characters");

            RuleFor(p => p.Salary)
                .NotNull().WithMessage("Salary is required");

            RuleFor(p => p.SalarySave)
                .NotNull().WithMessage("SalarySave is required");

            RuleFor(p => p.Role).NotNull().IsInEnum().WithMessage("Role invalid");
        }
    }
}
