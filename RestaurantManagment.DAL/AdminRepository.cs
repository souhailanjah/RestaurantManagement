using RestaurantManagment.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagment.DAL
{
   public class AdminRepository
    {
        private RestaurantManagmentContext context;

        public AdminRepository()
        {
            context = new RestaurantManagmentContext();
        }
        public void AddAdmin(Admin a)
        {
            context.Admins.Add(a);
            context.SaveChanges();
        }

        public List<Admin> GetAllAdmins()
        {

            return context.Admins.ToList();
        }

        public Admin FindAdmin (int id)
        {   foreach (Admin admin in context.Admins) {
                if (admin.Id==id)
                    return admin;
            }
            return null;
        }
      
        public void DeleteAdmin(int id)
        {
            context.Admins.Remove(GetAdminById(id));
            context.SaveChanges();
        }
        public void UpdateAdmin(Admin admin)
        {
            Admin a = FindAdmin(admin.Id);
            if (a != null)
            {
                context.Admins.Remove(a);
            }
            context.Admins.Add(a);

            context.SaveChanges();
        }
        public Admin GetAdminById(int id)
        {
            return context.Admins.Find(id);

        }
        public void Dispose()
        {
            context.Dispose();
        }

    }
}
