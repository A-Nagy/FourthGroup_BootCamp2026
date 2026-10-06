using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FourthGroup_1.Controllers
{
    [Authorize]
    public class DoashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
