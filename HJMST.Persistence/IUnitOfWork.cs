using HJMST.Persistence.Users.Repositories;

namespace HJMST.Persistence
{
    public interface IUnitOfWork : HJMST.Persistence.Base.IUnitOfWork
    {
        public IUserRepository Users { get; }
    }
}
