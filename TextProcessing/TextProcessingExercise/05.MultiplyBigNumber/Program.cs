using System;
using System.Linq;
using System.Text;

namespace _05.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());
            if (string.IsNullOrEmpty(bigNumber))
            {
                Console.WriteLine(0);
                return;
            }
            if (multiplier <= 0)
            {
                Console.WriteLine(0);
                return;
            }
            string result = string.Empty;
            double add = 0;

            for (int i = 0; i < bigNumber.Length; i++)
            {
                double number = char.GetNumericValue(bigNumber[bigNumber.Length - i - 1]);
                double product = number * multiplier;
                product += add;

                if (product < 10)
                {
                    result += product.ToString();
                    add = 0;
                }
                else
                {
                    double remainder = product % 10;
                    product -= remainder;
                    add = product /= 10;
                    result += remainder;
                }
            }

            string finalResult = string.Empty;
            for (int i = result.Length - 1; i >= 0; i--)
            {
                finalResult += result[i];
            }
            if (add != 0)
            {
                finalResult = finalResult.Insert(0, add.ToString());
            }
            Console.WriteLine(finalResult);
        }
    }
}
