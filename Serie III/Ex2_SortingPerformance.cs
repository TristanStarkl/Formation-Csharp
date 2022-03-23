using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_III
{
    public struct SortData
    {
        /// <summary>
        /// Moyenne pour le tri par insertion
        /// </summary>
        public long InsertionMean { get; set; }
        /// <summary>
        /// Écart-type pour le tri par insertion
        /// </summary>
        public long InsertionStd { get; set; }
        /// <summary>
        /// Moyenne pour le tri rapide
        /// </summary>
        public long QuickMean { get; set; }
        /// <summary>
        /// Écart-type pour le tri rapide
        /// </summary>
        public long QuickStd { get; set; }

        public void Display()
        {
            Console.WriteLine($"{InsertionMean};{InsertionStd};{QuickMean};{QuickStd}");
        }
    }

    public static class SortingPerformance
    {
        public static void DisplayPerformances(List<int> sizes, int count)
        {
            List<SortData> resultats = PerformancesTest(sizes, count);
            Console.WriteLine("n;MeanInsertion;StdInsertion;MeanQuick;StdQuick");
            for (int i = 0; i < sizes.Count; i++)
            {
                Console.Write(sizes[i]);
                resultats[i].Display();
            }

        }

        public static List<SortData> PerformancesTest(List<int> sizes, int count)
        {
            List<SortData> resultat = new List<SortData>();

            foreach (int size in sizes)
            {
                resultat.Add(PerformanceTest(size, count));
            }

            return resultat;
        }

        public static SortData PerformanceTest(int size, int count)
        {
            SortData resultat = new SortData();
            List<long> ListTimeQuickSort = new List<long>();
            List<long> ListTimeInsertionSort = new List<long>();
            long sumTime = 0;
            long standardDeviance = 0;
            List<int[]> res;
            if (size == 0 || count == 0)
                return new SortData();

            for (int i = 0; i <= count; i++)
            {
                res = ArraysGenerator(size);
                ListTimeInsertionSort.Add(UseInsertionSort(res[0]));
                ListTimeQuickSort.Add(UseQuickSort(res[1]));
            }
            resultat.InsertionMean = (long) ListTimeInsertionSort.Average();
            resultat.QuickMean = (long) ListTimeQuickSort.Average();
            foreach (long time in ListTimeInsertionSort)
            {
                standardDeviance += ((time - resultat.InsertionMean) * (time - resultat.InsertionMean));
            }
            resultat.InsertionStd = (long) Math.Sqrt(standardDeviance / (size - 1));
            standardDeviance = 0;
            resultat.QuickMean = count != 0 ? sumTime / count : 0;
            foreach (long time in ListTimeQuickSort)
            {
                standardDeviance += ((time - resultat.InsertionMean) * (time - resultat.InsertionMean));
            }
            resultat.QuickStd = (long)Math.Sqrt(standardDeviance / (size - 1));

            return resultat;
        }

        private static List<int[]> ArraysGenerator(int size)
        {
            Random rand = new Random();
            int[] array1 = new int[size];
            int[] array2 = new int[size];
            int random;
            List <int[]> result = new List<int[]>();

            for (int i = 0; i < size; i++)
            {
                random = rand.Next(-1000, 1001);
                array1[i] = random;
                array2[i] = random;
            }

            result.Add(array1);
            result.Add(array2);
        
            return result;
        }

        public static long UseInsertionSort(int[] array)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            InsertionSort(array);
            watch.Stop();

            return watch.ElapsedMilliseconds;
        }

        public static long UseQuickSort(int[] array)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            QuickSort(array, 0, array.Length - 1 );
            watch.Stop();

            return watch.ElapsedMilliseconds;
        }

        private static void InsertionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        int tmp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = tmp;
                    }
                }
            };
        }

        private static void QuickSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(array, left, right);
                QuickSort(array, left, pivot - 1);
                QuickSort(array, pivot + 1, right);
            }
        }

        private static int Partition(int[] array, int left, int right)
        {
            int pivot = array[right];
            int i = left;
            for (int j = left; j < right; j++)
            {
                if (array[j] < pivot)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                }
            }
            int tmp = array[i];
            array[i] = array[right];
            array[right] = tmp;
            return i;
        }
    }
}
