using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FourthGroup_1.Data;
using FourthGroup_1.Models;
using FourthGroup_1.Repositories.Base;

namespace FourthGroup_1.Controllers
{
    public class CategoriesController : Controller
    {
       // private readonly AppDbContext _context;
       private readonly IRepository<Category> _categoryRepository;

        public CategoriesController(AppDbContext context,  IRepository<Category> categoryRepository)
        {
           // _context = context;
           _categoryRepository = categoryRepository;

        }

        // GET: Categories
        public IActionResult Index()
        {
          //  return Content(_context.Categories.Find(2).Name);

            return View(_categoryRepository.GetAll());
        }
        // Content    : Text
        // View       : Interface
        // Not Found  : Error Interface
        // Ok         : Data AS Api 
        // Bad Request: Error Api
        // RedirectTo Action : Data From Anther Action
        //public IActionResult GetAllCateories()
        //{
        //    //  return Content(_context.Categories.Find(2).Name);

        //    return Ok(_context.Categories.ToList());
        //}

        // GET: Categories/Details/5
        public IActionResult Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = _categoryRepository.GetById(id);
              
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // GET: Categories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Categories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                _categoryRepository.Add(category);
                //_context.Add(category);
                // _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        // GET: Categories/Edit/5
        public IActionResult Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = _categoryRepository.GetById(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: Categories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Category category)
        {
            if (id != category.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _categoryRepository.Update(category);
                    //_context.Update(category);
                    // _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    //if (!CategoryExists(category.Id))
                    //{
                    //    return NotFound();
                    //}
                    //else
                    //{
                    //    throw;
                    //}
                }
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        // GET: Categories/Delete/5
        public IActionResult Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            //_context.Categories.FirstOrDefault(m => m.Id == id);
            var category = _categoryRepository.GetById(id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var category = _categoryRepository.GetById(id);
            if (category != null)
            {
                //_context.Categories.Remove(category);
                _categoryRepository.Delete(category);   
            }

             //_context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        //private bool CategoryExists(int id)
        //{
        //    return _context.Categories.Any(e => e.Id == id);
        //}
    }
}
