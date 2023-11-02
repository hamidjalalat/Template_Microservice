using HJMST.Persistence.Base;
using HJMST.Persistence.Users.Repositories;

namespace HJMST.Persistence
{
    public interface IUnitOfWork : IUnitOfWorkBase
    {
        public IUserRepository Users { get; }
    }
}
