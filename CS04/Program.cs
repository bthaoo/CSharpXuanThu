using System;
using System.Security.Cryptography.X509Certificates;
{
    static void Main(string[] args)
    {
        bool kq; 
        // toan tu so sanh == > < >= <= !=
        int a = 5;
        int b = 6;

        kq = a == b;
        Console.WriteLine("a == b ==> {0}", kqua); /*true/false duoc dien vao {0}*/
        Console.WriteLine($"a != b ==> {a != b}");
        Console.WriteLine($"a > b ==> {a > b}");
        Console.WriteLine($"a >= b ==> {a >= b}");
        Console.WriteLine($"a < b ==> {a < b}");
        Console.WriteLine($"a <= b ==> {a <= b}");

        // && : va
        // || : hoac
        // ! : phu dinh
        bool c = true;
        bool d = false;
        kq = c || d;
        Console.WriteLine(kq);
    }
}