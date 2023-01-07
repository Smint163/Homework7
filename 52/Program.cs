/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] array = new int[3,4];

    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i,j] = new Random().Next(0, 10);
                    Console.Write($"{array[i, j]} ");
                }
            Console.WriteLine();   
        }

float aver = 0;
float summ = 0;

Console.WriteLine("Среднее арифметическое каждого столбца:");

 for (int j = 0; j < array.GetLength(1); j++)
    {
        aver = 0;
        summ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        {
            summ = array[i,j] + summ;
            aver = summ / array.GetLength(0) ;
        }

    Console.Write($"{Math.Round(aver, 2)} ");
    }

