using System;
using System.Numerics;
using System.Diagnostics;

namespace prime
{
    class Program
    {
        public static BigInteger operationCount;
        static bool IsPrime(BigInteger Num)
        {
            operationCount = 0;

            if (Num < 2) return false;
            else if (Num < 4) return true;
            else if (Num % 2 == 0)
            {
                return false;
            }
            else for (BigInteger u = 3; u < Num / 2; u += 2)
                {
                    if (Num % u == 0)
                    {
                        return false;
                    }
                    operationCount++;
                }
            operationCount++;
            return true;
        }
        static void Main(string[] args)
        {
            BigInteger[] numbers = new BigInteger[] { 100913, 1009139, 10091401, 100914061, 1009140611, 10091406133, 100914061337, 1009140613399 };

            System.Console.WriteLine("number;oper_number");
            for (int i = 0; i < numbers.Length; i++)
            {
                IsPrime(numbers[i]);
                System.Console.WriteLine("{0};{1}", numbers[i], operationCount);
            }
            Console.ReadKey();

        }
    }
}
