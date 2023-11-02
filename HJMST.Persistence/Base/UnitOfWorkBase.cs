using Microsoft.EntityFrameworkCore;

namespace HJMST.Persistence.Base
{
	public abstract class UnitOfWorkBase<T> :QueryUnitOfWorkBase<T>, IUnitOfWorkBase where T : DbContext
	{
		public UnitOfWorkBase(Options options) : base(options: options)
		{
		}

		public async Task SaveAsync()
		{
			await DatabaseContext.SaveChangesAsync();
		}
	}
}
