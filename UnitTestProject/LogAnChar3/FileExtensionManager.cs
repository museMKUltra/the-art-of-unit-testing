using System;

namespace UnitTestProject.LogAnChar3
{
    internal interface IFileExtensionManager
    {
        bool IsValid(string fileName);
    }

    class FileExtensionManager : IFileExtensionManager
    {
        public bool IsValid(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
                throw new ArgumentException("filename has to be provided");

            return fileName.EndsWith(".SLF", StringComparison.CurrentCultureIgnoreCase);
        }
    }

    class AlwaysValidFakeExtensionManager : IFileExtensionManager
    {
        public bool IsValid(string fileName)
        {
            return true;
        }
    }
}