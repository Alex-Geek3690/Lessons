int[] array = {1, 12, 31, 4, 34, 98, 76, 45, 34};

int n = array.Length;
int find = 34;

int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    
    index++;
}
