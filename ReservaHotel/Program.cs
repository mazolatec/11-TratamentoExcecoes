using ReservaHotelMuitoRuin.Entities;
using System;

namespace ReservaHotelMuitoRuin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Room number: ");
            int roomnumber = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy: )");
            DateTime checkindate = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy: )");
            DateTime checkoutdate = DateTime.Parse(Console.ReadLine());
            if (checkoutdate <= checkindate)
            {
                Console.WriteLine("Error in reservstion: Check-out date must be after check-in date");
            }
            else
            {
                Reservation reservation = new Reservation(roomnumber, checkindate, checkoutdate);
                Console.WriteLine("Reservation: " + reservation);
                Console.WriteLine();
                Console.WriteLine("Enter date to update the reservation: ");
                Console.Write("Check-in date  (dd/MM/yyyy):");
                checkindate = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy):");
                checkoutdate = DateTime.Parse(Console.ReadLine());

                DateTime now = DateTime.Now;
                if (checkindate < now || checkoutdate < now)
                {
                    Console.WriteLine("Error in reservation: Reservation dates for update must be future dates");

                }else if (checkoutdate <= checkindate)
                {
                    Console.WriteLine("Error in reservstion: Check-out date must be after check-in date");
                }
                else
                {
                    reservation.UpdateDates(checkindate, checkoutdate);
                    Console.WriteLine("Reservation: "+reservation);
                }
            }
            
           
        }
    }
}
