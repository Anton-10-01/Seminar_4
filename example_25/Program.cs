/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.Write("Введи число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи степень: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Check(numberB);

void Check(int num) {
    if (num < 0) {
        Console.Write("Некорректный ввод степени!");
    } else if (num == 0) {
        Console.WriteLine("1");
    } else {
        int result = NumberPow(numberA, numberB);
        Console.WriteLine($"{numberA}, {numberB} -> {result}");
    }
}

int NumberPow(int x, int y) {
    int pow = x;
    for (int i = 1; i < y; i++) {
        pow = pow * x; 
    }
    return pow;
}