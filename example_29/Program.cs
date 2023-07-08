/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int [] array1 = new int[number];

FillArray(array1);
PrintArray(array1);

void FillArray(int[] arr) {
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++) {
        arr[i] = rnd.Next(100);
    }
}

void PrintArray(int[] arr) {
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++) {
        Console.Write($"{arr[i]}");
        if (i < arr.Length - 1) {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}