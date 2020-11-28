using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BusinessServices
{
    public interface IXL_SACH
    {
        List<SACH> LayDanhSach();

        void ThemSach(SACH s);

        void XoaSach(int maSach);

        SACH SuaSach(SACH sachMoi);
    }
}
