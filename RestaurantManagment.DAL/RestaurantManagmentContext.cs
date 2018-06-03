using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using RestaurantManagment.Entites;

namespace RestaurantManagment.DAL
{
    public class RestaurantManagmentContext:DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Personnel> Personnel { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
       


    }
}
