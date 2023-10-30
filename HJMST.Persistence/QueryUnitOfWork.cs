using HJMST.Persistence.Users.Repositories;

namespace HJMST.Persistence
{
	public class QueryUnitOfWork :HJMST.Persistence.Base.QueryUnitOfWork<QueryDatabaseContext>, IQueryUnitOfWork
	{
		public QueryUnitOfWork(HJMST.Persistence.Base.Options options) : base(options: options)
		{
		}

		private IUserQueryRepository _users;

		public IUserQueryRepository Users
		{
			get
			{
				if (_users == null)
				{
                    _users =new UserQueryRepository(databaseContext: DatabaseContext);
				}

				return _users;
			}
		}
	}
}
