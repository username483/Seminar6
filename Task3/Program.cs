// Не используя рекурсию, выведите первые N чисел 
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


/*Console.Clear();
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
int i = 0;
int Fib1 = 0;
int Fib2 = 1;
while(i<N)
{
Console.WriteLine(Fib1); // [1,2,3,4,5]  1)fib2=0+1; fib 1 = 1-0; 
                                      // 2)fib2=1+1; fib 1 = 2-1
                                      // 3)fib2=1+2; fib 1 = 3-1
                                      // 4)fib2=2+3; fib 1 = 5-2
Fib2 = Fib1+Fib2;
Fib1 = Fib2-Fib1;
i++;
}*/

// Напишите программу, которая будет 
// создавать копию заданного массива с помощью поэлементного копирования.

Console.Clear();
Console.WriteLine("задайте длину массива: ");
int size = int.Parse(Console.ReadLine());

int[] FillArray(int[] array)
{for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(0, size);
}
return array;
}
void PrintArray(int[]array)
{foreach(var elem in array)
   {
    Console.Write(elem + " ");
   }
   Console.WriteLine(" ");
}

int[] CopyArray(int[] array, int [] arrayNew)
{
    for(int i = 0; i < size; i++)
    {
        arrayNew[i]= array[i];
    }
    return arrayNew;
}

int[] array1 = new int[size];
int[] array2 = new int[size];

array1 = FillArray(array1);
array2 = CopyArray(array1,array2);

PrintArray(array1);
PrintArray(array2);