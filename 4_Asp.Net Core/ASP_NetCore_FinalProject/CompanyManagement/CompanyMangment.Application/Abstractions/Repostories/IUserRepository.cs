

using CompanyMangment.Domain.Entities;
using CompanyMangment.Infrastructure.Repositories.Base;

namespace CompanyMangment.Infrastructure.Repositories.Users
{
    public interface IUserRepository :IRepository<User>
    {
       User? GetByUserName(string userName);
       User? GetUserWithRoleAndPermissions(string userName);

    }
}
