/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

Console.WriteLine("Введите номер строки");
int num1 = Convert.ToInt32(Console.ReadLine())-1;
Console.WriteLine("Введите номер столбца");
int num2 = Convert.ToInt32(Console.ReadLine())-1;

Console.WriteLine($"Индекс элемента {num1+1}{num2+1}");

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

if (num1 < 0 || num1 > array.GetLength(0)-1 || num2 < 0 || num2 > array.GetLength(1)-1)
{
    Console.WriteLine("Такого числа в массиве нет");
}
else
{
    Console.WriteLine($"Значение элемента {array[num1, num2]}");
}
