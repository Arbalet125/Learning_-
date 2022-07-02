// ///////////////////////////////////////Задача 19////////////////////////////////////////////////////////////
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.///
// ///////////////////////////////////////14212 -> нет/////////////////////////////////////////////////////////
// ///////////////////////////////////////12821 -> да//////////////////////////////////////////////////////////
// ///////////////////////////////////////23432 -> да//////////////////////////////////////////////////////////

/* void FillArray(int [] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        Console.Write($"Введите {index}-ю цифру пятизначного нам числа: ");
        collection[index] = Convert.ToInt32(Console.ReadLine());
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    Console.WriteLine("Введенное вами число:");
    while(position < count)
    {
        Console.Write(col[position]);
        position ++;
    }
}

void Palindrom(int[] pal)
{
    int temp = 0;
    int palLength = pal.Length;
    int palIndex = 0;
    int tempIndex = palLength - (palIndex + 1);
    while(palIndex < palLength)
    {
        if (pal[palIndex] == pal[tempIndex])
        {
            temp++;
        }
        palIndex++;
        tempIndex++;
    }
    if (temp == palLength)
    {
       Console.WriteLine(", и оно является палиндромом");
    }
    else
    {
        Console.WriteLine(", и оно не является палиндромом");
    }
}

int[] array = new int[5];

FillArray(array);
PrintArray(array);
Palindrom(array); */


////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


///////////////////////////////////////////////////////Задача 21///////////////////////////////////////////////////////////
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


/* Console.WriteLine("Введите координаты первой точки в трехмерном пространстве:");
int xA = Convert.ToInt32(Console.ReadLine());
int yA = Convert.ToInt32(Console.ReadLine());
int zA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки в трехмерном пространстве:");
int xB = Convert.ToInt32(Console.ReadLine());
int yB = Convert.ToInt32(Console.ReadLine());
int zB = Convert.ToInt32(Console.ReadLine());

double distance = Math.Round(Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA - zB, 2)));

Console.WriteLine("");
Console.WriteLine("Расстояние между заданными точками " + distance); */


////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


///////////////////////////////////////////////////////Задача 23///////////////////////////////////////////////////////////
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N./////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

Console.Write("Веддите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
    Console.WriteLine($"Квадарт числа {i} равен {Math.Pow(i, 3)}");
}