//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
/*
int DeletDec(int new_number)
{
    int digit1 = new_number / 100; //456 / 100 = 4
    int digit2 = new_number / 10;  //456 / 10 = 45
    int new_num = digit2 % 10;
    Console.WriteLine($"Second digit of your number is {new_num}");
    return new_num;
}

Console.WriteLine("Enter your number: ");
int new_num = Convert.ToInt32(Console.ReadLine());
if(new_num > 99 && new_num < 1000 || new_num < -99 && new_num > -1000)
{
    DeletDec(new_num);
}
else
{
    Console.WriteLine("Error! Your number is not 3-digit!");
}
*/
//Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.
//есть одна погрешность, я сделала только для трехзначных чисел код, как для 4х значных 
//и более сделать код, чтоб искал только 3 цифру, я не знаю 
/*
int Digit1(int user_num)
{
    int digit1 = user_num / 100; //456 = 4
    int digit2 = user_num / 10; //456 = 5
    int digit3 = user_num % 10; //456 = 6
    int result = digit3;
    Console.WriteLine("The 3rd digit of your number " + user_num + " is: " + result);
    return result;
}
Console.WriteLine("Enter your number: ");
int user_number = Convert.ToInt32(Console.ReadLine());

    if(user_number > 99 && user_number < 1000 || user_number < -99 && user_number > - 1000)
    {
       Digit1(user_number);
    }
    else
    {
        Console.WriteLine("There is too large number!");
    }
*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

int Say(string number)
{
   Console.Write(number);
   string value = Console.ReadLine();
   int result = Convert.ToInt32(value);
   return result;
}
bool IsWeekend(int weekDay)
{
    if(weekDay > 5)
    {
        return true;
    }
    return false;
}

bool ValWeekday(int number_1)
{
    if(number_1 > 0 && number_1 <= 7)
    {
        return true;
    }
    Console.WriteLine("Its is day of the week!");
    return false;
}

int weekDay = Say("Enter day of the week: ");
if(ValWeekday(weekDay))
{
    if (IsWeekend(weekDay))
    {
        Console.WriteLine("Finally its weekend!");
    }
    else
    {
        Console.WriteLine("You need to work little bit more until weekends");
    }
}