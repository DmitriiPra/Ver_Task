/* Программа из имеющегося массива строк формирует 
массив из строк, длина которых меньше или равно 3 символа. */

String[] arrWords = {"Kazan'", "Tyumen", "Gasnn", "2007", "nn:-)"};

int count = ArrCount(0, arrWords);
String[] selectArray = СreatureSelectArray(count, 0, arrWords);
PrintArray (count, arrWords, selectArray);

int ArrCount (int cnt, String[]arr)
{
    for (int i=0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            cnt++;
        } 
    }
    return cnt;
}

String[] СreatureSelectArray(int cnt, int n, String[]arr)
{
    String[] selectWords = new String [cnt];
    // if (cnt == 0)
    // {
    //     PrintArray(arr);
    // } else 
    if (cnt == 0) return selectWords;
    else 
    {
        for (int i=0; i < arr.Length; i++)
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

void PrintArray(int cnt, String[] arr, String[] selectarr)
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
    } else
    {
        Console.Write("[");
        for (int i = 0; i < arr.Length - 1; i++)
        {
            Console.Write($"{arr[i]}, ");
        }
    Console.Write($"{arr[arr.Length - 1]}] --> [");
        for (int i = 0; i < selectarr.Length - 1; i++)
        {
            Console.Write($"{selectarr[i]}, ");
        }
    Console.WriteLine($"{arr[selectarr.Length - 1]}]");
    Console.WriteLine();
    }
}
