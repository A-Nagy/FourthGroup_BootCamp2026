

namespace CompanyMangment.Application.Security
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
        public const string DepartmentMangment   = "Departments.Mangments";
        //Roles
        public const string RoleMangments        = "Roles.Mangments";
        //Permissions
        public const string PermissionMangments  = "Permissions.Mangments";
        //Users
        public const string UserView       = "Users.View";
        public const string UserCreate     = "Users.Create";
        public const string UserEdit       = "Users.Edit";
        public const string UserDelete     = "Users.Delete";
        public const string UserAssignRole = "Users.AssignRole";
        //Products
        public const string ProductView    = "Products.View";
        public const string ProductCreate  = "Products.Create";
        public const string ProductEdit    = "Products.Edit";
        public const string ProductDelete  = "Products.Delete";
        //Categories
        public const string CategoryMangment = "Categories.Mangments";
        //Orders 
        public const string OrderView        = "Orders.View";
        public const string OrderCreate      = "Orders.Create";
        public const string OrderEdit        = "Orders.Edit";
        public const string OrderDelete      = "Orders.Delete";
        //OrderItems
        public const string OrderItemView    = "OrderItems.View";
        public const string OrderItemCreate  = "OrderItems.Create";
        public const string OrderItemEdit    = "OrderItems.Edit";
        public const string OrderItemDelete  = "OrderItems.Delete";


        public static readonly string[] All =
        {
            EmployeeView,
            EmployeeCreate,
            EmployeeEdit,
            EmployeeDelete,
            DepartmentMangment  ,
            RoleMangments ,
            PermissionMangments  ,
            UserView ,
            UserCreate ,
            UserEdit ,
            UserDelete,
            UserAssignRole ,
            ProductView ,
            ProductCreate,
            ProductEdit ,
            ProductDelete,
            CategoryMangment,
            OrderView ,
            OrderCreate ,
            OrderEdit ,
            OrderDelete ,
            OrderItemView ,
            OrderItemCreate ,
            OrderItemEdit,
            OrderItemDelete


    };
    }
}
