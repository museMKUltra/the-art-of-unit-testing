using System;

namespace UnitTestProject.LogAnChar7.CrossCuttingConcern
{
    class SystemTime
    {
        private static DateTime _date;

        public static DateTime Now => _date != DateTime.MinValue ? _date : DateTime.Now;

        public static void Set(DateTime custom)
        {
            _date = custom;
        }

        public static void Reset()
        {
            _date = DateTime.MinValue;
        }
    }
}