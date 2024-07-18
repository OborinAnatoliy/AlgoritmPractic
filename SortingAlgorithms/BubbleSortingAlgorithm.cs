namespace Algoritm.SortingAlgorithms
{
    /// <summary>
    /// Пузырьковый алгоритм сортировки
    /// </summary>
    public class BubbleSortingAlgorithm : SortingAlgorithm
    {
        /// <summary>
        /// Получить итоговую выборку
        /// </summary>
        /// <param name="array">Список значений для сортировки</param>
        /// <returns>Итоговая выборка значений</returns>
        public static int[] GetResult(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
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
    }
}
