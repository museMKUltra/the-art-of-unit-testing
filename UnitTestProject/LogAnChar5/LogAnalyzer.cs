namespace UnitTestProject.LogAnChar5
{
    public class LogAnalyzer
    {
        private IWebService _service;
        public int MinNameLength { get; set; }

        public LogAnalyzer(IWebService service)
        {
            _service = service;
        }

        public void Analyze(string fileName)
        {
            if (fileName.Length < MinNameLength)
            {
                _service.LogError("Filename too short:" + fileName);
            }
        }
    }
}