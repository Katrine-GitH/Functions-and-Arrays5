// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
//int[] Three_digit_array = new int[4];
int sum = 0;
int[] Array = new int[7];
Random r = new Random();
for (int i = 0; i < 7; i++)
{
    Array[i] = r.Next(1, 10);
    Console.WriteLine($"Array[{i}]:{Array[i]}");
    if (i % 2 != 0)
    {
        sum += Array[i];
    }
}
Console.WriteLine($"Сумма элементов стоящих на нечетных позициях :{sum}");

