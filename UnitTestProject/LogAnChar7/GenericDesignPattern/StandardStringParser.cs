namespace UnitTestProject.LogAnChar7.GenericDesignPattern
{
    public interface IStringParser
    {
        string GetStringVersionFromHeader();
    }

    public class StandardStringParser : IStringParser
    {
        private string _header;

        public StandardStringParser(string header)
        {
            _header = header;
        }

        public string GetStringVersionFromHeader()
        {
            var indexOfStart = _header.IndexOf('=');
            var indexOfEnd = _header.LastIndexOf(';');
            var version = _header.Substring(indexOfStart + 1, indexOfEnd - indexOfStart - 1);
            return version;
        }
    }
}