// Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет
void Square(int num1, int num2)
{
    if (num1 * num1 == num2) Console.WriteLine($"Число {num1} является квадратом {num2}");
    else Console.WriteLine($"Число {num1} не является квадратом {num2}");
}
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Square (number1, number2);