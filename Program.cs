using System;

namespace Algoritm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[10];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = random.Next(50);
            }
            int[] testArray = { 1, 15, 14, 13, 11, 10, 12, 5, 9, 2, 6, 3, 8, 7, 4 };
            Piramid_sort(testArray);
            foreach (var item in testArray)
            {
                Console.Write(item + " ");
            }
            ////добавление новых элементов для сортировки вставкой
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = random.Next(50);
            //}
            //Console.Write($"Искодный массив:      ");
            //foreach (var item in array)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //InsertSort(array);
            //Console.Write("Сортировка вставкой:  ");
            //foreach (var item in array)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine("\n");
            ////добавление новых элементов для сортировки пузырьком
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = random.Next(50);
            //}
            //Console.Write($"Искодный массив:      ");
            //foreach (var item in array)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //BubbleSort(array);
            //Console.Write("Сортировка пузырьком: ");
            //foreach (var item in array)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine("\n");
            ////добавление новых элементов для сортировки выбором
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = random.Next(50);
            //}
            //Console.Write($"Искодный массив:      ");
            //foreach (var item in array)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //SelectionSort(array);
            //Console.Write("Сортировка выбором:   ");
            //foreach (var item in array)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
        }

        //сортировка вставкой
        static int[] InsertSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                var x = array[i];
                var j = i - 1;
                while (j >= 0 && x < array[j])
                {
                    array[j + 1] = array[j];
                    j -= 1;
                }
                array[j + 1] = x;
            }
            return array;
        }
        //пузырьковая сортировка
        static int[] BubbleSort(int[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        Swap(array, i, j);
                    }
                }
            }
            return array;
        }
        //сортировка выбором
        static int[] SelectionSort(int[] array)
        {

            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }

                }
                Swap(array, min, i);
            }
            return array;
        }
        //пирамидальная сортировка
        static int[] Piramid_sort(int[] array)
        {
            int max = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (max < array[i])
                {
                    max = i;
                }
            }
            Swap(array, 0, max);
            int n = array.Length;
            for (int i = 0; i < (n / 2) - 1; i++)
            {
                
                if (array[2 * i + 1] > array[i])
                    Swap(array, i, 2 * i + 1);
                if (array[2 * i + 2] > array[i])
                    Swap(array, i, 2 * i + 2);
            }
            for (int i = 0; i < (n / 2) - 1; i++)
            {
                Swap(array, 0, n-1);
                if (array[2 * i + 1] > array[i])
                    Swap(array, i, 2 * i + 1);
                if (array[2 * i + 2] > array[i])
                    Swap(array, i, 2 * i + 2);
                n--;
            }
            return array;
        }

        static void Swap(int[] array, int positionA, int positionB)
        {
            int temp = array[positionA];
            array[positionA] = array[positionB];
            array[positionB] = temp;
        }
    }
}
