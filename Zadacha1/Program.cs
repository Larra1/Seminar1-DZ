// Задача 1
// Напишите программу, которая на вход принимает два числа и выдает, какое число бальшее а какое меньшее.

Console.WriteLine("Введите первое число");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int B = Convert.ToInt32(Console.ReadLine());
int max = A;

if (A==B)
{
    Console.WriteLine("Числа равны");
}


if (A>B)
{
    max=A;
    Console.Write("Наибольшее число ");
    Console.WriteLine(A);
}

if (A<B)
{
    max=B;
    Console.Write("Наибольшее число ");
    Console.WriteLine(B);
}




