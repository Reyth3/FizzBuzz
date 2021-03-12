using NUnit.Framework;
using System;
using System.Text;
using WC_FizzBuzz.Library;

namespace Tests
{
    public class FizzBuzz
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FizzBuzz_OneToFifteen_BasicDivisibleCheck()
        {
            var game = FizzBuzzBuilder.Create(1, 15).WithDivisibleCheckFor(3, "Fizz").WithDivisibleCheckFor(5, "Buzz").Build();
            var sb = new StringBuilder();
            sb.AppendLine("1");
            sb.AppendLine("2");
            sb.AppendLine("Fizz (3)");
            sb.AppendLine("4");
            sb.AppendLine("Buzz (5)");
            sb.AppendLine("Fizz (6)");
            sb.AppendLine("7");
            sb.AppendLine("8");
            sb.AppendLine("Fizz (9)");
            sb.AppendLine("Buzz (10)");
            sb.AppendLine("11");
            sb.AppendLine("Fizz (12)");
            sb.AppendLine("13");
            sb.AppendLine("14");
            sb.AppendLine("FizzBuzz (15)");
            var expected = sb.ToString();
            game.SolveFizzBuzz();
            
            Assert.AreEqual(expected, game.LastResult);
        }

        [Test]
        public void FizzBuzz_ZeroToFifteen_BasicDivisibleCheck_ShouldPrintZeroProperly()
        {
            var game = FizzBuzzBuilder.Create(0, 15).WithDivisibleCheckFor(3, "Fizz").WithDivisibleCheckFor(5, "Buzz").Build();
            var sb = new StringBuilder();
            sb.AppendLine("0");
            sb.AppendLine("1");
            sb.AppendLine("2");
            sb.AppendLine("Fizz (3)");
            sb.AppendLine("4");
            sb.AppendLine("Buzz (5)");
            sb.AppendLine("Fizz (6)");
            sb.AppendLine("7");
            sb.AppendLine("8");
            sb.AppendLine("Fizz (9)");
            sb.AppendLine("Buzz (10)");
            sb.AppendLine("11");
            sb.AppendLine("Fizz (12)");
            sb.AppendLine("13");
            sb.AppendLine("14");
            sb.AppendLine("FizzBuzz (15)");
            var expected = sb.ToString();
            game.SolveFizzBuzz();

            Assert.AreEqual(expected, game.LastResult);
        }

    }
}