//////////////////////////////////////////////////////////////////Задача 54://////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.//////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

/* Console.Write("Введите количество строк массива: ");
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
} */
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//////////////////////////////////////////////////////////////////Задача 56://////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.//////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

/* Console.Write("Введите количество строк и столбцов прямоугольного массива: ");
int rowsColumns = Convert.ToInt32(Console.ReadLine());

int[,] GetArray(int m, int n)
{
    int[,] resultArray = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            resultArray[i, j] = new Random().Next(11);
        }
    }
    return resultArray;
}
void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(0); j++)
        {
            Console.Write(inputArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] matrix = GetArray(rowsColumns, rowsColumns);
PrintArray(matrix);
int result = 0; //результирующая переменная
int firstRowSum = 0; //здесь считаем элементы 1-ой строки, с которой будем сравнивать последующие
int temp = 0; //временная переменная, которая нужна только для операций сравнения

int Row = 0; // номер строки, в которой элементы с наименьшей суммы

for (int i = 0; i < matrix.GetLength(0); i++) 
{
    firstRowSum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++) 
    { 
        firstRowSum += matrix[i, j]; //Сумма всех элементов 1-ой строки.
    } 
    if (firstRowSum < temp)
    { result = firstRowSum; Row = i; }
    temp = firstRowSum;
}
Console.WriteLine("Наименьшаяя сумма = " + result);
Console.WriteLine("Номер строки, из элементов которой эта сумма получается = " + Row + 1); */

