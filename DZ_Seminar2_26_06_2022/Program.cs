////////////////////////////
///////ЗАДАЧА №1////////////
////////////////////////////

/* 
Console.Write("Веддите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int digitOne = (number / 10);
int digitTwo = (digitOne % 10);

if (number > 999 || number < 100)
    {
        Console.Write("Веддено неверное число");
    }
    else
    {
        Console.Write($"Вторая цифра числа {number}: " + digitTwo);
    } 
*/

////////////////////////////
///////ЗАДАЧА №2////////////
////////////////////////////

/* 
Console.Write("Веддите число: ");
int originalNumber = Convert.ToInt32(Console.ReadLine());
int number = originalNumber;

if (number < 10)
    {
        Console.WriteLine($"Вы ввели однозначное число, второй цифры числа {originalNumber} не существует");
        return;
    }

while (number > 100)
    {
        number = number / 10;
    }
if (number < 10)
   {
        Console.WriteLine($"Вторая (с начала) цифра числа {originalNumber}: " + number);
    }
else
    {
        while (number >= 10) 
        {
            number = number - 10;
        }
        Console.WriteLine($"Вторая (с начала) цифра числа {originalNumber}: " + number);    
    }
 */