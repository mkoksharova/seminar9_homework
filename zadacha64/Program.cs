﻿// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

void PrintNaturalNumber(int m, int n)
{
    if (m == n) Console.Write($"{n} ");
    else
    {
        Console.Write($"{m} ");
        PrintNaturalNumber(m + 1, n);
    }
}

int m = 4;
int n = 8;
PrintNaturalNumber(m, n);