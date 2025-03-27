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
            string answer;
            bool continuation;
            do
            {
                Console.WriteLine("Podaj liczbę");
                while (true)
                {
                    if (!int.TryParse(Console.ReadLine(), out int input))
                    {
                        Console.WriteLine("Podana wartość nie jest liczbą, Spróbuj ponownie");
                        continue;
                    }
                    var result = FizzBuzz.CheckNumber(input);
                    Console.WriteLine(result);
                    break;
                }
                Console.WriteLine("Wprowadź 'K' by zakończyć, lub inny znak by kontunuować");
                answer = Console.ReadLine();
                if (answer == "K")
                {
                    continuation = false;
                }
                else
                {
                    continuation = true;
                }

            } 
            while (continuation);

        }

    }
}
