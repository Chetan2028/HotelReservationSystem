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
        //Adding hotels in list
        List<Hotel> hotelList = new List<Hotel>();
        //Adding hotel names and rates 
        List<Hotel> ratesAndHotelsList = new List<Hotel>();
        //Adding days 
        ArrayList daysList = new ArrayList();
        //Adding cheapest hotel
        List<Hotel> hotellistWithMinPrices = new List<Hotel>();

        /// <summary>
        /// UC1
        /// Adds the hotels.
        /// </summary>
        public void AddHotels(string customer)
        {
            try
            {
                if (customer.Equals("Regular", StringComparison.InvariantCultureIgnoreCase))
                {
                    hotelList.Add(new Hotel("Lakewood", 110, 90, 3));
                    hotelList.Add(new Hotel("Bridgewood", 150, 50, 4));
                    hotelList.Add(new Hotel("Ridgewood", 220, 150, 5));

                    Console.WriteLine("Hotels for {0} customer added in List", customer);
                    foreach (Hotel hotels in hotelList)
                    {
                        Console.WriteLine($"Hotel Name: {hotels.hotelName} , WeekDayRates : {hotels.weekDayRates} , WeekendRates : {hotels.weekendRates} , Rating : {hotels.hotelRatings}");
                    }
                }
                else if (customer.Equals("reward", StringComparison.InvariantCultureIgnoreCase))
                {
                    hotelList.Add(new Hotel("Lakewood", 80, 80, 3));
                    hotelList.Add(new Hotel("Bridgewood", 110, 50, 4));
                    hotelList.Add(new Hotel("Ridgewood", 100, 400, 5));

                    Console.WriteLine("Hotels for {0} customer added in List", customer);
                    foreach (Hotel hotels in hotelList)
                    {
                        Console.WriteLine($"Hotel Name: {hotels.hotelName} , WeekDayRates : {hotels.weekDayRates} , WeekendRates : {hotels.weekendRates} , Rating : {hotels.hotelRatings}");
                    }
                }
                else
                {
                    throw new HotelReservationCustomException(HotelReservationCustomException.ExceptionType.INVALID_CUSTOMER, "Customer is Invalid");
                }
            }
            catch(HotelReservationCustomException ex)
            {
                Console.WriteLine(ex.Message);
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
            try
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
                                total = total + hotels.weekendRates;
                            }
                            else
                            {
                                total = total + hotels.weekDayRates;
                            }
                        }
                        ratesAndHotelsList.Add(new Hotel(total, hotels.hotelName, hotels.hotelRatings));
                        Console.WriteLine($"Hotel : {hotels.hotelName} \tPrice : {total} \tRating : {hotels.hotelRatings}");
                    }
                }
                else
                {
                    throw new HotelReservationCustomException(HotelReservationCustomException.ExceptionType.INVALID_DATE, "Invalid Dates");
                }
            }
            catch(HotelReservationCustomException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        /// <summary>
        /// UC2
        /// Findings the cheapest hotel.
        /// </summary>
        /// <param name="checkInDate">The check in date.</param>
        /// <param name="checkOutDate">The check out date.</param>
        public void FindingCheapestHotelWithBestRating(DateTime checkInDate, DateTime checkOutDate)
        {
            CalculatingHotelPrices(checkInDate, checkOutDate);
            foreach (Hotel hotels in ratesAndHotelsList.OrderBy(r => r.totalPrice).ToList())
            {
                //printing the hotels with minimum rates
                if (hotels.totalPrice == ratesAndHotelsList.Min(r => r.totalPrice))
                {
                    //adding hotel with min prices in another list
                    hotellistWithMinPrices.Add(hotels);
                    Console.WriteLine($"Hotel Name : {hotels.hotelName} \nTotal Price : {hotels.totalPrice} \nRating : {hotels.hotelRatings}");
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

        /// <summary>
        /// Findings the hotel with best rating.
        /// </summary>
        /// <param name="checkInDate">The check in date.</param>
        /// <param name="checkOutDate">The check out date.</param>
        public void FindingHotelWithBestRating(DateTime checkInDate , DateTime checkOutDate)
        {
            CalculatingHotelPrices(checkInDate, checkOutDate);
            foreach (Hotel hotels in ratesAndHotelsList)
            {
                if (hotels.hotelRatings == ratesAndHotelsList.Max(r => r.hotelRatings))
                {
                    Console.WriteLine("----------------------------------BEST RATED HOTEL--------------------------");
                    Console.WriteLine($"Hotel Name : {hotels.hotelName} \nTotal Price : {hotels.totalPrice} \nRating : {hotels.hotelRatings}");
                    break;
                }
            }
        }
    }
}
