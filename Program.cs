﻿string[] array = { "Hello", "2", "world", ":-)" };
//string[] array = { "1234", "1567", "-2", "computer science" };
// string[] array = { "Russia", "Denmark", "Kazan"};
int count = 0;
int index = 0;
string temp = string.Empty;

PrintTextArray(array);
Console.Write(" -> ");

while (index < array.Length)
{
    temp = array[index];
    if (temp.Length <= 3)
    {
        count++;
    }
    index++;
}

if (count == 0)
{
    Console.Write("[ ]");
    return;
}
string[] array1 = new string[count];
index = 0;
int indexNew = 0;

while (index < array.Length)
{
    temp = array[index];
    if (temp.Length <= 3)
    {
        array1[indexNew] = array[index];
        indexNew++;
    }
    index++;
}

PrintTextArray(array1);

void PrintTextArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}