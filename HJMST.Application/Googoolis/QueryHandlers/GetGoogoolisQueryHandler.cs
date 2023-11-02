using HJMST.Persistence.ViewModels;

namespace HJMST.Application.Googoolis.CommandHandlers
{
	public class GetGoogoolisQueryHandler : object,
		Mediator.IRequestHandler
		<Queries.GetGoogoolisQuery, System.Collections.Generic.IEnumerable<GetGoogoolisQueryResponseViewModel>>
	{
		public GetGoogoolisQueryHandler
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
		Task
			<FluentResults.Result
				<IEnumerable
				<GetGoogoolisQueryResponseViewModel>>>
			Handle(Queries.GetGoogoolisQuery request, System.Threading.CancellationToken cancellationToken)
		{
			var result =
				new FluentResults.Result
				<System.Collections.Generic.IEnumerable
				<GetGoogoolisQueryResponseViewModel>>();

			try
			{
			
				var Googoolis =
					await
					UnitOfWork.Googoolis
					.GetSomeAsync(count: request.Count.Value)
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
