using RomanParserCore.Interface;

namespace RomanParserConsole
{
    public class RomanParserService : IRomanParserService
    {
        private readonly IRomanParserBusiness _romanParser;

        public RomanParserService(IRomanParserBusiness romanParser)
        {
            _romanParser = romanParser;
        }

        public int RomanParser(string roman)
        {
          return  _romanParser.RomanStringParser(roman);
        }
    }
}
