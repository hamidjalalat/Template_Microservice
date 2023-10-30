using FluentValidation;

namespace HJMST.Application.Users.Commands
{
	public class CreateUserCommandValidator :AbstractValidator<CreateUserCommand>
	{
		public CreateUserCommandValidator() : base()
		{
			RuleFor(current => current.UserName)
				.NotEmpty()
				.WithMessage(errorMessage: "Requred");
		
		}
	}
}
