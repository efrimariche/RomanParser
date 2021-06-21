using RomanParserCore.Interface;
using System;
using System.Globalization;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("RomanParserTests")]
namespace RomanParserCore
{
    public class RomanParserBusiness : IRomanParserBusiness
    {
        public int RomanStringParser(string roman)
        {
            if(string.IsNullOrEmpty(roman))
            {
                throw new ArgumentException("Invalid input character");
            }
            roman = roman.ToUpper(new CultureInfo("fr-FR"));

            var result = 0;

            foreach (var letter in roman)
            {
                result += RomanCharParser(letter);
            }

            if (roman.Contains("IV") || roman.Contains("IX"))
            {
                result -= 2;
            }

            if (roman.Contains("XL") || roman.Contains("XC"))
            {
                result -= 20;
            }

            if (roman.Contains("CD") || roman.Contains("CM"))
            {
                result -= 200;
            }

            return result;
        }

        internal int RomanCharParser(char letter)
        {
            switch (letter)
            {
                case 'I':
                    {
                        return 1;
                    }

                case 'V':
                    {
                        return 5;
                    }

                case 'X':
                    {
                        return 10;
                    }

                case 'L':
                    {
                        return 50;
                    }

                case 'C':
                    {
                        return 100;
                    }

                case 'D':
                    {
                        return 500;
                    }

                case 'M':
                    {
                        return 1000;
                    }

                default:
                    {
                        throw new ArgumentException("Invalid input character");
                    }
            }

        }
    }

}