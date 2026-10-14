using CompanyMangment.Domain.Entities;
using CompanyMangment.Infrastructure.Repositories.Base;

namespace CompanyMangment.Infrastructure.Repositories.Emoloyees

{
    public interface IEmployeeRepository : IRepository<Employee>
    {   

        IEnumerable<Employee> GetAllEmployeesWithDepartment();
        Employee GetEmployeeWithDepartment(int? Id);

    }
}
