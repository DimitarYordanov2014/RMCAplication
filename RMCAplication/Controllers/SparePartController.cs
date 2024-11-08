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

            SparePart? sparePart = await context.SpareParts
               .Where(s => s.Id == model.Id)
               .FirstOrDefaultAsync();
            if (sparePart == null)
            {
                return View(nameof(SparePartIndex));
            }

            ICollection<MechanizationSparePart> entitiesToAdd = new List<MechanizationSparePart>();
            foreach (MechnisationCheckBoxItem cinemaInputModel in model.MechanisationChecked)
            {
                            
                MechanizationSparePart? mechanizationSparePart = await context.MechanizationSpareParts
                    .FirstOrDefaultAsync(cm => cm.MechanizationId == cinemaInputModel.Id &&
                                                     cm.SparePartId == sparePart.Id);

                entitiesToAdd.Add(new MechanizationSparePart()
                {
                    MechanizationId = mechanizationSparePart.MechanizationId,
                    SparePartId = mechanizationSparePart.SparePartId
                });
            }

            await context.AddAsync(entitiesToAdd.ToArray());

            return View(nameof(SparePartIndex));
        }
    }
}
