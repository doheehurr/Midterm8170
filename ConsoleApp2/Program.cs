using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choise = 0;
            bool isContinue = true;

            while (isContinue) {

                Menu();

                switch (choise)
                {

                    case 1:
                        Console.WriteLine("Enter Screen width in pixels: ");
                        int width = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Screen height in pixels: ");

                        int height = int.Parse(Console.ReadLine());
                        //int height2 = Convert.ToInt32(Console.Read());
                        Console.WriteLine("Enter Screen diagonal in inches: ");
                        int diagonal = int.Parse(Console.ReadLine());

                        PixelCalc.Report(width, height, diagonal);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        isContinue= false;
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            }

            int Menu()
            {
                Console.WriteLine("Please choose an option");
                Console.WriteLine("1. Enter Screen dimensions");
                Console.WriteLine("2. Exit");
                try {
                    choise = int.Parse(Console.ReadLine());
                    return choise;
                }
                catch
                {
                    Console.Clear();
                    return Menu();
                }  
                
            }
        }
    }


}
