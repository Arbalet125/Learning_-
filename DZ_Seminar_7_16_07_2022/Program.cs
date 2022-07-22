//////////////////////////////////////////////////////////////////Задача 47://////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.//////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

/* Console.Write("Введите количество строк массива: ");
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
 */

// Эту задачу можно было сделать через метод, но, т.к. через метод мы уже делали практически эту же на семинаре, я решил попробовать без метода :)

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


//////////////////////////////////////////////////////////////////Задача 50://////////////////////////////////////////////////////////////////////////////////////////////
////Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.////
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//Для случая, когда ищем число в массиве, а не его индексы

/* Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите искомое число: ");
int searchNumber = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];

for (int i = 0; i < matrix.GetLength(0); i++) 
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(10);

    }
}
for (int i = 0; i < matrix.GetLength(0); i++) // лучше вывести массив на экран для наглядности
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
int count = 0; // в данном случае, возможно, и не нужен, но я оставлю для оператора if, ибо мне так спокойнее :)
for (int i = 0; i < matrix.GetLength(0); i++) 
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (searchNumber == matrix[i,j])
        {
            Console.WriteLine(); // чтобы была строчка после массива пустая           
            Console.WriteLine($"Число {searchNumber} в первый раз встречается на {i+1}-ой строчке и {j+1}-ом столбце массива"); // просто приятнее для глаз если будет выводится не 
            // "0-ая строчка массива", а "1-ая строчка массива", ибо пользователю так будет нагляднее, по-моему :)
            count++; // просто для подстраховки, если вдруг надо будет что-то добавить. Вообще в данном случае нет необходимости, но для общего случая оставлю.
            return; // чтобы тормознуть выполнение после нахождения элемента
        } 
    }
    Console.WriteLine();
}
if (count == 0) Console.WriteLine($"Число {searchNumber} не существует в данном массиве"); // в данном случае, можно было обойтись без if, но, опять же, для общего случая оставлю :)
 */

// Для случая, когда ищем индексы числа в массиве

/* Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное число в массиве: ");
int maxNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное число в массиве: ");
int minNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите строку, на которой находится искомое число: ");
int rowIndex = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите столбец, на котором находится искомое число: ");
int columnIndex = Convert.ToInt32(Console.ReadLine());

int [,] GetArray(int m, int n, int min, int max) // параметры в скобках Get: строчки, столбцы, минимальное число в матрице, максимальное число в матрице
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
void PrintArray (int[,] inputArray)
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

void SearchResult (int [,] newArray) // находим элемент по индексу
{
    for (int i = 0; i < newArray.GetLength(0); i++) 
{
    for (int j = 0; j < newArray.GetLength(1); j++)
    {
        if (rowIndex == i && columnIndex == j)
        {
            Console.WriteLine($"Число с индексом [{rowIndex},{columnIndex}] равно " + newArray[i, j]);
            return;
        }
    }
}   
Console.WriteLine($"Число с индексом [{rowIndex},{columnIndex}] не существует в данном массиве");
}

int[,] array = GetArray(rows, columns, minNumber, maxNumber);
PrintArray(array);
SearchResult(array); 

// на этот раз сделал с методами, чтобы было нагляднее :)
*/

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


//////////////////////////////////////////////////////////////////Задача 52://////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.//////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


