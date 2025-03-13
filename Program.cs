using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var FizzBuzz = new FizzBuzz();
            var result = FizzBuzz.CheckNumber();
            Console.WriteLine(result);
        }
    }
}
