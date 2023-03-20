using static System.Console;
Clear();

int n = int.Parse(Prompt("Введите значение n: "));
if (n < 1)
{
    WriteLine("Кол-во элементов должно быть больше нуля!");
    return;
}
string[] array_first = GetItems(n);
string[] array_second = GetItemsLess4(array_first);
PrintStringArray(array_first);
Write(" -> ");
PrintStringArray(array_second);

// Методы

string Prompt(string intro, bool oneline = true)
{
    Console.Write($"{intro}" + ((oneline) ? "" : "\n").ToString());
    string res = Console.ReadLine() ?? "";
    return res;
}

string[] GetItems(int n)
{
    string[] result = new string[n];
    for (int i = 0; i < n; i++)
    {
        result[i] = Prompt($"Введите {i + 1} элемент массива: ");
    }
    return result;
}

int GetCountLes4(string[] array)
{
    int count = 0;
    foreach (var item in array)
    {
        if (item.Length < 4) count++;
    }
    return count;
}

string[] GetItemsLess4(string[] array)
{
    string[] result = new string[GetCountLes4(array)];
    int i = 0;
    foreach (var item in array)
    {
        if (item.Length < 4)
        {
            result[i++] = item;
        }
    }
    return result;
}

void PrintStringArray(string[] array, bool oneline = true)
{
    Write("[\"" + string.Join("\", \"", array) + "\"]" + ((oneline) ? "" : "\n"));
}