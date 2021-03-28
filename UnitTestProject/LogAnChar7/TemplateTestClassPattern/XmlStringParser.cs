namespace UnitTestProject.LogAnChar7.TemplateTestClassPattern
{
    public interface IStringParser
    {
        string GetStringVersionFromHeader();
    }

    public class XmlStringParser : IStringParser
    {
        private string _header;

        public XmlStringParser(string header)
        {
            _header = header;
        }

        public string GetStringVersionFromHeader()
        {
            var indexOfStart = _header.IndexOf('>');
            var indexOfEnd = _header.LastIndexOf('<');
            var version = _header.Substring(indexOfStart + 1, indexOfEnd - indexOfStart - 1);
            return version;
        }
    }
}