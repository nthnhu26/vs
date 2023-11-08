using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btc4_1
{
    class Phanso
    {
        public int tuso;
        public int mauso;
        public void NhapPhanSo()
        {
            Console.Write("Tu so = ");
            this.tuso = int.Parse(Console.ReadLine());
            Console.Write("Mau so = ");
            do
                this.mauso = int.Parse(Console.ReadLine());
            while (this.mauso == 0);
        }

        public void XuatPhanSo()
        {
            Console.Write(tuso + "/" + mauso);
        }

        public int GCD(int a, int b)
        {
            if (b == 0)
                return a;
            else
                return GCD(b, a % b);
        }

        public void Rutgon()
        {
            int ucln = GCD(this.tuso, this.mauso);
            this.tuso = this.tuso / ucln;
            this.mauso = this.mauso / ucln;
        }

        public Phanso CongPhanSo(Phanso a, Phanso b)
        {
            Phanso tam = new Phanso();
            tam.tuso = a.tuso * b.mauso + b.tuso * a.mauso;
            tam.mauso = a.mauso * b.mauso;
            return tam;
        }

        public Phanso TruPhanSo(Phanso a, Phanso b)
        {
            Phanso tam = new Phanso();
            tam.tuso = a.tuso * b.mauso - b.tuso * a.mauso;
            tam.mauso = a.mauso * b.mauso;
            return tam;
        }

        public Phanso TichPhanSo(Phanso a, Phanso b)
        {
            Phanso tam = new Phanso();
            tam.tuso = a.tuso * b.tuso;
            tam.mauso = a.mauso * b.mauso;
            return tam;
        }

        public Phanso ThuongPhanSo(Phanso a, Phanso b)
        {
            Phanso tam = new Phanso();
            tam.tuso = a.tuso * b.mauso;
            tam.mauso = a.mauso * b.tuso;
            return tam;     
        }

    }
}
