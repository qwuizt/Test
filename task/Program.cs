int CountString(string[] array)
{
    int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4) k++;
    }
    return k;
}
string[] CreatArray(string[] array, int k)
{
    string[] arrayNew = new string[k];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            arrayNew[j] = array[i];
            j++;
        }
    }
    return arrayNew;
}
void PrintArray(string[]array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length-1]}.");
}

string[] array = new string[] {"1","hello","key","well","yes", "no"};
int k = CountString(array);
string[] arrayNew = CreatArray(array,k);
PrintArray(arrayNew);