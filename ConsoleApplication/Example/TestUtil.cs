using System;

namespace TheArtOfUnitTesting.Example
{
    public static class TestUtil
    {
        public static void ShowInfo(string test, string message)
        {
            Console.WriteLine(@"{0} {1}", test, message);
        }

        public static void ShowProblem(string test, string message)
        {
            string msg = string.Format(@"
---{0}---
     {1}
-----------------", test, message);
            Console.WriteLine(msg);
        }
    }
}