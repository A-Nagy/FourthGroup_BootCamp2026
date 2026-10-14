using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CompanyMangment.Web.Controllers
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
