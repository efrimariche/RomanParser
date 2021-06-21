using RomanParserConsole;
using RomanParserCore.Interface;
using System.Diagnostics.CodeAnalysis;
using Xunit;
using Moq;
using System;

namespace RomanParserTests
{
    [ExcludeFromCodeCoverage]
    public class RomanParserServiceTests
    {
        [Fact]
        public void Should_RomanStringParser_ThrowException_When_EmptyTest()
        {
            var serviceMock = new Mock<IRomanParserBusiness>();
            serviceMock.Setup(x => x.RomanStringParser(It.IsAny<string>())).Throws<ArgumentException>();
            var service = new RomanParserService(serviceMock.Object);
            Assert.Throws<ArgumentException>(() => service.RomanParser(string.Empty));
        }

        [Fact]
        public void Should_RomanStringParser_ThrowException_When_nullTest()
        {
            var serviceMock = new Mock<IRomanParserBusiness>();
            serviceMock.Setup(x => x.RomanStringParser(It.IsAny<string>())).Throws<ArgumentException>();
            var service = new RomanParserService(serviceMock.Object);
            Assert.Throws<ArgumentException>(() => service.RomanParser(null));
        }

        [Fact]
        public void Should_RomanStringParser_Return_Result_When_Not_EmptyTest()
        {
            var serviceMock = new Mock<IRomanParserBusiness>();
            serviceMock.Setup(x => x.RomanStringParser(It.IsAny<string>())).Returns(1005);
            var service = new RomanParserService(serviceMock.Object);
            var result = service.RomanParser("MV");
            Assert.Equal(1005, result);
            
        }



    }
}
