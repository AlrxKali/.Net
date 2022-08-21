using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;

namespace IMS.Plugins.InMemory
{
    public class InventoryRepository : IInventoryRepository
    {
        private List<Inventory> _inventories;

        public InventoryRepository()
        {
            _inventories = new List<Inventory>()
            {
                new Inventory {
                    InventoryId = 1, 
                    InventoryName = "Fluticasone Nasal Spray",
                    Quantity = 170,
                    Price = 14.49

                },
                new Inventory {
                    InventoryId = 2,
                    InventoryName = "Astepro Allergy Steroid",
                    Quantity = 123,
                    Price = 14.99

                },
                new Inventory {
                    InventoryId = 3,
                    InventoryName = "Navage Nasal Care Saline Nasal",
                    Quantity = 0,
                    Price = 101.99

                },
            };
        }

        public Task AddInventoryAsync(Inventory inventory)
        {
            if (_inventories.Any(x => x.InventoryName.Equals(inventory.InventoryName, StringComparison.OrdinalIgnoreCase)))
            {
                return Task.CompletedTask;
            }

            var maxId = _inventories.Max(x => x.InventoryId);
            inventory.InventoryId = maxId + 1;

            _inventories.Add(inventory);

            return Task.CompletedTask;
        }

        public async Task<IEnumerable<Inventory>> GetInventoryByNameAsync(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            { return await Task.FromResult(_inventories); }

            return _inventories.Where(x => x.InventoryName.Contains(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}