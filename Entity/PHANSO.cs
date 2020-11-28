using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class PHANSO
    {
        public int TuSo { get; set; }
        private int mauSo;
        public int MauSo
        {
            get
            {
                return this.mauSo;
            }
            set
            {
                if (value != 0)
                {
                    this.mauSo = value;
                }

            }
        }

        public PHANSO()
        {
            this.TuSo = 0;
            this.mauSo = 1;
        }

        public PHANSO(int t, int m)
        {
            this.TuSo = t;
            if (m != 0)
                this.mauSo = m;
            else
                this.mauSo = 1;
        }

        public PHANSO(string s)
        {
            string[] M = s.Split('/');
            this.TuSo = int.Parse(M[0]);
            this.MauSo = int.Parse(M[1]);
        }

        public static bool LaHopLe(int t, int m)
        {
            return m != 0;
        }

    }
}
