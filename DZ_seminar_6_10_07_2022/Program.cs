///////////////////////////////////////////////////////////////////Задача 41:////////////////////////////////////////////////////////////////////////////////
//////////////////////////////Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

/* Console.Write("Введите число М: ");
int mNumber = Convert.ToInt32(Console.ReadLine());

int[] array = new int[mNumber];
int countNumbers = 0;
for (int i = 0; i < mNumber; i++)
{
    Console.Write($"Введите {i + 1}-е число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    if (array[i] > 0) countNumbers ++;
}

Console.WriteLine($"Среди чисел [{String.Join("; ", array)}] вы ввели {countNumbers} положительных."); */


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


///////////////////////////////////////////////////////////////////Задача 41:///////////////////////////////////////////////////////////////////////////////////////////////
//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем//
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// x = (b2 - b1) / (k1 - k2);
// y = y = k1 * x + b1;

/* Console.Write($"Введите точку пересечения первой прямой с осью Y: ");
double firstLinePointCrossWithY = Convert.ToDouble(Console.ReadLine()); //b1

Console.Write($"Введите угловой коэффицент первой прямой: ");
double firstLineAngularCoefficient = Convert.ToDouble(Console.ReadLine()); //k1

Console.Write($"Введите точку пересечения второй прямой с осью Y: ");
double secondLinePointCrossWithY = Convert.ToDouble(Console.ReadLine()); //b2

Console.Write($"Введите угловой коэффицент второй прямой: ");
double secondLineAngularCoefficient = Convert.ToDouble(Console.ReadLine()); //k2

double firstCrossCoordinate = (secondLinePointCrossWithY - firstLinePointCrossWithY) / (firstLineAngularCoefficient - secondLineAngularCoefficient);

double secondCrossCoordinate = (firstLineAngularCoefficient * firstCrossCoordinate) + firstLinePointCrossWithY;

Console.WriteLine($"Прямые пересекуться в точке [{firstCrossCoordinate}; {secondCrossCoordinate}]"); */
