using System;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string strings = Console.ReadLine();
            string[] stringToReplace = strings.Split(",");
            string text = Console.ReadLine();
            foreach (var word in stringToReplace)
            {
                string asteriks = string.Empty;
                for (int i = 0; i < word.Length; i++)
                {
                    asteriks +='*';
                }
                text = text.Replace(word, asteriks);
            }
            Console.WriteLine(text);
        }
    }
}
