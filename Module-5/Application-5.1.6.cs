/*
using System;

namespace Module_5
{
    internal class Application_5_1_6
    {
        static void Main(string[] args)
        {
            GetArrayFromConsole();
        }

        static int[] GetArrayFromConsole()
        {
            var result = new int[5];

            int num;

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            for(int k = 0; k < result.Length; k++)
            {
                for(int j = k + 1; j < result.Length; j++)
                {
                    if (result[k] > result[j])
                    {
                        num = result[j];
                        result[j] = result[k];
                        result[k] = num;
                    }
                }
            }

            foreach (var b in result)
            {
                Console.Write(b);
            }

            return result;
        }
    }
}
*/