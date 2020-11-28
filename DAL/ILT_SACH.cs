using Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
    public interface ILT_DOCSACH
    {
        List<SACH> DocDanhSach();
    }

    public interface ILT_GHISACH
    {
        void LuuSach(SACH s);

        void LuuDanhSach(List<SACH> dsSach);
    }

    public interface ILT_XOASACH 
    {
        void XoaSach(int maSach);
    }
}
