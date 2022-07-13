/* 
void FillArray(int [] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        Console.Write($"Введите {index}-ю цифру пятизначного числа: ");
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
    //int temp = 0;
    int palLength = pal.Length;
    int palIndex = 0;
    int tempIndex = palLength - (palIndex + 1);
    while(palIndex < palLength)
    {
        // if (pal[palIndex] == pal[tempIndex])
        // {
        //     temp++;
        // }
        palIndex++;
        tempIndex++;
    Console.WriteLine(pal[palIndex]);
    }
}
//     if (temp == palLength)
//     {
//        Console.WriteLine(", и оно является палиндромом");
//     }
//     else
//     {
//         Console.WriteLine(", и оно не является палиндромом");
//     }
// }

int[] array = new int[5];

FillArray(array);
PrintArray(array);
Palindrom(array);
 */

// int number = Convert.ToInt32(Console.ReadLine());
       
// void IsPalindrome(int[] num)
// {
//     int numLength = num.Length;
//     int[] digits = new int[numLength];
//     for (int i = numLength - 1; i >= 0; i--) 
//     {
//         digits[i] = number % 10;
//         number /= 10;
//     }
// }

// IsPalindrome(number);