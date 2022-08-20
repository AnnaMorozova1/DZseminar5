// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

System.Console.Write("Введите колличество эллементов в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] mass = new int[number];
int summ = 0;
Random rand = new Random();
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = rand.Next(-1000, 1000);
    Console.WriteLine(mass[i]);
    if (i % 2 != 0)
    {
        summ = summ + mass[i];
    }
}
Console.Write("Сумма ровна: ");
Console.WriteLine(summ);