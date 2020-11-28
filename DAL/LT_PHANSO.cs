using Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LT_PHANSO
    {
        private string filePath = "E:\\VB2\\HK III\\LTHDT\\phanso.txt";

        public void Ghi(PHANSO p)
        {
            StreamWriter file = new StreamWriter(filePath);
            file.Write($"{p.TuSo}/{p.MauSo}");

            file.Close();
        }

        public PHANSO Doc()
        {
            StreamReader file = new StreamReader(filePath);
            string s = file.ReadLine();
            var p = new PHANSO(s);
            file.Close();

            return p;
        }
    }
}
