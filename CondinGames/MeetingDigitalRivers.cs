using System;
using System.Collections.Generic;
using System.Linq;

namespace CondinGames
{
    public class MeetingDigitalRivers
    {
        public void MeetingDigitalRiversMain()
        {
            Console.WriteLine("Meeting Digital Rivers");

            long r1 = long.Parse(Console.ReadLine());
            long r2 = long.Parse(Console.ReadLine());

            List<long> river1 = new List<long> { r1 };
            List<long> river2 = new List<long> { r2 };
            long meetPoint = 0;

            while(meetPoint == 0)
            {
                if(river1[river1.Count - 1] == river2[river2.Count - 1])
                {
                    meetPoint = river1[river1.Count - 1];
                }
                else if(river1[river1.Count - 1] < river2[river2.Count - 1])
                {
                    river1[river1.Count - 1] = river1[river1.Count - 1] + GetSumOfDigits(river1[river1.Count - 1]);
                }
                else if (river2[river2.Count - 1] < river1[river1.Count - 1])
                {
                    river2[river2.Count - 1] = river2[river2.Count - 1] + GetSumOfDigits(river2[river2.Count - 1]);
                }
            }


            Console.WriteLine(meetPoint);
        }

        public static long GetSumOfDigits(long n)
        {
            long sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n = n / 10;
            }
            return sum;
        }
    }
}
