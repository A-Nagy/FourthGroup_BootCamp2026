using CompanyMangment.Domain.Entities;
using CompanyMangment.Infrastructure.Repositories.Base;

namespace CompanyMangment.Infrastructure.Repositories.Roles

{
    public interface IRoleRepository : IRepository<Role>
    {
        Role? GetRoleWithPermissions(int Id);
    }
}
