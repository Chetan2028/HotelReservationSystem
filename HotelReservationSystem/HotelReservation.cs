using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    class HotelReservation
    {
        /// <summary>
        /// UC1
        /// Adds the hotels.
        /// </summary>
        public void AddHotels()
        {
            List<Hotel> hotelList = new List<Hotel>();
            hotelList.Add(new Hotel("Lakewood", 110));
            hotelList.Add(new Hotel("Bridgewood", 160));
            hotelList.Add(new Hotel("Ridgewood", 220));

            Console.WriteLine("Hotels are added in List");
            foreach (Hotel hotels in hotelList)
            {
                Console.WriteLine(hotels.hotelName + "      :    " + hotels.weekDayRegularRates);
            }
        }
    }
}
