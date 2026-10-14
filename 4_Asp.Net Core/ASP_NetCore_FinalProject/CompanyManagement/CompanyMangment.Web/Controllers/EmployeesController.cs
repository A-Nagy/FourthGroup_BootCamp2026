
using CompanyMangment.Application.Security;
using CompanyMangment.Domain.Entities;
using CompanyMangment.Infrastructure.Repositories.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;


namespace CompanyMangment.Web.Controllers
{
    [Authorize]
    public class EmployeesController : Controller
    {
      
        private readonly IUnitOfWork _unitOfWork;

        public EmployeesController(IUnitOfWork unitOfWork)
        { 
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [Authorize(Policy = PermissionsNames.EmployeeView)]
        public IActionResult Index()
        {  
            var employees = _unitOfWork.Employees.GetAllEmployeesWithDepartment();
            return View(employees);
        }

        [Authorize(Policy = PermissionsNames.EmployeeView)]
        [HttpGet]
        public IActionResult Details(int Id)
        {
            var employee = _unitOfWork.Employees.GetEmployeeWithDepartment(Id);
            return View(employee);
        }

        [Authorize(Policy = PermissionsNames.EmployeeCreate)]
        [HttpGet]
        public IActionResult Create()
        {
            LoadDepartments();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = PermissionsNames.EmployeeCreate)]
        public IActionResult Create(Employee emp)
        {
            if (!ModelState.IsValid)
            {
                return View(emp);
            }
 
            _unitOfWork.Employees.Add(emp);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Authorize(Policy = PermissionsNames.EmployeeEdit)]
        public IActionResult Update(int Id)
        {
 
            LoadDepartments();
             return View(_unitOfWork.Employees.GetEmployeeWithDepartment(Id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Employee emp)
        {
            if (!ModelState.IsValid)
            {
                return View(emp);
            }
            _unitOfWork.Employees.Update(emp);
 
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            return View(_unitOfWork.Employees.GetById(Id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Employee emp)
        {
            _unitOfWork.Employees.Delete(emp);
            return RedirectToAction("Index");
        }
         
        private void LoadDepartments()
        {
         
            IEnumerable<Department> departments = _unitOfWork.Departments.GetAll();
            ViewBag.DepartmentList = new SelectList(departments, "Id", "Name");
        }

    }
}
