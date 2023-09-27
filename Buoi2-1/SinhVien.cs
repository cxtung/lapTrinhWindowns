using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1
{
    internal class SinhVien
    {
        public string MaSv { get; set; }
        public string HoTen { get; set; }
        public double DiemTB { get; set; }
        public string Khoa { get; set; }




        public SinhVien() { }
        public SinhVien(string masv, string hoten, double diemtb, string khoa)
        {
            this.MaSv = masv;
            this.HoTen = hoten;
            this.DiemTB = diemtb;
            this.Khoa = khoa;
        }
        public SinhVien(SinhVien sv)
        {
            this.MaSv = sv.MaSv;
            this.HoTen = sv.HoTen;
            this.DiemTB = sv.DiemTB;
            this.Khoa = sv.Khoa;
        }

        public void NhapSV()
        {
            Console.Write("Nhap MaSv: ");
            MaSv= Console.ReadLine();
            Console.Write("Nhap Ho va ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap diem: ");
            DiemTB =Convert.ToDouble( Console.ReadLine());
            Console.Write("Nhap khoa: ");
            Khoa = Console.ReadLine();
        }
        public void XuatSv()
        {
            Console.WriteLine("MaSv:{0} \t Ho va ten:{1} \t Diem:{2} \t Khoa:{3} \t", MaSv, HoTen, DiemTB, Khoa);
        }

    }
}
