using RestaurantManagment.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagment.DAL
{
  public  class ClientRepositroy
    {
            private RestaurantManagmentContext context;

            public ClientRepositroy()
            {
                context = new RestaurantManagmentContext();
            }
            public void AddClient(Client client)
            {
                context.Client.Add(client);
                context.SaveChanges();
        }

            public List<Client> GetAllClients()
            {

                return context.Client.ToList();
            }

            public Client FindClient(int id)
            {
                foreach (Client client in context.Client)
                {
                    if (client.Id==id)
                        return client;
                }
                return null;
            }

            public void DeleteClient(int id)
            {
                context.Client.Remove(GetClientById(id));
                 context.SaveChanges();
        }
        public void UpdateClient(Client Client)
        {
            Client c = FindClient(Client.Id);
            if (c != null)
            {
                context.Client.Remove(c);
            }
            context.Client.Add(c);

            context.SaveChanges();
        }
        public Client GetClientById(int id)
        {
            return context.Client.Find(id);

        }
        public void Dispose()
        {
            context.Dispose();
        }
    }
}
