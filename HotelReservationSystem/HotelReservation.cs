using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace HotelReservationSystem
{
    class HotelReservation
    {
        List<Hotel> hotelList = new List<Hotel>();
        List<Hotel> ratesAndHotelsList = new List<Hotel>();
        ArrayList daysList = new ArrayList();
        List<Hotel> hotellistWithMinPrices = new List<Hotel>();

        /// <summary>
        /// UC1
        /// Adds the hotels.
        /// </summary>
        public void AddHotels()
        {
            hotelList.Add(new Hotel("Lakewood", 110, 90, 3));
            hotelList.Add(new Hotel("Bridgewood", 150, 50, 4));
            hotelList.Add(new Hotel("Ridgewood", 220, 150, 5));

            Console.WriteLine("Hotels are added in List");
            foreach (Hotel hotels in hotelList)
            {
                Console.WriteLine($"Hotel Name: {hotels.hotelName} , WeekDayRates : {hotels.weekDayRegularRates} , WeekendRates : {hotels.weekendRegularRates} , Rating : {hotels.hotelRatings}");
            }
        }

        /// <summary>
        /// UC4
        /// Addings the days to list.
        /// </summary>
        /// <param name="checkInDate">The check in date.</param>
        /// <param name="checkOutDate">The check out date.</param>
        public void AddingDaysToList(DateTime checkInDate, DateTime checkOutDate)
        {
            while (checkOutDate >= checkInDate)
            {
                daysList.Add(checkInDate.DayOfWeek);
                checkInDate = checkInDate.AddDays(1);
            }
        }
        /// <summary>
        /// UC2
        /// Calculatings the hotel prices.
        /// </summary>
        /// <param name="checkInDate">The check in date.</param>
        /// <param name="checkOutDate">The check out date.</param>
        public void CalculatingHotelPrices(DateTime checkInDate, DateTime checkOutDate)
        {
            if (checkInDate < checkOutDate)
            {
                foreach (Hotel hotels in hotelList)
                {
                    int total = 0;
                    for (int index = 0; index < daysList.Count; index++)
                    {
                        if (daysList[index].ToString().Equals("Saturday") || daysList[index].ToString().Equals("Sunday"))
                        {
                            total = total + hotels.weekendRegularRates;
                        }
                        else
                        {
                            total = total + hotels.weekDayRegularRates;
                        }
                    }
                    Console.WriteLine("Hotel Name : {0} and Total Price : {1}", hotels.hotelName, total);
                    ratesAndHotelsList.Add(new Hotel(total, hotels.hotelName, hotels.hotelRatings));
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
        public void FindingCheapestHotel(DateTime checkInDate, DateTime checkOutDate)
        {
            CalculatingHotelPrices(checkInDate, checkOutDate);
            foreach (Hotel hotels in ratesAndHotelsList.OrderBy(r => r.totalPrice).ToList())
            {
                //printing the hotels with minimum rates
                if (hotels.totalPrice == ratesAndHotelsList.Min(r => r.totalPrice))
                {
                    //adding hotel with min prices in another list
                    hotellistWithMinPrices.Add(hotels);
                }

            }
            //Iterating through a list of minimum hotel price
            foreach (Hotel hotels in hotellistWithMinPrices)
            {
                //finding out hotel with maximum rating
                if (hotels.hotelRatings == hotellistWithMinPrices.Max(r => r.hotelRatings))
                {
                    Console.WriteLine("----------------CHEAPEST HOTEL WITH BEST RATINGS--------------------");
                    Console.WriteLine($"Hotel Name : {hotels.hotelName} \nTotal Price : {hotels.totalPrice} \nRating : {hotels.hotelRatings}");
                }
            }
        }
    }
}
