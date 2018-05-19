using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class MyMatrix
    {
        private int a, b, c, d;
        public MyMatrix(int a, int b)
        {
            Random r = new Random();
            for (int i = 0; i < a; i++)
                for (int j = 0; j < b; j++)
                    Matrix[i, j] = r.Next(-100, 100);
        }
        public int[,] Matrix = new int[100, 100];

        public void Output_main(int c, int d) //метод вывода матрицы
        {
            //выводим матрицу 
            for (int i = 0; i < c; i++)
            {
                for (int j = 0; j < d; j++)
                    Console.Write(Matrix[i, j] + "\t");
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }

    class PodMatrix
    {
        public PodMatrix(ref int[,] matr, int a, int b)
        //в конструктор передаём параметры: указатель на исх. матрицу, длинну ширину создаваемой матрицы
        {
            A = a; B = b;
            for (int i = 0; i < a; i++)
                for (int j = 0; j < b; j++)
                    Array[i, j] = matr[i, j]; //передаём элементы исх. матрицы в подматрицу
        }

        private int A, B; // А,В - размер матрицы
        private int[,] Array = new int[50, 50]; //объявляем матрицу

        public void Output_inner() //метод вывода подматрицы
        {
            for (int i = 0; i < A; i++)
            {
                for (int j = 0; j < B; j++)
                    Console.Write(Array[i, j] + "\t");
                Console.Write("\n");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            int a, b, c, d;
            Console.WriteLine("Дана матрица: Martix[a, b]");
            Console.Write("Введите количество строк a = ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов b = ");
            b = Int32.Parse(Console.ReadLine());
            MyMatrix main_matrix = new MyMatrix(a, b);
            main_matrix.Output_main(a, b);

            Console.WriteLine("Выводим на экран подматрицу:");
            Console.WriteLine("Дана матрица: PodMatr[c, d]");
            Console.Write("Введите количество строк подматрицы c = ");
            c = Int32.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов подматрицы d = ");
            d = Int32.Parse(Console.ReadLine());

            PodMatrix inner_matrix = new PodMatrix(ref main_matrix.Matrix, c, d);
            inner_matrix.Output_inner();
            Console.ReadKey();
        }
    }
}
