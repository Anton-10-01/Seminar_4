/* Задача 24. Напишите программу, которая
принимает на вход число (N) и
выдает произведение чисел от 1 до N.
*/

Console.Write("Введи целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 0) {
    Console.WriteLine("Некорректный ввод!");
    return;
}

int factorial = Factorial(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {factorial}");

int Factorial(int num) {
    int fact = 1;
    for (int i = 1; i <= num; i++) {
        checked {   // Проверка на переполнение типа
            fact *= i;
        }
    }
    return fact;
}