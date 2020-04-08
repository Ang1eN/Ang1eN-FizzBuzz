using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzCmdLine;
using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzOutputTests
    {
        [Fact]
        public void GivenTheNumbers1To20_WhenFizzBuzzIsProcessed_ThenResultIsAsExpected()
        {
            // arrange
            var target = new FizzBuzzOutput();
            var expected =
                "1 2 lucky 4 buzz fizz 7 8 fizz buzz 11 fizz lucky 14 fizzbuzz 16 17 fizz 19 buzz fizz: 4 buzz: 3 fizzbuzz: 1 lucky: 2 integer: 10";

            // act
            var actual = target.ProcessFizzBuzz(1, 20);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
