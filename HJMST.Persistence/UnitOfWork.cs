using HJMST.Persistence.Users.Repositories;

namespace HJMST.Persistence
{
	public class UnitOfWork :HJMST.Persistence.Base.UnitOfWork<DatabaseContext>, IUnitOfWork
	{
		public UnitOfWork(HJMST.Persistence.Base.Options options) : base(options: options)
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
