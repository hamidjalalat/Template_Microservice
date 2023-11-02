

using AutoMapper;
using FluentResults;
using HJMST.Application.Googoolis.Commands;
using HJMST.Domain.Models;
using System.Resources;

namespace HJMST.Application.Googoolis.CommandHandlers
{
	public class CreateGoogooliCommandHandler :Mediator.IRequestHandler<CreateGoogooliCommand, Guid>
	{
		public CreateGoogooliCommandHandler(AutoMapper.IMapper mapper,Persistence.IUnitOfWork unitOfWork) : base()
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
		}

		protected IMapper Mapper { get; }

		protected Persistence.IUnitOfWork UnitOfWork { get; }

		

		public async Task<Result<Guid>>Handle(
			Commands.CreateGoogooliCommand request,
			CancellationToken cancellationToken)
		{
			var result =new FluentResults.Result<Guid>();

			try
			{
                var Googooli = Mapper.Map<Googooli>(source: request);
          
                await UnitOfWork.Googoolis.InsertAsync(entity: Googooli);

                await UnitOfWork.SaveAsync();
              
                result.WithValue(value: Googooli.Id);
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
