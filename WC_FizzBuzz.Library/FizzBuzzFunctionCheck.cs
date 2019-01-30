using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WC_FizzBuzz.Library
{
    public class FizzBuzzFunctionCheck : IFizzBuzzCheck
    {
        public Func<int, bool> Condition { get; private set; }
        public string Message { get; private set; }

        public FizzBuzzFunctionCheck(Func<int, bool> condition, string message)
        {
            Condition = condition;
            Message = message;
        }

        public bool ExecuteFor(int n)
        {
            return Condition(n);
        }
    }
}
