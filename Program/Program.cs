// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Clear();
Console.Write("Enter the length of the array: ");
int i = int.Parse(Console.ReadLine()!);

string[] array1 = new string[i];
string[] array2 = new string[i];

FillArray(array1);
Console.Write("Specified array: ");
PrintArray1(array1);
SortArray(array1, array2);
Console.Write("Sorting result: ");
PrintArray2(array2);

void FillArray(string[] array1)
{
    int num = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        num ++;
        Console.Write($"Enter the item № {num}: ");
        array1[i] = Console.ReadLine()!;
    }
}

void PrintArray1(string[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write($"{array1[i]} ");
    }
    Console.WriteLine();
}

void SortArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}

void PrintArray2(string[] array2)
{
    for (int i = 0; i < array2.Length; i++)
    {
        Console.Write($"{array2[i]} ");
    }
    Console.WriteLine();
}
