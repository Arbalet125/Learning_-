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

 ////////////////////////////
///////ЗАДАЧА №3////////////
////////////////////////////

/* 
Console.Write("Веддите день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
if (dayNumber >= 1 && dayNumber <= 8) //&& - and - обязательно выполняющееся условие
    {
        if (dayNumber == 6 || dayNumber == 7)
        {
            Console.WriteLine($"{dayNumber}-й день недели является выходным");
        }
        else
        {
            Console.WriteLine($"{dayNumber}-й день недели не является выходным");
        }
    }
else
    {
        Console.WriteLine("Неправильно задан день недели");
    } 
*/