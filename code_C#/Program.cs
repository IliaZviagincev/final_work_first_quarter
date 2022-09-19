// Задача: 
// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

Console.WriteLine("Введите слова через пробел");
string[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
int element=3;
string temp=string.Empty;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length==element) temp+=array[i]+" ";
}
string[] newArray=temp.Split(' ').ToArray();

for (int i = 0; i < newArray.Length; i++)
{
    Console.Write(newArray[i]+" ");
}