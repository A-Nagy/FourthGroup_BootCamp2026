using CompanyMangment.Application.Abstractions.Services;
using CompanyMangment.Application.Dtos.EmployeeDtos;
using CompanyMangment.Domain.Entities;
using CompanyMangment.Infrastructure.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyMangment.Application.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IUnitOfWork _unitOfwork;

        public EmployeeService(IUnitOfWork unitOfwork)
        {
            _unitOfwork = unitOfwork;
        }

        public void AddEmployee(Employee employee)
        {
            _unitOfwork.Employees.Add(employee);
            _unitOfwork.SaveChanges();
        }

        public void DeleteEmployee(Employee employee)
        {
            _unitOfwork.Employees.Delete(employee);
            _unitOfwork.SaveChanges();
        }

        public IEnumerable<EmployeeDto> GetAllEmployee()
        {
                    IEnumerable<Employee> employees = _unitOfwork.Employees.GetAll();
                    IEnumerable<EmployeeDto> EmployeesDto = employees.Select(e => new  EmployeeDto
                                                                        {
                                                                            Id = e.Id,
                                                                            Name = e.Name,
                                                                            DepartmentName=e.Department.Name}).ToList();

                    return EmployeesDto; 
        }

        public IEnumerable<Department> GetDepartment()
        {
            return _unitOfwork.Departments.GetAll();
         }

        public Employee GetEmployeeWithDepartment(int? Id)
        {
            return _unitOfwork.Employees.GetEmployeeWithDepartment(Id);
        
        }

        public void UpdaEmployee(Employee employee)
        {
            _unitOfwork.Employees.Update(employee);
            _unitOfwork.SaveChanges();
        }
    }
}
