//////////////////////////////////////////////////////////////////Задача 47://////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.//////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное число в массиве: ");
int maxNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное число в массиве: ");
int minNumber = Convert.ToInt32(Console.ReadLine());

int coeficent = new Random().Next(minNumber, maxNumber); //Коэфициент для того, чтобы получать числа не только в промежутке между -1 и 1



Random rand = new Random(); // зарезервируем память для случайного числа

double [,] matrix = new double [rows,columns];

for (int i = 0; i < matrix.GetLength(0); i++) //заполняем массив
{
    for (int j = 0; j < matrix.GetLength(1); j++) 
    {
        matrix[i,j] = rand.NextDouble()*coeficent;
    }
}

for (int i = 0; i < matrix.GetLength(0); i++) // выводим массив на экран
{
    for (int j = 0; j < matrix.GetLength(1); j++) 
    {
        Console.Write(Math.Round(matrix[i,j], 2) + "\t"); // Math.Round(х, 2) - выводим с двумя числами после запятой
    }
    Console.WriteLine();
}
