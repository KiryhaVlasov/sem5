// Задача 36: Задайте одномерный массив, заполненный 
// случайными числами. Найдите сумму элементов, стоящих 
// на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.Clear();
int sum = 0;
int[] array = new int[4];
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 100);

    Console.Write($" {array[i]} ");

    if (i % 2 == 1)
    {

        sum = sum + array[i];

    }


}
Console.Write($"] -> {sum}");