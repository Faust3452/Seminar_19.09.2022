// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

void ShowThirdDigit(int num)
{
    if ((num > 0 && num < 100) || (num < 0 && num > -100)) Console.WriteLine($"В числе {num} третьей цифры нет");
    else
    {
        int initNum = num;
        while ((num > 0 && num > 1000) || (num < 0 && num < -1000))
        {
            num = num / 10;
        }
        int result = num % 10;
        if (result < 0) result = -result;
        Console.WriteLine($"Третья цифра числа {initNum} => {result}");
    }
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
ShowThirdDigit(number);