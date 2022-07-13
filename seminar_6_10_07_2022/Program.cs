// int[] array = GetArray(10, 0, 10);
// Console.WriteLine(String.Join(" ", array));

// int[] reversArray=PrintReversItem(array);
// Console.WriteLine(String.Join(" ", reversArray));

// ReversArray(array);
// Console.WriteLine(String.Join(" ", array));


// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }

// void ReversArray(int[] inArray)
// {
//     for (int i = 0; i < inArray.Length / 2; i++)
//     {
//         int temp = inArray[i];
//         inArray[i] = inArray[inArray.Length - i - 1];
//         inArray[inArray.Length - i - 1] = temp;
//     }
// }

// int[] PrintReversItem(int[] inArray)
// {
//     int[] result = new int[inArray.Length];
//     for (int i = 0; i < inArray.Length; i++)
//     {
//         result[i] = inArray[inArray.Length - 1 - i];
//     }

//     return result;
// }

// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

// Длины сторон треугольника удовлетворяют неравенству треугольника: длина любой стороны треугольника меньше суммы длин двух других сторон. a < b + c

/* Console.Write("Введите длину первой стороны треугольника: ");
int triangleSide1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите длину первой стороны треугольника: ");
int triangleSide2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите длину первой стороны треугольника: ");
int triangleSide3 = Convert.ToInt32(Console.ReadLine());

if (triangleSide1 < (triangleSide2 + triangleSide3) && triangleSide2 < (triangleSide1 + triangleSide3) && triangleSide3 < (triangleSide1 + triangleSide2))
{
    Console.Write("Треугольник может существовать ");
}
else
{
    Console.Write("Треугольник не может существовать ");
} */

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

//
// int N = Convert.ToInt32(Console.ReadLine());
// int[] array = new int [N];
// int sum = 0;
// for (int i = 0; i<N; i++)
// {
//     if (i == 0|| i == 1)
//     {
//         array[i] = 1;
//     }
//     else
//     {
//     sum = sum + 
//     }
//     Console.Write(sum);
// }

/* Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int previousElement = 0;
int currentElement = 1;
int tempElement = currentElement;
Console.WriteLine(previousElement);
for (int i = 0; i <= N; i++)
{
    Console.WriteLine(currentElement);
    tempElement = currentElement;
    currentElement = currentElement + previousElement;
    previousElement = tempElement;
} */

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

/* void ConversionBinary(int number)
{
    string result = "";
    while (number > 0)
    {
        result = number%2 + result; //записываем СТРОЧКУ наоборот, чтобы получить сначала конец 
        number/=2;
    }
Console.WriteLine(result);
}
int inputNumber = Convert.ToInt32(Console.ReadLine());
ConversionBinary(inputNumber); */

//ДЗ:

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)