// Задача: 
// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

Console.WriteLine("Введите слова через пробел");
string[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
int element = 3;
string[] newArray = CheckArray(array, element).Split(' ').ToArray();
PrintArray(array, "Старый");
PrintArray(newArray, "Новый");
Console.ReadLine();

string CheckArray(string[] arr, int elem)
{
    string temp = string.Empty;
    for (int i = 0; i < arr.Length; i++)
    {
        if (array[i].Length == elem) temp += array[i] + " ";
    }
    return temp;
}

void PrintArray(string[] arr, string arrName)
{
    Console.WriteLine();
    Console.Write($"{arrName} массив: ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}