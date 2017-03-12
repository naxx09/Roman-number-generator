using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumberGenerator
{
    class Program
    {
        public static void Run()
        {
            int Num;

            Console.WriteLine("Input an integer: ");
            if (int.TryParse(Console.ReadLine(), out Num))
            {
                if (Num / 10 >= 1)
                {
                    int TenDigit = Num / 10;
                    int SinDigit = Num % 10;
                    Console.Write("\n");
                    for (int i = 0; i < TenDigit; i++)
                    {
                        Console.Write("X");
                    }
                    switch (SinDigit)
                    {
                        case 1:
                            Console.Write("I");
                            break;
                        case 2:
                            Console.Write("II");
                            break;
                        case 3:
                            Console.Write("III");
                            break;
                        case 4:
                            Console.Write("IV");
                            break;
                        case 5:
                            Console.Write("V");
                            break;
                        case 6:
                            Console.Write("VI");
                            break;
                        case 7:
                            Console.Write("VII");
                            break;
                        case 8:
                            Console.Write("VIII");
                            break;
                        case 9:
                            Console.Write("IX");
                            break;
                        default:
                            break;
                    }
                } // Num >= 10 END
                else
                {
                    switch (Num)
                    {
                        case 1:
                            Console.Write("I");
                            break;
                        case 2:
                            Console.Write("II");
                            break;
                        case 3:
                            Console.Write("III");
                            break;
                        case 4:
                            Console.Write("IV");
                            break;
                        case 5:
                            Console.Write("V");
                            break;
                        case 6:
                            Console.Write("VI");
                            break;
                        case 7:
                            Console.Write("VII");
                            break;
                        case 8:
                            Console.Write("VIII");
                            break;
                        case 9:
                            Console.Write("IX");
                            break;
                        default:
                            break;
                    }
                } // Num < 10 END
            }
            else
            {
                Console.WriteLine("please input a valid integer.");
            }

        }
        static void Main(string[] args)
        {
            do
            {
                Run();
                Console.Write("\n");

                Console.WriteLine("\nDo you want to convert other number? (y/n)? ");
            } while (Console.ReadLine() != "n");

        }
    }
}
