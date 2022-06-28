// Console.Write("Веддите день недели: ");
// int dayNumber = Convert.ToInt32(Console.ReadLine());
// if (dayNumber >= 1 && dayNumber <= 8) //&& - and - обязательно выполняющееся условие
//     {
//         if (dayNumber == 1)
//         {
//             Console.WriteLine("Понидельник");
//         }
//         if (dayNumber == 2)
//         {
//             Console.WriteLine("Вторник");
//         }
//         if (dayNumber == 3)
//         {
//             Console.WriteLine("Среда");
//         }
//         if (dayNumber == 4)
//         {
//             Console.WriteLine("Четверг");
//         }
//         if (dayNumber == 5)
//         {
//             Console.WriteLine("Пятница");
//         }
//         if (dayNumber == 6)
//         {
//             Console.WriteLine("Суббота");
//         }
//         if (dayNumber == 7)
//         {
//             Console.WriteLine("Воскрсенье");
//         }
//     }
//     else
//     {
//         Console.WriteLine("Неправильно задан день недели");
//     }
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Напишите программу, которая на вход принимает 
//одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

Console.Write("Веддите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int negativeN = N * (-1); //4*(-1) = -4, -4+1 =-3, -3+1 = -2 
// (-N) до N 

while (negativeN <= N)
{
    Console.WriteLine(negativeN);
    negativeN++; // negativeN = negativeN + 1
}


