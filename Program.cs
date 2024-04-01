using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите количество строк в массиве:");
        int n = Convert.ToInt32(Console.ReadLine());
        string[] originalArray = new string[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Введите строку {i + 1}:");
            originalArray[i] = Console.ReadLine();
        }
        int count = 0;
        foreach (string str in originalArray)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }
        string[] newArray = new string[count];
        int index = 0;
        foreach (string str in originalArray)
        {
            if (str.Length <= 3)
            {
                newArray[index++] = str;
            }
        }
        Console.WriteLine("\nНовый массив со строками длиной меньше или равной 3:");
        foreach (string str in newArray)
        {
            Console.WriteLine(str);
        }
    }
}