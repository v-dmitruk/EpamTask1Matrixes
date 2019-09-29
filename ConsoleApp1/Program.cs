using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            List<Matrix> matrixes = new List<Matrix>();
            Pending(matrixes);
            Console.WriteLine("Recursion ended");
            Console.ReadKey();
            
        }

        static void Help(List<Matrix> matrixes)
        {
            Console.WriteLine("You can create random matrix by pressing C");
            Console.WriteLine("You can view matrix by pressing it's number");
            Console.WriteLine("Currently you have " + matrixes.Count + " matrixes");
            Console.WriteLine("You can create matrix by yourself by pressing m");
            Console.WriteLine("You can delete matrix by its number by pressing d");
            Console.WriteLine("You can add matrixes by its numbers by pressing a");
            Console.WriteLine("You can subtract matrixes by its numbers by pressing s");
            Console.WriteLine("You can multiply matrixes by its numbers by pressing x");
            Console.WriteLine("You can quit by pressing q");
        }

        static void Pending(List<Matrix> matrixes)
        {
            Console.WriteLine("You can type 'help' to find out what to do");
            string Key = Console.ReadLine();
            //if (Key == "c")
            //{
            //    Console.WriteLine("Input matrix dimension M please");
            //    int m = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Input matrix dimension N please");
            //    int n = Convert.ToInt32(Console.ReadLine());
            //    Matrix matrix = new Matrix();
            //    matrix.CreateRandomly(m, n, ref matrixes);
            //}
            //else
            //{
            //    if (Key == "q")
            //        return;
            //    else
            //    {
            //        if (Convert.ToInt32(Key) <= matrixes.Count && matrixes.Count != 0)
            //        {
            //            matrixes[Convert.ToInt32(Key) - 1].Show();
            //        }
            //        else
            //        {
            //            Pending(matrixes);
            //        }
            //    }
            //}
            switch (Key)
            {
                case "help":
                    Help(matrixes);
                    break;
                case "c":
                    Console.WriteLine("Input matrix dimension M please");
                    int m = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Input matrix dimension N please");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Matrix matrix = new Matrix();
                    matrix.CreateRandomly(m, n, ref matrixes);
                    break;
                case "q":
                    return;
                case "1":
                    if (matrixes.Count >= 1)
                        matrixes[Convert.ToInt32(Key) - 1].Show();
                    else
                        Console.WriteLine($"You have only {matrixes.Count} matrixes");
                    break;
                case "2":
                    if (matrixes.Count >= 2)
                        matrixes[Convert.ToInt32(Key) - 1].Show();
                    else
                        Console.WriteLine($"You have only {matrixes.Count} matrixes");
                    break;
                case "3":
                    if (matrixes.Count >= 3)
                        matrixes[Convert.ToInt32(Key) - 1].Show();
                    else
                        Console.WriteLine($"You have only {matrixes.Count} matrixes");
                    break;
                case "4":
                    if (matrixes.Count >= 4)
                        matrixes[Convert.ToInt32(Key) - 1].Show();
                    else
                        Console.WriteLine($"You have only {matrixes.Count} matrixes");
                    break;
                case "m":
                    Console.WriteLine("Input matrix dimension M please");
                    int m2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Input matrix dimension N please");
                    int n2 = Convert.ToInt32(Console.ReadLine());
                    Matrix matrix1 = new Matrix();
                    matrix1.CreateManualy(m2, n2, ref matrixes);
                    break;
                case "d":
                    Console.WriteLine("Input matrix number that you want to delete");
                    int n1 = Convert.ToInt32(Console.ReadLine());
                    matrixes.RemoveAt(n1-1);
                    Console.WriteLine("Matrix " + n1 + " succesfully deleted");
                    break;
                case "a":
                    Console.WriteLine("Input first matrix number that you want to add");
                    int n3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Input second matrix number that you want to add");
                    int n4 = Convert.ToInt32(Console.ReadLine());
                    if (n3 > matrixes.Count || n4 > matrixes.Count)
                    {
                        Console.WriteLine("Matrix number doesn't exist");
                    }
                    else
                    {
                        if (n3 == n4)
                        {
                            Console.WriteLine("Do you want to sum the matrix with itself?");
                            Console.ReadKey();
                            matrixes[n3 - 1].Summ(matrixes[n4 - 1]);
                        }
                        else
                        {
                            matrixes[n3 - 1].Summ(matrixes[n4 - 1]);
                        }
                    }
                    break;
                case "s":
                    Console.WriteLine("Input first matrix number that you want to subtract from");
                    n3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Input second matrix number that you want to subtract");
                    n4 = Convert.ToInt32(Console.ReadLine());
                    if (n3 > matrixes.Count || n4 > matrixes.Count)
                    {
                        Console.WriteLine("Matrix number doesn't exist");
                    }
                    else
                    {
                        if (n3 == n4)
                        {
                            Console.WriteLine("Do you want to subtract the matrix from itself?");
                            Console.ReadKey();
                            matrixes[n3 - 1].Subtraction(matrixes[n4 - 1]);
                        }
                        else
                        {
                            matrixes[n3 - 1].Subtraction(matrixes[n4 - 1]);
                        }
                    }
                    break;
                case "x":
                    Console.WriteLine("Input first matrix number that you want to multiply");
                    n3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Input second matrix number that you want to multiply");
                    n4 = Convert.ToInt32(Console.ReadLine());
                    if (n3 > matrixes.Count || n4 > matrixes.Count)
                    {
                        Console.WriteLine("Matrix number doesn't exist");
                    }
                    else
                    {
                        if (n3 == n4)
                        {
                            Console.WriteLine("Do you want to multiply the matrix at itself?");
                            Console.ReadKey();
                            matrixes[n3 - 1].Multiply(matrixes[n4 - 1], ref matrixes);
                        }
                        else
                        {
                            matrixes[n3 - 1].Multiply(matrixes[n4 - 1], ref matrixes);
                        }
                    }
                    break;
                default:
                    break;

            }
            Pending(matrixes);
        }
    }
}
