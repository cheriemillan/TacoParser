using System;
using Microsoft.VisualBasic.CompilerServices;
using Xunit;


namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        // Test to ensure the Parse method returns a non-null object
        [Fact]
        public void ShouldReturnNonNullObject()
        {
            //Arrange: Create an instance of TacoParser
            var tacoParser = new TacoParser();

            //Act: Parse a sample input string
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert: Check that the result is not null
            Assert.NotNull(actual);

        }
        // Test to verify that longitude is correctly parsed from the input string
        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("32.92496,-85.961342,Taco Bell Alexander Cit...", -85.961342)]
        [InlineData("34.176666,-84.420356,Taco Bell Canto...", -84.420356)]
        [InlineData("33.810924,-86.820487,Taco Bell Warrio...", -86.820487)]
        [InlineData("34.272015,-85.229599,Taco Bell Rome...", -85.229599)]
        [InlineData("33.9268,-84.174881,Taco Bell Norcros...", -84.174881)]

        //Referred to my CSV file.
        public void ShouldParseLongitude(string line, double expected)
        {

            // Arrange: Create an instance of TacoParser
            var tacoParser = new TacoParser();

            //Act: Parse the input string and get the result
            var actual = tacoParser.Parse(line);

            //Assert: Verify that the parsed longitude matches the expected value
            Assert.Equal(expected, actual.Location.Longitude);
        }

        // Test to verify that latitude is correctly parsed from the input string
        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        [InlineData("32.92496,-85.961342,Taco Bell Alexander Cit...", 32.92496)]
        [InlineData("34.176666,-84.420356,Taco Bell Canto...", 34.176666)]
        [InlineData("33.810924,-86.820487,Taco Bell Warrio...", 33.810924)]
        [InlineData("34.272015,-85.229599,Taco Bell Rome...", 34.272015)]
        [InlineData("33.9268,-84.174881,Taco Bell Norcros...", 33.9268)]
        public void ShouldParseLatitude(string line, double expected)
        {
            // Arrange: Create an instance of TacoParser
            var tacoParser = new TacoParser();

            // Act: Parse the input string and get the result
            var actual = tacoParser.Parse(line);

            // Assert: Verify that the parsed latitude matches the expected value
            Assert.Equal(expected, actual.Location.Latitude);
        }

    }
}
