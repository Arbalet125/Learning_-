﻿////////////////////////////
///////ЗАДАЧА №1////////////
////////////////////////////

/* Console.Write("Веддите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Веддите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int Max = Math.Max(firstNumber, secondNumber);
int Min = Math.Min(firstNumber, secondNumber);

if (firstNumber == secondNumber)
{
    Console.WriteLine("Числа равны");
}
else
{
    Console.WriteLine("БОльшая цифра из двух: " + Max);
    Console.WriteLine("Меньшая цифра из двух: " + Min);
}
*/

////////////////////////////
///////ЗАДАЧА №2////////////
////////////////////////////

/* Console.Write("Веддите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Веддите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Веддите третье число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());


int Max = Math.Max(firstNumber, secondNumber);
int secondMax = Math.Max(Max, thirdNumber);

if (firstNumber == secondNumber && firstNumber == thirdNumber)
{
    Console.WriteLine("Числа равны");
}
else
{
    Console.WriteLine("БОльшая цифра из трех: " + secondMax);
} */

////////////////////////////
///////ЗАДАЧА №3////////////
////////////////////////////

/* Console.Write("Веддите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = (number % 2);

if (result == 0)
    {
      Console.WriteLine("Да, число кратно двум");  
    }
else 
    {
        Console.WriteLine("Нет, число не кратно двум");  
    } 
*/

////////////////////////////
///////ЗАДАЧА №4////////////
////////////////////////////

/* Console.Write("Веддите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
int listCount = 1;
while (count <= number)
{
    int result = (count % 2);
    if (result == 0)
        {
            Console.WriteLine($"{listCount}-e число кратное двум в промежутке от 1 до {number}: " + count);  
            listCount ++;
        }
    count++;
} 
*/