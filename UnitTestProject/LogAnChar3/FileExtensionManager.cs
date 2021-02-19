using System;

namespace UnitTestProject.LogAnChar3
{
    public interface IFileExtensionManager
    {
        bool IsValid(string fileName);
    }

    public class FileExtensionManager : IFileExtensionManager
    {
        public bool IsValid(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
                throw new ArgumentException("filename has to be provided");

            return fileName.EndsWith(".SLF", StringComparison.CurrentCultureIgnoreCase);
        }
    }

    class FakeFileExtensionManager : IFileExtensionManager
    {
        public bool WillBeValid = false;

        public bool IsValid(string fileName)
        {
            return WillBeValid;
        }
    }
}