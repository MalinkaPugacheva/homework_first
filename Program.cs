// Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Input integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine($"{num1} is max and {num2} is min");
}
else
{
    Console.WriteLine($"{num2} is max and {num1} is min");
}
*/

// Задача 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Input integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input integer number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if(num1>max) max = num1;
if(num2>max) max = num2;
if(num3>max) max = num3;
 {
    Console.WriteLine($"max = ");
    Console.WriteLine(max);
 }
*/

// Задача 6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Input integer number: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number%2==0)
{
    Console.WriteLine($"{number} is even number");
}
else
{
    Console.WriteLine($"{number} is odd number");
}
*/

// Задача 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Input positive integer number: ");
int number = Convert.ToInt32(Console.ReadLine());
int current = number%2;

while(current<=number)
{
    Console.Write(current=number%2);
    current++;
}
*/
