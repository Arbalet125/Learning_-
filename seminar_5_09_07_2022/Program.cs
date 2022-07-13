// firstNumber = 5;  // -  camelCase
// SearchResult()    // -  PascalCase
//{

//}

// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

/* int [] array = new int [12];
int size = array.Length;

int resultPositive = 0;
int resultNegative = 0;

for(int i = 0; i < size; i++)
{
    array[i] = new Random().Next(-9, 10);

    if (array[i] > 0)
    {
        resultPositive += array[i];
    }
    else
    {
        resultNegative += array[i];
    }
}

Console.WriteLine($"Исходный массив: [{String.Join(";",array)}]");
Console.WriteLine($"Cумма позитивных чисел в нем равна: {resultPositive}, сумма отрицательных: {resultNegative}"); */

// Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент,
//второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

/* int[] inputArray = { 1, 2, 3, 4, 5 };

int lastIndex = inputArray.Length - 1; // 5 - 1 = 4

int[] resultArray = new int[inputArray.Length / 2 + inputArray.Length % 2];

for (int i = 0; i < resultArray.Length; i++)
{
    resultArray[i] = inputArray[i] * inputArray[lastIndex - i];
    if (i == lastIndex - i)
        {
            resultArray[i] = inputArray[i];
        }
}
Console.WriteLine($"Ответ: [{String.Join("; ",resultArray )}]"); */

// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

/* int[] inputArray = { 4, -7, 12, -26, 5 };

int[] resultArray = new int[inputArray.Length];

for (int i = 0; i < resultArray.Length; i++)
{
    resultArray[i] = inputArray[i] * (-1);    
}
Console.WriteLine($"Ответ: [{String.Join("; ",resultArray )}]"); */



// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

/* Console.Write("Введите размер массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число, которое необходимо найти: ");
int findNumber = Convert.ToInt32(Console.ReadLine());

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(-99, 100);
        index++;
    }
}

int[] array = new int[arrayLength];

FillArray(array);
int count = 0;

for (int i = 0; i < arrayLength; i++)
{
    if (array[i] == findNumber)
    {
        count++;
    }
}

if (count > 0)
{
    Console.WriteLine($"Число {findNumber} присутствует в массиве [{String.Join(";", array)}]");
}
else
{
    Console.WriteLine($"Число {findNumber} не найдено в массиве [{String.Join(";", array)}]");
} */

/* int [] array = {1,2,3,4,5,88};

int searchNumber = -2;

bool flagResult = false; // false - ответ не найден

for (int i = 0; i<array.Length; i++)
{
if (searchNumber == array[i])
{
flagResult = true;
break;
}
}

if (flagResult) Console.WriteLine($"Элемент {searchNumber} найден");
else Console.WriteLine($"Элемент {searchNumber} НЕ найден"); */