using RMCAplication.Data.Models;
using RMCAplication.Data.Repository.Interfaces;
using RMCAplication.Services.Data.Interfaces;
using RMCAplication.ViewModels;
using RMCAplication.Services.Mapping;

namespace RMCAplication.Services.Data
{
    public class WarehouseService : IWarehouseService
    {
        private IRepository<Warehouse, int> repository;

        public WarehouseService(IRepository<Warehouse, int> repository)
        {
            this.repository = repository;
        }

        public Task CreateWarehouse(WarehouseViewModel model)
        {
            throw new NotImplementedException();
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
