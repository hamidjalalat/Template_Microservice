using HJMST.Persistence.ViewModels;

namespace HJMST.Application.Googoolis.Queries
{
	public class GetByGoogooliNameQuery : Mediator.IRequest<GetGoogoolisQueryResponseViewModel>
	{
		public GetByGoogooliNameQuery() : base()
		{
		}

		public string GoogooliName { get; set; }
		public string Password { get; set; }
	}
}
