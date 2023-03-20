using static System.Console;
Clear();

int n = int.Parse(Prompt("Введите количество элементов исходного массива n: "));
if (n < 1)
{
    WriteLine("Кол-во элементов должно быть больше нуля!");
    return;
}
int max_len = int.Parse(Prompt("Введите минимальную длину строки для нового массива: "));
if (max_len < 1)
{
    WriteLine("Минимаоьное кол-во символов в элементах массива должно быть больше 1!");
    return;
}
string[] array_first = GetItems(n);
string[] array_second = GetItemsLessN(array_first, max_len);

PrintStringArray(array_first);
Write(" -> ");
PrintStringArray(array_second, false);

// Методы
// Метод запрашивает у пользователя вввод строки. 
string Prompt(string intro, bool oneline = true)
{
    Console.Write($"{intro}" + ((oneline) ? "" : "\n").ToString());
    string res = Console.ReadLine() ?? "";
    return res;
}
// Метод запрашивает у пользователя ввод определенного кол-ва элементов массива
string[] GetItems(int n)
{
    string[] result = new string[n];
    for (int i = 0; i < n; i++)
    {
        result[i] = Prompt($"Введите {i + 1} элемент массива: ");
    }
    return result;
}
// Метод считает кол-во элементов с длиной меньше n кол-ва символов
int GetCountLesN(string[] array, int n)
{
    int count = 0;
    foreach (var item in array)
    {
        if (item.Length <= n) count++;
    }
    return count;
}
// Метод возвращает массив элементов с длиной меньше n кол-ва символов из массива array
string[] GetItemsLessN(string[] array, int n)
{
    string[] result = new string[GetCountLesN(array, n)];
    int i = 0;
    foreach (var item in array)
    {
        if (item.Length <= n)
        {
            result[i++] = item;
        }
    }
    return result;
}
// Метод печатает массив в виде [,] и согласно параметру oneline делает перевод строки или нет
void PrintStringArray(string[] array, bool oneline = true)
{
    Write("[\"" + string.Join("\", \"", array) + "\"]" + ((oneline) ? "" : "\n"));
}