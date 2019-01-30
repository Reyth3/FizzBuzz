using System;
using System.Collections.Generic;
using System.Text;

namespace WC_FizzBuzz.Library
{
    public class FizzBuzzDivisibleCheck : IFizzBuzzCheck
    {
        public int DivisibleNumber { get; private set; }
        public string Message { get; private set; }
        
        public FizzBuzzDivisibleCheck(int divisible, string message)
        {
            DivisibleNumber = divisible;
            Message = message;
        }

        public bool ExecuteFor(int n)
        {
            if (n % DivisibleNumber == 0)
                return true;
            return false;
        }
    }
}
