using FluentValidation;
using Tinder.Domain.Model;

namespace Tinder.Domain.Validators;

public class UserValidator : AbstractValidator<User>
{
  public UserValidator()
  {
    RuleFor(x => x.Name).NotEmpty().MinimumLength(1);
    RuleFor(x => x.Age).GreaterThanOrEqualTo(18);
  }
}