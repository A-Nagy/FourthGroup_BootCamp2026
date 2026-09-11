using FourthGroup_1.Data;
using FourthGroup_1.Models;
using Microsoft.AspNetCore.Mvc;

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
            List<Employee> employees = _dbContext.Employees.ToList();
            return View(employees);
        }

        [HttpGet]
        public IActionResult Create() 
        {
            return View(); 
        }

        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            _dbContext.Employees.Add(emp);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
