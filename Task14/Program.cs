// Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да
bool CheckMultiple(int num, int mult1, int mult2)
{
    return ((num % mult1 == 0) && (num % mult2 == 0));
}

Console.Write("Введите число для проверки кратности: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите первое число кратности: ");
int multNum1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите второе число кратности: ");
int multNum2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
bool res = CheckMultiple(number, multNum1, multNum2);
if (res == true) Console.WriteLine("Да");
else Console.WriteLine("Нет");