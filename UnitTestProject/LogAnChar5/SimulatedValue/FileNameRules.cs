using System;

namespace UnitTestProject.LogAnChar5.SimulatedValue
{
    public interface IFileNameRules
    {
        bool IsValidLogFileName(string fileName);
    }

    public class FileNameRules : IFileNameRules
    {
        public bool IsValidLogFileName(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
                throw new ArgumentException("filename has to be provided");

            return fileName.EndsWith(".txt", StringComparison.CurrentCultureIgnoreCase);
        }
    }
}