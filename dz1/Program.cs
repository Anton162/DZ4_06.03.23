// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("A= ");
int numA = int.Parse(Console.ReadLine()!);
Console.Write("B= ");
int numB = int.Parse(Console.ReadLine()!);


int expFunction = Power(numA, numB);
Console.WriteLine("Результат " + expFunction);


int Power(int numberA, int numberB)
{
    int expAinB = numberA;
    for (int i = 1; i < numberB; i++)
    {
        expAinB = expAinB * numberA;
    }
    return expAinB;
}