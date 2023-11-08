using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btc4_3
{
    class HinhTru : HinhTron
    {
        public double h;
        public override double TinhDienTich(double r, double h)
        {
            return base.TinhDienTich(r) * 2 * (h + r) / r;
        }
    }
}
