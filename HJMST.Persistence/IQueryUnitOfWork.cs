using HJMST.Persistence.Base;
using HJMST.Persistence.Users.Repositories;

namespace HJMST.Persistence
{
    public interface IQueryUnitOfWork : IQueryUnitOfWorkBase
    {
        public IUserQueryRepository Users { get; }
    }
}
