using HJMST.Domain.Models;
using HJMST.Persistence.Base;
using HJMST.Persistence.ViewModels;

namespace HJMST.Persistence.Googoolis.Repositories
{
	public interface IGoogooliQueryRepository : IQueryRepository<Googooli>
	{
		Task<IList<GetGoogoolisQueryResponseViewModel>> GetSomeAsync(int count);

		Task<GetGoogoolisQueryResponseViewModel> GetByGoogooliNameAsync(String googooliname);
     
    }
}
