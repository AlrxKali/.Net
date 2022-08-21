﻿using IMS.CoreBusiness;
using IMS.UseCases.Inventories.Interfaces;
using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases.Inventories
{
    public class ViewInventoriesByNameUseCases : IViewInventoriesByNameUseCases
    {
        private readonly IInventoryRepository inventoryRepository;

        public ViewInventoriesByNameUseCases(IInventoryRepository inventoryRepository)
        {
            this.inventoryRepository = inventoryRepository;
        }

        public async Task<IEnumerable<Inventory>> ExecuteAsync(string name = "")
        {
            return await inventoryRepository.GetInventoryByNameAsync(name);
        }
    }
}
