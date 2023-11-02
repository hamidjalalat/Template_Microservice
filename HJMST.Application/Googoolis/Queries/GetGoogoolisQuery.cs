using HJMST.Persistence.ViewModels;

namespace HJMST.Application.Googoolis.Queries
{
	public class GetGoogoolisQuery : Mediator.IRequest<IEnumerable<GetGoogoolisQueryResponseViewModel>>
	{
		public GetGoogoolisQuery() : base()
		{
		}

		public int? Count { get; set; }
	}
}
