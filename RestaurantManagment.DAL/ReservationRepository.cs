using RestaurantManagment.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagment.DAL
{
  public  class ReservationRepository
    {
        private RestaurantManagmentContext context;

        public ReservationRepository()
        {
            context = new RestaurantManagmentContext();
        }
        public void AddReservation(Reservation reservation)
        {
            context.Reservation.Add(reservation);
            context.SaveChanges();
        }

        public List<Reservation> GetAllReservation()
        {

            return context.Reservation.ToList();
        }

        public Reservation FindReservation(int id)
        {
            foreach (Reservation reservation in context.Reservation)
            {
                if (reservation.Id==id)
                    return reservation;
            }
            return null;
        }

        public void DeleteReservation(int id)
        {
            context.Reservation.Remove(GetReservationById(id));
            context.SaveChanges();
        }
        public void UpdateReservation(Reservation reservation)
        {
            Reservation p = FindReservation(reservation.Id);
            if (p != null)
            {
                context.Reservation.Remove(p);
            }
            context.Reservation.Add(p);

            context.SaveChanges();
        }
        public Reservation GetReservationById(int id)
        {
            return context.Reservation.Find(id);

        }
        public void Dispose()
        {
            context.Dispose();
        }
    }
}
