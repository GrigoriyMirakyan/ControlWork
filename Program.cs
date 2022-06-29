/*
Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []
*/









string[] FillArray()
{
    string[] arrayStr;
    int count = 0;
    string str = string.Empty;
    string[] arrayStr2;

    Console.WriteLine("Введите строки через Enter. Для завершения ввода нажмите Enter дважды.");

    arrayStr = new string[count];

    do
    {
        str = Console.ReadLine();
        if (str != "")
        {
            count++;
            arrayStr2 = new string[count];

            for (int i = 0; i < arrayStr2.Length - 1; i++)
                arrayStr2[i] = arrayStr[i];
            arrayStr2[count - 1] = str;
            arrayStr = arrayStr2;
        }
    }
    while
    (str != "");
    return arrayStr;
}

string[] arrayString = FillArray();

for (int i = 0; i < arrayString.Length; i++)
    Console.Write($"{arrayString[i] + " "}");
Console.ReadKey();