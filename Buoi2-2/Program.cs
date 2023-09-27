using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2
{
    internal class Program
    {
        public static List<SinhVien> NhapDSSV()
        {
            List<SinhVien> listSinhVien = new List<SinhVien>();
            Console.Write("Nhap tong so sinh vien n=");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\n ====Nhập danh sách sinh viên====");
            for (int i = 0; i < n;)
            {
                Console.Write("Nhập sinh vien thứ {0}", i + 1);
                SinhVien sv = new SinhVien();
                sv.NhapSV();
                listSinhVien.Add(sv);
            }
            return listSinhVien;
        }
        public static void XuatDSSV(List<SinhVien> listSinhvien)
        {
            Console.WriteLine("\n ===Xuất danh sách Sinh Viên===");
            foreach (SinhVien sv in listSinhvien)
            {
                sv.XuatSv();
            }
        }
        public static void DSSVCNTT(List<SinhVien> listSinhvien)
        {
            List<SinhVien> listCNTT1 = listSinhvien.Where(p => p.Khoa == "CNTT").ToList();

            List<SinhVien> listCNTT2 = (from s in listSinhvien where s.Khoa == "CNTT" select s).ToList();

            if (listCNTT1.Count() == 0)
            {
                Console.WriteLine("không có sinh vien khoa CNTT");
            }
            else
            {
                XuatDSSV(listCNTT1);
            }
            if (listCNTT2.Count() == 0)
            {
                Console.WriteLine("Không có sinh vien khoa CNTT");
            }
            else
            {
                XuatDSSV(listCNTT2);
            }
        }

        public static void DSSVLONHON5(List<SinhVien> listSinhVien)
        {
            List<SinhVien> listSV = listSinhVien.Where(p => p.DiemTB >= 5).ToList();
            if (listSV.Count() == 0)
            {
                Console.WriteLine("Không có sinh viên co điểm >=5");

            }
            else
            {
                XuatDSSV(listSV);
            }
        }
        public static void DSSVSAPXEP(List<SinhVien> listSinhVien)
        {
            List<SinhVien> listSv = listSinhVien.OrderBy(p => p.DiemTB).ToList();
            XuatDSSV(listSv);
        }

        public static void DSSVDSapXepTB(List<SinhVien> listSinhVien)
        {
            List<SinhVien> listCNTT = listSinhVien.OrderBy(p => p.DiemTB).ToList();
            Console.WriteLine("Danh sach diem duoc sap xep");
            XuatDSSV(listCNTT);
        }
        public static void DSSVD1_5(List<SinhVien> listSinhVien)
        {
            List<SinhVien> listCNTT = listSinhVien.Where(p => p.DiemTB >= 5).ToList();
            listCNTT.Where(p => p.Khoa == "CNTT").ToList();
            if (listCNTT.Count() == 0)
            {
                Console.WriteLine("Khong co sinh vien nao nho hon 5");
            }
            else
            {
                Console.WriteLine("Danh sach SV co diem lon hon 5 va thuoc khoa CNTT");
                XuatDSSV(listCNTT);
            }
        }
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.Write("Nhap tong so sinh vine N=");
            int n = Convert.ToInt32(Console.ReadLine());
            List<SinhVien> listSV = NhapDSSV();
            XuatDSSV(listSV);
            //1.1Xuất ra thông tin của các sinh viên thuộc khoa "CNTT"(nếu có).
            DSSVCNTT(listSV);
            //1.2 Xuất ra thông tin sinh viên có điểm TB lớn hơn bằng 5(nếu có).
            DSSVLONHON5(listSV);
            //1.3 Xuất ra danh sách sinh viên được sắp xếp theo điểm trung bình tăng dần.
            DSSVSAPXEP(listSV);
            //1.4 Xuất ra danh sách sinh viên có điểm TB lớn hơn bằng 5 và thuộc khoa "CNTT"(nếu có).
            DSSVDSapXepTB(listSV);
            //1.5 Xuất ra danh sách sinh viên có điểm trung bình cao nhất và thuộc khoa "CNTT"(nếu có).
            DSSVD1_5(listSV);
            Console.ReadKey();
        }
    }
}
