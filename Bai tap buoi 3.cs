using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Session2
{
    internal class Bai_tap_buoi_3
    {
        private static void Main2(string[] args)
        {
            baitap1();
            baitap2();
            baitap3();
            baitap4();
            baitap5();
        }
        static void baitap1()
        {
            Console.Write("Nhap vao so a: ");
            double num_a1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap vao so b: ");
            double num_b1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{num_a1} + {num_b1} = {num_a1 + num_b1}");
            Console.WriteLine($"{num_a1} - {num_b1} = {num_a1 - num_b1}");
            Console.WriteLine($"{num_a1} x {num_b1} = {num_a1 * num_b1}");
            Console.WriteLine($"{num_a1} / {num_b1} = {num_a1 / num_b1}");
        }
        static void baitap2()
        {

            Console.WriteLine(" Ta co ham so: x = y^2 + 2y +1: ");
            for (int y = -5; y <= 5; y++)
            {
                int x = y * y + 2 * y + 1;
                Console.WriteLine($" Voi y = {y}, Ta co x = {x} ");
            }
        }
        static void baitap3()
        {
            Console.WriteLine("Nhap vao thoi gian theo thu tu gio, phut, giay: ");
            int gio = Convert.ToInt32(Console.ReadLine());
            int phut = Convert.ToInt32(Console.ReadLine());
            int giay = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vao khoang cach (km): ");
            double km = Convert.ToDouble(Console.ReadLine());
            double convert_gio = gio + phut / 60 + giay / 3600;
            double mile = km * 0.621371192;
            Console.WriteLine($"Toc do tinh bang km/h la: {km / convert_gio} km/h");
            Console.WriteLine($" Toc do tinh bang miles/h la: {mile / convert_gio} miles/h");
        }
        static void baitap4()
        {
            Console.Write("Nhap vao ban kinh hinh cau: ");
            float radius = Convert.ToSingle(Console.ReadLine());
            double pi = Math.PI;
            double surface = 4 * pi * Math.Pow(radius, 2);
            double volume = 4 / 3 * pi * Math.Pow(radius, 3);
            Console.WriteLine("Surface = " + surface);
            Console.WriteLine("Volume = " + volume);
        }
        static void baitap5()
        {
            Console.Write("Nhap vao mot ki tu: ");
            char c = Convert.ToChar(Console.ReadLine());
            char c1 = char.ToLower(c);
            if (c1 == 'a' || c1 == 'e' || c1 == 'o' || c1 == 'u' || c1 == 'i')
            {
                Console.WriteLine("ki tu nay la nguyen am");
            }
            else if ( c1 >= '0' && c1 <= '9')
            {
                Console.WriteLine("ki tu nay la so");
            }
            else
            {
                Console.WriteLine(" day la mot ki tu hoac bieu tuong khac");
            }



        }
    }
}
