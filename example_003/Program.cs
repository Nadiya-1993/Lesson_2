int[] array = { 14, 42, 93, 4, 5, 5, 61, 47, 88 };

int n = array.Length;
int find = 5;

int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index ++;
}