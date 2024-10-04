using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    internal class Bai_tap
    {
        public static void Mainb(string[] args)
        {
            int[] a = new int[100];
            InputRandomData(a);
            BubbleSort(a);
            PrintArray(a);
            PrintArray(FindDupe(a));


        }
        static int[] BubbleSort(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for(int j = 0; j<a.Length-i-1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
            return a;
        }
        static void InputRandomData(int[] a)
        {
            Random r = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(0,100);
            }
        }
        static void PrintArray(int[] a)
        {
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static double CalculateAvg(int[] a)
        {
            double s = 0;
            foreach (int i in a)
            {
                s += i;
            }
            return s / a.Length;
        }
        static bool CheckExist(int[] a, int val)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (val == a[i])
                {
                    return true;
                }
            }
            return false;
        }
        static int FindIndex(int[] a, int val)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == val)
                {
                    return i;
                }
            }
            return -1;
        }
        static  int[] RemoveEle(ref int[] a, int ele)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == ele)
                {
                    for (int j = i; j < a.Length - 1; j++)
                    {
                        a[j] = a[j + 1];

                    }
                    i--;
                    Array.Resize(ref a, a.Length - 1);
                }
                
            }

            return a;
        }
        static void MaxMin(int[] a)
        {
            int min = a[0];
            int max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < min)
                    min = a[i];
                if (a[i] > max)
                    max = a[i];
            }
            Console.WriteLine($"Max: {max}, Min: {min}");
        }
        static int[] Reserve(int[] a)
        {
            
            for (int i = 0; i<a.Length/2; i++)
            {
                int temp = a[i];
                a[i] = a[a.Length-i-1];
                a[a.Length-i-1] = temp;
            }
            return a;
        }
        //static void BubbleSortString(char[] s)
        //{
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        for (int j = 0; j < s.Length - i - 1; j++)
        //        {
        //            if (char.ToLower(s[j]) > char.ToLower(s[j + 1]))
        //            {
        //                char temp = s[j];
        //                s[j] = s[j + 1];
        //                s[j + 1] = temp;
        //            }
        //        }
        //    }
        //}

        static int[] FindDupe(int[] a)
        {
            int index = 0;
            int[] c = new int[100];
            
            bool[] CheckPrint = new bool[100];
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {

                    if (a[j] == a[i])
                    {

                        if (!CheckPrint[a[i]])
                        {
                            
                            
                            c[index] = a[i];
                            index++;
                            CheckPrint[a[i]] = true;
                        }
                        break;
                    }
                }
            }
            Array.Resize(ref c, index);
            return c;
        }
        static int[] RemoveDupe(int[] a)
        {
            int[] c = FindDupe(a);
            for (int i = 0; i < c.Length; i++)
            {
                RemoveEle(ref a, c[i]);
            }
            return a;
        }
        public static void Mainxx(string[] args)
        {
            //int[] a = new int[10];
            //InputData(a);
            //PrintArray(a);
            //Console.WriteLine();
            //Sort(a);
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            if(!SearchLinear(sentence, word))
                Console.WriteLine("The word don't exist in sentence");
            else
                Console.WriteLine("The word exist in sentence");


        }
        static void InputData(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"Please enter a number {i + 1} ");
                bool res = int.TryParse(Console.ReadLine(), out a[i]);
                if (!res)
                {
                    Console.WriteLine("Incorrect, enter again");
                    i--;
                }
            }
        }
        static void PrintArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
        static void BubbleSort(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = 0; j < a.Length - i - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int c = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = c;

                    }
                }
            }
            PrintArray(a);
        }
        static bool  SearchLinear(string sentence, string word)
        {
            char[] s = sentence.ToCharArray();
            char[] w = word.ToCharArray();
            for (int i = 0; i <= s.Length - w.Length; i++)
            {
                bool find = true;
                for (int j = 0; j < w.Length; j++)
                {
                    if (s[i + j] != w[j] && char.ToLower(s[i + j]) != char.ToLower(w[j]))
                    {
                        find = false;
                        break;
                    }
                    if (find)
                    {
                        return true;
                    }

                }
            }
            return false;
        }


    }
}

