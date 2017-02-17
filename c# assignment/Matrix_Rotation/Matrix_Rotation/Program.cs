using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_Rotation
{

    class Rotation
    {
        
        public void display(int n,int m,int[,] numbers)
        {
            int R = n, C = m;
            int row = 0, column = 0;
            int i, j;
            int prev, current;


            Console.WriteLine("before rotation....");
            for (i = 0; i < R; i++)
            {
                for (j = 0; j < C; j++)
                {

                    Console.Write(" " + numbers[i, j]);

                }

                Console.WriteLine();

            }

            while (row < n && column < m)
            {
                if (row + 1 == n || column + 1 == m)
                    break;

                prev = numbers[row + 1, m-1];


                for (j = m-1; j >= column; j--)
                {
                    current = numbers[row , j];
                    numbers[row, j] = prev;
                    prev = current;

                }
                
                row++;

                for (i = row; i < n; i++)
                {

                    current = numbers[i, column];
                    numbers[i, column] = prev;
                    prev = current;

                }
                column++;

                if (row < n)
                {
                    for (j = column; j < m; j++)
                    {

                        current = numbers[n-1, j];
                        numbers[n-1, j] = prev;
                        prev = current;
                    }

                }
               
                n--;

                if(column < m)
                {
                    for (i = n - 1; i >= row; i--)
                    {

                        current = numbers[i, m-1];
                        numbers[i, m-1] = prev;
                        prev = current;
                    }

                }

                m--;

            }


            Console.WriteLine("After rotation....");

            for (i = 0; i < R; i++)
            {
                for(j=0; j < C; j++)
                {

                    Console.Write(" "+numbers[i, j]);

                }

                Console.WriteLine();

            }

            Console.Read();

        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = new int[10,10];
            int row, column;
            Rotation rotate = new Rotation();
            Console.WriteLine("Enter number of rows");
            row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of columns");
            column = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements");

            for(int i=0; i<row; i++)
            {

                for (int j = 0; j < column; j++)
                {

                    numbers[i, j] = Convert.ToInt32(Console.ReadLine());

                }

            }

          //  Console.WriteLine("Enter number of rotations");
           // int num_rotation = Convert.ToInt32(Console.ReadLine());

            rotate.display(row, column, numbers);

          
        }
  
    }
}
