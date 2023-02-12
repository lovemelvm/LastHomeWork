string[] ReadArray()
{
    Console.WriteLine("Введите элементы массива через пробел: ");
    return Console.ReadLine().Split(" ");
}

string[] FilterArrayByLenght(string[] array, int lenght)
{
    int resultArrayLenght = 0;
    int[] resultIndexes = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= lenght)
        {
            resultIndexes[resultArrayLenght] = i;
            resultArrayLenght++;
        }
    }
    string[] result = new string[resultArrayLenght];
    if (resultArrayLenght != 0)
    {
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = array[resultIndexes[i]];
        }
    }
    return result;
}

void GoodPrint(string[] inputArray, string[] resultArray)
{
    string formattedString = $"[{String.Join(" , ", inputArray)}] -> [{String.Join(" , ", resultArray)}]";
    Console.WriteLine(formattedString);
}


string[] inputArray = ReadArray();
string[] result = FilterArrayByLenght(inputArray, 3);
GoodPrint(inputArray, result);
