using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2
{
    internal class Bai_tap_buoi_4
    {
        private static void Main5(string[] args)
        {
            baitap1();
            baitap2();
            baitap3();
            baitap4();
            baitap5();
            baitap6();
            baitap7();
            baitap8();
            baitap9();
            baitap10();
        }
        static void baitap1()
        {
            Console.Write("Enter a number: ");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }
        }
        static void baitap2()
        {
            Console.Write("Enter the first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            double c = double.Parse(Console.ReadLine());
            double max = a;
            if (b > max)
                max = b;
            if (c > max)
                max = c;
            Console.WriteLine("The largest of three numbers is: " + max);
        }
        static void baitap3() 
        {
            Console.Write("Enter the X coordinate: ");
            double x= double.Parse(Console.ReadLine());
            Console.Write("Enter the Y coordinate: ");
            double y= double.Parse(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                Console.WriteLine("The point lies in the First quadrant");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("The point lies in the Second quadrant");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("The point lies in the Third quadrant");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("The point lies in the Fourth quadrant");
            }
            else if (x != 0 && y == 0)
            {
                Console.WriteLine("The point lies on the X-axis.");
            }
            else if (x==0 && y != 0)
            {
                Console.WriteLine("The point lies on the Y-axis.");
            }
            else
            {
                Console.WriteLine("The point is at the origin.");
            }

        }
        static void baitap4()
        {
            Console.Write("Enter the length of side a: "); 
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter the length of side b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter the length of side c: ");
            double c = double.Parse(Console.ReadLine());
            if (a + b > c && a>0 && b>0 && c>0 && a+c>b && b+c>a)
            {
                if (a == b || b == c || c == a)
                {
                    Console.WriteLine(" A triangle is Isosceles");
                }
                else if (a==b && a==c)
                {
                    Console.WriteLine(" A triangle is Equilateral");
                }
                else
                {
                    Console.WriteLine(" A triangle is Scalene");
                }
            }
            else
            {
                Console.WriteLine(" Not a triangle");
            }
        }
        static void baitap5()
        {
            double sum= 0.0;
            for(int i = 1;i <= 10; i++) 
            {
                Console.Write($"Enter a number {i}: ");
                double a= double.Parse(Console.ReadLine());
                sum += a;
            }
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {sum / 10}");
        }
        static void baitap6()
        {
            Console.Write("Select multiplication table : ");
            int number= int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
        }
        static void baitap7()
        {
            int n = 4;
            int number1 = 1;
            int number2 = 1;
            for ( int i = 1; i <= n; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.WriteLine() ;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(number1+ " ");
                    number1++;
                }
                Console.WriteLine() ;
            }
            Console.WriteLine();
            for ( int i = 1; i <= n; i++)
            {
                for ( int j = i ; j <= n+1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1 ; k <= i; k++)
                {
                    Console.Write(number2 + " ");
                    number2++;
                }
                Console.WriteLine();
            }
        } 
        static void baitap8()
        {
            Console.Write("Enter terms: ");
            int n = int.Parse(Console.ReadLine());
            double number = 0.0;
            for ( int i = 1;i <= n; i++)
            {
                number += 1.0 / i;
                if (i == n)
                {
                    Console.Write($"1/{i}");
                    break;
                }
                else if (i == 1)
                {
                    Console.Write("1 + ");
                    
                }
                Console.Write($"1/{i} + ");
            }
            Console.WriteLine();
            Console.WriteLine("Sum of them: "+number);
        }
        static void baitap9()
        {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        int sum= 0;
        for( int i=1; i<n; i++)
        {
            if(n%i==0)
            {
                sum+=i;
            }
        }
        if(sum==n)
        {
            Console.WriteLine( n+" is a perfect number");
        }
        else
        {
            Console.WriteLine( n+" is not a perfect number");
        }
        }
        static void baitap10()
        {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        int count=0;
        if(n<2)
        {
            Console.WriteLine(n +" is not a prime number");
        }
        for (int i=2; i<n; i++)
        {
            if(n%i==0)
            {
                count++;
            }
        }
        if (count==0)
        {
            Console.WriteLine(n +" is a prime number");
        }
        else
        {
            Console.WriteLine(n +" is not a prime number");
        }
        }
    }
}
