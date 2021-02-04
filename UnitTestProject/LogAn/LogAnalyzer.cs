using System;

namespace UnitTestProject.LogAn
{
    public class LogAnalyzer
    {
        public bool IsValidLogFileName(string fileName)
        {
            return fileName.EndsWith(".SLF", StringComparison.CurrentCultureIgnoreCase);
        }
    }
}