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









//string[] FillArray()
//{
string[] arrayStr;
int count = 0;
int count2 = 0;
string str = string.Empty;
string[] arrayStr2;
string[] arrayStr3;
string[] arrayStr4;
Console.WriteLine("Введите строки через Enter. Для завершения ввода нажмите Enter дважды.");

arrayStr = new string[count];
arrayStr3 = new string[count];
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
    if (str != "" && str.Length <= 3)
    {
        count2++;
        arrayStr4 = new string[count2];

        for (int i = 0; i < arrayStr4.Length - 1; i++)
            arrayStr4[i] = arrayStr3[i];
        arrayStr4[count2 - 1] = str;
        arrayStr3 = arrayStr4;
    }

}
while
(str != "");
//return arrayStr;
//}

//string[] arrayString = FillArray();
Console.Write("[ ");
for (int i = 0; i < arrayStr.Length; i++)
    Console.Write($"{arrayStr[i] + ", "}");
Console.Write("] -> [ ");
for (int i = 0; i < arrayStr3.Length; i++)
    Console.Write($"{arrayStr3[i] + ", "}");
Console.Write("]");
Console.ReadKey();