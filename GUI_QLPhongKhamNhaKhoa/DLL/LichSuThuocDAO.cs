using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class LichSuThuocDAO
    {
        private NhaKhoaModel context;
        public LichSuThuocDAO()
        {
            context = new NhaKhoaModel();

        }
        public List<LICHSUNHAPLIEUTHUOC> GetLSThuocByTenThuoc(string tenthuoc)
        {
            return context.LICHSUNHAPLIEUTHUOCs.Where(t => t.TENTHUOC.Contains(tenthuoc)).ToList();

        }

        public LICHSUNHAPLIEUTHUOC GetLSThuocByMaThuoc(string maThuoc)
        {
            return context.LICHSUNHAPLIEUTHUOCs.FirstOrDefault(t => t.MATHUOC == maThuoc);
        }

        public List<LICHSUNHAPLIEUTHUOC> GetLichSuNhapLieuthuoc()
        {
            return context.LICHSUNHAPLIEUTHUOCs.OrderByDescending(l => l.THOIGIAN).ToList();
        }

        public void ThemLichSuNhapLieuthuoc(string loaiNhapLieuthuoc, string mathuoc, string tenThuoc, int soLuong, string donVi, double donGia)
        {

            LICHSUNHAPLIEUTHUOC lichSuNhap = new LICHSUNHAPLIEUTHUOC
            {
                LOAINHAPLIEU = loaiNhapLieuthuoc,
                MATHUOC = mathuoc,
                TENTHUOC = tenThuoc,
                SOLUONG = soLuong,
                DVT = donVi,
                DONGIA = donGia,
                THOIGIAN = DateTime.Now
            };
            context.LICHSUNHAPLIEUTHUOCs.Add(lichSuNhap);
            context.SaveChanges();

        }
    }
}
