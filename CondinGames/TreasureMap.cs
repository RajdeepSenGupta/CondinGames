using System;

namespace CondinGames
{
    public class TreasureMap
    {
        public void TreasureMapMain()
        {
            Console.WriteLine("TREASURE MAP");

            int iPos = 0, jPos = 0;
            bool isFound = false;
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int[,] mapValueArr = new int[height, width];

            for (int i = 0; i < height; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                for (int j = 0; j < width; j++)
                {
                    mapValueArr[i, j] = int.Parse(inputs[j]);
                }
            }

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    // Corners
                    if(i == 0 && j == 0)
                    {
                        // Up Left
                        if (mapValueArr[i, j + 1] == 1 && mapValueArr[i + 1, j] == 1 && mapValueArr[i + 1, j + 1] == 1)
                        {
                            iPos = i;
                            jPos = j;
                            isFound = true;
                            break;
                        }
                    }
                    else if(i == 0 && j == width - 1)
                    {
                        // Up Right
                        if (mapValueArr[i, j - 1] == 1 && mapValueArr[i + 1, j] == 1 && mapValueArr[i + 1, j - 1] == 1)
                        {
                            iPos = i;
                            jPos = j;
                            isFound = true;
                            break;
                        }
                    }
                    else if(i == height - 1 && j == 0)
                    {
                        // Down Left
                        if (mapValueArr[i, j + 1] == 1 && mapValueArr[i - 1, j] == 1 && mapValueArr[i - 1, j + 1] == 1)
                        {
                            iPos = i;
                            jPos = j;
                            isFound = true;
                            break;
                        }
                    }
                    else if(i == height - 1 && j == width - 1)
                    {
                        // Down Right
                        if (mapValueArr[i, j - 1] == 1 && mapValueArr[i - 1, j] == 1 && mapValueArr[i - 1, j - 1] == 1)
                        {
                            iPos = i;
                            jPos = j;
                            isFound = true;
                            break;
                        }
                    }
                    // Edges
                    else if(i == 0 && j > 0 && j < width - 1)
                    {
                        // Top
                        if (mapValueArr[i, j - 1] == 1 && mapValueArr[i, j + 1] == 1
                            && mapValueArr[i + 1, j - 1] == 1 && mapValueArr[i + 1, j] == 1 && mapValueArr[i + 1, j + 1] == 1)
                        {
                            iPos = i;
                            jPos = j;
                            isFound = true;
                            break;
                        }
                    }
                    else if(i == height - 1 && j > 0 && j < width - 1)
                    {
                        // Down
                        if (mapValueArr[i, j - 1] == 1 && mapValueArr[i, j + 1] == 1
                            && mapValueArr[i - 1, j - 1] == 1 && mapValueArr[i - 1, j] == 1 && mapValueArr[i - 1, j + 1] == 1)
                        {
                            iPos = i;
                            jPos = j;
                            isFound = true;
                            break;
                        }
                    }
                    else if(i > 0 && i < height - 1 && j == 0)
                    {
                        // Left
                        if (mapValueArr[i - 1, j] == 1 && mapValueArr[i + 1, j] == 1
                            && mapValueArr[i, j + 1] == 1 && mapValueArr[i - 1, j + 1] == 1 && mapValueArr[i + 1, j + 1] == 1)
                        {
                            iPos = i;
                            jPos = j;
                            isFound = true;
                            break;
                        }
                    }
                    else if(i > 0 && i < height - 1 && j == width - 1)
                    {
                        // Right
                        if (mapValueArr[i - 1, j] == 1 && mapValueArr[i + 1, j] == 1
                            && mapValueArr[i, j - 1] == 1 && mapValueArr[i - 1, j - 1] == 1 && mapValueArr[i + 1, j - 1] == 1)
                        {
                            iPos = i;
                            jPos = j;
                            isFound = true;
                            break;
                        }
                    }
                    // Inside the map
                    else
                    {
                        if (mapValueArr[i, j - 1] == 1 && mapValueArr[i, j + 1] == 1
                            && mapValueArr[i - 1, j] == 1 && mapValueArr[i + 1, j] == 1
                            && mapValueArr[i - 1, j - 1] == 1 && mapValueArr[i - 1, j + 1] == 1
                            && mapValueArr[i + 1, j - 1] == 1 && mapValueArr[i + 1, j + 1] == 1)
                        {
                            iPos = i;
                            jPos = j;
                            isFound = true;
                            break;
                        }
                    }
                }
                if (isFound)
                    break;
            }

            Console.WriteLine(string.Format("{0} {1}", jPos, iPos));
        }
    }
}