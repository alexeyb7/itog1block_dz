/* 
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

string[] CreateArray(int Length) //создание массива
{
    string[] numbers = new string[Length];
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write("Введите строку: ");
        numbers[i] = Console.ReadLine();
    }
    return numbers;
}
int ReadInt(string arg)
{
    Console.Write($"Введите {arg}: ");
    return int.Parse(Console.ReadLine());
}

void PrintArray(string[] numbers) // печать массива
{
    Console.Write("[");
    for (int i = 0; i < numbers.Length - 1; i++)
    {
        Console.Write(numbers[i] + "; ");
    }
    Console.WriteLine(numbers[numbers.Length - 1] + "]");
}

void CalcArray(string[] numbers) //вычисление количества элементов длиной меньше 3
{
    int calc = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i].Length <= 3) calc++;
    }
    Console.WriteLine($"Количество строк меньше 3 равно {calc}");

    string[] newnumbers = new string[calc];
    for (int i = 0; (i < newnumbers.Length); i++)
    {
        for (int j = 0; (j < numbers.Length); j++)
        {
            if (numbers[j].Length <= 3)
            {
                newnumbers[i] = numbers[j];
                i++;
            }

        }
    }

    for (int j = 0; j < newnumbers.Length; j++)
    {
        Console.Write(newnumbers[j] + " ");
    }

}

int Length = ReadInt("количество строк");

string[] numbers = CreateArray(Length);

PrintArray(numbers);
CalcArray(numbers);


