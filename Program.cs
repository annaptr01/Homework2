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
/*
void Digit(int user_num)
{
    int digit1 = user_num / 100;
    int digit2 = user_num / 10;
    int digit3 = user_num % 10;
    int result = digit3;
    if(user_num > 99 && user_num < 1000)
    {
        Console.WriteLine("The 3rd digit of your number " + user_num + " is: " + result);

    }
    else
    {
        Console.WriteLine("There is no 3 digit number!");
    }
}
Console.WriteLine("Enter your number: ");
int user_num = Convert.ToInt32(Console.ReadLine());
*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

