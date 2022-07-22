﻿//////////////////////////////////////////////////////////////////Задача 54://////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.//////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];

Console.WriteLine("Изначальный массив имеет вид: ");

for (int i = 0; i < matrix.GetLength(0); i++) 
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(10);
        Console.Write(matrix[i, j] + "\t"); // в интернетах пишут, что делать два действия в одном блоке - это плохой тон, но пока так и оставлю.
    }
    Console.WriteLine();
}

int[] temp = new int[columns]; //временный одномерный массив, который можно представить, как нужную нам строку


Console.WriteLine("После сортировки строк получаем: ");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
        temp[j] = matrix[i, j];
    Array.Sort(temp); //выучил новую команду, которая позволяет сортировать массив по возрастанию!
    Array.Reverse(temp); //просто развернул этот массив
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        matrix[i, k] = temp[k];
        Console.Write(matrix[i, k] + "\t");
    }
    Console.WriteLine();
}
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////