using System;
using System.Collections.Generic;

namespace CondinGames
{
    public class RubiksFace
    {
        public void RubiksFaceMain()
        {
            string rotations = Console.ReadLine();
            string[] rotationsArr = rotations.Split(' ');
            string face1 = Console.ReadLine();
            string face2 = Console.ReadLine();
            List<string> facesList = new List<string> { face1, face2 };

            foreach (string rotation in rotationsArr)
            {
                for (int i = 0; i < facesList.Count; i++)
                {
                    switch (facesList[i].ToUpperInvariant())
                    {
                        case "F":
                            {

                                if (rotation.ToLowerInvariant().Equals("x"))
                                {
                                    facesList[i] = "U";
                                }
                                else if (rotation.ToLowerInvariant().Equals("x'"))
                                {
                                    facesList[i] = "D";
                                }
                                else if (rotation.ToLowerInvariant().Equals("y"))
                                {
                                    facesList[i] = "L";
                                }
                                else if (rotation.ToLowerInvariant().Equals("y'"))
                                {
                                    facesList[i] = "R";
                                }
                                break;
                            }
                        case "B":
                            {
                                if (rotation.ToLowerInvariant().Equals("x"))
                                {
                                    facesList[i] = "D";
                                }
                                else if (rotation.ToLowerInvariant().Equals("x'"))
                                {
                                    facesList[i] = "U";
                                }
                                else if (rotation.ToLowerInvariant().Equals("y"))
                                {
                                    facesList[i] = "R";
                                }
                                else if (rotation.ToLowerInvariant().Equals("y'"))
                                {
                                    facesList[i] = "L";
                                }
                                break;
                            }
                        case "U":
                            {
                                if (rotation.ToLowerInvariant().Equals("x"))
                                {
                                    facesList[i] = "B";
                                }
                                else if (rotation.ToLowerInvariant().Equals("x'"))
                                {
                                    facesList[i] = "F";
                                }
                                else if (rotation.ToLowerInvariant().Equals("z"))
                                {
                                    facesList[i] = "R";
                                }
                                else if (rotation.ToLowerInvariant().Equals("z'"))
                                {
                                    facesList[i] = "L";
                                }
                                break;
                            }
                        case "D":
                            {
                                if (rotation.ToLowerInvariant().Equals("x"))
                                {
                                    facesList[i] = "F";
                                }
                                else if (rotation.ToLowerInvariant().Equals("x'"))
                                {
                                    facesList[i] = "B";
                                }
                                else if (rotation.ToLowerInvariant().Equals("z"))
                                {
                                    facesList[i] = "L";
                                }
                                else if (rotation.ToLowerInvariant().Equals("z'"))
                                {
                                    facesList[i] = "R";
                                }
                                break;
                            }
                        case "L":
                            {
                                if (rotation.ToLowerInvariant().Equals("y"))
                                {
                                    facesList[i] = "B";
                                }
                                else if (rotation.ToLowerInvariant().Equals("y'"))
                                {
                                    facesList[i] = "F";
                                }
                                else if (rotation.ToLowerInvariant().Equals("z"))
                                {
                                    facesList[i] = "U";
                                }
                                else if (rotation.ToLowerInvariant().Equals("z'"))
                                {
                                    facesList[i] = "D";
                                }
                                break;
                            }
                        case "R":
                            {
                                if (rotation.ToLowerInvariant().Equals("y"))
                                {
                                    facesList[i] = "F";
                                }
                                else if (rotation.ToLowerInvariant().Equals("y'"))
                                {
                                    facesList[i] = "B";
                                }
                                else if (rotation.ToLowerInvariant().Equals("z"))
                                {
                                    facesList[i] = "D";
                                }
                                else if (rotation.ToLowerInvariant().Equals("z'"))
                                {
                                    facesList[i] = "U";
                                }
                                break;
                            }
                        default:
                            break;
                    }
                }
            }

            Console.WriteLine(facesList[0]);
            Console.WriteLine(facesList[1]);
        }
    }
}