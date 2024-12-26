using System;

namespace ClassLibrary1
{
    public class Class1
    {
        public int IndexAverage(int[,] mas)
        {
            int average = mas[0, 0];
            int index = -1;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (mas[i, j] > average)
                    {
                        average = mas[i, j];
                        index = i + j / mas.GetLength(0);
                    }
                }
            }
            return index;
        }
    }
}
