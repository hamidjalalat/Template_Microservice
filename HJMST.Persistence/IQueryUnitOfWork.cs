using HJMST.Persistence.Base;
using HJMST.Persistence.Googoolis.Repositories;

namespace HJMST.Persistence
{
    public interface IQueryUnitOfWork : IQueryUnitOfWorkBase
    {
        public IGoogooliQueryRepository Googoolis { get; }
    }
}
