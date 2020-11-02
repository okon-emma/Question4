using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> alphabets = new List<char>()
            {
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
                'n', 'o', 'p', 'q', 'r', 's', 't','u', 'v', 'w', 'x', 'y', 'z'
            };

            List<char> vowels = new List<char>()
            {
                'a', 'e', 'i', 'o', 'u'
            };

            Console.Write("Enter your alphabet: ");
            char input = Convert.ToChar(Console.Read());
            
            if (char.IsWhiteSpace(input))
            {
                Console.WriteLine("Empty Character");
            } else
            {
                if (alphabets.Contains(char.ToLower(input)))
                {
                    if (vowels.Contains(char.ToLower(input)))
                    {
                        Console.WriteLine("The alphabet is a vowel");
                    } else
                    {
                        Console.WriteLine("The alphabet is a consonant");
                    }
                } else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
            Console.ReadKey();

        }
    }
}
