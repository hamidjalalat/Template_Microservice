using HJMST.Persistence.Base;
using HJMST.Persistence.Googoolis.Repositories;

namespace HJMST.Persistence
{
	public class QueryUnitOfWork :QueryUnitOfWorkBase<QueryDatabaseContext>, IQueryUnitOfWork
	{
		public QueryUnitOfWork(Options options) : base(options: options)
		{
		}

		private IGoogooliQueryRepository _googoolis;

		public IGoogooliQueryRepository Googoolis
		{
			get
			{
				if (_googoolis == null)
				{
                    _googoolis =new GoogooliQueryRepository(databaseContext: DatabaseContext);
				}

				return _googoolis;
			}
		}
	}
}
