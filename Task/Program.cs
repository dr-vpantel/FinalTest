string[] LessThanFourSymbolsArray (string[] array)
{
    int n = 3;
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= n)
        {
            size++;
        }
    }
    string[] arrayTwo = new string[size];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= n)
        {
            arrayTwo[j] = array[i];
            j++;
        }
    }
    return arrayTwo;
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
string[] firstArray = new string[4] {"Hello", "2", "world", ":-)"};
Console.WriteLine("Первоначальный массив:");
PrintArray(firstArray);
Console.WriteLine("Новый массив из строк, длина которых меньше, либо равна 3 символам:");
PrintArray(LessThanFourSymbolsArray(firstArray));
