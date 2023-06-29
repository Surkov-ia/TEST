﻿// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Clear();
Console.WriteLine("Enter the length of the array: ");
int i = int.Parse(Console.ReadLine()!);

string[] array1 = new string[i];
string[] array2 = new string[i];

void FillArray(string[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = Console.ReadLine()!;
    }
}
FillArray(array1);