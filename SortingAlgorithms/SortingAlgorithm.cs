namespace Algoritm.SortingAlgorithms
{
    /// <summary>
    /// Общий класс для алгоритмов сортировки
    /// </summary>
    public class SortingAlgorithm
    {
        /// <summary>
        /// Смена позиций значений
        /// </summary>
        /// <param name="array">Список значений</param>
        /// <param name="positionA">Позиция первого значения</param>
        /// <param name="positionB">Позиция второго значения</param>
        public static void Swap(int[] array, int positionA, int positionB)
        {
            (array[positionB], array[positionA]) = (array[positionA], array[positionB]);
        }
    }
}
