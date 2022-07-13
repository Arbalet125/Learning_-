// int [] array = {1, 2 , 3, 4, 5}
// Console.WriteLine($"[{String.Join(";",array)}]"); // через String.join (разделитель, название переменной) - переводит в строчную переменную


// почитать про методы разработки

// Демонстрация решения
// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

// int number = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// for (int i = 1; i <= number; i++)
// {
//     Console.WriteLine($"число = {i}");
//     sum += i;
//     Console.WriteLine($"сумма = {sum}");
       
// }
// Console.WriteLine($"Сумма всех чисел от 1 до {number}, равно " + sum);

// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

/* Console.Write("Введите число ");

string number = Console.ReadLine();
if (number.StartsWith("-")) number = number.Substring(1); 

Console.WriteLine($"В числе {number.Length} цифр"); */

// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

/* Console.Write("Введите число ");

int number = Convert.ToInt32(Console.ReadLine());
int Multiplication = 1;

for (int i = 1; i <= number; i++)
{
    Multiplication *= i;
}

Console.WriteLine($"Результат {Multiplication} "); */

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

/* int [] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(2);
}

Console.WriteLine($"[{String.Join(";",array)}]"); */

/* int[] array = GetBinaryArray(8);
Console.WriteLine($"[{String.Join("; ", array)}]");
int[] GetBinaryArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i<size; i++)
    {
        result[i] = new Random().Next(2);
    }
    return result;
} */
