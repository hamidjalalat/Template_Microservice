using HJMST.Domain.Models;
using HJMST.Persistence.Base;
using HJMST.Persistence.ViewModels;

namespace HJMST.Persistence.Users.Repositories
{
	public interface IUserQueryRepository : IQueryRepository<User>
	{
		Task<IList<GetUsersQueryResponseViewModel>> GetSomeAsync(int count);

		Task<GetUsersQueryResponseViewModel> GetByUserNameAsync(String username);
     
    }
}
