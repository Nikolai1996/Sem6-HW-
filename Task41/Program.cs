// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3


int[] FillArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите элемент индекса {i}: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i = i + 1)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");

}
int AboveZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}
Console.WriteLine("Введите необходимое количество чисел: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(num);
PrintArray(array);

int res = AboveZero(array);
Console.Write($"Чисел больше нуля -> {res}");