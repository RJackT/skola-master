﻿// See https://aka.ms/new-console-template for more information

int[] array = { 4, 6, 7, 1, 2, 9 };


for(int i = 0; i < array.Length; i++) // iterera genom array
{
    int swap = i;

    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] > array[swap])  // KOlla om mindre
        {
            if (j < swap)
                swap = j;
        };
    }

    if (swap != i)
    {
        int temp = array[swap];  // Swap array numbers
        array[swap] = array[i];
        array[i] = temp;

        i = 0; // Reset array
    }
}
 // printa
for(int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + ", ");
}


