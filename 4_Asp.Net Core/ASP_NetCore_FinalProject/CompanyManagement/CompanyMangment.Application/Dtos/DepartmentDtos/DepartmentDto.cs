using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyMangment.Application.Dtos.DepartmentDtos
{
    public class CreateDepartmentDto 
    {
        public string Name { get; set; }
    }
    public class UpdateDepartmentDto :CreateDepartmentDto 
    {
        public int Id { get; set; }
    }
    public class DepartmentDto : UpdateDepartmentDto
    { }
}
