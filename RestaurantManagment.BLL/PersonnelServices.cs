using RestaurantManagment.DAL;
using RestaurantManagment.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagment.BLL
{
   public class PersonnelServices
    {
        PersonnelRepository personnelRepository = new PersonnelRepository();
        public void AddPersonnel(Personnel personnel)
        {
            personnelRepository.AddPersonnel(personnel);
        }
        public void UpdatePersonnel(Personnel personnel)
        {
            personnelRepository.UpdatePersonnel(personnel);
        }
        public void DeletePersonnel(int id)
        {
            personnelRepository.DeletePersonnel(id);
        }
        public List<Personnel> FindPersonnel()
        {
            return personnelRepository.GetAllPersonnel();
        }
        public Personnel FindById(int id)
        {
            return (personnelRepository.FindPersonnel(id));
        }
        public void Dispose()
        {
            personnelRepository.Dispose();
        }
    }
}
