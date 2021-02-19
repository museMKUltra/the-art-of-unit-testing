namespace UnitTestProject.LogAnChar3
{
    public class LogAnalyzerUsingFactoryMethodWithoutStub
    {
        public bool IsValidLogFileName6(string fileName)
        {
            return IsValid(fileName);
        }

        protected virtual bool IsValid(string fileName)
        {
            var manager = new FileExtensionManager();
            return manager.IsValid(fileName);
        }
    }

    public class TestableLogAnalyzerWithoutStub : LogAnalyzerUsingFactoryMethodWithoutStub
    {
        public bool IsSupported { get; set; }

        protected override bool IsValid(string fileName)
        {
            return IsSupported;
        }
    }
}