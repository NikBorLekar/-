string[] array = { "Hello", "2", "world", ":-)" };
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