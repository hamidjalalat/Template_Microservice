

using AutoMapper;
using FluentResults;
using HJMST.Application.Users.Commands;
using HJMST.Domain.Models;
using System.Resources;

namespace HJMST.Application.Users.CommandHandlers
{
	public class CreateUserCommandHandler :Mediator.IRequestHandler<CreateUserCommand, Guid>
	{
		public CreateUserCommandHandler(AutoMapper.IMapper mapper,Persistence.IUnitOfWork unitOfWork) : base()
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
		}

		protected IMapper Mapper { get; }

		protected Persistence.IUnitOfWork UnitOfWork { get; }

		

		public async Task<Result<Guid>>Handle(
			Commands.CreateUserCommand request,
			CancellationToken cancellationToken)
		{
			var result =new FluentResults.Result<Guid>();

			try
			{
                var user = Mapper.Map<User>(source: request);
          
                await UnitOfWork.Users.InsertAsync(entity: user);

                await UnitOfWork.SaveAsync();
              
                result.WithValue(value: user.Id);
                string successInsert = string.Format("عملیات درج با موفقیت انجام شد");

                result.WithSuccess (successMessage: successInsert);

            }
			catch (System.Exception ex)
			{
				result.WithError(errorMessage: ex.Message);
			}

			return result;
		}
	}
}
