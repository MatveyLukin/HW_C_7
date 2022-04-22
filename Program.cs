
// Семинар7
// Задача №1
// Условие: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

// void NewRandomArray(int m, int n)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             matrix[i, j] = new Random().Next(-99, 100);
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// NewRandomArray(2, 6);

// Задача №2
// Условие: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
//Выведите полученный массив на экран.

// void NewRandomArray(int m, int n)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             matrix[i, j] = i + j;
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// NewRandomArray(2, 6);



// Задача №3
// Условие: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

// void FindBothPositiveElenents(int m, int n)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             matrix[i, j] = new Random().Next(1, 10);

//             if (i % 2 == 0 && j % 2 == 0)
//             {
//                 matrix[i, j] = matrix[i, j] * matrix[i, j];
//             }
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// FindBothPositiveElenents(3, 3);


// Задача №4
// Условие: Задайте двумерный массив. 
//Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

// void SumOfElenentsOnMainDiagional(int m)
// {
//     int sum = 0;
//     int[,] matrix = new int[m, m];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < m; j++)
//         {
//             matrix[i, j] = new Random().Next(0, 10);

//             if (i == j)
//             {
//                 sum = sum + matrix[i, j];
//             }
//             Console.Write("The sum is: " + sum);
//         }
//         Console.WriteLine();
//     }
// }
// SumOfElenentsOnMainDiagional(3);

//Домашняя работа №7
// Задача 1. 
// Условие: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// void NewRandomArray(int m, int n)
// {
//     double[,] matrix = new double[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             matrix[i, j] = new Random().NextDouble() * 200 - 100;
//             Console.Write("{0,0:F2} ", matrix[i, j]);

//         }
//         Console.WriteLine();
//     }
// }
// NewRandomArray(2, 3);



//Задача 2. 
// Условие: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//1 7 -> такого числа в массиве нет

// void Array (int m, int n)
// {
//     int [,] matrix = new int [m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             matrix [i, j] = new Random().Next (-10, 10);
//             Console.Write ($"{matrix [i,j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.Write ("Введите номер строки искомого элемента в матрице ");
//     int row = Convert.ToInt32(Console.ReadLine());
//     Console.Write ("Введите номер столбеца искомого элемента в матрице ");
//     int col = Convert.ToInt32(Console.ReadLine());
    
//     if (row > 0 || col > 0 || row <= m || col <= n)
//     {
//         Console.Write ($"{matrix [row,col]} "); 
//     }
//     else
//     {
//         Console.Write ("Такого элемента не существует в матрице ");
//     }
        
//     Console.WriteLine();
    
// }
// int LengthRow = 3;
// int LengthCol = 4;
// Array (LengthRow, LengthCol);

//Задача 3
// Условие: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void Array(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(-99, 100);
            Console.Write($"{matrix[i,j]} ");

        }
        Console.WriteLine();
    }
    Console.WriteLine();
    for (int i = 0; i < n; i++)
    {
        double Avrg = 0;
        for (int j = 0; j < m; j++)
        {
           Avrg = matrix[i,j] + Avrg; 
        }
        Console.Write("{0,0:F2} / ", Avrg/m);;
    }
    Console.WriteLine();
        
    
}

Array(3, 3);



