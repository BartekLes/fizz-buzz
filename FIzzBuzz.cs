using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class FizzBuzz
    {
        public string CheckNumber()
        {
            var number = GetNumber();
            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else (number % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else (number % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(number);
            }
        }
        private int GetNumber()
        {
            Console.WriteLine("Podaj liczbę")
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
