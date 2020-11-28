using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BusinessServices
{
    public class XL_SACH: IXL_SACH
    {
        private ILT_DOCSACH docSach;
        private ILT_GHISACH ghiSach;
        private ILT_XOASACH xoaSach;

        public XL_SACH (LT_SACH ltSach)
        {
            docSach = ltSach;
            ghiSach = ltSach;
            xoaSach = ltSach;
        }

        public List<SACH> LayDanhSach()
        {
            var kq = docSach.DocDanhSach();
            return kq;
        }

        public void ThemSach(SACH s)
        {
            ghiSach.LuuSach(s);
        }

        public void XoaSach(int maSach)
        {
            xoaSach.XoaSach(maSach);
        }

        public SACH SuaSach(SACH sachMoi)
        {
            List<SACH> dsSach = LayDanhSach();
            for (var i=0; i< dsSach.Count; i++)
            {
                if (dsSach[i].MaSach == sachMoi.MaSach)
                {
                    dsSach[i] = sachMoi;
                    break;
                }
            }
            ghiSach.LuuDanhSach(dsSach);
            return null;
        }
    }
}
