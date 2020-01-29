using System;
using System.Collections.Generic;
using System.Linq;

namespace CondinGames
{
    public class SentenceFormatting
    {
        public void SentenceFormattingMain()
        {
            Console.WriteLine("Sentenct Formatting");

            /* 
             * Only a single space between words(remove excessive spaces);
             * No spaces before punctuation marks;
             * One space after each punctuation mark in front of a letter;
             * Use only lowercase letters, except for the beginning of the sentence(after a dot);
             * Remove repeated punctuation marks.
             */

            // Test cases
            // one,two,three.
            // one,two,three.four,five, six.
            // one , two , three.four , five , six
            // one , TWO  ,,  three  ..  four,fivE , six .
            // when a father gives to his son,,, Both laugh; When a son gives to his father, , , Both cry...shakespeare

            string intext = Console.ReadLine();
            List<char> answerList = new List<char>();

            for(int i = 0; i < intext.Length; i++)
            {
                if(intext[i] != '.' && intext[i] != ',' && intext[i] != ';')
                {

                }
                else
                {

                }
            }
            
            Console.WriteLine(new string(answerList.ToArray()));
        }

        static string RemoveDuplicates(char[] s)
        {
            int n = s.Length;
            if (n < 2)
            {
                return new string(s);
            }

            int j = 0;

            for (int i = 1; i < n; i++)
            {
                if ((s[i] != '.' && s[i] != ',' && s[i] != ';' && s[i] != ' ' && s[j] == s[i]) || s[j] != s[i])
                {
                    j++;
                    s[j] = s[i];
                }
            }
            char[] A = new char[j + 1];
            Array.Copy(s, 0, A, 0, j + 1);
            return new string(A);
        }
    }
}
