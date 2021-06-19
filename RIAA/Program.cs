using System;

class Program
{
    //метод для обмена элементов массива
    static void Swap(ref int x, ref int y)
    {
        var t = x;
        x = y;
        y = t;
    }

    //метод возвращающий индекс опорного элемента
    static int Partition(int[] array, int minIndex, int maxIndex)
    {
        var pivot = minIndex - 1;
        for (var i = minIndex; i < maxIndex; i++)
        {
            if (array[i] < array[maxIndex])
            {
                pivot++;
                Swap(ref array[pivot], ref array[i]);
            }
        }

        pivot++;
        Swap(ref array[pivot], ref array[maxIndex]);
        return pivot;
    }

    //быстрая сортировка
    static int[] QuickSort(int[] array, int minIndex, int maxIndex)
    {
        if (minIndex >= maxIndex)
        {
            return array;
        }

        var pivotIndex = Partition(array, minIndex, maxIndex);
        QuickSort(array, minIndex, pivotIndex - 1);
        QuickSort(array, pivotIndex + 1, maxIndex);

        return array;
    }

    static int[] QuickSort(int[] array)
    {
        return QuickSort(array, 0, array.Length - 1);
    }

    static void Main(string[] args)
    {
        int[] nums = new int[10] { 3, 4, 2, 9, 1, 5, 8, 16, 5, 7 }; 


        for (var i = 0; i < nums.Length - 1; ++i)
        {
            Console.Write("{0}, ", nums[i]);
        }
        Console.WriteLine("{0} ", nums[9]);

        Console.WriteLine("{0}: Упорядоченный массив", string.Join(", ", QuickSort(nums)));

        Console.ReadLine();
    }
}

// 3, 4, 2, 9, 1, 5, 8, 16, 5, 7