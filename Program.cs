    // Написать программу, которая из имеющегося массива строк формирует 
    // массив из строк, длина которых меньше либо равна 3 символа.
internal class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        string[] inputArray1 = {"hello", "2", "world", ":-)"};
        string[] inputArray2 = {"1234", "1567", "-2", "computer science"};
        string[] inputArray3 = {"Russia", "Denmark", "Kazan"};

        string[] array1 = GetFilteredArray(inputArray1, 3);
        string[] array2 = GetFilteredArray(inputArray2, 3);
        string[] array3 = GetFilteredArray(inputArray3, 3);
        
        Console.Write(
                     $"Примеры:\n"
                   + $"\n{JoinArray(inputArray1, ',')} -> {JoinArray(array1, ',')}\n"
                   + $"\n{JoinArray(inputArray2, ',')} -> {JoinArray(array2, ',')}\n"
                   + $"\n{JoinArray(inputArray3, ',')} -> {JoinArray(array3, ',')}\n\n"
        );
    }

    static string[] GetFilteredArray(string[] inArray, int inLimiter)
    {
        int resultArraySize = 0;
        string[] resultArray = new string[resultArraySize];
        for (int i = 0; i < inArray.Length; i++)
        {
            if (inArray[i].Length <= inLimiter)
            {
                resultArraySize++;
                Array.Resize(ref resultArray, resultArraySize);
                resultArray[resultArraySize - 1] = inArray[i];
            }
        }
        return resultArray;
    }

        static string JoinArray(string[] inArray, char inSeparator)
    {
        string resultString = "[";
        if (inArray.Length == 0) return resultString + "]";
        foreach (var item in inArray)
        {
            resultString += $"\"{item}\"{inSeparator} ";
        }
        return resultString + "\b\b]";
    }
}