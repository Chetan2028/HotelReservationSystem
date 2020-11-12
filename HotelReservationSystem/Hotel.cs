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
        public int weekendRegularRates;
        public int hotelRatings;
        public int totalPrice;

        /// <summary>
        /// Initializes a new instance of the <see cref="Hotel"/> class.
        /// </summary>
        /// <param name="totalPrice">The total price.</param>
        /// <param name="weekDayRegularRates">The week day regular rates.</param>
        /// <param name="weekendRegularRates">The weekend regular rates.</param>
        public Hotel(int totalPrice, string hotelName , int hotelRatings)
        {
            this.totalPrice = totalPrice;
            this.hotelName = hotelName;
            this.hotelRatings = hotelRatings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Hotel"/> class.
        /// </summary>
        /// <param name="hotelName">Name of the hotel.</param>
        /// <param name="weekDayRegularRates">The week day regular rates.</param>
        /// <param name="weekendRegularRates">The weekend regular rates.</param>
        /// <param name="hotelRatings">The hotel ratings.</param>
        public Hotel(string hotelName , int weekDayRegularRates , int weekendRegularRates , int hotelRatings)
        {
            this.hotelName = hotelName;
            this.weekDayRegularRates = weekDayRegularRates;
            this.weekendRegularRates = weekendRegularRates;
            this.hotelRatings = hotelRatings;
        }
    }
}
