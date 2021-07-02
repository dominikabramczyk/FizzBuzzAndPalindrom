using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        private static bool CheckPalindrom(string text) //funkcja sprawdza czy dany wyraz/zdanie jesy palindromem
        {
            if (string.IsNullOrWhiteSpace(text))
                return false;

            text = text.Replace(" ", "").ToLower();

            return text == new string(text.ToCharArray().Reverse().ToArray());

        }

        private static void Solution() // Funkcja wywołuje funkcję, która wypisuje liczby od 1 do 100 i zamiast liczby jeśli jesy podzielna przez 3 wyspisuje Fizz, jeśli jest podzielna przez 5 wypizuje Buzz, a jeśli przez 15 to FizzBuzz
        {
            Enumerable.Range(1, 100).Select(x =>
             {
                 var str = "";
                 if (x % 3 == 0)
                     str += "Fizz";
                 if (x % 5 == 0)
                     str += "Buzz";
                 if (str == "")
                     str = x.ToString();
                 return str;
             }).ToList().ForEach(Console.WriteLine);
        }

        static void Main(string[] args)
        {
            Solution(); 

            string[] array = { "   ", "deska", "Ala", "ala", "Kobyła ma mały bok" };
            foreach (var item in array)
            {
                Console.WriteLine("{0} = {1}",item, CheckPalindrom(item));
            }
            

        }
    }
}
