namespace HJMST.Persistence.Base
{
	public interface IUnitOfWorkBase : IQueryUnitOfWorkBase
	{
		Task SaveAsync();
	}
}
