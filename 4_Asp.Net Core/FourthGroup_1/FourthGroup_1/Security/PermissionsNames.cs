namespace FourthGroup_1.Security
{
    public class PermissionsNames
    {
        public const string ClaimType = "Permission";
        //Employees
        public const string EmployeeView   = "Employees.View";
        public const string EmployeeCreate = "Employees.Create";
        public const string EmployeeEdit   = "Employees.Edit";
        public const string EmployeeDelete = "Employees.Delete";
        //Departments
        public const string DepartmentView   = "Departments.View";
        public const string DepartmentCreate = "Departments.Create";
        public const string DepartmentEdit   = "Departments.Edit";
        public const string DepartmentDelete = "Departments.Delete";
        //Roles
        public const string RoleView = "Roles.View";
        public const string RoleCreate = "Roles.Create";
        public const string RoleEdit = "Roles.Edit";
        public const string RoleDelete = "Roles.Delete";

        public static readonly string[] All =
        {
            EmployeeView,
            EmployeeCreate,
            EmployeeEdit,
            EmployeeDelete,
            DepartmentView ,
            DepartmentCreate,
            DepartmentEdit,
            DepartmentDelete
        };
    }
}
