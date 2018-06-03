using RestaurantManagment.DAL;
using RestaurantManagment.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagment.BLL
{
   public class ReservationService
    {
        ReservationRepository reservationRepository = new ReservationRepository();
        //ClientRepositroy clientRepositroy = new ClientRepositroy();

    
        public void AddReservation(Reservation reservation)
        {
            reservationRepository.AddReservation(reservation);
        }
        public void UpdateReservation(Reservation reservation)
        {
            reservationRepository.UpdateReservation(reservation);
        }
        public void DeleteReservation(int id)
        {
            reservationRepository.DeleteReservation(id);
        }
        public List<Reservation> FindReservation()
        {
            return reservationRepository.GetAllReservation();
        }
        public Reservation FindById(int id)
        {
            return reservationRepository.GetReservationById(id);
        }
        public void Dispose()
        {
            reservationRepository.Dispose();
        }
    }
}
