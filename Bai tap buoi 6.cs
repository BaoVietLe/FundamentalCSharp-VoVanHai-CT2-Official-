using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Reflection.Metadata;
using System.Threading.Channels;
using System.Xml.Linq;

namespace Exercise_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //baitap01_AverageVal();
            //baitap02_ContainASpecificVal();
            //baitap03_FindIndex();
            //baitap04_RemoveASpecificElement();
            //baitap05_FindMaxMin();
            //baitap06_ReverseAnArrOfIntegerVal();
            //baitap07_FindDuplicateVal();
            baitap08_RemoveDuplicateElements();
        }

        static void baitap01_AverageVal()
        {
            int rows = 3, cols = 4;
            int[,] arrayA = new int[rows, cols];
           
            Random rand = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    arrayA[i, j] = rand.Next(1, 1000); 
                }
            }

            int sum = 0;
            float average = 0;

            for (int i = 0; i < arrayA.GetLength(0); i++)
            {
                for (int j = 0; j < arrayA.GetLength(1); j++)
                {
                    Console.Write(arrayA[i, j] + " ");
                    sum = sum + arrayA[i, j];
                    average = sum / 9;

                }
                Console.WriteLine();

            }
            Console.WriteLine("TBC cac gia tri trong mang: " + average);
        }

        static void baitap02_ContainASpecificVal()
        {
            Random rnd = new Random();
            int arraySize = 8;
            int[] arrayB = new int[arraySize];

            for (int i = 0;i < arraySize ; i++)
                {
                    arrayB[i] = rnd.Next(1, 100);
                    Console.Write(arrayB[i] + " ");
                }
            Console.WriteLine();

            Console.WriteLine("Enter the value you want to search in the array");
            int searchEle = Convert.ToInt32(Console.ReadLine());

            if (arrayB.Contains(searchEle))
                   Console.WriteLine($"The value {searchEle} is present in the array");
            
            else Console.WriteLine($"The value {searchEle} is not present in the array"); 

            Console.WriteLine();  
        
        }
        
        static void baitap03_FindIndex() 
        {

            Random rnd = new Random();
            int arraySize = 8;
            int[] arrayC = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                arrayC[i] = rnd.Next(1, 100);
                Console.Write(arrayC[i] + " ");
            }

            Console.WriteLine("Enter the element to find index:");
            int EleTosearchIndex = Convert.ToInt32(Console.ReadLine());
            
            int index = Array.IndexOf(arrayC, EleTosearchIndex);

            if (index > -1)
                Console.WriteLine($"{EleTosearchIndex} found in the array at index {index}");

            else Console.WriteLine($"{EleTosearchIndex} not found in the array");
            Console.WriteLine();
        }

        static void baitap04_RemoveASpecificElement() 
        {
            int[] arrayD = { 1, 2, 3, 4, 5, 6, 7 };


            //int limit = Convert.ToInt32(Console.ReadLine());
            //int[] arrayD = new int[limit];
            //Console.WriteLine("Enter your array:");
            //for (int i = 0; i<= limit; i++)
            //{
            //    Console.Write($"array index [{i}] : ");
            //    arrayD[i] = Convert.ToInt32(Console.ReadLine());

            //}

            for (int j = 0; j < arrayD.Length; j++)
            {
                Console.Write(arrayD[j] + " ");
            }


            Console.Write("enter element's position to remove:");
            int posToRemove = Convert.ToInt32(Console.ReadLine());

            for (int i = posToRemove+1; i < arrayD.Length; i++)
            {
                arrayD[i - 1] = arrayD[i];

            }

            arrayD[arrayD.Length - 1] = 0;

            //Console.WriteLine($"After remove {posToRemove} : ");
            //for (int i = 0; i < arrayD.Length; i++)
            //{
            //    Console.Write(arrayD[i] + " ");
            //}
            //Console.ReadLine();

            int[] newArr = new int[arrayD.Length - 1];

            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = arrayD[i];

            }
            Console.WriteLine($"After remove index {posToRemove} : ");
            for (int i = 0;i < newArr.Length; i++)
            {
                Console.Write(newArr[i] + " ");
            }

        }

        static void baitap05_FindMaxMin() 
        {
            Random rand = new Random();
            int arrSize = 8;
            int[] arr = new int[arrSize];
            for (int i = 0; i< arrSize; i++)
            {
                arr[i] = rand.Next(1,199);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            int max = arr[0];
            int min = arr[0];

            for (int i = 0; i< arrSize; i++)
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                }    
                  
            }    

            for (int i = 0; i < arrSize; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                } 
                 
            }    
            Console.WriteLine("Max of the array is: " + max);
            Console.WriteLine("Min of the array is " + min);
        }

        static void baitap06_ReverseAnArrOfIntegerVal()
        {
            Random rnd = new Random();
            int arrSize = 8;
            int[] arr = new int[arrSize];
            for(int i = 0;i< arrSize; i++)
            {
                arr[i] = rnd.Next(1, 100);
                Console.Write(arr[i] + " ");
            }
           
            Console.WriteLine();
              
            Console.WriteLine("The reverse array is: ");

            for (int i = arr.Length - 1; i>=0; i--)
            {
                Console.Write(arr[i] + " ");
            }    
                
        }

        static void baitap07_FindDuplicateVal()
        {

            int[] arr = new int[10] { 1, 4, 33, 5, 33, 7, 5, 4, 9, 10 };
            Console.Write("The array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();


            int count = 0;

            Console.WriteLine("Duplicate value are: ");

            for (int i = 0; i<arr.Length; i++)
            {
                for(int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.WriteLine(arr[i]); 
                    }
                }        
            }

        }

        static void baitap08_RemoveDuplicateElements()
        {
            int[] arr = new int[10] { 1, 4, 33, 5, 33, 7, 5, 4, 9, 10 };
            Console.Write("The array before removing duplicate values: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            int[] after = new int[arr.Length];

            bool isDup = false;
            int countDup = 0;

            for(int i = 0;i<arr.Length; i++)
            {
                for (int j = 0;j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        isDup = true;
                        countDup++;
                        break;
                    }           

                } 

            }


        }
    }
}
