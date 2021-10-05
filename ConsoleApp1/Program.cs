using System;
using System.Xml;


namespace ConsoleApp1
{
    class Program
    {
        public static int[] sortCSharp(int[] data)
        {
            Array.Sort(data);

            foreach (int val in data)
            {
                Console.WriteLine(val);
            }
            return data;
        }
        public static void sortLogic(int[] data)
        {

            int n = data.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int min_idx = 1;
                for (int j = i + 1; j < n; j++)
                    if (data[j] < data[min_idx])
                        min_idx = j;

                int temp = data[min_idx];
                data[min_idx] = data[i];
                data[i] = temp;
            }

            foreach (int val in data)
            {
                Console.WriteLine(val);
            }

        }
        public static void Swap(int number)
        {
            int[] seed = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            if (0 < number && number < 10)
            {
                for (int i = 0; i < number; i++)
                {
                    Console.WriteLine(seed[i]);

                }
            }
        }

        static void Main(string[] args)
        {

            //Sortea numeros de menor a mayor de dos maneras
            int[] numbers = { -10, -1, -500, 2000, 1234, -5000, 5000, 0, 14, 12, 13, 48, 465, 8120, -15198, -4812, 10, -48954, 300, 12 };

            sortLogic(numbers);
            sortCSharp(numbers);

            //recibe una lista de numeros y permuta una lista de hasta 9 numeros
            int n;
            formPermut test = new formPermut();
            int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("\n\n genera todas las permutaciones de un array max 9");

            n = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Input {0} number of elements in the array :\n", n);
            Console.Write("\n The Permutations with a combination of {0} digits are : \n", n);

            test.prnPermut(arr1, 0, n - 1);
            Console.Write(",");

        }
        public static void serial(){
            
            byte[] array_name = { 0x58, 0xA6, 0xFC, 0x89, 0xBD, 0x1A, 0x43, 0x13, 0x12, 0x50, 0x0F, 0x21, 0xC8, 0x9B, 0xD1, 0xA4 };

            
            //int decValue = Convert.ToInt64(0x58, 1);
            //Contexto insuficiente para terminar la prueba
        }
    }
    class formPermut
    {
        public void swapTwoNumber(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public void prnPermut(int[] list, int k, int m)
        {
            int i;
            if (k == m)
            {
                for (i = 0; i <= m; i++)
                    Console.WriteLine("{0}", list[i]);
                Console.WriteLine(" ");
            }
            else
            {
                for (i = k; i <= m; i++)
                {
                    swapTwoNumber(ref list[k], ref list[i]);
                    prnPermut(list, k + 1, m);
                    swapTwoNumber(ref list[k], ref list[i]);
                }
            }
        }
    }
}

