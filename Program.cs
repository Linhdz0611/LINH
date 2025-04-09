using System;
using System.Collections;
using System.Threading.Channels;
namespace ArrayListEz
{
    internal class program
    {
        static void Main(string[] args)
        {
            sanpham a = new sanpham();
            a.nhap();
            a.xuat();
        }
    }
    public class sinhvien
    {
        string name;
        float diem;
        public sinhvien() { }
        public sinhvien(float diem,string name)
        {
            this.diem = diem;
            this.name = name;
        }
        public void nhap()
        {
            Console.WriteLine("Nhap name:");
            name=Console.ReadLine();
            Console.WriteLine("Nhap diem");
            diem = int.Parse(Console.ReadLine());

        }
        public void xuat()
        {
            Console.WriteLine("ho ten:{0}-diem:{1}", name, diem);
        }
    }
    public class sanpham
    {
        string ten;
        double dongia;
        double giamgia;
        public sanpham() { }
        public sanpham(string ten, double dongia, double giamgia)
        {
            this.ten = ten;
            this.dongia = dongia;
            this.giamgia = giamgia;
        }

        public void nhap()
        {
            Console.WriteLine("Nhap ten san pham");
            ten =Console.ReadLine();
            Console.WriteLine("Nhap don gia san pham");
            dongia = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap giam gia san pham");
            giamgia = double.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            Console.WriteLine($"Ten san pham:{ten}");
            Console.WriteLine($"gia san pham:{dongia}");
            Console.WriteLine($"giam gia san pham:{giamgia}");
            Console.WriteLine($"thue nhap khau:{getThuenhapkhau()}");
        }
        public double getThuenhapkhau()
        {
            return dongia / 10;
        }
    }
}
