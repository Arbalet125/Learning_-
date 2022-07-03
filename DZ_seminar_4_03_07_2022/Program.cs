////////////////////////////////////////////////////////////////////Задача 25:///////////////////////////////////////////////////////////
////////////////////////Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.///////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


//Без цикла:
/* Console.Write("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Число {numberOne} в степени {numberTwo}, будет: {Math.Pow(numberOne, numberTwo)}"); */

//С циклом:

/* Console.Write("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
int tempOne = numberOne;

Console.Write("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < numberTwo; i++)
{
    tempOne *= numberOne;
}
Console.WriteLine($"Число {numberOne} в степени {numberTwo}, будет: {tempOne}"); */

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

////////////////////////////////////////////////////////////////////Задача 27:///////////////////////////////////////////////////////////
////////////////////////////////Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе./////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

/* Console.Write("Введите число: "); 
int number = Convert.ToInt32(Console.ReadLine());
int tempNumber = number;
int result = 0;
int digit = 0;
while(number > 0)
{
    digit = number % 10;
    result += digit;
    number /= 10;
}
Console.WriteLine($"Сумма цифр числа {tempNumber}, будет составлять: {result}"); */

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

////////////////////////////////////////////////////////////////////Задача 29:///////////////////////////////////////////////////////////
////////////////////////////////Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.//////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//Через методы из лекции:


Console.Write("Введите размер массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());

void FillArray(int [] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        Console.Write($"Введите {index}-й элемент массива: ");
        collection[index] = Convert.ToInt32(Console.ReadLine());
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    Console.WriteLine("Введенный вами массив: ");
    Console.Write("[ ");
    while(position < count)
    {
        Console.Write($"{col[position]} ");
        position ++;
    }
Console.Write("]");
}   
int[] array = new int[arrayLength];

FillArray(array);
PrintArray(array);

///////// Через методы с семинара:

/* Console.Write("Введите размер массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());

int [] array = new int[arrayLength];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите {i}-й элемент массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"[{String.Join("; ", array)}]");  */