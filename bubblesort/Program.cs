using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubblesort
{
    internal class Program
    {
        static public int[] Init()
        {
            Random rnd = new Random();
            int[] arr = new int[10];
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = rnd.Next(100);
            }
            foreach(int i in arr)
            {
                Console.Write(i+ " ");
            }
            Console.WriteLine();
            return arr;
        } 
        static void Main(string[] args)
        {
            int[] arr = Init();
            (int, int) tausch =(0,0);
            //int hilfe = 0;
            for (int j = 0; j < arr.Length - 1; j++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    //if (arr[i] > arr[i + 1])
                    //{
                    //    hilfe = arr[i];
                    //    arr[i] = arr[i + 1];
                    //    arr[i + 1] = hilfe;
                    //}
                    tausch=(arr[i], arr[i+1]);
                    if (arr[i] > arr[i + 1])
                    {
                        arr[i] = tausch.Item2;
                        arr[i+1] = tausch.Item1;
                    }
                }
            }
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
