using Microsoft.AspNetCore.Mvc;
using RMCAplication.Data;
using RMCAplication.ViewModels.SparePartViewModels;
using RMCAplication.Services.Mapping;
using Microsoft.EntityFrameworkCore;
using RMCAplication.Data.Models;

namespace RMCAplication.Controllers
{
    public class SparePartController(RMCApplicationDbContext context) : Controller
    {
        public async Task<IActionResult> SparePartIndex()
        {
            var model = await context.SpareParts
                 .Where(x => x.IsDeleted == false)
                 .Include(x => x.Warehouse)
                 .Include(x => x.MechanizationSpareParts)
                 .To<SparePartCreateViewModel>()
                 .OrderBy(x => x.Name)
                 .ToListAsync();
            return View(model);
        }

        public async Task<IActionResult> Create()
        {
            SparePartCreateViewModel viewModel = new SparePartCreateViewModel()
            {
                Name = string.Empty,
                warehouses = await context.Warehouses.ToListAsync(),
                MechanisationChecked = await context.Mechanizations
                .Include(x => x.MechanizationSpareParts)
                .ThenInclude(m => m.Mechanization)
                .Select(c => new MechnisationCheckBoxItem()
                {
                    Id = c.Id,
                    Name = c.Name,
                    IsSelected = false
                })
                .ToListAsync()
            };
          
            return View(viewModel);
        }

        public async Task<IActionResult> Add(SparePartCreateViewModel model)
        {
            var sp = new SparePart()
            {
                Name = model.Name,
                Description = model.Description,
                WarehouseId = model.WarehouseId,
                Count = model.Count
            };
            await context.SpareParts.AddAsync(sp);
            await context.SaveChangesAsync();

            var result = await context.SpareParts.FirstOrDefaultAsync(x => x.Name == sp.Name && sp.IsDeleted == false && x.Description == sp.Description);
            foreach (MechnisationCheckBoxItem cinemaInputModel in model.MechanisationChecked)
            {
                if (cinemaInputModel.IsSelected == true)
                {
                    MechanizationSparePart? mechanizationSparePart = new MechanizationSparePart()
                    {
                        SparePartId = result.Id,
                        MechanizationId = cinemaInputModel.Id
                    };

                    await context.MechanizationSpareParts.AddAsync(mechanizationSparePart);
                    await context.SaveChangesAsync();
                }
                
            }

            return RedirectToAction("SparePartIndex");
        }
    }
}
