using Algoritm.SortingAlgorithms;
using System;
using System.Linq;

namespace Algoritm
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LocalizationStrings.SelectionAlgorithmTypeCaption);
            string selectionTypeResult = Console.ReadLine();
            switch (selectionTypeResult)
            {
                case "1":
                    GetSortingAlgorithm();
                    break;
                case "2":
                    GetSearchAlgorithm();
                    break;
                default:
                    Console.WriteLine(LocalizationStrings.SpecifiedValueIncorrectError);
                    break;
            }
        }

        /// <summary>
        /// Получение данных с помощью алгоритма сортировки
        /// </summary>
        static void GetSortingAlgorithm()
        {
            Console.WriteLine(LocalizationStrings.SelectionSortingAlgorithmCaption);
            string selectionSortingResult = Console.ReadLine();

            Console.WriteLine(LocalizationStrings.SpecifyListValuesCaption);
            string specifyListValues = Console.ReadLine();
            if (specifyListValues == string.Empty)
            {
                Console.WriteLine(LocalizationStrings.SpecifyListValuesIncorrectError);
                return;
            }

            int[] initialListValues = specifyListValues.Split(',').Select(x => int.Parse(x)).ToArray();
            if (initialListValues.Length == 0 ) 
            {
                Console.WriteLine(LocalizationStrings.SpecifyListValuesIncorrectError);
                return;
            }

            switch (selectionSortingResult)
            {
                case "1":
                    int[] resultBubbleSorting = BubbleSortingAlgorithm.GetResult(initialListValues);
                    DisplayingValues(resultBubbleSorting);
                    break;
                case "2":
                    int[] resultInsertSorting = InsertingSortingAlgorithm.GetResult(initialListValues);
                    DisplayingValues(resultInsertSorting);
                    break;
                case "3":
                    int[] resultPiramidSorting = PiramidSortingAlgorithm.GetResult(initialListValues);
                    DisplayingValues(resultPiramidSorting);
                    break;
                case "4":
                    int[] resultSelectionSorting = SelectionSortingAlgorithm.GetResult(initialListValues);
                    DisplayingValues(resultSelectionSorting);
                    break;
                case "5":
                    int[] resultQuickSorting = QuickSortingAlgorithm.GetResult(initialListValues);
                    break;
                default:
                    Console.WriteLine(LocalizationStrings.SpecifiedValueIncorrectError);
                    break;
            }
        }

        /// <summary>
        /// Получение данных с помощью алгоритма поиска
        /// </summary>
        static void GetSearchAlgorithm()
        {
            Console.WriteLine(LocalizationStrings.AlgorithmTypeNotImplementedCaption);
        }

        /// <summary>
        /// Отображение полученной выборки в консоли
        /// </summary>
        /// <param name="array">Список итоговых значений</param>
        static void DisplayingValues(int[] array)
        {
            string result = string.Empty;
            foreach (var item in array)
            {
                result += item + " ";
            }
            Console.WriteLine(string.Format(LocalizationStrings.FinalSampleValuesCaption, result));
        }
    }
}
