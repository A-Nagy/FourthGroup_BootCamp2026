using FourthGroup_1.Models;
using FourthGroup_1.Repositories.Base;

namespace FourthGroup_1.Repositories.Emoloyee
{
    public interface IEmployeeRepository : IRepository<Employee>
    {   

        IEnumerable<Employee> GetAllEmployeesWithDepartment();
        Employee GetEmployeeWithDepartment(int? Id);

    }
}
