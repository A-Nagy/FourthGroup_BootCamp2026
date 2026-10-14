using CompanyMangment.Application.Security;
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
    [Authorize(Policy = PermissionsNames.PermissionMangments)]
    public class PermissionsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public PermissionsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

       
        public IActionResult Index()
        {
            return View(_unitOfWork.Permissions.GetAll());
        }
 
        [HttpGet]
        public IActionResult Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Permission permission = _unitOfWork.Permissions.GetById(id);
            return View(permission);
        }

   
        public IActionResult Create()
        {
            return View();
        }

      

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Name")] Permission permission)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Permissions.Add(permission);
                _unitOfWork.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(permission);
        }


        [HttpGet]
        public IActionResult Edit(int Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            Permission permission = _unitOfWork.Permissions.GetById(Id); 
            if (permission == null)
            {
                return NotFound();
            }
            return View(permission);
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Name")] Permission permission)
        {
            if (id != permission.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _unitOfWork.Permissions.Update(permission);
                    _unitOfWork.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    ;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(permission);
        }

        // GET: Permissions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var permission = _unitOfWork.Permissions.GetById(id.Value);
            if (permission == null)
            {
                return NotFound();
            }

            return View(permission);
        }

        // POST: Permissions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var permission = _unitOfWork.Permissions.GetById(id);
            if (permission != null)
            {
                _unitOfWork.Permissions.Delete(permission);
            }

            _unitOfWork.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        
    }
}
