int[] array = { 1, 21, 32, 4, 28, 15, 46, 17, 28};

int n = array.Length;
int find = 28;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++; //index = index + 1
}
