using AutoMapper;
using HJMST.Application.Googoolis.Queries;
using HJMST.Persistence;
using HJMST.Persistence.ViewModels;

namespace HJMST.Application.Googoolis.CommandHandlers
{
	public class GetGoogoolisQueryHandler :
		Mediator.IRequestHandler<GetGoogoolisQuery, IEnumerable<GetGoogoolisQueryResponseViewModel>>
	{
		public GetGoogoolisQueryHandler(IMapper mapper, IQueryUnitOfWork unitOfWork) : base()
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
		}

		protected IMapper Mapper { get; }

		protected IQueryUnitOfWork UnitOfWork { get; }

		public async Task<FluentResults.Result<IEnumerable<GetGoogoolisQueryResponseViewModel>>>
			Handle(GetGoogoolisQuery request, CancellationToken cancellationToken)
		{
			var result =new FluentResults.Result<IEnumerable<GetGoogoolisQueryResponseViewModel>>();

			try
			{
				var Googoolis =await UnitOfWork.Googoolis.GetSomeAsync(count: request.Count.Value);

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
