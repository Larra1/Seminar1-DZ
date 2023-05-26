// Задача 3

// Напишите программу, которая на вход принимает число и выдает, является ли оно четным.

Console.WriteLine("Введите число ");
int A = Convert.ToInt32(Console.ReadLine());

if (A==0)
{
    Console.WriteLine("Старичок, ноль мне не нужен, хоть ладно ");
}

if (A%2==0)
{
    Console.Write("Число ");
    Console.Write(A);
    Console.WriteLine(" является четным");
}
else
{
    Console.Write("Число ");
    Console.Write(A);
    Console.WriteLine(" является нечетным");
}