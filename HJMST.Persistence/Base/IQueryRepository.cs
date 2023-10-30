using HJMST.Domain.Models.Base;

namespace HJMST.Persistence.Base
{
	public interface IQueryRepository<T> where T :IEntity
	{
		Task<T> GetByIdAsync(Guid id);

		Task<IList<T>> GetAllAsync();
	}
}
