// Задача 2

// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел

Console.WriteLine("Введите первое число");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
int C = Convert.ToInt32(Console.ReadLine());

int max = A;

if (A==B)
{
    Console.WriteLine("Первые два числа равны");
}
if (A==C)
{
    Console.WriteLine("Первое и третье числа равны");
}
if (B==C)
{
    Console.WriteLine("Второе и третье числа равны");
}

if (A>max) max=A;
if (B>max) max=B;
if (C>max) max=C;


Console.Write("Максимальное число ");
Console.WriteLine(max);
