//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Write("Input first number > ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number (power) > ");
int power = Convert.ToInt32(Console.ReadLine());

int result = number;

for (int i = 1; i<power; i++)
{
    result *= number;
}

Console.WriteLine($"Number {number} in power {power} is {result}");