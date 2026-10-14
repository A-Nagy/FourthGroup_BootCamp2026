using CompanyMangment.Domain.Entities;
using CompanyMangment.Infrastructure.Repositories.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CompanyMangment.Web.Controllers
{
    [Authorize(Roles ="Admin")]
    public class RolesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public RolesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: Roles

        public async Task<IActionResult> Index()
        {
            IEnumerable<Role> roles = _unitOfWork.Roles.GetAll();
            return View(roles);
        }

        // GET: Roles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var role =  _unitOfWork.Roles.GetById(id.Value);
            if (role == null)
            {
                return NotFound();
            }

            return View(role);
        }

        // GET: Roles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Roles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] Role role)
        {
            if (ModelState.IsValid)
            {
              _unitOfWork.Roles.Add(role);
                _unitOfWork.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(role);
        }

        // GET: Roles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var role = _unitOfWork.Roles.GetById(id.Value);
            if (role == null)
            {
                return NotFound();
            }
            return View(role);
        }

        // POST: Roles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] Role role)
        {
            if (id != role.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _unitOfWork.Roles.Update(role);
                    _unitOfWork.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    ;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(role);
        }

        // GET: Roles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var role =_unitOfWork.Roles.GetById(id.Value);
            if (role == null)
            {
                return NotFound();
            }

            return View(role);
        }

        // POST: Roles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var role = _unitOfWork.Roles.GetById(id);
            if (role != null)
            {
                _unitOfWork.Roles.Delete(role);
                _unitOfWork.SaveChanges();
            }

          
            return RedirectToAction(nameof(Index));
        }

        

        [HttpGet]
        public IActionResult AssignPermissions(int Id) 
        {/*_context.Roles.Include(r => r.Permissions).FirstOrDefault(r=>r.Id== Id);*/
            Role? role= _unitOfWork.Roles.GetRoleWithPermissions(Id);
            
            if (role == null) 
            {
                return NotFound();
            }

            IEnumerable<Permission> permissions= _unitOfWork.Permissions.GetAll();
            ViewBag.AllPermissions = permissions;

            ViewBag.AssignedPermissions =  role.Permissions.Select(p=>p.Id).ToList();

            return View(role);
        }

        [HttpPost]
        public IActionResult AssignPermissions(int Id, List<int> permissionsIds)
        {
            Role? role = _unitOfWork.Roles.GetRoleWithPermissions(Id);
            if (role == null)
            {
                return NotFound();
            }
            role.Permissions.Clear();

            List<Permission> selectedPermissions =
                           _unitOfWork.Permissions.GetAll().Where(p => permissionsIds.Contains(p.Id)).ToList();
            foreach (Permission permission in selectedPermissions) 
            {
                role.Permissions.Add(permission);
            }
            _unitOfWork.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
