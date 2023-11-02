using HJMST.Persistence.Base;
using HJMST.Persistence.Googoolis.Repositories;

namespace HJMST.Persistence
{
	public class UnitOfWork :UnitOfWorkBase<DatabaseContext>, IUnitOfWork
	{
		public UnitOfWork(Options options) : base(options: options)
		{
		}

		private IGoogooliRepository _googoolis;

		public IGoogooliRepository Googoolis
		{
			get
			{
				if (_googoolis == null)
				{
                    _googoolis =new GoogooliRepository(databaseContext: DatabaseContext);
				}

				return _googoolis;
			}
		}
	}
}
