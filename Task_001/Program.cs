/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int EnterLength()
{
    Console.WriteLine("Введите длину массива: ");
    int length = int.Parse(Console.ReadLine() ?? "");
    return length;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length-1]);
}

int[] GetArray(int number)
{
    int[] array = new int[number];
    Console.WriteLine($"Введите значенение {number} элементов:");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(Console.ReadLine() ?? "");
    }
    Console.WriteLine();
    PrintArray(array);
    return array;
}

int CheckElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine("Кол-во элементов: " + count);
    return count;
}

int number = EnterLength();
int[] array = GetArray(number);
Console.WriteLine();
int count = CheckElements(array);