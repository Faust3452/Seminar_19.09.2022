// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
bool IsThreeDigit(int num)
{
    return (((num > 99) && (num < 1000)) || (num < -99) && (num > -1000));
}

void ShowSecondDigit(int num)
{
    int result = ((num / 10) % 10);
    if (result < 0) result = -result;
    Console.WriteLine($"Вторая цифра числа {num} => {result}");
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
bool checkTG = IsThreeDigit(number);
if (checkTG == true)
{
    ShowSecondDigit(number);
}
else Console.WriteLine("Вы ввели не трехзначное число :( \n Попробуйте заново");