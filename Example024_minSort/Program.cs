﻿int [] arr = { 1, 5, 4, 5, 2, 5, 3, 6, 7, 7 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

async void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1 ; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}


PrintArray(arr);

SelectionSort(arr);
PrintArray(arr);