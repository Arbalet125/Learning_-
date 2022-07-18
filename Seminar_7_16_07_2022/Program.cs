// var переменная - если неизвестен тип переменной. Обычно, если неизвестен тип, переводит в тип string: var test = "2" + 2 // результатом будет 22

//Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

//string? test = Console.ReadLine(); - вопросительный знак означает объеденить элементы с null, то есть не будет предупреждения.

/* int rows = int.Parse(Console.ReadLine()); // можно задать считывание с клавиатуры и таким образом. Также можно задать простой формулой: int.Parse(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());


int [,] matrix = new int[rows,columns]; // так задают двумерный массив

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix [i,j] = new Random().Next(11);
        Console.WriteLine(matrix[i,j] + "\t");
    }
    Console.WriteLine("");
}
 */

// int rows = int.Parse(Console.ReadLine());
// int columns = Convert.ToInt32(Console.ReadLine());
// int [,] matrix = new int[rows,columns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++) //обрти внимание, что длину столбца начинается с еденицы GetLength(1)
//     {
//         matrix[i,j] = new Random().Next(11);
//         // [0;11) -> [0;10]
//         Console.Write(matrix[i,j] + "\t"); // Литералы
//     }
//     Console.WriteLine();
// }

// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


/* Console.Write("Введите количество строк ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов ");
int [,] matrix = new int[rows,columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = i + j;
        Console.Write(matrix[i,j] + "\t"); 
    }
    Console.WriteLine();
} */

// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

/* Console.Write("Введите количество строк ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int[rows,columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(11);
        Console.Write(matrix[i,j] + "\t"); 
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < matrix.GetLength(0); i+= 2)
{
    for (int j = 0; j < matrix.GetLength(1); j+=2)
    {
    matrix[i, j] *= matrix[i,j];
    }
}
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i,j] + "\t"); 
    }
    Console.WriteLine();
}
 */


// Задача 51: Найти сумму элементов главной диагонали.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

/* Console.Write("Введите количество строк ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int[rows,columns];
int summ = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(11);
        Console.Write(matrix[i,j] + "\t");
        if (i == j) summ += matrix[i, j]; 
    }
    Console.WriteLine();
}

Console.WriteLine($"Сумма элементов главной диагонали {summ}");
 */

/* double test = 3.1452667
                                                    // округление
Console.WriteLine(Math.Round(test, 2)); */   