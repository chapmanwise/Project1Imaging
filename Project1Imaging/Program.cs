using Microsoft.Internal.VisualStudio.PlatformUI;
using System;

namespace Project1_ImageASCIIConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            char KeepGoing = 'y';
            while (KeepGoing == 'y')
            {
                Console.WriteLine("Input the path to your disired image");
                string path = Console.ReadLine();

                Console.WriteLine("Input the height for the image");
                int height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Input the width for the image");
                int width = Convert.ToInt32(Console.ReadLine());

                int[,] luminances = ImageHelper.LoadPixelValuesFromPath(path, height, width);


                for (var y = 0; y < luminances.GetLength(1); y++)
                {
                    for (var x = 0; x < luminances.GetLength(0); x++)
                    {
                        int point = luminances[x, y];
                        string convertPixels = ConvertToChar(point);

                        Console.WriteLine(convertPixels);

                        Console.WriteLine();
                        Console.WriteLine("Keep going? (y/n)");
                        string keepgoing = Console.ReadLine();
                    }
                }
                Console.ReadKey();
            }
        }


        private static string ConvertToChar(int luminance)
        {
            if (luminance > 0 && luminance <= 25)
            {
                return (" ");
            }
            else if (luminance > 25 && luminance <= 50)
            {
                return (".");
            }
            else if (luminance > 50 && luminance <= 75)
            {
                return ("*");
            }
            else if (luminance > 75 && luminance <= 100)
            {
                return (":");
            }
            else if (luminance > 100 && luminance <= 125)
            {
                return ("o");
            }
            else if (luminance > 125 && luminance <= 150)
            {
                return ("&");
            }
            else if (luminance > 150 && luminance <= 175)
            {
                return ("8");
            }
            else if (luminance > 175 && luminance <= 200)
            {
                return ("#");
            }
            else if (luminance > 200 && luminance <= 225)
            {
                return ("@");
            }
            else if (luminance > 225 && luminance <= 250)
            {
                return ("$");
            }
            else
            { return "error"; }
        }
    }
}

