using HJMST.Domain.Models;
using HJMST.Persistence.Base;
using Microsoft.EntityFrameworkCore;

namespace HJMST.Persistence.Googoolis.Repositories
{
	public class GoogooliRepository :Repository<Googooli>, IGoogooliRepository
	{
		protected internal GoogooliRepository(DbContext databaseContext) : base(databaseContext: databaseContext)
		{
		}
	}
}
