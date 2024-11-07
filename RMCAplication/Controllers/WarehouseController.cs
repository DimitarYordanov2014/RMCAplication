using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RMCAplication.Data;
using RMCAplication.Data.Models;
using RMCAplication.Data.Repository.Interfaces;
using RMCAplication.Services.Data.Interfaces;
using RMCAplication.ViewModels.WarehouseViewModels;


namespace RMCApp.Web.Controllers
{
    [Authorize]
    public class WarehouseController(RMCApplicationDbContext context, IWarehouseService warehouseService) : Controller
    {
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index()
        {
            var warehouses = warehouseService.GetAllWarehouses();
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

            await warehouseService.CreateWarehouse(model);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var warehouse = await context.Warehouses
                .Include(x => x.SpareParts)
                .Include(x => x.Consumables)
                .Include(x => x.Tools)
                .Where(x => x.IsDeleted == false)
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
