namespace HJMST.Persistence.Base
{
	public interface IUnitOfWork : IQueryUnitOfWork
	{
		Task SaveAsync();
	}
}
