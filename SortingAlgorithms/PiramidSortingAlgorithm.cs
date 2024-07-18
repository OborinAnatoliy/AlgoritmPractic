namespace Algoritm.SortingAlgorithms
{
    /// <summary>
    /// Пирамидальный алгоритм сортировки
    /// </summary>
    public class PiramidSortingAlgorithm : SortingAlgorithm
    {
        /// <summary>
        /// Получить итоговую выборку
        /// </summary>
        /// <param name="array">Список значений для сортировки</param>
        /// <returns>Итоговая выборка значений</returns>
        public static int[] GetResult(int[] array)
        {
            var max = 0;
            for (var i = 0; i < array.Length - 1; i++)
            {
                if (max < array[i])
                {
                    max = i;
                }
            }
            Swap(array, 0, max);
            int n = array.Length;
            for (var i = 0; i < (n / 2) - 1; i++)
            {
                if (array[2 * i + 1] > array[i])
                    Swap(array, i, 2 * i + 1);
                if (array[2 * i + 2] > array[i])
                    Swap(array, i, 2 * i + 2);
            }
            for (var i = 0; i < (n / 2) - 1; i++)
            {
                Swap(array, 0, n - 1);
                if (array[2 * i + 1] > array[i])
                    Swap(array, i, 2 * i + 1);
                if (array[2 * i + 2] > array[i])
                    Swap(array, i, 2 * i + 2);
                n--;
            }
            return array;
        }
    }
}
