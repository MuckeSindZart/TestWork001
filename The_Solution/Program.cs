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

string[] ArraySorting(string[] array)                       //метод сортировки массива
{
    string[] SortedArray = new string[array.Length];
    int count = 0; 

    for (int i = 0; i < array.Length; i++)                  
    {
        if (array[i].Length <= 3)                           //поиск элементов меньше 3-х символов
        {
            SortedArray[count] = array[i];
            count++;
        }
    }
    return SortedArray;
}

void PrintArray(string[] array)                             //вывод массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}


//-------Main-----------------------------------------------------//
System.Console.Write("Задан массив -> ");                
string[] array = { "hello", "2", "world", ":-)" };          //задан массив
PrintArray(array);                                          //печать массива
string[] newArray = ArraySorting(array);                    //сортировка массива в новый массив
System.Console.Write("Новый массив -> ");
PrintArray(newArray);                                       //печать нового массива
System.Console.WriteLine();


//--------Main1----------------------------------------------------// 

System.Console.Write("Задан массив -> ");
string[] array1 = { "1234", "1567", "-2", "computer science" };
PrintArray(array1);
string[] newArray1 = ArraySorting(array1);
System.Console.Write("Новый массив -> ");
PrintArray(newArray1);
System.Console.WriteLine();


//--------Main2---------------------------------------------------//

System.Console.Write("Задан массив -> ");
string[] array2 = { "Russia", "Denmark", "Kazan" };
PrintArray(array2);
string[] newArray2 = ArraySorting(array2);
System.Console.Write("Новый массив -> ");
PrintArray(newArray2);
System.Console.WriteLine();


//--------Main3---------------------------------------------------//

System.Console.Write("Задан массив -> ");
string[] array3 = { "Абрр", "Валк", "Вот", "Так", "Вот" };
PrintArray(array3);
string[] newArray3 = ArraySorting(array3);
System.Console.Write("Новый массив -> ");
PrintArray(newArray3);
System.Console.WriteLine();

