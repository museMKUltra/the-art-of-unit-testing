namespace UnitTestProject.LogAnChar3
{
    static class FileExtensionManagerFactory
    {
        private static IFileExtensionManager _customManager = null;

        public static IFileExtensionManager Create()
        {
            return _customManager ?? new FileExtensionManager();
        }

        public static void SetManager(FakeFileExtensionManager manager)
        {
            _customManager = manager;
        }
    }
}