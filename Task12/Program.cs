// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно
void Multiple(int num1, int num2)
{
    if ((num1 % num2) == 0) Console.WriteLine($"Число {num1} кратно {num2}");
    else 
    {
        int remain = num1 % num2;
        Console.WriteLine($"Число {num1} не кратно {num2}, остаток {remain}");
    };
}

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Multiple (number1, number2);