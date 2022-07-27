//выведите все значения от 1-го до N

/* Console.Write("Введите число N: ");

int N = Convert.ToInt32(Console.ReadLine());

string PrintNumbers(int start, int end)
// 1 - start, end - N
{
    // Базовый случай
    if (start == end) return start.ToString();
    // Рекурсивный случай
    return (start + ", " + PrintNumbers(start + 1,end));
}

System.Console.WriteLine(PrintNumbers(1, N));
 */

/*  // Задача 65: Задайте значения M и N. 
// Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

string PrintNumbers(int start, int end)
// 1 - start, end - N
{
    // Базовый случай
    if (start == end) return start.ToString();
    // Рекурсивный случай
    return (start + ", " + PrintNumbers(start + 1, end));
}
Console.WriteLine(PrintNumbers(M, N));
 */

//  Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

/* int ReturnSum(int n)
{
    if (n % 10 == 0 && n < 10) return 0;
    return (n%10) + ReturnSum(n/10);
}
Console.Write(ReturnSum(101110)); */


// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Write("Enter the number please: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number please: ");
int b = Convert.ToInt32(Console.ReadLine());

int PowerOf(int number, int power)
{
    if (number == 0) return 0;
    else if (power == 0) return 1;
    return number * PowerOf(number, power-1);
}
Console.Write(PowerOf(a,b));
