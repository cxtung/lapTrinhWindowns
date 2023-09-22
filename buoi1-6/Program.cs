using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_6
{
    internal class Program
    {
       
            static void giaiPtBac2(float a,float b,float c)
            {
                if (a == 0) 
                {
                    if (b == 0)
                    {
                        Console.Write("phuong trinh vo nghiem!");
                    }
                    else
                    {
                        Console.Write("phuong trinh co mot nghiem!");

                    }
                    return;
                }
                float delta = b * b - 4 * a * c;
                float x1, x2;
                if (delta > 0)
                {
                    x1  =(float)((-b+Math.Sqrt(delta))/(2*a));
                    x2 = (float)((-b - Math.Sqrt(delta)) / (2 * a));
                    Console.Write("Phuong Trinh co 2 nghiem la :x1={0} va x2={1}", x1, x2);

                }
                else if(delta == 0)
                {
                    x1=(-b/(2*a));
                    Console.Write("phuong trinh co nghiem kep :x1=x2={0}", x1);
                }
                else 
                {
                    Console.Write("Phuong trinh vo nghiem!");
                }
            }
        
        static void Main(string[] args)
        {
            float a,b,c;
            Console.Write("Nhap he so bac 2, a = ");
            String valA = Console.ReadLine();
            a = Convert.ToInt32(valA);
            Console.Write("Nhap he so bac 1, b = ");
            String valB = Console.ReadLine();
            b = Convert.ToInt32(valB);
            Console.Write("Nhap he so bac 0, c = ");
            String valC = Console.ReadLine();
            c = Convert.ToInt32(valC);
            giaiPtBac2(a, b, c);
            Console.ReadKey();
        }
    }
}
