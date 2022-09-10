// Напишите программу, которая перевернет массив
// [1,2,3,4,5] - [5,4,3,2,1]

Console.Clear();
Console.Write("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine());

int[]array = FillArray (size, 1, 10);

Console.WriteLine("Входной массив: ");
Console.WriteLine(String.Join(" ", array));
Console.WriteLine("Полученный массив: ");
Console.WriteLine(String.Join(" ", array.Reverse())); // 1 способ
Console.WriteLine("Полученный массив 2 способ: ");
Console.WriteLine(String.Join(" ", ReverseArray(array)));
int [] FillArray (int size, int min, int max)
{
    int [] result = new int [size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min,max+1);
    }
    return result;
}
int [] ReverseArray (int [] array)
{
    int [] result = new int [array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = array[array.Length - 1 -i];
    }
    return result;
}