namespace Algoritm.SortingAlgorithms
{
    /// <summary>
    /// Алгоритм сортировки вставкой
    /// </summary>
    public class InsertingSortingAlgorithm : SortingAlgorithm
    {
        /// <summary>
        /// Получить итоговую выборку
        /// </summary>
        /// <param name="array">Список значений для сортировки</param>
        /// <returns>Итоговая выборка значений</returns>
        public static int[] GetResult(int[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                int x = array[i];
                int j = i - 1;
                while (j >= 0 && x < array[j])
                {
                    array[j + 1] = array[j];
                    j -= 1;
                }
                array[j + 1] = x;
            }
            return array;
        }
    }
}
