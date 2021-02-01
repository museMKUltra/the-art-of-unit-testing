using System;
using System.Reflection;

namespace TheArtOfUnitTesting.Example
{
    public class SimpleParserTests
    {
        public static void TestReturnsZeroWhenEmptyString()
        {
            var testName = MethodBase.GetCurrentMethod().Name;
            try
            {
                var parser = new SimpleParser();
                var result = parser.ParseAndSum(string.Empty);
                if (result != 0)
                {
                    TestUtil.ShowProblem(testName, "Parse and sum should have returned 0 on an empty string");
                }
                else
                {
                    TestUtil.ShowInfo(testName, "success");
                }
            }
            catch (Exception e)
            {
                TestUtil.ShowProblem(testName, e.ToString());
                throw;
            }
        }
    }
}