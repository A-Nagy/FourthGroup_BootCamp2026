using FourthGroup_1.Data;
using FourthGroup_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace FourthGroup_1.Controllers
{
    public class StudentsController : Controller
    {

        private readonly AppDbContext _dbContext;
        public StudentsController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult Index()
        { 
            List<Student> students = _dbContext.Students.ToList();
            return View(students);
        }

        [HttpGet]
        public IActionResult Details(int Id)
        {
            Student? st = _dbContext.Students.Find(Id);

            if (st == null)
            {
                //Error 404 Not Found  
                return NotFound();
            }
            return View(st);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student st)
        {
            if (!ModelState.IsValid)
            {
                return View(st);
            }
            _dbContext.Students.Add(st);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int Id)
        {
            Student? st = _dbContext.Students.Find(Id);

            if (st == null)
            {
                //Error 404 Not Found  
                return NotFound();
            }
            return View(st);
        }

        [HttpPost]
        public IActionResult Update(Student st)
        {
            if (ModelState.IsValid) 
            {
            _dbContext.Students.Update(st);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");

            }
            return View(st);
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            Student? st = _dbContext.Students.Find(Id);

            if (st == null)
            {
                //Error 404 Not Found  
                return NotFound();
            }
            return View(st);
        }

        [HttpPost]
        public IActionResult Delete(Student student)
        {
            _dbContext.Students.Remove(student);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

       
    }
}
