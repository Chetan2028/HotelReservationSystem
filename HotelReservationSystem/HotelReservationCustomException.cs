using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public class HotelReservationCustomException : Exception
    {
        public enum ExceptionType
        {
            INVALID_CUSTOMER, INVALID_DATE
        }

        public ExceptionType type;

        public HotelReservationCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
