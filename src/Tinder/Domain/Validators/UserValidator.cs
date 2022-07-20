using FluentValidation;
using Kolaczyn.Domain.Model;

namespace Kolaczyn.Domain.Validators;

public class UserValidator : AbstractValidator<User>
{
  public UserValidator()
  {
    RuleFor(x => x.Name).NotEmpty().MinimumLength(1);
    RuleFor(x => x.Age).GreaterThanOrEqualTo(18);
  }
}