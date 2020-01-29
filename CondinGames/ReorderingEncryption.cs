using System;
using System.Collections.Generic;
using System.IO;

namespace CondinGames
{
    public class ReorderingEncryption
    {
        public void ReorderingEncryptionMain()
        {
            Console.WriteLine("Reordering Encryption");
            Console.SetIn(new StreamReader(Console.OpenStandardInput(), Console.InputEncoding, false, bufferSize: 1024));

            int n = int.Parse(Console.ReadLine());
            string message = Console.ReadLine();
            string answer = string.Empty;

            if (n > 0)
            {
                // Decode
                while (n != 0)
                {
                    List<int> splitStringCountsList = GetSplitStringCountArray(message);
                    bool isFront = splitStringCountsList.Count % 2 == 0;

                    for (int i = splitStringCountsList.Count - 1; i >= 0; i--)
                    {
                        string splitString = string.Empty;
                        if (isFront)
                        {
                            splitString = message.Substring(0, splitStringCountsList[i]);
                            message = message.Remove(0, splitStringCountsList[i]);
                        }
                        else
                        {
                            splitString = message.Substring(message.Length - splitStringCountsList[i], splitStringCountsList[i]);
                            message = message.Remove(message.Length - splitStringCountsList[i], splitStringCountsList[i]);
                        }
                        answer = splitString + answer;
                        isFront = !isFront;
                    }
                    n--;
                    if(n != 0)
                    {
                        message = answer;
                        answer = string.Empty;
                    }
                }
            }
            else
            {
                // Encode
                while (n != 0)
                {
                    List<int> splitStringCountsList = GetSplitStringCountArray(message);
                    bool isFront = splitStringCountsList.Count % 2 == 0;

                    isFront = false;
                    for (int i = 0; i < splitStringCountsList.Count; i++)
                    {
                        string splitString = message.Substring(0, splitStringCountsList[i]);
                        message = message.Remove(0, splitStringCountsList[i]);
                        if (isFront)
                        {
                            answer = splitString + answer;
                        }
                        else
                        {
                            answer = answer + splitString;
                        }
                        isFront = !isFront;
                    }
                    n++;
                    if (n != 0)
                    {
                        message = answer;
                        answer = string.Empty;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine(answer);
        }

        public List<int> GetSplitStringCountArray(string message)
        {
            List<int> splitStringCountsList = new List<int>();
            int lettersCount = 1;

            while (!string.IsNullOrEmpty(message))
            {
                string splitString = lettersCount > message.Length ? message.Substring(0, message.Length) : message.Substring(0, lettersCount);
                message = lettersCount > message.Length ? message.Remove(0, message.Length) : message.Remove(0, lettersCount);
                splitStringCountsList.Add(splitString.Length);
                lettersCount++;
            }

            return splitStringCountsList;
        }
    }
}
