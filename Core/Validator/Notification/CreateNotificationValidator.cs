using API.Domain.VM;
using FluentValidation;

namespace Core.Validator.Notification
{
    public class CreateNotificationValidator : AbstractValidator<NotificationVM>
    {
        public CreateNotificationValidator()
        {
            RuleFor(p => p.Message)
                .NotNull().WithMessage("Message can't be null")
                .MinimumLength(2).WithMessage("Message must to be more than 1 character")
                .MaximumLength(200).WithMessage("Message can't be more than 200 character");

            RuleFor(p => p.Subject)
                .NotNull().WithMessage("Subject is required")
                .NotEmpty().WithMessage("Subject is required");

            RuleFor(p => p.ClientName)
                .NotNull().WithMessage("ClientName is required")
                .NotEmpty().WithMessage("ClientName is required");

            RuleFor(p => p.UserName)
                .NotNull().WithMessage("UserName is required")
                .NotEmpty().WithMessage("UserName is required");

            RuleFor(p => p.RecipientEmail).
                EmailAddress().WithMessage("Email invalid");

            RuleFor(p => p.Type).NotNull().IsInEnum().WithMessage("Type invalid");
        }
    }
}
