using System;

namespace Module_5
{
    internal class Application_5_2_8_17_18
    {
        static void Main(string[] args)
        {
            var array = GetArrayFromConsole(10);
            var sortedaarray = SortResult(array);
            ShowResult(sortedaarray);
        }

        static int[] GetArrayFromConsole(int num = 10)
        {
            var result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }

        static int[] SortResult(int[] result)
        {
            int num = 0;

            for (int k = 0; k < result.Length; k++)
            {
                for (int j = k + 1; j < result.Length; j++)
                {
                    if (result[k] > result[j])
                    {
                        num = result[j];
                        result[j] = result[k];
                        result[k] = num;
                    }
                }
            }

            return result;

        }

        static void ShowResult(int[] array, bool IsSort = false)
        {
            var temp = array;
            if (IsSort) 
            {
                temp = SortResult(array);
            }

            foreach (var b in temp)
            {
                Console.Write(b);
            }
        }

    }
}