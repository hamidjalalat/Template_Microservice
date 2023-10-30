using HJMST.Domain.Models;
using HJMST.Persistence.Base;
using Microsoft.EntityFrameworkCore;

namespace HJMST.Persistence.Users.Repositories
{
	public class UserRepository :Repository<User>, IUserRepository
	{
		protected internal UserRepository(DbContext databaseContext) : base(databaseContext: databaseContext)
		{
		}
	}
}
