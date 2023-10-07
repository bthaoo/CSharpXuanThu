﻿using System;
namespace CS06
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = 2;
            //if (a == 1)
            //{
            //    Console.WriteLine("Gia tri a bang mot");
            //}
            //else if (a == 2)
            //{
            //    Console.WriteLine("Gia tri a bang hai");
            //}
            //else
            //{
            //    Console.WriteLine("Hay kiem tra so khac");
            //}

            switch (a)
            {
                case 1:
                    Console.WriteLine("Gia tri a bang mot");
                    break;

                case 2:
                    Console.WriteLine("Gia tri a bang hai");
                    break ;
                default: // optional co hay ko deu duoc
                    Console.WriteLine("Hay thu so khac");
                    break;
            }

        //menu tinh 2 so
            int b, c;
            Console.WriteLine("Nhap so b: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so c: ");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("Hay chon lenh");
            Console.WriteLine("1. Tinh tong");
            Console.WriteLine("2. Tinh hieu");
            Console.WriteLine("3. Tinh tich");
            Console.WriteLine("4. Tinh thuong");

            char d;
            L1:
            d = Console.ReadKey().KeyChar; //readkey: nhap tu ban phim
            Console.WriteLine();
                
            switch (d)
            {
                case '1':
                    Console.WriteLine($"Tong la: {b + c}");
                break;

                case '2':
                    Console.WriteLine($"Hieu la: {b - c}");
                break;

                case '3':
                    Console.WriteLine($"Tich la: {b * c}");
                break;

                case '4':
                    Console.WriteLine($"Thuong la: {b / c}");
                break;

                default:
                    Console.WriteLine("Hay chon lenh khac");
                    goto L1; //điều hướng đến dòng lệnh mình muốn
                break;
            }
        }
    }
}