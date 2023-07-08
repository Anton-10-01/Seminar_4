/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Write("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = SumNumbers(number);
Console.WriteLine($"{number} -> {result}");

int SumNumbers(int num){
    int sum = 0;
    int count = 0;
    while (num != 0) {
        sum += num % 10;
        num /= 10;
        count++;
    }
    return sum;
}