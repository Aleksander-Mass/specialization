/*
Выбор специализации
Урок 2. Итоги блока. Выбор специализации
Итоговая проверочная работа

Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуру, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []

*/


// Вариант решения 1
// ниже предлагаются разные массивы для проверки 
//string [] arr = {"1234", "1567", "-2", "computer science"};  // -> ["-2"]
//string [] arr = {"hello", "2", "world", ":-)"}; // -> ["2", ":-)"];
//string [] arr = {"qwe", "wer", "ert", "rty", "tyu", "yui", "uio", "asd"};
string [] arr = {"Russia", "Denmark", "Kazan"};  // -> []
int n = 4;

string res = string.Empty;
int len = arr.Length;

res = "-> [ ";
for (int i = 0; i < len; i++)
{
    if(arr[i].Length < n)
        {
            res += $"{'"' + arr[i] + '"' + ","} ";
        }
        
}

res += "]";
Console.Write($"{res} ");

/*
// Вариант решения 2
//string[] array1 = new string[] {"qwe", "wer", "ert", "rty", "tyu", "yui", "uio", "asd"};
//string[] array1 = new string[] {"Russia", "Denmark", "Kazan"};
//string[] array1 = new string[] {"hello", "2", "world", ":-)"};
//string[] array1 = new string[] {"1234", "1567", "-2", "computer science"};
string[] array1 = new string[5] {"123", "23", "hello", "world", "res"}; 
string[] array2 = new string[array1.Length];
void SecondArrayWithIF(string[] array1, string[] array2)
{
int count = 0;
for (int i = 0; i < array1.Length; i++)
{
if(array1[i].Length <= 3)
{
array2[count] = array1[i];
count++;
}
}
}
void PrintArray(string[] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write($"{array[i]} ");
}
Console.WriteLine();
}
SecondArrayWithIF(array1, array2);
PrintArray(array2);
*/
/*
// Вариант решения 3
Console.Clear();
string[] myArrayStrings = { "Hello", "2", "world", "231", "223", "ggez" };

string[] Selection(string[] myArrayStrings)
{
string[] ArrayFinite = new string[0];
int j = 0;
for (int i = 0; i < myArrayStrings.Length; i++)
{
if (myArrayStrings[i].Length <= 3)
{
int lenght = ArrayFinite.Length;
Array.Resize(ref ArrayFinite, lenght + 1);
ArrayFinite[j] = myArrayStrings[i];
j++;

}
}
return (ArrayFinite);
}

void WriteArray(string[] myArrayStrings, string[] ArrayFinite)

{
Console.Write("[");
for (int i = 0; i < myArrayStrings.Length; i++)
{
Console.Write(myArrayStrings[i]);
if (i != myArrayStrings.Length - 1)
{
Console.Write(", ");
}
}
Console.Write("] -> [");
for (int i = 0; i < ArrayFinite.Length; i++)
{
Console.Write(ArrayFinite[i]);
if (i != ArrayFinite.Length - 1)
{
Console.Write(", ");
}
}
Console.WriteLine("]");
}
WriteArray(myArrayStrings, Selection(myArrayStrings));

*/