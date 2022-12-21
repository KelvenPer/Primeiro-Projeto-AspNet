using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Elfie.Serialization;

namespace Projeto.Controllers
{
    public class ApiController : Controller
    {

        public IActionResult ConsomeApi()
        {

            return View();
        }
    }
}
