﻿//
int[] array = { 11, 211, 31, 41, 15, 61, 17, 18, 19 };
int n = array.Length;
int find = 41;
int index = 0;
while (index < n)
{
    if (array [index] == find)
    {
        Console.WriteLine(index);
    }
        // index=index+1;
        index++;
}
