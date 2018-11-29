using FizzBuzz_C_;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace FizzBuzz_C__tests
{
    public class FizzBuzzTests
    {

        [Fact]
        public void DivisibleByThreeReturnsFizz()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                FizzBuzz.DivisibleByThree(3);

                string expected = string.Format("Fizz{0}", Environment.NewLine);
                Assert.Equal(expected, sw.ToString());
            }
        }

        [Fact]
        public void DivisibleByFiveReturnsBuzz()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                FizzBuzz.DivisibleByFive(5);

                string expected = string.Format("Buzz{0}", Environment.NewLine);
                Assert.Equal(expected, sw.ToString());

            }
        }

        [Fact]
        public void DivisibleByFifteenReturnsFizzBuzz()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                FizzBuzz.DivisibleByFifteen(15);

                string expected = string.Format("FizzBuzz{0}", Environment.NewLine);
                Assert.Equal(expected, sw.ToString());
            }
        }

    }
}
