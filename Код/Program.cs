// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//  либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Пример: 
// ["hello", "2", "world", ":-)" ] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science" ] -> ["-2"]
// ["Russia", "Denmark", "Kazan" ] -> []

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string[] array = new string[num];
FillStringArray(array);
Console.Write("[" + string.Join(", ", array) + "]");
Console.WriteLine();
int numArr = 3;
int ArrayNew = CountNewArrayLenght(array, numArr);
Console.Write(ArrayNew);
if (ArrayNew == 0) Console.Write("[]");
else
{
    string[] newArray = new string[ArrayNew];
    FillNewStringArray(array, newArray, numArr);
    Console.Write("[" + string.Join(", ", newArray) + "]");
    Console.WriteLine();
}
void FillStringArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите значение: ");
        array[i] = Console.ReadLine();
    }
}
int CountNewArrayLenght(string[] arr, int number)
{
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= number) counter++;
    }
    return counter;
}
void FillNewStringArray(string[] arrayNumber, string[] arrayNew, int numLenMumber)
{
    int IndexArrayNum = 0;
    for (int i = 0; i < arrayNumber.Length; i++)
    {
        if (arrayNumber[i].Length <= numLenMumber)
        {
            arrayNew[IndexArrayNum] = arrayNumber[i];
            IndexArrayNum++;
        }
    }
}