using System;
using Trat.Exceção.Entities;
using Trat.Exceção.Exceptions;

namespace Trat.Exceção
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());


                Reservation reservation = new Reservation(number, checkin, checkout);
                Console.WriteLine(reservation);

                Console.WriteLine();

                Console.WriteLine("Emter data to update the reservation: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());


                reservation.UpdateDates(checkin, checkout);

                Console.WriteLine(reservation);
            }
            catch(DomainException e)
            {
                Console.WriteLine("Erro!" + e.Message);
            }
        }
    }
}
