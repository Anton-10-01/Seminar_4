﻿/* Задача 30: Напишите программу, которая
выводит массив из 8 элементов, заполненный
нулями и единицами в случайном порядке.
[1, 0, 1, 1, 0, 1, 0, 0]
*/

Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int [] array1 = new int[number];

FillArray(array1);
PrintArray(array1);

void FillArray(int[] arr) {
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++) {
        arr[i] = rnd.Next(2);
    }
}

void PrintArray(int[] arr) {
    for (int i = 0; i < arr.Length; i++) {
        Console.Write($"{arr[i]}");
        if (i < arr.Length - 1) {
            Console.Write(", ");
        }
    }
}