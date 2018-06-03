using RestaurantManagment.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagment.DAL
{
  public  class InventoryRepository
    {
        private RestaurantManagmentContext context;

        public InventoryRepository()
        {
            context = new RestaurantManagmentContext();
        }
        public void AddInventory(Inventory inventory)
        {
            context.Inventory.Add(inventory);
            context.SaveChanges();
        }

        public List<Inventory> GetAllInventory()
        {

            return context.Inventory.ToList();
        }

        public Inventory FindInventory(int id)
        {
            foreach (Inventory inventory in context.Inventory)
            {
                if (inventory.Id == id)
                    return inventory;
            }
            return null;
        }

        public void DeleteInventory(int id)
        {
            context.Inventory.Remove(GetInventoryById(id));
            context.SaveChanges();
        }
        public void UpdateInventory(Inventory inventory)
        {
            Inventory s = FindInventory(inventory.Id);
            if (s != null)
            {
                context.Inventory.Remove(s);
            }
            context.Inventory.Add(s);

            context.SaveChanges();
        }
        public Inventory GetInventoryById(int id)
        {
            return context.Inventory.Find(id);

        }
        public void Dispose()
        {
            context.Dispose();
        }
    }
}
