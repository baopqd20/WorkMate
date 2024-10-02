using Microsoft.AspNetCore.Mvc;

namespace WorkMateBE.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
