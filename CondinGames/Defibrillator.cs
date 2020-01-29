using System;
using System.Collections.Generic;

namespace CondinGames
{
    public class Defibrillator
    {
        public void DefibrillatorMain()
        {
            Console.WriteLine("DEFIBRILLATOR");

            string userLongitudeStr = Console.ReadLine();
            string userLatitudeStr = Console.ReadLine();
            double userLongitude = double.Parse(userLongitudeStr.Replace(',', '.'));
            double userLatitude = double.Parse(userLatitudeStr.Replace(',', '.'));

            int n = int.Parse(Console.ReadLine());
            List<List<string>> defibDetailsList = new List<List<string>>();
            string nearestDefibName = string.Empty;
            double minDistance = double.MaxValue;
            for (int i = 0; i < n; i++)
            {
                string defibDetails = Console.ReadLine();
                string[] defibDetailArr = defibDetails.Split(';');
                double defibLongitude = double.Parse(defibDetailArr[4].Replace(',', '.'));
                double defibLatitude = double.Parse(defibDetailArr[5].Replace(',', '.'));

                double x = (defibLongitude - userLongitude) * Math.Cos((userLatitude + defibLatitude) / 2);
                double y = defibLatitude - userLatitude;
                double d = Math.Sqrt((x * x) + (y * y)) * 6371;

                if (d < minDistance)
                {
                    minDistance = d;
                    nearestDefibName = defibDetailArr[1];
                }
            }  

            Console.WriteLine(nearestDefibName);
        }
    }
}
