using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class ThuocDAO
    {
        private NhaKhoaModel context;
        public ThuocDAO()
        {
            context = new NhaKhoaModel();
        }

        public List<THUOC> GetAllThuoc()
        {
            return context.THUOCs.ToList();
        }

        public List<THUOC> GetThuocByTenThuoc(string tenthuoc)
        {
            return context.THUOCs.Where(t => t.TENTHUOC.Contains(tenthuoc)).ToList();

        }

        public THUOC GetThuocByMaThuoc(string maThuoc)
        {
            return context.THUOCs.FirstOrDefault(t => t.MATHUOC == maThuoc);
        }



        public void Them_UpDate(THUOC thuoc)
        {
            THUOC tontaiThuoc = context.THUOCs.FirstOrDefault(t => t.MATHUOC == thuoc.MATHUOC);
            if (tontaiThuoc != null)
            {
                // Cập nhật thông tin thuốc
                tontaiThuoc.TENTHUOC = thuoc.TENTHUOC;
                tontaiThuoc.SOLUONG = thuoc.SOLUONG;
                tontaiThuoc.DVT = thuoc.DVT;
                tontaiThuoc.DONGIA = thuoc.DONGIA;
            }
            else
            {
                // Thêm mới thuốc
                context.THUOCs.Add(thuoc);

            }

            context.SaveChanges();

        }

        public void XoaThuoc(THUOC thuoc)
        {
            context.THUOCs.Remove(thuoc);
            context.SaveChanges();
        }
    }
}
