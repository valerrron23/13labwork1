using System;

class Program
{

    static void Main(string[] args)
    { //Дана матрица размера n X n. В каждом столбце матрицы найти максимальный элемент.
        Random r = new Random();
        Console.WriteLine("Введите кол-во строк");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите кол-во столбцов");
        int m = int.Parse(Console.ReadLine());
        int[,] A = new int[n, m];
        Console.WriteLine("Исходный массив"); // записываем построчно 
        for (int i = 0; i < A.GetLength(0); ++i)
        {
            for (int j = 0; j < A.GetLength(1); ++j)
            {

                A[i, j] = r.Next(-99, -10);
                Console.Write(A[i, j] + "  ");


            }
            Console.WriteLine("");
        }
        Console.WriteLine("Максимальные элементы в каждом стольце"); // выполняем задание читая по столбцам
        for (int i = 0; i < A.GetLength(1); ++i)
        {
            int tempmax = int.MinValue;
            for (int j = 0; j < A.GetLength(0); ++j)
            {
                if (A[j, i] > tempmax)
                {
                    tempmax = A[j, i];
                }
            }

            Console.WriteLine("В столбце номер {0} -> {1}", i, tempmax);

        }
        Console.ReadKey();

    }

}