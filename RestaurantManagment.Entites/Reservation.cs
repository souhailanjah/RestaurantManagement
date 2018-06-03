using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagment.Entites
{
    public class Reservation
    {

        public int Id { get; set; }
        public virtual Client client { get; set; }
        public DateTime Time { get; set; }

    }
}
