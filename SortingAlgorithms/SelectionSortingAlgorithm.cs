namespace Algoritm.SortingAlgorithms
{
    /// <summary>
    /// Алгоритм сортировки выбором
    /// </summary>
    public class SelectionSortingAlgorithm : SortingAlgorithm
    {
        /// <summary>
        /// Получить итоговую выборку
        /// </summary>
        /// <param name="array">Список значений для сортировки</param>
        /// <returns>Итоговая выборка значений</returns>
        public static int[] GetResult(int[] array)
        {
            for (var i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for (var j = i + 1; j < array.Length; j++)
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
    }
}
