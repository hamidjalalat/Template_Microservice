using HJMST.Persistence.ViewModels;

namespace HJMST.Application.Users.Queries
{
	public class GetByUserNameQuery : Mediator.IRequest<GetUsersQueryResponseViewModel>
	{
		public GetByUserNameQuery() : base()
		{
		}

		public string UserName { get; set; }
		public string Password { get; set; }
	}
}
