using CompanyMangment.Domain.Entities;
using CompanyMangment.Infrastructure.Repositories.Base;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompanyMangment.Application.Abstractions.Services;


namespace CompanyMangment.Web.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public UsersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

       
        public async Task<IActionResult> Index()
        {
            return View(_unitOfWork.Users.GetAll());
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(int Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var user =  _unitOfWork.Users.GetById(Id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Email,UserName,Password")] User user)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Users.Add(user);
                _unitOfWork.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user =_unitOfWork.Users.GetById(id.Value);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Email,UserName,Password")] User user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _unitOfWork.Users.Update(user);
                    _unitOfWork.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    
                }
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = _unitOfWork.Users.GetById(id.Value);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user =  _unitOfWork.Users.GetById(id);
            if (user != null)
            {
            _unitOfWork.Users.Delete(user);
                _unitOfWork.SaveChanges();
            }

             return RedirectToAction(nameof(Index));
        }

        //private bool UserExists(int id)
        //{
        //    return _context.Users.Any(e => e.Id == id);
        //}

        //[HttpGet]
        //public IActionResult AssignRoles(int Id)
        //{
        //    User? user = _context.Users.Include(u => u.Roles).FirstOrDefault(u => u.Id == Id);

        //    if (user == null)
        //    {
        //        return NotFound();
        //    }

        //    List<Role> roles = _context.Roles.ToList();
        //    ViewBag.AllRoles = roles;

        //    ViewBag.AssignedRoles = user.Roles.Select(r => r.Id).ToList();

        //    return View(user);
        //}

        //[HttpPost]
        //public IActionResult AssignRoles(int Id, List<int> RolesIds)
        //{
        //    User? user = _context.Users.Include(u => u.Roles).FirstOrDefault(u => u.Id == Id);
        //    if (user == null)
        //    {
        //        return NotFound();
        //    }
        //    user.Roles.Clear();

        //    List<Role> selectedroles =
        //                      _context.Roles.Where(r => RolesIds.Contains(r.Id)).ToList();
        //    foreach (Role role in selectedroles)
        //    {
        //        user.Roles.Add(role);
        //    }
        //    _context.SaveChanges();

        //    return RedirectToAction("Index");
        //}
  
    }
}
