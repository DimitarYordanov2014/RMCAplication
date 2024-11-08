using Microsoft.EntityFrameworkCore;
using RMCAplication.Data;
using RMCAplication.Data.Models;
using RMCAplication.Data.Repository.Interfaces;
using RMCAplication.Services.Data.Interfaces;
using RMCAplication.Services.Mapping;
using RMCAplication.ViewModels.WarehouseViewModels;

namespace RMCAplication.Services.Data
{
    public class WarehouseService(RMCApplicationDbContext context, IRepository<Warehouse, int> repository) : IWarehouseService
    {
        

        public async Task CreateWarehouse(WarehouseViewModel model)
        {
            Warehouse warehouse = new Warehouse();
            AutoMapperConfig.MapperInstance.Map(model, warehouse);

            await repository.AddAsync(warehouse);
        }

        public IEnumerable<WarehouseViewModel> GetAllWarehouses()
        {
             var warehouses = repository
                .GetAllAttached()
                .Where(x => x.IsDeleted == false)
                .To<WarehouseViewModel>()
                .ToList();
            return warehouses;
        }

        public async Task<WarehouseViewModel> GetWarehouseDetailsById(int id)
        {
            var warehouse = await context.Warehouses
                .Include(x => x.SpareParts)
                .Include(x => x.Consumables)
                .Include(x => x.Tools)
                .Where(x => x.IsDeleted == false)
                .FirstOrDefaultAsync(c => c.Id == id);          

            var newWarehouse = new WarehouseViewModel();
            AutoMapperConfig.MapperInstance.Map(warehouse, newWarehouse);

            return newWarehouse;
        }
    }
}
