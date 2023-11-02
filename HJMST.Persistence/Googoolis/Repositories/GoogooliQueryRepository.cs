using System.Linq;
using HJMST.Domain.Models;
using HJMST.Persistence.Base;
using HJMST.Persistence.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace HJMST.Persistence.Googoolis.Repositories
{
	public class GoogooliQueryRepository :QueryRepository<Googooli>, IGoogooliQueryRepository
	{
		public GoogooliQueryRepository(QueryDatabaseContext databaseContext) : base(databaseContext)
		{
		}

		public async Task<IList<GetGoogoolisQueryResponseViewModel>> GetSomeAsync(int count)
		{

			var result =await DbSet
			
				.Select(current => new ViewModels.GetGoogoolisQueryResponseViewModel()
				{
					Id = current.Id,
					GoogooliName=current.GoogooliName,
					FirstName=current.FirstName,
					LastName=current.LastName,
					EmailAddress=current.EmailAddress,
					Password=current.Password,
				})
				.ToListAsync()
				;


			return result;
		}

		//موقت تا زمانی که بانک اطلاعاتی راه بندازم
        public override Task<Googooli> GetByIdAsync(Guid id)
        {
			GetGoogoolisQueryResponseViewModel result = new GetGoogoolisQueryResponseViewModel()
			{
				Id = id,
				GoogooliName="Hjalalat",
				FirstName="Hamid",
				LastName="Jalalat",
				EmailAddress="hjalalat@yahoo.com",
			};

            return base.GetByIdAsync(id);
        }

        //موقت تا زمانی که بانک اطلاعاتی راه بندازم
        public async Task<GetGoogoolisQueryResponseViewModel> GetByGoogooliNameAsync(String googooliname)
        {
			//GetGoogoolisQueryResponseViewModel result = new GetGoogoolisQueryResponseViewModel()
			//{
			//    Id = new Guid(),
			//    GoogooliName = Googooliname,
			//    FirstName = "Hamid",
			//    LastName = "Jalalat",
			//    EmailAddress = "hjalalat@yahoo.com",
			//};

			var result =
			await
			DbSet.Where(C => C.GoogooliName == googooliname).
			Select(current => new ViewModels.GetGoogoolisQueryResponseViewModel()
			{
				GoogooliName = current.GoogooliName,
				FirstName = current.FirstName,
				LastName = current.LastName,
				EmailAddress=current.EmailAddress,

			})
            .FirstOrDefaultAsync();

            return result;
        }
    }
}
