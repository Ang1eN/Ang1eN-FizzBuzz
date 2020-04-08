using System.Linq;
using FizzBuzzCmdLine;
using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzEvaluatorTests
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(6, "fizz")]
        [InlineData(3, "lucky")]
        [InlineData(15, "fizzbuzz")]
        [InlineData(10, "buzz")]
        public void GivenANumber_WhenEvaluated_ThenOutputShouldBEAsExpected(int number, string expected)
        {
            // arrange
            var target = new FizzBuzzEvaluator();

            // act
            var actual = target.Evaluate(number);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenAMultipleOf3ButContains3_WhenEvaluated_ThenTheOutputIsLucky()
        {
            // arrange
            var target = new FizzBuzzEvaluator();
            var testNumbers = Enumerable.Range(1, 100)
                .Select(x => x * 3)
                .Where(multiple => multiple.ToString().Contains('3'));

            // act
            foreach (var testNumber in testNumbers)
            {
                // assert
                Assert.Equal("lucky", target.Evaluate(testNumber));
            }
        }
    }
}

