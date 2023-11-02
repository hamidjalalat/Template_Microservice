using HJMST.Persistence.ViewModels;

namespace HJMST.Application.Googoolis.CommandHandlers
{
	public class GetByGoogooliNameQueryHandler : 
		Mediator.IRequestHandler<Queries.GetByGoogooliNameQuery,GetGoogoolisQueryResponseViewModel>
	{
		public GetByGoogooliNameQueryHandler
            (
			AutoMapper.IMapper mapper,
            HJMST.Persistence.IQueryUnitOfWork unitOfWork) : base()
		{
		
			Mapper = mapper;
			UnitOfWork = unitOfWork;
		}

		protected AutoMapper.IMapper Mapper { get; }

		protected HJMST.Persistence.IQueryUnitOfWork UnitOfWork { get; }

		

		public
			async
			System.Threading.Tasks.Task
			<FluentResults.Result<GetGoogoolisQueryResponseViewModel>>
			Handle(Queries.GetByGoogooliNameQuery request, System.Threading.CancellationToken cancellationToken)
		{
			var result =
				new FluentResults.Result
				<GetGoogoolisQueryResponseViewModel>();

			try
			{

				var Googoolis =
					await
					UnitOfWork.Googoolis
					.GetByGoogooliNameAsync(googooliname:request.GoogooliName);
					;

				result.WithValue(value: Googoolis);
			
			}
			catch (System.Exception ex)
			{
				result.WithError
					(errorMessage: ex.Message);
			}

			return result;
		}
	}
}
