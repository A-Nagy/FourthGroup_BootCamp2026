using FourthGroup_1.Data;
using FourthGroup_1.Models;
using FourthGroup_1.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace FourthGroup_1.Repositories.Users
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }

        public User? GetByUserName(string userName)
        {
            return _dbContext.Users.FirstOrDefault(u => u.UserName == userName);
        }

        public User? GetUserWithRoleAndPermissions(string userName)
        {
            return _dbContext.Users
                .Include(u => u.Roles)
                .ThenInclude(r => r.Permissions)
                .FirstOrDefault(u => u.UserName == userName);
        }
    }
}
