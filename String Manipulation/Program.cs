//@author Jacob Schuller
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Manipulation
{
    class Program
    {
        static string quote = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots.So far, the universe is winning.";

        static void Main(string[] args)
        {
            Console.WriteLine(quote);

            Console.WriteLine("What's your word?>>");
            string userWord = Console.ReadLine();

            Console.WriteLine($"What do you want to replace your {userWord} with?>>");
            string replaceWord = Console.ReadLine();

            if (quote.Contains(userWord))
            {
               string replaceQuote = quote.Replace(userWord, replaceWord);
                Console.WriteLine(replaceQuote);
            }

            else
            {
                //This spits out your answer backwards
                Console.WriteLine($"Sorry, I could not find your word, {userWord}.");
                for (int i = userWord.Length - 1; i > 0; i--)
                {
                    Console.Write(userWord[i]);
                }
            }
            





            Console.ReadKey();
        }
    }
}
