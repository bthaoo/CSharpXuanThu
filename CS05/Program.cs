﻿using System;
namespace CS05
{
    class program
    {
        static void Main(string[] args)
        {
            /*
             if (dieu_kien_logic)
                dong_lenh;

            if (dieu_kien_logic)
            {
                ... (khoi lenh if)
            }

            else if (dieu_kien_1)
            {
              ... (khoi lenh else)
            }
            else if (dieu_kien_2)
            {
              ... (khoi lenh else)
            }
            else 
            {

            }

            */
 
            int a;
            Console.WriteLine("Nhap so nguyen a: ");
            a = int.Parse(Console.ReadLine());

            //kiem tra a co phai so chan k
            //a % 2 == 0
            if (a % 2 == 0)
            {
                Console.WriteLine("Ket qua: ");
                Console.WriteLine($"So {a} la so chan");
            }

            else
            {
                Console.WriteLine("Ket qua: ");
                Console.WriteLine($"So {a} la so le");
            }
            Console.WriteLine("The end");




            //TINH DIEM TRUNG BINH
            //[8 - 10] : gioi
            //[6.5 - 8] : kha
            //[5 - 6.5] : trung binh
            //[0 - 5] : yeu

            float dtb;
            Console.WriteLine("Hay nhap diem trung binh: ");
            dtb = float.Parse(Console.ReadLine());
            if (dtb < 5.0)
            {
                Console.WriteLine("Hoc luc Yeu");
            }    
            else if (dtb < 6.5)
            {
                Console.WriteLine("Hoc luc Trung binh");
            }
            else if (dtb < 8)
            {
                Console.WriteLine("Hoc luc Kha");
            }
            else if (dtb <= 10)
            {
                Console.WriteLine("Hoc luc Gioi");
            }
            else
            {
                Console.WriteLine("Nhap sai so diem");
            }




            //TIM SO LON NHAT
            float b, c;
            Console.WriteLine("So b: ");
            b = float.Parse(Console.ReadLine());

            Console.WriteLine("So c: ");
            c = float.Parse(Console.ReadLine());
            float max;
            
            if (b > c)
                max = b;
            else
                max = c;
            Console.WriteLine("So lon nhat la: {0}", max);


            //Cach khac (toan tu 3 ngoi): (dieu_kien) ? bieuthuc1 : bieu thuc2;
            //float b, c;
            //float max;
            //max = (b > c) ? b : c;
            //Console.WriteLine(max);
        }
    }
}