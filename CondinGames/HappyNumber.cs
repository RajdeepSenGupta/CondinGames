using System;
using System.Numerics;

namespace CondinGames
{
    public class HappyNumber
    {
        public void HappyNumberMain()
        {
            Console.WriteLine("Happy Numbers");

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                BigInteger x = BigInteger.Parse(Console.ReadLine());
                BigInteger copy = x;
                int count = 10;

                while (count != 0)
                {
                    BigInteger squaredSum = GetSquaredSum(copy);
                    if(squaredSum == 1)
                    {
                        Console.WriteLine(x + " :)");
                        break;
                    }
                    if (squaredSum > copy)
                    {
                        count--;
                    }
                    copy = squaredSum;
                }
                if(count == 0)
                {
                    Console.WriteLine(x + " :(");
                }
            }
        }

        private BigInteger GetSquaredSum(BigInteger n)
        {
            BigInteger sum = 0;

            while (n > 0)
            {
                BigInteger mod = n % 10;
                sum += mod * mod;
                n = n / 10;
            }

            return sum;
        }
    }
}
