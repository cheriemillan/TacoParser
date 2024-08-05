using System;
using Microsoft.VisualBasic.CompilerServices;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldReturnNonNullObject()
        {
            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("32.92496,-85.961342,Taco Bell Alexander Cit...", -85.961342)]
        [InlineData("34.176666,-84.420356,Taco Bell Canto...", -84.420356)]
        [InlineData("33.810924,-86.820487,Taco Bell Warrio...", -86.820487)]
        [InlineData("34.272015,-85.229599,Taco Bell Rome...", -85.229599)]
        [InlineData("33.9268,-84.174881,Taco Bell Norcros...", -84.174881)]

        //Add additional inline data. Refer to your CSV file.
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete the test with Arrange, Act, Assert steps below.
            //       Note: "line" string represents input data we will Parse 
            //       to extract the Longitude.  
            //       Each "line" from your .csv file
            //       represents a TacoBell location

            //Arrange

            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse(line);

            //Assert
            Assert.Equal(expected, actual.Location.Longitude);
        }


        //TODO: Create a test called ShouldParseLatitude
        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        [InlineData("32.92496,-85.961342,Taco Bell Alexander Cit...", 32.92496)]
        [InlineData("34.176666,-84.420356,Taco Bell Canto...", 34.176666)]
        [InlineData("33.810924,-86.820487,Taco Bell Warrio...", 33.810924)]
        [InlineData("34.272015,-85.229599,Taco Bell Rome...", 34.272015)]
        [InlineData("33.9268,-84.174881,Taco Bell Norcros...", 33.9268)]
        public void ShouldParseLatitude(string line, double expected)
        {
            //Arrange

            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse(line);

            //Assert
            Assert.Equal(expected, actual.Location.Latitude);
        }

    }
}
