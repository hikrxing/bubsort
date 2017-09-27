using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {

            int[] a = { 1, 2, 3, 4, 5 };
            int len = a.Length;

            for (int j = 0; j < len; j++)
            {
                Console.Write(a[j] + ",");

            }



            Console.WriteLine();
            Console.WriteLine(bubble_sort(a, len));



            for (int j = 0; j < len; j++)
            {
                Console.Write(a[j] + ",");
            }
            Console.WriteLine();

            Console.Read();
        }
        static int bubble_sort(int[] array, int len)
        {
            //cout << len << endl;
            int temp;
            len--;
            //	int pos=len;

            int times = 0;
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len - i; j++)
                {
                    if (array[j] < array[j + 1])
                    {

                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        times++;
                    }

                }
                //pos--;
            }
            return times;
        }
    }
}
