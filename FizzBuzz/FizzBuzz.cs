using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string Get(int num)
        {
            bool m3 = false;
            bool m5 = false;
            if (IsMultipleOf3(num))
            {
                m3 = true;
            }
            if (IsMultipleOf5(num))
            {
                m5 = true;
            }
            if (m3 && !m5)
                return "Fizz";
            else if (!m3 && m5)
                return "Buzz";
            else if (m3 && m5)
                return "FizzBuzz";
            else
                return num.ToString();
        }

        private bool IsMultipleOf3 (int numberToCheck)
        {
            return numberToCheck % 3 == 0;
        }
        private bool IsMultipleOf5(int numberToCheck)
        {
            return numberToCheck % 5 == 0;
        }
    }
}
