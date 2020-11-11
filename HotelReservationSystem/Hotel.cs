using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public class Hotel
    {
        //Variables
        public string hotelName;
        public int weekDayRegularRates;

        /// <summary>
        /// Initializes a new instance of the <see cref="Hotel"/> class.
        /// </summary>
        /// <param name="hotelName">Name of the hotel.</param>
        /// <param name="weekDayRegularRates">The week day regular rates.</param>
        public Hotel(string hotelName , int weekDayRegularRates)
        {
            this.hotelName = hotelName;
            this.weekDayRegularRates = weekDayRegularRates;
        }
    }
}
