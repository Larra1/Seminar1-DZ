//Напишите программу, которая на вход принимает
//два числа и проверяет, является ли первое число
//квадратом второго


//a=25, b=5 - да
//а=2, b=10 - нет
//a=9, b=-3 -да


Console.WriteLine ("Введите первое число");
string input1 = Console.ReadLine();
int numberA = Convert.ToInt32(input1);
Console.WriteLine ("Введите второе число");
string input2 = Console.ReadLine();
int numberB = Convert.ToInt32(input2);


if (numberA/numberB == numberB)
{
   Console.WriteLine("Первое число является квадратом второго");
}
else        

Console.WriteLine("Первое число не является квадратом второго");




