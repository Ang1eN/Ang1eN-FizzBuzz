using FizzBuzzCmdLine;
using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzResultTrackerTests
    {
        [Theory]
        [InlineData(new [] { "1", "2", "fizz", "4", "buzz" }, "fizz: 1 buzz: 1 integer: 3")]
        [InlineData(new [] { "1", "2", "fizz", "fizz", "buzz", "fizzbuzz", "fizzbuzz", "lucky" }, "fizz: 2 buzz: 1 fizzbuzz: 2 lucky: 1 integer: 2")]
        public void GivenMyCounterIsSetUp_WhenTheEvaluationResultsAreTracked_ThenMyReportWouldBeAsExpected(
            string[] results,
            string expectedReport)
        {
            // arrange
            var target = new FizzBuzzResultTracker();

            foreach (var result in results)
            {
                target.TrackResult(result);
            }

            // act
            var actual = target.PublishResult();

            // assert
            Assert.Equal(expectedReport, actual);
        }
    }
}
