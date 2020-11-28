using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class SACH
    {
        public int MaSach { get; set; }
        public string TenSach { get; set; }
        public int Gia { get; set; }
        public string TacGia { get; set; }
        public int NamXuatBan { get; set; }

        public SACH()
        {
        }

        public SACH(string s)
        {
            string[] M = s.Split(',');
            this.MaSach = int.Parse(M[0]);
            this.TenSach = M[1];
            this.Gia = int.Parse(M[2]);
            this.TacGia = M[3];
            this.NamXuatBan = int.Parse(M[4]);
        }
    }
}
