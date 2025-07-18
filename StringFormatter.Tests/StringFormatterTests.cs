using Xunit;
using PointsBet_Backend_Online_Code_Test;

namespace StringFormatter.Tests
{
    public class StringFormatterTests
    {
        [Fact]
        public void ReturnsCommaSeparatedQuotedStrings_GivenValidInput()
        {
            var result = StringFormatter.ToCommaSeparatedList(new[] { "apple", "banana", "cherry" }, "\"");
            Assert.Equal("\"apple\", \"banana\", \"cherry\"", result);
        }

        [Fact]
        public void ReturnsSingleQuotedString_GivenSingleItem()
        {
            var result = StringFormatter.ToCommaSeparatedList(new[] { "apple" }, "'");
            Assert.Equal("'apple'", result);
        }

        [Fact]
        public void ReturnsEmptyString_GivenEmptyArray()
        {
            var result = StringFormatter.ToCommaSeparatedList(new string[] { }, "\"");
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void ReturnsEmptyString_GivenNullInput()
        {
            var result = StringFormatter.ToCommaSeparatedList(null, "'");
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void WorksWithEmptyQuoteCharacter()
        {
            var result = StringFormatter.ToCommaSeparatedList(new[] { "one", "two" }, "");
            Assert.Equal("one, two", result);
        }

        [Fact]
        public void WorksWithCustomQuoteCharacters()
        {
            var result = StringFormatter.ToCommaSeparatedList(new[] { "a", "b" }, "**");
            Assert.Equal("**a**, **b**", result);
        }
    }
}
