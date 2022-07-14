int Max(int arg1, int arg2, int arg3) // задаем функцию Макс и пеедаем ей 3 аргумента возвращаемого типа
// ниже будет описано тело метода, в арг1 включено три числа, в арг2 - другая тройка..
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int[] array = {17,209,33,4,65,67,17,83,99};
array[0] = 19;


int max = Max (
    Max (array[0], array[1], array[2]),
    Max (array[3], array[4], array[5]), 
    Max (array[6], array[7], array[8]));

Console.WriteLine(max);
