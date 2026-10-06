using FourthGroup_1.Data;
using FourthGroup_1.Models;
using FourthGroup_1.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace FourthGroup_1.Repositories.Roles
{
    public class RoleRepository: Repository<Role>, IRoleRepository
    {
        public RoleRepository(AppDbContext context) : base(context)
        {
        }
        public Role? GetRoleWithPermissions(int Id)
        {
            return _dbContext.Roles
                .Include(r => r.Permissions)
                .FirstOrDefault(r => r.Id == Id);
        }
    {
    }
}
