namespace UnitTestProject.LogAnChar3
{
    public class LogAnalyzer
    {
        private IFileExtensionManager _manager;
        public IFileExtensionManager Manager { get; set; }

        public LogAnalyzer(IFileExtensionManager manager = null)
        {
            _manager = manager ?? new FileExtensionManager();
            Manager = new FileExtensionManager();
        }

        public bool IsValidLogFileName(string fileName)
        {
            return _manager.IsValid(fileName);
        }

        public bool IsValidLogFileName2(string fileName)
        {
            return Manager.IsValid(fileName);
        }

        public bool IsValidLogFileName3(string fileName, IFileExtensionManager manager)
        {
            return manager.IsValid(fileName);
        }
    }
}