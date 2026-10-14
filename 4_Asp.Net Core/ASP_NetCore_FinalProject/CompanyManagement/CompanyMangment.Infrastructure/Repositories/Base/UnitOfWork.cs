
using CompanyMangment.Domain.Entities;
using CompanyMangment.Infrastructure.Data;
using CompanyMangment.Infrastructure.Repositories.Emoloyees;
using CompanyMangment.Infrastructure.Repositories.Roles;
using CompanyMangment.Infrastructure.Repositories.Users;

namespace CompanyMangment.Infrastructure.Repositories.Base

{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public IEmployeeRepository Employees { get; }

        public IUserRepository Users { get; }

        public IRoleRepository Roles { get; }
        public IRepository<Permission> Permissions { get; }

        public IRepository<Department> Departments { get; }

        public IRepository<Category> Categories { get; }

        public IRepository<Product> Products { get; }
        public UnitOfWork(AppDbContext context) 
        {
            _context     = context;
            Employees    = new EmployeeRepository(_context);
            Users        = new UserRepository(_context);
            Roles        = new RoleRepository(_context);
            Permissions  = new Repository<Permission>(_context);
            Departments  = new Repository<Department>(_context);
            Categories   = new Repository<Category>(_context);
            Products     = new Repository<Product>(_context);

        }

        public int SaveChanges()
        {
          return _context.SaveChanges();
        }
    }
}
