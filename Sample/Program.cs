﻿using System;
using System.Collections.Generic;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 0, -4, 7, 6, 4 };
            int[] arr2 = new int[] { 0, 2, 4, -3, 2, 1 };
            int[] arr3;
            int x = 8;
            int a = -5, b = 8;

            Console.WriteLine(ToBinary(8));

            arr3=FindPairOfNumber(arr1, arr1.Length, arr2, arr2.Length, x);

            Console.WriteLine(arr3[0]+"-"+arr3[1]);

            Swap(ref a, ref b);

            Console.WriteLine(a);

            Console.WriteLine(b);

            //string[] arrStr = new string[]{ "a", "a", "a", "a", "b", "b", "b", "c", "c", "d" };
            string[] arrStr = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "c" };

            FindPairs(arrStr);

            Console.ReadLine();
        }

        private static string ToBinary(int number)
        {
            if (number < 2)
                return number.ToString();

            int divisor = number / 2;
            int remainder = number % 2;
            return ToBinary(divisor) + remainder;
        }

        private static int[] FindPairOfNumber(int[] arr1, int length1, int[] arr2, int length2, int sum)
        {
            int[] result = null;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for(int i=0;i<length1;i++)
            {
                dic[arr1[i]]= 0;
            }

            for(int j=0;j<length2;j++)
            {
                int value1 = sum - arr2[j];
                if (dic.ContainsKey(value1))
                {
                    result = new int[] { value1, arr2[j] };
                    break;
                }
            }

            return result;
        }
        
        private static void Swap(ref int a,ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }

        private static void FindPairs(string[] arr)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();

            for(int i=0;i<arr.Length;i++)
            {
                if (dic.ContainsKey(i))
                    continue;

                for (int j=i+1;j<arr.Length;j++)
                {
                    if (dic.ContainsKey(j))
                        continue;
                    if(arr[i]!=arr[j])
                    {
                        Console.WriteLine(arr[i] + "-" + arr[j]);
                        dic[i] = arr[i];
                        dic[j]= arr[j];
                        break;
                    }
                }
            }
        }

        private static void FindPairsInOneArray(int[] arr,int x)
        {

        }
        
    }
}