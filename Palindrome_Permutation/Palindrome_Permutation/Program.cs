using System;

namespace Palindrome_Permutation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a series of letters here.");

            IsPermutationOfPalindrome(Console.ReadLine());


            Console.ReadLine();
        }

        static bool IsPermutationOfPalindrome(string phrase)
        {
            int[] monitor = MonitorCharFrequency(phrase);
            return IsThereMoreThanOneOdd(monitor);
        }

        static bool IsThereMoreThanOneOdd(int[] table)
        {
            bool foundOdd = false;
            foreach (int match in table)
            {
                if (match % 2 == 1)
                {
                    if (foundOdd)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        static int GetCharNumberValue(char c)
        {
            int a = Convert.ToInt32(char.GetNumericValue('a'));
            int z = Convert.ToInt32(char.GetNumericValue('z'));
            int value = Convert.ToInt32(char.GetNumericValue(c));

            if (a <= value && value <= z)
            {
                return value - a;
            }
            return -1;
        }

        static int[] MonitorCharFrequency(string phrase)
        {
            int[] monitor = new int[Convert.ToInt32(char.GetNumericValue('z') - char.GetNumericValue('a') + 1)];

            foreach (char c in phrase.ToCharArray())
            {
                int x = GetCharNumberValue(c);

                if (x != -1)
                {
                    monitor[x]++;
                }
            }
            return monitor;
        }
    }
}
