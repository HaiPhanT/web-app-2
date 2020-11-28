using Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
    public class LT_SACH: ILT_DOCSACH, ILT_GHISACH, ILT_XOASACH
    {
        private string filePath = "E:\\VB2\\HK III\\LTHDT\\dssach.txt";

        public List<SACH> DocDanhSach()
        {
            List<SACH> dsSach = new List<SACH>();
            StreamReader reader = new StreamReader(File.Open(filePath, FileMode.OpenOrCreate));

            while(reader.EndOfStream == false)
            {
                string s = reader.ReadLine();
                var sach = new SACH(s);
                dsSach.Add(sach);
            }

            reader.Close();
            return dsSach;
        }

        public void LuuSach(SACH s)
        {
            var dsSach = DocDanhSach();
            dsSach.Add(s);
            LuuDanhSach(dsSach);
        }

        public void LuuDanhSach(List<SACH> dsSach)
        {
            StreamWriter writer = new StreamWriter(filePath);

            for (int i = 0; i < dsSach.Count; i++)
            {
                var s = dsSach[i];
                string line = $"{s.MaSach},{s.TenSach},{s.Gia},{s.TacGia},{s.NamXuatBan}";

                if (i == dsSach.Count - 1)
                {
                    writer.Write(line);
                }
                else
                {
                    writer.WriteLine(line);
                }
            }

            writer.Close();
        }

        public void XoaSach(int maSach)
        {
            List<SACH> dsSach = DocDanhSach();
            foreach (SACH sach in dsSach)
            {
                if (sach.MaSach == maSach)
                {
                    dsSach.Remove(sach);
                    break;
                }
            }
            LuuDanhSach(dsSach);
        }
    }
}
