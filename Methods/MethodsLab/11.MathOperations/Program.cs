using System;

namespace _11.MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    Console.WriteLine(Add(number1, number2)); 
                    break;
                case '-':
                    Console.WriteLine(Subtract(number1, number2));
                    break;
                case '*':
                    Console.WriteLine(Multiply(number1, number2)); 
                    break;
                case '/':
                    Console.WriteLine(Divide(number1, number2)); 
                    break;

            }
        }
        static int Add(int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;
        }
        static int Subtract(int number1, int number2)
        {
            int sum = number1 - number2;
            return sum;
        }
        static int Multiply(int number1, int number2)
        {
            int sum = number1 * number2;
            return sum;
        }
        static int Divide(int number1, int number2)
        {
            int sum = number1 / number2;
            return sum;
        }
    }
}
