﻿using System;
class Program
{
    static void Main() // 100/100
    {
        int number = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = 0; i < number; i++)
        {
            sum += int.Parse(Console.ReadLine());
        }
        Console.WriteLine(sum);
    }
}