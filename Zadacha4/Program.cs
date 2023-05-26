// Задача 4

// Напишите программу, которая на вход принимает число N а на выходе показывает все четные числа от 1 до N

Console.WriteLine("Введите число");
int A = Convert.ToInt32(Console.ReadLine());
int N = Math.Abs(A);

Console.Write("Четные числа от 1 до ");
Console.WriteLine(N);

for (int i = 1; i<=N; i++)
{
    if (i%2==0)
    {    
        Console.Write(i+";  ");
    }

}

