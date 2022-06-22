using System;
using System.Linq;
using System.Text;

namespace _5._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var letters = new StringBuilder();
            var nums = new StringBuilder();
            var other = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                var chartext = text[i];
                if (char.IsDigit(chartext))
                {
                    nums.Append(chartext);
                }
                else if (char.IsLetter(chartext))
                {
                    letters.Append(chartext);
                }
                else
                {
                    other.Append(chartext);
                }
            }
            Console.WriteLine($"{nums}\n{letters}\n{other}");
        }
    }
}
