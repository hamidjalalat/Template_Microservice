using FluentValidation;

namespace HJMST.Application.Googoolis.Commands
{
	public class CreateGoogooliCommandValidator :AbstractValidator<CreateGoogooliCommand>
	{
		public CreateGoogooliCommandValidator() : base()
		{
			RuleFor(current => current.GoogooliName)
				.NotEmpty()
				.WithMessage(errorMessage: "Requred");
		}
	}
}
