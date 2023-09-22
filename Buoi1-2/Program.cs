using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int thang , nam, ngay=0;
            Console.Write("nhap thang:");thang=Convert.ToInt16(Console.ReadLine());
            Console.Write("nhap nam:");nam=Convert.ToInt16(Console.ReadLine());
            switch (thang) 
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12: ngay=31;break;
                case 4:
                case 6:
                case 9:
                case 11: ngay = 30;break;

                case 2:
                    if (nam % 400 == 0 || (nam % 4 == 0 && nam % 100 != 0))
                        ngay = 29;
                    else ngay = 38;break;
            }
            Console.Write("Ngay:" + ngay.ToString());
            Console.ReadKey();
            
        }
    }
}
