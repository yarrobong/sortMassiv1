using System;

class Program
{
    static void Main()
    {
        int[] A = { 6, 2, -4, 0, 3, 7, -1, 8, -5, 9 };

        
        int firstNegIndex = -1;
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] < 0)
            {
                firstNegIndex = i;
                break;
            }
        }

        int lastPosIndex = -1;
        for (int i = A.Length - 1; i >= 0; i--)
        {
            if (A[i] > 0)
            {
                lastPosIndex = i;
                break;
            }
        }

        int product = 1;
        
        if (firstNegIndex != -1 && lastPosIndex != -1 && lastPosIndex > firstNegIndex)
        {
            for (int i = firstNegIndex + 1; i < lastPosIndex; i++)
            {
                if (A[i] != 0)
                {
                    product *= A[i];
                }
            }
        }
        else
        {
            Console.WriteLine("Не найдены отрицательные или положительные элементы для вычисления произведения.");
        }

        Array.Sort(A);

        Console.WriteLine($"Произведение ненулевых элементов: {product}");
        Console.WriteLine("Отсортированный массив:");
        foreach (int element in A)
        {
            Console.Write(element + " ");
        }
        Console.ReadKey();
    }
}