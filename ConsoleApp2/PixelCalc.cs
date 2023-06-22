using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public static class PixelCalc
    {
        static int screenWidth = 0;
        static int screenHeight = 0;
        static int diagonalSize = 0;

        public static string Report(int screenWidth, int screenHeight, int diagonalSize)
        {
            double diagonalPixels = Math.Round(Math.Sqrt(Math.Pow(screenWidth, 2) + Math.Pow(screenHeight, 2)), 2);
            double ppiPixels = Math.Round(diagonalPixels / diagonalSize, 2);
            double dotPitch = Math.Round((diagonalSize * 25.4) / diagonalPixels, 2);

            Console.WriteLine("PPI = " + ppiPixels);
            Console.WriteLine("Diagonal (in pixels) = " + diagonalPixels);
            Console.WriteLine("Dot Pitch = " + dotPitch);
        }

    }
}
