using HJMST.Persistence.Users.Repositories;

namespace HJMST.Persistence
{
    public interface IQueryUnitOfWork : HJMST.Persistence.Base.IQueryUnitOfWork
    {
        public IUserQueryRepository Users { get; }
    }
}
