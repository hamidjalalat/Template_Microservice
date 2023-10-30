using FluentValidation;

namespace HJMST.Application.Users.Queries
{
	public class GetUsersQueryValidator :AbstractValidator<GetUsersQuery>
	{
		public GetUsersQueryValidator() : base()
		{
			RuleFor(current => current.Count)
				.NotEmpty()
				.WithMessage(errorMessage: "Count is required!")

				;
		}
	}
}
