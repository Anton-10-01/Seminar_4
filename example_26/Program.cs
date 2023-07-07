﻿/* Задача 26: Напишите программу, которая принимает
на вход число и выдает количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

Console.Write("Ввидите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = LengthNumber(number);
Console.WriteLine(number + " -> " + result);

int LengthNumber(int num) {
    int count = 0;
    while (num != 0) {
        num /= 10;
        count++;
    }
    return count == 0 ? 1 : count;
}