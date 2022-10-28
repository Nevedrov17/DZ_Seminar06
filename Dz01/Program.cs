Console.Clear();

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] arr;
arr = new int[size];
for( int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(-100,100);
    Console.Write(arr[i] + " ");
}
Console.WriteLine();

int count = 0;
for( int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0) 
    {
        count++;
    }
}
Console.WriteLine($"Положительных чисел = {count}");
