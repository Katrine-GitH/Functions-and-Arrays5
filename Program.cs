// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
//Создать массив наполненный положительными 3х значными цифарми
int[] Three_digit_array = new int[4];
int Even = 0;
for (int i = 0; i < 4; i++)
{
    {
        Three_digit_array[i] = new Random().Next(100, 999);
        // Console.WriteLine($"{Three_digit_array[i]}");
    }
    Console.WriteLine($"Three_digit_array {i}:{Three_digit_array[i]}");
}
// //показать массив
for (int i = 0; i < 4; i++)
{
    if (Three_digit_array[i] % 2 == 0)
    {
        Even += 1;
    }
    //Console.WriteLine($"i:{i}");
}
Console.WriteLine($"Even:{Even}");
//ввод переменной хранящей количество четных чисел
//показать эту переменную
