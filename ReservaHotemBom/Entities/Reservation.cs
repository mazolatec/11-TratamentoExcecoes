using ReservaHotemBom.Entities.Exceptions;
using System;


namespace ReservaHotelBom.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }
        
        public Reservation() { }      
        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            if (checkout <= checkin)
            { //A data de check-out deve ser posterior à data de check-in  Check-out date must be after check-in date
                throw new DomainExeptions("Error in reservstion:  A data de check-out deve ser posterior à data de check-in ");
            }

            RoomNumber = roomNumber;
            Checkin = checkin;
            Checkout = checkout;
        }
        

       public int Duration()
        {
            TimeSpan duration = Checkout.Subtract(Checkin);
            return   (int)duration.TotalDays;
        }
       
        public void UpdateDates(DateTime checkin,DateTime checkout)
        {
            DateTime now = DateTime.Now;
            if (checkin < now || checkout < now)
            {
             throw new DomainExeptions( "Error in reservation: Reservation dates for update must be future dates");

            }
           if (checkout <= checkin)
            {
              throw new DomainExeptions( "Error in reservstion: Check-out date must be after check-in date");
            }

            Checkin = checkin;
            Checkout = checkout;
         
        }
       
        public override string ToString()
        {
            return "Room "
                + RoomNumber
                + ", check-in: "
                + Checkin.ToString("dd/MM/yyyy")
                + ", check-out: "
                + Checkout.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nights";
        }

    }
}
