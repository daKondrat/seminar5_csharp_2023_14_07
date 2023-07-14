// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.WriteLine("Введите длину массива  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] myArray = new double[size];
GenerateArray(myArray);
PrintArray(myArray);

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int a = 0; a < myArray.Length; a++)
{
    if (myArray[a] > max)
    {
        max = myArray[a];
    }
    if (myArray[a] < min)
    {
        min = myArray[a];
    }
}


Console.WriteLine($"\nВсего в массиве {myArray.Length} чисел. Максимальное = {max}, Минимальное = {min}");
Console.WriteLine($"Разность между максимальным и минимальным = {max - min}.");

void GenerateArray(double[] myArray)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = Convert.ToDouble(new Random().Next(-1000, 1000)) / 10;
    }
}

void PrintArray(double[] myArray)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write(myArray[i] + " ");
    }
}