using System;

namespace CondinGames
{
    public class DateManipulation
    {
        public void DateManipulationMain()
        {
            Console.WriteLine("Date Manipulation (dd.mm.yyyy)");

            string[] begin = Console.ReadLine().Split('.');
            string[] end = Console.ReadLine().Split('.');

            DateTime startDate = new DateTime(int.Parse(begin[2]), int.Parse(begin[1]), int.Parse(begin[0]));
            DateTime endDate = new DateTime(int.Parse(end[2]), int.Parse(end[1]), int.Parse(end[0]));

            var a = 1;
            
            double totalDays = (endDate - startDate).TotalDays;
            double yearDiff = (int)(totalDays / 365);
            double remainingDays = totalDays % 365;
            double monthDiff = remainingDays == 30
                ? 0
                : (int)(remainingDays / 30);

            string answer = string.Format("total {0} days", totalDays);
            if (monthDiff != 0)
                answer = monthDiff > 1 
                    ? string.Format("{0} months, ", monthDiff) + answer
                    : string.Format("{0} month, ", monthDiff) + answer;
            if (yearDiff != 0)
                answer = yearDiff > 1
                    ? string.Format("{0} years, ", yearDiff) + answer
                    : string.Format("{0} year, ", yearDiff) + answer;

            Console.WriteLine(answer);
        }
    }
}
