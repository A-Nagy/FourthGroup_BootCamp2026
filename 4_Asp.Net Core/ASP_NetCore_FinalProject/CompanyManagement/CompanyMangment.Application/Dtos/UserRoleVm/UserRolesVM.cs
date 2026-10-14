using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyMangment.Application.Dtos.UserRoleVm
{
    public  class UserRolesVM
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public List<RoleCheckVm> Roles { get; set; }
    }
    public class RoleCheckVm 
    {
        public int RoleId { get; set; } 
        public string RoleName { get; set; }
        public bool IsSelected { get; set; }
    }
}
