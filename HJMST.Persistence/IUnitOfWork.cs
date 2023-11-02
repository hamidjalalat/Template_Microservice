using HJMST.Persistence.Base;
using HJMST.Persistence.Googoolis.Repositories;

namespace HJMST.Persistence
{
    public interface IUnitOfWork : IUnitOfWorkBase
    {
        public IGoogooliRepository Googoolis { get; }
    }
}
