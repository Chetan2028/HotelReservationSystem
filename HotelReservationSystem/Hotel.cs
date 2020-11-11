﻿using System;
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

        /// <summary>
        /// Initializes a new instance of the <see cref="Hotel"/> class.
        /// </summary>
        /// <param name="hotelName">Name of the hotel.</param>
        /// <param name="weekDayRegularRates">The week day regular rates.</param>
        public Hotel(string hotelName , int weekDayRegularRates , int weekendRegularRates)
        {
            this.hotelName = hotelName;
            this.weekDayRegularRates = weekDayRegularRates;
            this.weekendRegularRates = weekendRegularRates;
        }
    }
}
