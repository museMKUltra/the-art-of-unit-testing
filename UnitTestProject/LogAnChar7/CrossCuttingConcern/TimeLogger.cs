using System;

namespace UnitTestProject.LogAnChar7.CrossCuttingConcern
{
    public class TimeLogger
    {
        public static string CreateMessage(string info)
        {
            // return DateTime.Now.ToShortDateString() + " " + info;
            return SystemTime.Now.ToShortDateString() + " " + info;
        }
    }
}