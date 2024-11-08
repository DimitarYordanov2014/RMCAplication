using Microsoft.AspNetCore.Mvc;

namespace RMCAplication.Controllers
{
    public class SparePart : Controller
    {
        public IActionResult SparePartIndex()
        {
            return View();
        }
    }
}
