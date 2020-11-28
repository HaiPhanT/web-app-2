using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices
{
    public class XL_PHANSO
    {
        public bool Ghi(int t, int m)
        {
            if (PHANSO.LaHopLe(t, m))
            {
                PHANSO p = new PHANSO(t, m);
                var luuTruPhanSo = new LT_PHANSO();
                luuTruPhanSo.Ghi(p);
                return true;
            }
            return false;
        }

        public PHANSO Doc()
        {
            var luuTruPhanSo = new LT_PHANSO();
            var p = luuTruPhanSo.Doc();
            return p;
        }
    }
}
