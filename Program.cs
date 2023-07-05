/* Программа из имеющегося массива строк формирует 
массив из строк, длина которых меньше или равно 3 символа. */

String[] arrWords = { "Kazan'", "Tyumen", "Gas", "moscow", ":-)", "123" };

int count = ArrCount(0, arrWords);
String[] selectArray = СreatureSelectArray(count, 0, arrWords);
PrintArray(count, arrWords, selectArray);

int ArrCount(int cnt, String[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            cnt++;
        }
    }
    return cnt;
}
String[] СreatureSelectArray(int cnt, int n, String[] arr)
{
    String[] selectWords = new String[cnt];

    if (cnt == 0) return selectWords;
    else
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= 3)
            {
                selectWords[n] = arr[i];
                n++;
            }
        }
    }
    return selectWords;
}
void PrintArray(int cnt, String[] arr, String[] selectArr)
{
    Console.WriteLine();
    if (cnt == 0)
    {
        Console.Write("[");
        for (int i = 0; i < arr.Length - 1; i++)
        {
            Console.Write($"{arr[i]}, ");
        }
        Console.WriteLine($"{arr[arr.Length - 1]}] --> [] ");
        Console.WriteLine();
    }
    else
    {
        Console.Write("[");
        for (int i = 0; i < arr.Length - 1; i++)
        {
            Console.Write($"{arr[i]}, ");
        }
        Console.Write($"{arr[arr.Length - 1]}] --> [");
        for (int i = 0; i < cnt - 1; i++)
        {
            Console.Write($"{selectArr[i]}, ");
        }
        Console.WriteLine($"{selectArr[cnt - 1]}]");
        Console.WriteLine();
    }
}
