using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btc4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Phanso a = new Phanso();
            Phanso b = new Phanso();
            Phanso tam1 = new Phanso();
            Phanso tam2 = new Phanso();
            Phanso tam3 = new Phanso();
            Phanso tam4 = new Phanso();

            Console.WriteLine("Nhap phan so 1 ");
            a.NhapPhanSo();
            Console.WriteLine("Nhap phan so 2 ");
            b.NhapPhanSo();

            tam1 = tam1.CongPhanSo(a, b);
            Console.Write("Tong hai phan so = ");
            tam1.Rutgon();
            tam1.XuatPhanSo();

            tam2 = tam2.TruPhanSo(a, b);
            Console.Write("\nHieu hai phan so = ");
            tam2.Rutgon();
            tam2.XuatPhanSo();

            tam3 = tam3.TichPhanSo(a, b);
            Console.Write("\nTich hai phan so = ");
            tam3.Rutgon();
            tam3.XuatPhanSo();

            tam4 = tam4.ThuongPhanSo(a, b);
            Console.Write("\nThuong hai phan so = ");
            tam4.Rutgon();
            tam4.XuatPhanSo();

            Console.ReadLine();
        }
    }
}
