using System;
using System.Collections;

namespace HotelReservationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hotel Reservation System");
            HotelReservation hotelReservation = new HotelReservation();
            hotelReservation.AddHotels();
            Console.WriteLine("Enter the check-in date in the form dd/mm/yyyy");
            string checkIn = Console.ReadLine();
            Console.WriteLine("Enter the checkout date in the form dd/mm/yyyy");
            string checkOut = Console.ReadLine();
            DateTime checkInDate = DateTime.Parse(checkIn);
            Console.WriteLine(checkInDate.ToString("d"));
            DateTime checkOutDate = DateTime.Parse(checkOut);
            Console.WriteLine(checkOutDate.ToString("d"));
            Console.WriteLine("Check in day : " + checkInDate.DayOfWeek);
            Console.WriteLine("Checkout date day : " + checkOutDate.DayOfWeek);
            hotelReservation.AddingDaysToList(checkInDate, checkOutDate);
            hotelReservation.FindingCheapestHotelWithBestRating(checkInDate, checkOutDate);
        }
    }
}
