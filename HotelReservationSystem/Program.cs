using System;
using System.Collections;

namespace HotelReservationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Miami Hotel Reservation System");
            HotelReservation hotelReservation = new HotelReservation();

            Console.WriteLine("Enter the check-in date in the form dd/mm/yyyy");
            string checkIn = Console.ReadLine();

            Console.WriteLine("Enter the checkout date in the form dd/mm/yyyy");
            string checkOut = Console.ReadLine();

            DateTime checkInDate = DateTime.Parse(checkIn);
            DateTime checkOutDate = DateTime.Parse(checkOut);

            Console.WriteLine("Checkin day : " + checkInDate.DayOfWeek);
            Console.WriteLine("Checkout day : " + checkOutDate.DayOfWeek);

            Console.WriteLine("Please enter the type of customer \nRegular \nReward");
            string customer = Console.ReadLine();

            hotelReservation.AddHotels(customer);
            hotelReservation.AddingDaysToList(checkInDate, checkOutDate);
            hotelReservation.FindingCheapestHotelWithBestRating(checkInDate, checkOutDate);
        }
    }
}
