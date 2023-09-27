using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.Unicode;
            Console.InputEncoding= Encoding.Unicode;
            Console.Write("Nhap tong so sinh vine N=");
            int n=Convert.ToInt32(Console.ReadLine());
            SinhVien[] arrSV=new SinhVien[n];
            Console.WriteLine("\n ====Nhập danh sách sinh viên====");
            for (int i=0;i<n;i++)
            {
                Console.Write("Nhap sinh vien thu {0}:", i + 1);
                arrSV[i]=new SinhVien();
                arrSV[i].NhapSV();
            }
            Console.WriteLine("\n====Xuất danh sách Sinh Viên====");
            foreach(SinhVien sv in arrSV)
            {
                sv.XuatSv();
            }
            Console.ReadKey();

        }
    }
}
