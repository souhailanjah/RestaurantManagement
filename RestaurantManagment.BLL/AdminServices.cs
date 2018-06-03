using RestaurantManagment.DAL;
using RestaurantManagment.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagment.BLL
{
    public class AdminServices
    {
        AdminRepository adminRepository = new AdminRepository();


        public  void  AddAdmin(Admin admin)
        {
           adminRepository.AddAdmin(admin);
        }
        public void UpdateAdmin(Admin admin)
        {
            adminRepository.UpdateAdmin(admin);
        }
        public void DeleteAdmin(int id)
        {
            adminRepository.DeleteAdmin(id);
        }
        public List<Admin> FindAdmin()
        {
            return adminRepository.GetAllAdmins();
        }
        public Admin FindById(int id)
        {
            return (adminRepository.FindAdmin(id));
        }
        public void Dispose()
        {
            adminRepository.Dispose();
        }
    }
}
