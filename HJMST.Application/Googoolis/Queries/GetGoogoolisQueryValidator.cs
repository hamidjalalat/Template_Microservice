using FluentValidation;

namespace HJMST.Application.Googoolis.Queries
{
	public class GetGoogoolisQueryValidator :AbstractValidator<GetGoogoolisQuery>
	{
		public GetGoogoolisQueryValidator() : base()
		{
			RuleFor(current => current.Count)
				.NotEmpty()
				.WithMessage(errorMessage: "Count is required!");
		}
	}
}
