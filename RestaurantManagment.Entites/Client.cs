using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagment.Entites
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }

    }
}
