using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CondinGames
{
    public class CreditCardNumberVerifier
    {
        public void CreditCardNumberVerifierMain()
        {
            Console.WriteLine("Credit Card Number Verifier");

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string card = Console.ReadLine();
                card = Regex.Replace(card, @"\s+", "");

                List<int> evenDigits = new List<int>();
                List<int> oddDigits = new List<int>();
                for(int j = 0; j < card.Length; j++)
                {
                    if ((j + 1) % 2 == 0) evenDigits.Add(Convert.ToInt32(card[j].ToString()));
                    else oddDigits.Add(Convert.ToInt32(card[j].ToString()));
                }

                List<int> doubleOddDigits = oddDigits.ConvertAll(x => 2 * x);
                for(int j = 0; j < doubleOddDigits.Count; j++)
                {
                    if (doubleOddDigits[j] > 9) doubleOddDigits[j] -= 9;
                }

                int doubleOddDigitsSum = doubleOddDigits.Sum();
                int evenDigitsSum = evenDigits.Sum();

                Console.WriteLine((evenDigitsSum + doubleOddDigitsSum) % 10 == 0 ? "YES" : "NO");
            }
        }
    }
}
