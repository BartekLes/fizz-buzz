﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class FizzBuzz
    {
        public string CheckNumber(int number)
        {
            string result;

            if (number % 3 == 0 && number % 5 == 0)
            {
                result = "FizzBuzz";
            }
            else if (number % 3 == 0)
            {
                result = "Fizz";
            }
            else if (number % 5 == 0)
            {
                result = "Buzz";
            }
            else
            {
                result = number.ToString();
            }
            return result;
        }
    }
}
