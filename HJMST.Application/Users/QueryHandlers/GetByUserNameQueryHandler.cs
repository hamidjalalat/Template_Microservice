using HJMST.Persistence.ViewModels;

namespace HJMST.Application.Users.CommandHandlers
{
	public class GetByUserNameQueryHandler : 
		Mediator.IRequestHandler<Queries.GetByUserNameQuery,GetUsersQueryResponseViewModel>
	{
		public GetByUserNameQueryHandler
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
			<FluentResults.Result<GetUsersQueryResponseViewModel>>
			Handle(Queries.GetByUserNameQuery request, System.Threading.CancellationToken cancellationToken)
		{
			var result =
				new FluentResults.Result
				<GetUsersQueryResponseViewModel>();

			try
			{

				var Users =
					await
					UnitOfWork.Users
					.GetByUserNameAsync(username:request.UserName);
					;

				result.WithValue(value: Users);
			
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
