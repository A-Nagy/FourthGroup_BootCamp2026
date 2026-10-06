using FourthGroup_1.Models;
using FourthGroup_1.Repositories.Base;

namespace FourthGroup_1.Repositories.Roles
{
    public interface IRoleRepository : IRepository<Role>
    {
        Role? GetRoleWithPermissions(int Id);
    }
}
