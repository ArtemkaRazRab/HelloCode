﻿// Найти максимум из 9 чисел (массивы)

//              0   1   2   3   4   5   6   7   8
int[] array = { 11, 21, 33, 41, 15, 61, 17, 18, 19 };

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int max1 = Max(array[0], array[1], array[2]);
int max2 = Max(array[3], array[4], array[5]);
int max3 = Max(array[6], array[7], array[8]);
int max = Max(max1, max2, max3);

Console.WriteLine("Максимальное число: " + max);