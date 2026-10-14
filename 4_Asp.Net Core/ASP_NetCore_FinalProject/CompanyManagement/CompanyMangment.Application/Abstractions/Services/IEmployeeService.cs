using CompanyMangment.Application.Dtos.EmployeeDtos;
using CompanyMangment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyMangment.Application.Abstractions.Services
{
    public interface IEmployeeService
    {
        IEnumerable<EmployeeDto> GetAllEmployee();
        Employee GetEmployeeWithDepartment(int? Id);
        void  AddEmployee(Employee employee);

        void UpdaEmployee(Employee employee);
        void DeleteEmployee(Employee employee);
        IEnumerable<Department> GetDepartment();
    }
}
