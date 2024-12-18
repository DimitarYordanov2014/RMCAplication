﻿using RMCAplication.Data.Models;
using RMCAplication.ViewModels.WarehouseViewModels;

namespace RMCAplication.Services.Data.Interfaces
{
    public interface IWarehouseService
    {
        IEnumerable<WarehouseViewModel> GetAllWarehouses();
        Task CreateWarehouse(WarehouseViewModel model);
        Task<WarehouseViewModel> GetWarehouseDetailsById(int id);
    }
}
