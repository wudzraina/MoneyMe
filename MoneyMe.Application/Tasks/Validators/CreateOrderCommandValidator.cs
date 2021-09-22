using FluentValidation;
using MoneyMe.Application.Tasks.Command;

namespace MoneyMe.Application.Tasks.Validators
{
    public class CreateOrderCommandValidator : AbstractValidator<CreateOrderCommand>
    {
        public CreateOrderCommandValidator()
        {

            RuleFor(t => t.Amount).NotEmpty();
            RuleFor(t => t.DateOfBirth).NotEmpty();
            RuleFor(t => t.Email).NotEmpty().WithMessage("Required Email").EmailAddress();
            RuleFor(t => t.FirstName).NotNull();
            RuleFor(t => t.LastName).NotNull();
            RuleFor(t => t.Mobile).NotNull().WithMessage("Please Entire Mobile No")
                                  .NotEmpty().WithMessage("Please Entire Mobile No");
            RuleFor(t => t.Term).NotNull();
            RuleFor(t => t.Title).NotNull();

        }
    }
}
