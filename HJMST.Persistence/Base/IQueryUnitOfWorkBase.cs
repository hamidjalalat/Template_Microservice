namespace HJMST.Persistence.Base
{
	public interface IQueryUnitOfWorkBase : IDisposable
	{
		bool IsDisposed { get; }
	}
}
