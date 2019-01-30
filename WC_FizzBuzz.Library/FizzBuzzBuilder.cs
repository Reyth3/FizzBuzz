using System;
using System.Collections.Generic;
using System.Text;

namespace WC_FizzBuzz.Library
{
    public class FizzBuzzBuilder
    {
        private int _rangeMin;
        private int _rangeMax;
        private List<IFizzBuzzCheck> _checks;

        public static FizzBuzzBuilder Create(int min = 1, int max = 100)
        {
            return new FizzBuzzBuilder()
            {
                _checks = new List<IFizzBuzzCheck>(),
                _rangeMin = min,
                _rangeMax = max
            };
        }

        public FizzBuzzBuilder WithDivisibleCheckFor(int divisible, string message)
        {
            _checks.Add(new FizzBuzzDivisibleCheck(divisible, message));
            return this;
        }

        public FizzBuzzBuilder WithFunctionCheckFor(Func<int, bool> condition, string message)
        {
            _checks.Add(new FizzBuzzFunctionCheck(condition, message));
            return this;
        }

        public FizzBuzz Build()
        {
            return new FizzBuzz(_rangeMin, _rangeMax, _checks);
        }
    }
}
