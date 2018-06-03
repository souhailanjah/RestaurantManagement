using RestaurantManagment.DAL;
using RestaurantManagment.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagment.BLL
{
    public class ClientServices
    {
        ClientRepositroy clientRepository = new ClientRepositroy();
        public void AddClient(Client client)
        {
            clientRepository.AddClient(client);
        }
        public void UpdateClient(Client client)
        {
            clientRepository.UpdateClient(client);
        }
        public List<Client> FindClient()
        {
            return clientRepository.GetAllClients();
        }
        public Client FindById(int Id)
        {
            return(clientRepository.FindClient(Id));
        }
        public void DeleteClient(int Id)
        {
            clientRepository.DeleteClient(Id);
        }
        public void Dispose()
        {
            clientRepository.Dispose();
        }
    }
}
