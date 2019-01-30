using System;
using System.Diagnostics;
using System.Text;
using WC_FizzBuzz.Library;

namespace WC_FizzBuzz
{
    class Program
    {
        static FizzBuzz game;

        static void Main(string[] args)
        {
            game = FizzBuzzBuilder.Create(-500, 500)
                .WithDivisibleCheckFor(3, "Fizz")
                .WithDivisibleCheckFor(5, "Buzz")
                .WithDivisibleCheckFor(7, "Jazz")
                .WithDivisibleCheckFor(11, "Guzz")
                .WithDivisibleCheckFor(13, "Razz")
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

            var sw = Stopwatch.StartNew();
            game.SolveFizzBuzz();
            sw.Stop();
            Console.WriteLine(game.LastResult);
            Console.WriteLine($"Elapsed: {sw.ElapsedMilliseconds}ms");
            Console.ReadLine();
        }
    }
}
