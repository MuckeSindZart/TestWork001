// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Программа, которая из имеющегося массива строк "
                    + "формирует массив из строк, длина которых меньше либо "
                    + "равна 3 символа.");
System.Console.WriteLine();                    

/*
 Задача: Написать программу, которая из имеющегося массива строк 
формирует массив из строк, длина которых меньше либо 
равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.
Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> [] ]
*/

string[] ArraySorting(string[] array) 
{
    string[] SortedArray = new string[array.Length];
    int count = 0; 

    for (int i = 0; i < array.Length; i++) 
    {
        if (array[i].Length <= 3)
        {
            SortedArray[count] = array[i];
            count++;
        }
    }
    return SortedArray;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}


//-------Main-----------------------------------------------------//
System.Console.Write("Задан массив -> ");
string[] array = { "1234", "1567", "-2", "computer science" };
PrintArray(array);
string[] NewArray = ArraySorting(array);
System.Console.Write("Новый массив -> ");
PrintArray(NewArray);
