using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RMCAplication.Data;
using RMCAplication.Data.Models;
using RMCAplication.ViewModels;
using RMCApp.Web.ViewModels.ViewModels;


namespace RMCApp.Web.Controllers
{
    [Authorize]
    public class WarehouseController(RMCApplicationDbContext context) : Controller
    {
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var warehouses = await context.Warehouses.ToListAsync();
            return View(warehouses);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new WarehouseViewModel());
        }
        public async Task<IActionResult> Create(WarehouseViewModel model)
        {
            if (!ModelState.IsValid)
            {
                RedirectToAction("Index");
            }

            var warehouse = new Warehouse
            {
                Name= model.Name,
                Description = model.Description,
                Tools = new HashSet<Tool>(),
                Consumables = new HashSet<Consumable>(),
                SpareParts = new HashSet<SparePart>()
            };

            await context.Warehouses.AddAsync(warehouse);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var warehouse = await context.Warehouses
                .FirstOrDefaultAsync(c => c.Id == id);
            if (warehouse == null)
            {
                RedirectToAction("Index");
            }

            var newWarehouse = new WarehouseViewModel
            {
                Name = warehouse.Name,
                Description = warehouse.Description,
                Tools = warehouse.Tools,
                SpareParts = warehouse.SpareParts,
                Consumables = warehouse.Consumables
            };

            return View(newWarehouse);
        }
    }
}
