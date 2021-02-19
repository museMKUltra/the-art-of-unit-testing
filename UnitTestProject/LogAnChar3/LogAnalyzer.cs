namespace UnitTestProject.LogAnChar3
{

    public class LogAnalyzer
    {
        private IFileExtensionManager _manager;

        public LogAnalyzer(IFileExtensionManager manager)
        {
            _manager = manager;
        }
        public bool IsValidLogFileName(string fileName)
        {
            return _manager.IsValid(fileName);
        }
    }
}