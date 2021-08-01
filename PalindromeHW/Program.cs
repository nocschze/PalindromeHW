using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir kelime giriniz (c: Cıkıs): ");
            string kelime = Console.ReadLine();
            string kelime_ters = "";
            while (kelime != "c")
            {
                if (kelime.Length >= 3)
                {
                    kelime_ters = "";
                    for (int i = kelime.Length - 1; i >= 0; i--)
                    {
                        kelime_ters += kelime[i];
                    }

                    Console.WriteLine("\nKelimenin tersten yazılısı = " + kelime_ters);

                    if (kelime_ters == kelime)
                    {
                        Console.WriteLine("\nGirilen kelime Palindromik bir kelimedir.");
                    }
                    else
                    {
                        Console.WriteLine("\nGirilen kelime Palindromik bir kelime değildir.");
                    }
                }
                else
                {
                    Console.WriteLine("Girilen kelime en az 3 harfli olmalidir!");
                }
                Console.WriteLine("Bir kelime giriniz (c: Cıkıs): ");
                kelime = Console.ReadLine();
            }
        }
    }
}
