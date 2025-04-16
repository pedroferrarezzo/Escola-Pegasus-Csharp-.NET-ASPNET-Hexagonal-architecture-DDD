using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
