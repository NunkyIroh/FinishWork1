Console.Clear();

Console.Write("Введите длинну массива: ");
int sizeArr = int.Parse(Console.ReadLine());

Console.Write("Заполните массив любыми символами: ");

string[] CreateStringArray(int size)
{
    string[] arr = new string[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = Console.ReadLine();
    }
    return arr;
}

string[] ResultStringArray(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            count++;
        }
    }
    string[] newArray = new string[count];
    int num = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newArray[num] = arr[i];
            num++;
        }
    }
    return newArray;
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("Массив [");
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i] + "]");
    }
}

string[] array = CreateStringArray(sizeArr);
PrintArray(array);
string[] newArray = ResultStringArray(array);
PrintArray(newArray);