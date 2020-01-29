using System;
using System.Collections.Generic;

namespace CondinGames
{
    public class HorseRacingHyperDual
    {
        public void HorseRacingHyperDualMain()
        {
            Console.WriteLine("Horse Racing Hyperdual");

            int n = int.Parse(Console.ReadLine());
            List<Tuple<int, int>> horseStrengthsList = new List<Tuple<int, int>>();
            double answer = double.MaxValue;

            for (int i = 0; i < n; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int v = int.Parse(inputs[0]);
                int e = int.Parse(inputs[1]);
                horseStrengthsList.Add(new Tuple<int, int>(v, e));

                for (int j = 0; j < horseStrengthsList.Count; j++)
                {
                    if(i != j)
                    {
                        double dist = Math.Abs(horseStrengthsList[j].Item2 - horseStrengthsList[i].Item2) + Math.Abs(horseStrengthsList[j].Item1 - horseStrengthsList[i].Item1);
                        if (dist < answer)
                            answer = dist;
                    }
                }
            }

            Console.WriteLine(answer);
        }
    }
}
