using System;
using TheArtOfUnitTesting.Example;

namespace TheArtOfUnitTesting
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                SimpleParserTests.TestReturnsZeroWhenEmptyString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}