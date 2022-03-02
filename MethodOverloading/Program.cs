using System;

namespace MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var intAnswer = Add(5, 10);
            var decimalAnswer = Add(12.13, 27.35);
            var boolAnswer = Add(10,5,true);

            Console.WriteLine($"Your int addition answer is: {intAnswer}");
            Console.WriteLine($"Your decimal addition answer is: {decimalAnswer}");
            Console.WriteLine($"Your bool reliant if answer is: {boolAnswer}");
        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public static string Add(int num1, int num2, bool bool1)
        {
            if (bool1 == true)
            {
                var answer = num1 + num2;
                string isThereS = (answer != 1) ? $"{answer} dollars" : $"{answer} dollar";
                return isThereS;
            }
            else
            {
                int answer = num1 + num2;
                return $"{answer}";
            }
        }
    }
}
