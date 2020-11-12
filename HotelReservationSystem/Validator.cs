using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace HotelReservationSystem
{
    class Validator
    {
        //constants
        public const string REGEX_DATE_FORMAT = "^[0-9]{1,2}[/]{1}[0-9]{1,2}[/]{1}[0-9]{4}$";

        //public bool ValidateDateFormat(string date)
        //{
        //    try
        //    {
        //        if (Regex.IsMatch(date,REGEX_DATE_FORMAT))
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            throw new HotelReservationCustomException(HotelReservationCustomException.ExceptionType.INVALID_DATE_FORMAT, "Invalid Date Format");
        //        }
        //    }
        //    catch(HotelReservationCustomException ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}
    }
}
