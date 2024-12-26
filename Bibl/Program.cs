using static ClassLibrary1.ClassLib;
Random random = new Random();
int[,] mas = new int[7, 6];
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        mas[i, j] = random.Next(10, 100);
        Console.WriteLine(mas[i,j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Среднее арифметическое элемнтов:" + IndexAverage(mas));