using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btc4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            HinhTron a = new HinhTron();
            Console.Write("dien tich hinh trong la " + a.TinhDienTich(5));

            Console.ReadLine();

        }
    }
}
