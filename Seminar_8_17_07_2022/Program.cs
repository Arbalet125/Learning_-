
// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

/* Console.Write("Введите количество строк ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());
int [,] GetMatrix(int m, int n, int min, int max) // параметры в скобках Get: строчки, столбцы, минимальное число в матрице, максимальное число в матрице
{
    int [,] resultArray = new int [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            resultArray[i,j] = new Random().Next(min, max + 1);
        }
    }
    return resultArray;
}
int [,] matrix = GetMatrix (rows, columns, 0, 10);

void PrintArray() (int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(0); j++)                
        {
            Console.Write(inputArray[i,j] +"\t");
        }
    Console.WriteLine();
    }
}
 */

//То же самое:

/* Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
/// summary
/// строчки - m, столбцы - n; min , max
int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++) // Строчки
    {
        for (int j = 0; j < n; j++) // Столбцы
        {
            result[i, j] = new Random().Next(min, max + 1); // [min,max]
        }
    }
    return result;
}

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + "\t"); // tab - "\t"
        }
        Console.WriteLine();
    }
}

void ChangesRows(int[,] matrix)
{
    int rowCount = matrix.GetLength(0) - 1; // Последняя строка
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int temp = matrix[0, i];
        matrix[0, i] = matrix[rowCount, i];
        matrix[rowCount, i] = temp;

    }
}

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
ChangesRows(array);
System.Console.WriteLine();
System.Console.WriteLine();
PrintArray(array); */

// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.**
/


/* Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++) // Строчки
    {
        for (int j = 0; j < n; j++) // Столбцы
        {
            result[i, j] = new Random().Next(min, max + 1); // [min,max]
        }
    }
    return result;
}

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + "\t"); // tab - "\t"
        }
        Console.WriteLine();
    }
}

void ChangesRows(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            System.Console.Write(matrix[j,i] + "\t");
        }
        System.Console.WriteLine();
    }
}

// то же что и чейндж роус, но с доп массивом.
// int[,] ChangeArray(int[,] array)
// {
//     int[,] result = new int[array.GetLength(0), array.GetLength(1)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             result[j, i] = array[i, j];
//         }
//     }
//     return result;
// }




int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
ChangesRows(array);
System.Console.WriteLine();
System.Console.WriteLine();
 */

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1

int rows = 3;
int columns = 3;
 
int[,] matrix = new int[rows, columns];
 
int minValue = int.MaxValue; //Значение минимального элемента
int minIndexRows = 0;        //Задание индекса минимального элемента (строчка)
int minIndexColumns = 0;     //Задание индекса минимального элемента (столбец)
 
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(11); // [0,10]
        Console.Write(matrix[i, j] + "\t");
        if (minValue > matrix[i, j])
        // minValue = 5(пусть)
        // 5>0, то минимум уже не 5, minValue = 0
        {
            minValue = matrix[i, j];
            minIndexRows = i;
            minIndexColumns = j;
        }
 
    }
    Console.WriteLine();
}
Console.WriteLine("Минимум:" + minValue);
System.Console.WriteLine("Результат:");
for (int i = 0; i < rows; i++) // rows = GetLength(0)
{
    if (i != minIndexRows)
    {
        for (int j = 0; j < columns; j++) //columns - GetLength(1)
        {
            if (j != minIndexColumns)
            {
                Console.Write(matrix[i,j] + "\t");
 
            }
        }
        System.Console.WriteLine();
    }
}
