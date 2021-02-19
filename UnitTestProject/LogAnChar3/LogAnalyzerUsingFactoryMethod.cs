namespace UnitTestProject.LogAnChar3
{
    public class LogAnalyzerUsingFactoryMethod
    {
        public bool IsValidLogFileName5(string fileName)
        {
            return GetManager().IsValid(fileName);
        }

        protected virtual IFileExtensionManager GetManager()
        {
            return new FileExtensionManager();
        }
    }

    public class TestableLogAnalyzer : LogAnalyzerUsingFactoryMethod
    {
        public IFileExtensionManager Manager;

        public TestableLogAnalyzer(IFileExtensionManager manager)
        {
            Manager = manager;
        }

        protected override IFileExtensionManager GetManager()
        {
            return Manager;
        }
    }
}