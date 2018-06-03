using RestaurantManagment.DAL;
using RestaurantManagment.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagment.BLL
{
   public class InventoryServices
    {
        InventoryRepository inventoryRepository = new InventoryRepository();
        public void AddInventory(Inventory inventory)
        {
            inventoryRepository.AddInventory(inventory);
        }
        public void UpdateInventory(Inventory inventory)
        {
            inventoryRepository.UpdateInventory(inventory);
        }
        public void DeleteInventory(int id)
        {
           inventoryRepository.DeleteInventory(id);
        }
        public List<Inventory> Findinventory()
        {
            return inventoryRepository.GetAllInventory();
        }
        public Inventory FindById(int id)
        {
            return (inventoryRepository.FindInventory(id));
        }
        public void Dispose()
        {
            inventoryRepository.Dispose();
        }
    }
}
