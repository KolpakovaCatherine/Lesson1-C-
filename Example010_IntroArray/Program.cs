﻿//поиск максимального из 9 с помощью массива

int max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
//    Индексы   0   1    2   3   4   5   6   7   8
int[] array = { 11, 211, 31, 41, 15, 61, 17, 18, 19 };

int maxF = max(
    max(array[0], array[1], array[2]),
    max(array[3], array[4], array[5]),
    max(array[6], array[7], array[8])
);
Console.WriteLine(maxF);