using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ReviewWIthClassApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"this should be true because its a {ValidateVowels("a")}");
            Console.WriteLine($"this should be false because its b {ValidateVowels("b")}");
            CountVowels("Hi My Name is robrt");
            Console.ReadKey();
        }

        public static void PrintResult()
        {
            var age = GetAge();
            var isEven = IsDivisible(age, 2);

            if(age >= 21 && isEven)
            {
                Console.WriteLine("You can drink!!! and your age is even");
            }else if(age < 21 && isEven)
            {
                Console.WriteLine("Yuo cannot ddrink!! bummer. but your age is even !");
            }else if(age < 21 && !isEven)
            {

            }
            else
            {

            }
        }

        public static bool IsDivisible(int x, int y)
        {
            bool isTrue = x % y == 0;

            return isTrue;
        }

        public static void CountVowels(string input)
        {
            int vowels = 0;
            for(var i = 0; i < input.Length; i++)
            {
                if (ValidateVowels(input[i].ToString()))
                {
                    vowels++;
                }
            }

            Console.WriteLine($"You ahve {vowels} vowels");
        }

        public static bool ValidateVowels(string input)
        {
            Regex reg = new Regex("^[aeiou]$");
            var isVowelValid = reg.Match(input).Success;

            return isVowelValid;
        }

        public static int GetAge()
        {
            int age = 0;
            bool isValidInput = false;

            while (!isValidInput) {
                Console.WriteLine("Enter  your age");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out age))
                {
                    Console.WriteLine($"{input} cannot be parsed into an int");
                }
                else
                {
                    isValidInput = true;
                }
            }
            return age;
        }
    }
}
