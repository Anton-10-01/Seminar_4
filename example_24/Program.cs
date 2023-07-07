/* Задача 24. Напишите программу, которая
принимает на вход число (А) и
выдает сумму чисел от 1 до А.
*/

Console.Write("Введи целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 0) {
    Console.WriteLine("Некорректный ввод!");
    return;
}

int sumNumbers = SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sumNumbers}");

int SumNumbers(int num) {
    int sum = 0;
    for (int i = 1; i <= num; i++) {
        checked {   // Проверка на переполнение типа
            sum += i; 
        }
    }
    return sum;
}