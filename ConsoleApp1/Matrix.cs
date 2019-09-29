using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Matrix
    {
        public int m;
        public int n;
        public int[,] matrix;

        public void CreateManualy(int m, int n, ref List<Matrix> matrixes)
        {
            this.matrix = new int[m,n];
            for (int m1 = 0; m1 < m; m1++)
            {
                for (int n1 = 0; n1 < n; n1++)
                {
                    Console.WriteLine($"Input element number {m1}, {n1}");
                    this.matrix[m1, n1]=Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
            this.m = m;
            this.n = n;
            matrixes.Add(this);
        }


        public void CreateRandomly(int m, int n, ref List<Matrix> matrixes)
        {
            Random rnd = new Random();
            this.matrix = new int[m,n];
            for (int m1 = 0; m1 < m; m1++)
            {
                for (int n1 = 0; n1 < n; n1++)
                {
                    this.matrix[m1, n1] = (int)rnd.Next(0, 9);
                }
            }
            this.m = m;
            this.n = n;
            matrixes.Add(this);          
        }

        public void Show()
        {
            for (int m1 = 0; m1 < this.m; m1++)
            {
                for (int n1 = 0; n1 < this.n; n1++)
                {
                    Console.Write(this.matrix[m1,n1]+" | ");
                }
                Console.WriteLine();
            }
        }

        public void Summ(Matrix matrix)
        {
            if (this.m != matrix.m || this.n != matrix.n)
            {
                Console.WriteLine($"Matrixes dimensions are {this.m}x{this.n} and {matrix.m}x{matrix.n}");
                return;
            }
            else
            {
                for (int m = 0; m < this.m; m++)
                {
                    for (int n = 0; n < this.n; n++)
                    {
                        this.matrix[m, n] += matrix.matrix[m,n];
                    }
                }
                Show();
            }
        }

        public void Subtraction(Matrix matrix)
        {
            if (this.m != matrix.m || this.n != matrix.n)
            {
                Console.WriteLine($"Matrixes dimensions are {this.m}x{this.n} and {matrix.m}x{matrix.n}");
                return;
            }
            else
            {
                for (int m = 0; m < this.m; m++)
                {
                    for (int n = 0; n < this.n; n++)
                    {
                        this.matrix[m, n] -= matrix.matrix[m, n];
                    }
                }
                Show();
            }
        }

        public void Multiply(Matrix matrix, ref List<Matrix> matrixes)
        {
            if (this.n != matrix.m)
            {
                Console.WriteLine($"Matrixes dimensions are {this.m}x{this.n} and {matrix.m}x{matrix.n}");
                return;
            }
            else
            {
                Matrix result = new Matrix();
                result.m = this.m;
                result.n = matrix.n;
                result.matrix = new int[result.m, result.n];

                for (int m = 0; m < this.m; m++)
                {
                    for (int n = 0; n < matrix.n; n++)
                    {
                        int a =0;
                        for (int i = 0; i < this.n; i++)
                            a += this.matrix[m, i]* matrix.matrix[i, n];
                        result.matrix[m, n] = a;
                    }
                }
                matrixes.Add(result);
                result.Show();
            }
        }
    }


}
