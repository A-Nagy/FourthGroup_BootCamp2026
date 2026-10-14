
using CompanyMangment.Domain.Entities;
using CompanyMangment.Infrastructure.Repositories.Emoloyees;
using CompanyMangment.Infrastructure.Repositories.Roles;
using CompanyMangment.Infrastructure.Repositories.Users;

namespace CompanyMangment.Infrastructure.Repositories.Base

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
