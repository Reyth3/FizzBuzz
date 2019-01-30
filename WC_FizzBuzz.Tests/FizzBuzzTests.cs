using NUnit.Framework;
using System;
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
        public void BasicTest()
        {
            var game = FizzBuzzBuilder.Create().WithDivisibleCheckFor(3, "Fizz").WithDivisibleCheckFor(5, "Buzz").Build();
            game.SolveFizzBuzz();
            Assert.Pass(game.LastResult);
        }

        [Test]
        public void NegativeBasicTest()
        {
            var game = FizzBuzzBuilder.Create(-150, 150).WithDivisibleCheckFor(3, "Fizz").WithDivisibleCheckFor(5, "Buzz").Build();
            game.SolveFizzBuzz();
            Assert.Pass(game.LastResult);
        }

        [Test]
        public void NegativeBonusTest()
        {
            var game = FizzBuzzBuilder.Create(-150, 150)
                .WithDivisibleCheckFor(3, "Fizz")
                .WithDivisibleCheckFor(5, "Buzz")
                .WithDivisibleCheckFor(7, "Jazz")
                .Build();
            game.SolveFizzBuzz();
            Assert.Pass(game.LastResult);
        }

        [Test]
        public void ExtendedBonusTest()
        {
            var game = FizzBuzzBuilder.Create(-1000, 1000)
                .WithDivisibleCheckFor(3, "Fizz")
                .WithDivisibleCheckFor(5, "Buzz")
                .WithDivisibleCheckFor(7, "Jazz")
                .WithDivisibleCheckFor(11, "Razz")
                .WithDivisibleCheckFor(13, "Guzz")
                .Build();
            game.SolveFizzBuzz();
            Assert.Pass(game.LastResult);
        }

        [Test]
        public void MassiveTest()
        {
            var game = FizzBuzzBuilder.Create(-920000, 920000)
                .WithDivisibleCheckFor(3, "Fizz")
                .WithDivisibleCheckFor(5, "Buzz")
                .WithDivisibleCheckFor(7, "Jazz")
                .WithDivisibleCheckFor(11, "Razz")
                .WithDivisibleCheckFor(13, "Guzz")
                .WithDivisibleCheckFor(17, "Wuzz")
                .WithDivisibleCheckFor(19, "Mizz")
                .WithDivisibleCheckFor(23, "Jizz")
                .WithDivisibleCheckFor(29, "Shizz")
                .WithFunctionCheckFor((n) => {
                    if (n > -10 && n < 10)
                        return false;
                    var str = n.ToString();
                    int b = 0, e = 0;
                    for (int i = 0; i < str.Length; i++)
                    {
                        b = i;
                        e = str.Length - 1 - i;
                        if (b > e)
                            return true;
                        if (str[b] != str[e])
                            return false;
                    }
                    return false;
                }, "Quizz")
                .Build();
            game.SolveFizzBuzz();
            Assert.Pass(game.LastResult);
        }
    }
}