using RestaurantManagment.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagment.DAL
{
  public  class PersonnelRepository
    {
        private RestaurantManagmentContext context;

        public PersonnelRepository()
        {
            context = new RestaurantManagmentContext();

        }
        public void AddPersonnel(Personnel personnel)
        {
            context.Personnel.Add(personnel);
            context.SaveChanges();
        }

        public List<Personnel> GetAllPersonnel()
        {

            return context.Personnel.ToList();
        }

        public Personnel FindPersonnel(int id)
        {
            foreach (Personnel personnel in context.Personnel)
            {
                if (personnel.Id == id)
                    return personnel;
            }
            return null;
        }

        public void DeletePersonnel(int id)
        {
            context.Personnel.Remove(GetPersonnelById(id));
            context.SaveChanges();
        }
        public void UpdatePersonnel(Personnel personnel)
        {
            Personnel d = FindPersonnel(personnel.Id);
            if (d != null)
            {
                context.Personnel.Remove(d);
            }
            context.Personnel.Add(d);

            context.SaveChanges();
        }
        public Personnel GetPersonnelById(int id)
        {
            return context.Personnel.Find(id);

        }
        public void Dispose()
        {
            context.Dispose();
        }
    }
}
