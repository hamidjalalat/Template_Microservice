using HJMST.Persistence.ViewModels;

namespace HJMST.Application.Users.Queries
{
	public class GetUsersQuery : Mediator.IRequest<IEnumerable<GetUsersQueryResponseViewModel>>
	{
		public GetUsersQuery() : base()
		{
		}

		public int? Count { get; set; }
	}
}
