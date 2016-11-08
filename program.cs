using System;

namespace Subwords
{
    class Program
    {
        static void Main(string[] args)
        {            
            Subwords("abcd", "");           
        }

        public static void Subwords(string word, string sub)
        {
            if (word.Length > 0)
            {
                Subwords(word.Remove(0, 1), sub + word[0]);
                Subwords(word.Remove(0, 1), sub);
            }
            else
            {
                Console.WriteLine(sub);
            }
        }

    }
}
