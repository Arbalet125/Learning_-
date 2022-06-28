// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

// int number = new Random().Next(10, 100);
// Console.WriteLine($"Рандомное число: {number}");

// int digitOne = number / 10;
// int digitTwo = number % 10; 

// Console.WriteLine($"первая цифра нашего числа: {digitOne}");
// Console.WriteLine($"вторая цифра нашего числа: {digitTwo}");

// int Max = Math.Max(digitOne, digitTwo); // Max(первое число, второе число), Max возвращает максимальное число из ДВУХ чисел, указанных в скобках
// Console.WriteLine("БОльшая цифра из двух: " + Max);

//////////////////////////////////////////////////////////////////////////

// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// int number = new Random().Next(100, 1000);
// Console.WriteLine($"Рандомное число: {number}");
// int digitOne = number / 100;
// int digitThree = number % 10;

// int result = digitOne * 10 + digitThree;

// Console.WriteLine("" + result);

///////////////////////////////////////////////////////////////

// 12.Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// Console.Write("Веддите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Веддите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// int result = (firstNumber % secondNumber);

// if (result == 0)
//     {
//       Console.WriteLine("кратно");  
//     }
// else 
//     {
//         Console.WriteLine("не кратно, остаток: " + result);  
//     }
/////////////////////////////////////////////////////////////////

// 14.Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Write("Веддите число: ");
int number = Convert.ToInt32(Console.ReadLine());
 
bool parityCheck (int number)

{
    return(number % 7 == 0 && number % 23 == 0);
}

Console.WriteLine(parityCheck(number));

// if(parityCheck = true)
//     {
//         Console.WriteLine("Да");
//     }
// else
//     {
//         Console.WriteLine("Нет");
//     }

// if ((firstNumber % 7 == 0) && (firstNumber % 23 == 0))
//     {
//         Console.WriteLine("Да");
//     }
// else
//     {
//         Console.WriteLine("Нет");
//     }

