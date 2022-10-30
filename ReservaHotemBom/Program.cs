using ReservaHotelBom.Entities;
using ReservaHotemBom.Entities.Exceptions;
using System;

namespace ReservaHotemBom
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number: ");
                int roomnumber = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy: )");
                DateTime checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy: )");
                DateTime checkout = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(roomnumber, checkin, checkout);
                Console.WriteLine("Reservation: " + reservation);
                Console.WriteLine();
                Console.WriteLine("Enter date to update the reservation: ");
                Console.Write("Check-in date  (dd/MM/yyyy):");
                checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy):");
                checkout = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkin, checkout);
                Console.WriteLine("Reservation: " + reservation);
            }
            catch (DomainExeptions d)
            {
                Console.WriteLine("Error in rervation: " + d.Message) ;
            }catch(FormatException f)
            {
                Console.WriteLine("Format error: "+f.Message);
            }catch(Exception e)
            {
                Console.WriteLine("Unxpected error: "+e.Message);
            }
        }
    }
}

