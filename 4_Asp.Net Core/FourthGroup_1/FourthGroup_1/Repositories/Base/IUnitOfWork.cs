using FourthGroup_1.Models;
using FourthGroup_1.Repositories.Emoloyee;
using FourthGroup_1.Repositories.Roles;
using FourthGroup_1.Repositories.Users;

namespace FourthGroup_1.Repositories.Base
{
    public interface IUnitOfWork
    {
        IEmployeeRepository Employees { get; }
        IUserRepository Users { get; }
        IRoleRepository Roles { get; }
        IRepository<Permission> Permissions { get; }
        IRepository<Department> Departments { get; }
        IRepository<Category> Categories { get; }
        IRepository<Product> Products { get; }
        int SaveChanges();

    }
}
