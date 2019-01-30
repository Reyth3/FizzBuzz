using System;
using System.Collections.Generic;
using System.Text;

namespace WC_FizzBuzz.Library
{
    public class FizzBuzz
    {
        public int Minimum { get; private set; }
        public int Maximum { get; private set; }
        public string LastResult { get; set; }
        public IList<IFizzBuzzCheck> Checks { get; private set; }

        private StringBuilder _stringBuilder;
        
        public FizzBuzz(int min, int max, IList<IFizzBuzzCheck> checks)
        {
            Minimum = min;
            Maximum = max;
            Checks = checks;
            _stringBuilder = new StringBuilder();
        }

        public string SolveFizzBuzz()
        {
            _stringBuilder.Clear();
            for (int i = Minimum; i <= Maximum; i++)
                SolveFizzBuzzFor(i);
            LastResult = _stringBuilder.ToString();
            return LastResult;
        }


        void SolveFizzBuzzFor(int n)
        {
            var specialCase = false;
            if (n == 0)
            {
                _stringBuilder.AppendLine("0");
                return;
            }
            foreach(var check in Checks)
                if(check.ExecuteFor(n))
                {
                    _stringBuilder.Append(check.Message);
                    specialCase = true;
                }

            if (specialCase)
                _stringBuilder.Append($" ({n})");
            else _stringBuilder.Append(n);
            _stringBuilder.AppendLine();
        }

    }
}
