using RMCAplication.Data.Models;
using RMCAplication.Data.Repository.Interfaces;
using RMCAplication.Services.Data.Interfaces;
using RMCAplication.Services.Mapping;
using RMCAplication.ViewModels.WarehouseViewModels;

namespace RMCAplication.Services.Data
{
    public class WarehouseService : IWarehouseService
    {
        private IRepository<Warehouse, int> repository;

        public WarehouseService(IRepository<Warehouse, int> repository)
        {
            this.repository = repository;
        }

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

        public Task<WarehouseViewModel> GetWarehouseDetailsById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
