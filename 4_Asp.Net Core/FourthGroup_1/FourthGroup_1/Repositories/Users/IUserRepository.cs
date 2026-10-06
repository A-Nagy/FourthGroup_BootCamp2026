using FourthGroup_1.Models;
using FourthGroup_1.Repositories.Base;

namespace FourthGroup_1.Repositories.Users
{
    public interface IUserRepository :IRepository<User>
    {
       User? GetByUserName(string userName);
       User? GetUserWithRoleAndPermissions(string userName);

    }
}
