
using CompanyMangment.Domain.Entities;
using CompanyMangment.Infrastructure.Data;
using CompanyMangment.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace CompanyMangment.Infrastructure.Repositories.Roles

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
  
    }
}
