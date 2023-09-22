using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace buoi1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Nhap a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Nhap b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Nhap c: ");
            int c = int.Parse(Console.ReadLine());

            if (latamgiac(a, b, c))
            {
                double chuvi = a + b + c;
                double s = chuvi / 2;
                double dientich = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

                Console.WriteLine($"Ba so {a}, {b}, và {c} la đo dai ba canh cua mot tam giac.");
                Console.WriteLine($"Chu vi cua tam giac la: {chuvi}");
                Console.WriteLine($"Dien tich cua tam giac la: {dientich}");
            }
            else
            {
                Console.WriteLine($"Ba so {a}, {b}, và {c} khong phai la đo dai ba canh cua mot tam giac.");
            }
            Console.ReadKey();
        }

        static bool latamgiac(int a, int b, int c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
    }
    }

