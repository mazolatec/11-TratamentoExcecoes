using ReservaHotel.Entities;
using System;

namespace ReservaHotelRuin
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
                Reservation reservation = new(roomnumber, checkindate, checkoutdate);
                Console.WriteLine("Reservation: " + reservation);
                Console.WriteLine();
                Console.WriteLine("Enter date to update the reservation: ");
                Console.Write("Check-in date  (dd/MM/yyyy):");
                checkindate = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy):");
                checkoutdate = DateTime.Parse(Console.ReadLine());

                string error = reservation.UpdateDates(checkindate,checkoutdate);

                if (error != null)
                {
                    Console.WriteLine(" Error in reservation: " + error);
                }
                else
                {
                    Console.WriteLine("Reservation: " + reservation);
                }
            }
        }
    }
}
