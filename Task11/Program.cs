// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
int DeleteMethod(int num)
{
    int first = num / 100;
    int third = (num % 100) % 10;
    int res = first * 10 + third;
    return res;
}

int number = new Random().Next(100, 1000);
Console.WriteLine($"Сгенерированное число => {number}");

int res = DeleteMethod(number);
Console.WriteLine($"Число без второй цифры => {res}");