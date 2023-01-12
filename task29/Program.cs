//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// В данной задаче не подразумевается явный ввод чиссел массива от пользователя, поэтому я сгенерировал значения элементов массива

int[] GenerateArray(int length, int minNum, int maxNum)
{
    int[] arr = new int[length];
    for (int i=0;i<arr.Length;i++)
    {
        arr[i] = new Random().Next(minNum, maxNum + 1);
    }
    return arr;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i=0;i<array.Length;i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write("]");
    Console.WriteLine();
}

int arr_len = 8;
int arrayMinNum = 0;
int arrayMaxNum = 8;
//PrintArray(GenerateArray(arr_len, arrayMinNum, arrayMaxNum));
// Или как альтернативное решение
int[] my_arr = GenerateArray(arr_len, arrayMinNum, arrayMaxNum);
Console.WriteLine($"[{String.Join(", ", my_arr)}]");