using CompanyMangment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyMangment.Application.Dtos.EmployeeDtos
{
    public  class EmployeeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DepartmentName { get; set; }

    }
    public class CreateEmployee 
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string DepartmentId { get; set; }
    }
}
