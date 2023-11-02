using HJMST.Persistence.Base;
using HJMST.Persistence.Users.Repositories;

namespace HJMST.Persistence
{
	public class UnitOfWork :UnitOfWorkBase<DatabaseContext>, IUnitOfWork
	{
		public UnitOfWork(Options options) : base(options: options)
		{
		}

		private IUserRepository _users;

		public IUserRepository Users
		{
			get
			{
				if (_users == null)
				{
                    _users =new UserRepository(databaseContext: DatabaseContext);
				}

				return _users;
			}
		}
	}
}
