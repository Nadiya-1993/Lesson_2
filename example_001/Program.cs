﻿int Max(int arg1, int arg2, int arg3) // задаем функцию Макс и пеедаем ей 3 аргумента возвращаемого типа
// ниже будет описано тело метода, в арг1 включено три числа, в арг2 - другая тройка..
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 33;
int b1 = 45;
int c1 = 5155;
int a2 = 4;
int b2 = 1;
int c2 = 3;
int a3 = 94;
int b3 = 9;
int c3 = 2;

//int max1 = Max (a1, b1, c1);
//int max2 = Max (a2, b2, c2);
//int max3 = Max (a3, b3, c3);
//int max = Max (max1, max2, max3);

int max = Max (
    Max (a1, b1, c1),
    Max (a2, b2, c2), 
    Max (a3, b3, c3));

Console.WriteLine(max);
