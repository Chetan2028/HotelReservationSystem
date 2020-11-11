using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    class HotelReservation
    {

        List<Hotel> hotelList = new List<Hotel>();
        SortedDictionary<int,string> ratesAndHotelsDictionary = new SortedDictionary<int,string>();

        /// <summary>
        /// UC1
        /// Adds the hotels.
        /// </summary>
        public void AddHotels()
        {
            hotelList.Add(new Hotel("Lakewood", 110));
            hotelList.Add(new Hotel("Bridgewood", 160));
            hotelList.Add(new Hotel("Ridgewood", 220));

            Console.WriteLine("Hotels are added in List");
            foreach (Hotel hotels in hotelList)
            {
                Console.WriteLine(hotels.hotelName + "      :    " + hotels.weekDayRegularRates);
            }
        }

        /// <summary>
        /// UC2
        /// Calculatings the hotel prices.
        /// </summary>
        /// <param name="checkInDate">The check in date.</param>
        /// <param name="checkOutDate">The check out date.</param>
        public void CalculatingHotelPrices(DateTime checkInDate , DateTime checkOutDate)
        {
            if (checkInDate < checkOutDate)
            {
                TimeSpan diff = checkOutDate.Subtract(checkInDate);
                foreach (Hotel hotels in hotelList)
                {
                    int total = 0;
                    for(int i=0; i<diff.TotalDays; i++)
                    {
                        total = total +  hotels.weekDayRegularRates;
                    }
                    Console.WriteLine("Hotel Name : {0} and Total Price : {1}",hotels.hotelName,total);
                    ratesAndHotelsDictionary.Add(total, hotels.hotelName);
                }
            }
            else
            {
                Console.WriteLine("Please enter dates properly");
            }
        }

        /// <summary>
        /// UC2
        /// Findings the cheapest hotel.
        /// </summary>
        /// <param name="checkInDate">The check in date.</param>
        /// <param name="checkOutDate">The check out date.</param>
        public void FindingCheapestHotel(DateTime checkInDate , DateTime checkOutDate)
        {
            CalculatingHotelPrices(checkInDate, checkOutDate);
            foreach (var hotelPrice in ratesAndHotelsDictionary)
            {
                Console.WriteLine("Cheapest Hotel Name : {0} , Total Price : {1}",hotelPrice.Value,hotelPrice.Key);
                break;
            }
        }
    }
}
