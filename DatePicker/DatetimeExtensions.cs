﻿using System;
using System.Globalization;

namespace ExtensionsMethod
{
    public static class DateTimeExtensions
    {
        public static DateTime? ConvertToDate(this string input)
        {
            try
            {
                var startDateYear = input.Split('/')[0];
                var startDateMonth = input.Split('/')[1];
                var startDateDay = input.Split('/')[2];
                return new DateTime(int.Parse(startDateYear), int.Parse(startDateMonth), int.Parse(startDateDay),
                    new PersianCalendar());
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}