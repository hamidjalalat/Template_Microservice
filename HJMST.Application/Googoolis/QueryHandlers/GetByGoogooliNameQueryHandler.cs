using AutoMapper;
using HJMST.Application.Googoolis.Queries;
using HJMST.Persistence;
using HJMST.Persistence.ViewModels;

namespace HJMST.Application.Googoolis.CommandHandlers
{
	public class GetByGoogooliNameQueryHandler : 
		Mediator.IRequestHandler<Queries.GetByGoogooliNameQuery,GetGoogoolisQueryResponseViewModel>
	{
		public GetByGoogooliNameQueryHandler (IMapper mapper,IQueryUnitOfWork unitOfWork)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
		}

		protected IMapper Mapper { get; }

		protected IQueryUnitOfWork UnitOfWork { get; }

		public async Task<FluentResults.Result<GetGoogoolisQueryResponseViewModel>>
			Handle(GetByGoogooliNameQuery request, CancellationToken cancellationToken)
		{
			var result =new FluentResults.Result<GetGoogoolisQueryResponseViewModel>();

			try
			{

				var Googoolis =await UnitOfWork.Googoolis.GetByGoogooliNameAsync(googooliname:request.GoogooliName);

				result.WithValue(value: Googoolis);
			
			}
			catch (System.Exception ex)
			{
				result.WithError(errorMessage: ex.Message);
			}

			return result;
		}
	}
}
