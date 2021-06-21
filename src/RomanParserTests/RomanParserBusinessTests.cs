using RomanParserCore;
using System;
using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace RomanParserTests
{
    [ExcludeFromCodeCoverage]
    public class RomanParserBusinessTests
    {

        [Fact]
        public void Should_RomanStringParser_ThrowException_When_EmptyTest()
        {
            var service = new RomanParserBusiness();
            Assert.Throws<ArgumentException>(() => service.RomanStringParser(string.Empty));
        }

        [Fact]
        public void Should_RomanStringParser_ThrowException_When_NullTest()
        {
            var service = new RomanParserBusiness();
            Assert.Throws<ArgumentException>(() => service.RomanStringParser(null));
        }

        [Fact]
        public void Should_Return_Total_When_No_SpecificalCharacterTest()
        {
            var service = new RomanParserBusiness();
            var result = service.RomanStringParser("XVIII");
            Assert.Equal(18, result);
        }

        [Theory]
        [InlineData("IV", 4)]
        [InlineData("IX", 9)]
        [InlineData("XL", 40)]
        [InlineData("XC", 90)]
        [InlineData("CD", 400)]
        [InlineData("CM", 900)]
        public void Should_Return_correct_Result_When_specifics_CharacterTest(string item, int soustract)
        {
            var service = new RomanParserBusiness();
            var expected = $"M{item}";
            var result = service.RomanStringParser(expected);
            Assert.Equal(1000 + soustract, result);
        }

        [Fact]
        public void Should_Return_correct_Result_When_IV_CharacterTest()
        {
            var service = new RomanParserBusiness();
            var expected = $"MXL";
            var result = service.RomanStringParser(expected);
            Assert.Equal(1040, result);
        }

        [Fact]
        public void Should_Return_correct_Result_When_IX_CharacterTest()
        {
            var service = new RomanParserBusiness();
            var expected = $"MXL";
            var result = service.RomanStringParser(expected);
            Assert.Equal(1040, result);
        }

        [Fact]
        public void Should_Return_correct_Result_When_XL_CharacterTest()
        {
            var service = new RomanParserBusiness();
            var expected = $"MXL";
            var result = service.RomanStringParser(expected);
            Assert.Equal(1040, result);
        }

        [Fact]
        public void Should_Return_correct_Result_When_XC_CharacterTest()
        {
            var service = new RomanParserBusiness();
            var expected = $"MXL";
            var result = service.RomanStringParser(expected);
            Assert.Equal(1040, result);
        }

        [Fact]
        public void Should_Return_correct_Result_When_CD_CharacterTest()
        {
            var service = new RomanParserBusiness();
            var expected = $"MXL";
            var result = service.RomanStringParser(expected);
            Assert.Equal(1040, result);
        }

        [Fact]
        public void Should_Return_correct_Result_When_CM_CharacterTest()
        {
            var service = new RomanParserBusiness();
            var expected = $"MXL";
            var result = service.RomanStringParser(expected);
            Assert.Equal(1040, result);
        }


        [Theory]
        [InlineData('I', 1)]
        [InlineData('V', 5)]
        [InlineData('X', 10)]
        [InlineData('L', 50)]
        [InlineData('C', 100)]
        [InlineData('D', 500)]
        [InlineData('M', 1000)]
        public void Should_Return_Correct_Integer_WhenParse_CharTest(char character, int expected)
        {
            var service = new RomanParserBusiness();        
            var result = service.RomanCharParser(character);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Should_RomanChargParser_ThrowException_When_unknown_Test()
        {
            var service = new RomanParserBusiness();
            Assert.Throws<ArgumentException>(() => service.RomanCharParser('F'));
        }
    }
}