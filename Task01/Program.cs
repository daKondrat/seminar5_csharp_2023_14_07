// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите длину массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = new int[size];
GenerateArray(myArray);
Console.WriteLine("В этом массиве: ");
PrintArray(myArray);

void GenerateArray(int[] myArray)
{
    for (int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(99, 999);
    }
}

int count = 0;
for (int x = 0; x < myArray.Length; x++)
{
    if (myArray[x] % 2 == 0)
        count++;
}
Console.WriteLine($"\nМассив из {myArray.Length} чисел, из них {count} четных");

void PrintArray(int[] myArray)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write(myArray[i] + " ");
    }
}