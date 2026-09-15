using FourthGroup_1.Data;
using FourthGroup_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FourthGroup_1.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly AppDbContext _dbContext;
        public EmployeesController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult Index()
        {
            //List<Employee> employeelist = new List<Employee>();

            //Employee emp1 = new Employee 
            //{
            //    Id =  1 ,
            //    Name = "Ahmed Nagi Good Engineeer ",
            //    Email = "xxxx@gmail.com",
            //    Address = "123 Main St",
            //    Salary = 3000,
            //    Phone = "1234567890"
            //};

            //Employee emp2 = new Employee
            //{
            //    Name = "Mesho Best student EVER",
            //    Email = "xxxx@gmail.com",
            //    Address = "123 Main St",
            //    Salary = 3000,
            //    Phone = "1234567890"
            //};

            //Employee emp3 = new Employee
            //{
            //    Name = "MMMOOSSS Doe",
            //    Email = "xxxx@gmail.com",
            //    Address = "123 Main St",
            //    Salary = 3000,
            //    Phone = "1234567890"
            //};

            //// put all obj inside list
            //employeelist.Add(emp1);
            //employeelist.Add(emp2);
            //employeelist.Add(emp3);
            //return View(employeelist);

            // ToList() Mean Select * 
            // Include() 
            IEnumerable<Employee> employees = _dbContext.Employees.Include(e=>e.Department).ToList();
            return View(employees);
        }
    
        [HttpGet]
        public IActionResult Details(int Id)
        {
            Employee? emp = _dbContext.Employees.Find(Id);

            if (emp == null)
            {
                //Error 404 Not Found  
                return NotFound();
            }
            return View(emp);
        }

        [HttpGet]
        public IActionResult Create() 
        {
            LoadDepartments();
            return View(); 
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employee emp)
        {
            if(!ModelState.IsValid)
            {
                return View(emp);
            }
            _dbContext.Employees.Add(emp);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int Id)
        { Employee? emp = _dbContext.Employees.Find(Id);
           
            if (emp == null)
            {   
                //Error 404 Not Found  
                return NotFound();
            }
            return View(emp);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Employee emp)
        {
            if (!ModelState.IsValid)
            {
                return View(emp);
            }
            _dbContext.Employees.Update(emp);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            Employee? emp = _dbContext.Employees.Find(Id);

            if (emp == null)
            {
                //Error 404 Not Found  
                return NotFound();
            }
            return View(emp);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Employee emp)
        {
            _dbContext.Employees.Remove(emp);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
       
        [HttpGet]
        public IActionResult Search()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Search(Employee emp)
        {
            Employee? employee = _dbContext.Employees.FirstOrDefault(e => e.Phone == emp.Phone);
            if (employee == null) 
            {
                return NotFound();
            }
            return RedirectToAction("Details", new { Id = employee.Id });
        }

        private void LoadDepartments() 
        {
            IEnumerable<Department> departments = _dbContext.Departments.ToList();
            ViewBag.DepartmentList = new SelectList(departments, "Id", "Name");
        }

    }
}
