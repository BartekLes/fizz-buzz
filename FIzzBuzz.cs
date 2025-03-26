using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class FizzBuzz
    {
    string result;
        public string CheckNumber()
        {
            var number = GetNumber();
            

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
        private int GetNumber()
        {
            Console.WriteLine("Podaj liczbę");
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int input))
                {
                    Console.WriteLine("Podana wartość nie jest liczbą, Spróbuj ponownie");
                    continue;
                }

                return input;
            }
        }

    }
}
