

using CompanyMangment.Domain.Entities;
using CompanyMangment.Infrastructure.Data;
using CompanyMangment.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace CompanyMangment.Infrastructure.Repositories.Emoloyees
{
    public class EmployeeRepository :Repository<Employee> ,IEmployeeRepository
    {
       
        public EmployeeRepository(AppDbContext context) : base(context)
        { }

        public IEnumerable<Employee> GetAllEmployeesWithDepartment()
        {
          //  return _context.Employees.Include(e => e.Department).ToList();
          return _dbContext.Employees.Include(e => e.Department).ToList();  
        }

       
        Employee IEmployeeRepository.GetEmployeeWithDepartment(int? Id)
        {
            Employee? emp = _dbContext.Employees.Include(e => e.Department).First(e => e.Id == Id);
            return emp;
        }
   
    }
}
