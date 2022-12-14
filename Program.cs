// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
double[] Array = new double[5];
//{3,7,22,2,78};
Random r = new Random();
int i = 0;
double difference = 0;
while (i < 5)

{
    Array[i] = r.NextDouble() * 100;
    Console.WriteLine($"Array {i} = {Array[i]}");
    i++;
}
i = 0;
double min = Array[0];
double max = Array[0];
while (i < 4)
{
    if (Array[i] > max)
    {
        max = Array[i];
    }
    else
    if (Array[i] < min)
    {
        min = Array[i];
        //Console.WriteLine($"difference= {difference}");
    }
    i++;
    difference = max - min;
}
Console.WriteLine($"difference= {difference}");

//Difference = max - min;

// double[,] a = new double[5, 10];

// Random random = new Random();
// for (int i = 0; i < 5; i++)
// {
//     for (int j = 0; j < 10; j++)
//     {
//         a[i, j] = random.NextDouble() * 100; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
//         Console.Write("{0,6:F2}", a[i, j]);
//     }
//     Console.WriteLine();
// }
