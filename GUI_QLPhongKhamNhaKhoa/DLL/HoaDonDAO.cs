using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class HoaDonDAO
    {
        public List<HOADON> GetAll()
        {
            NhaKhoaModel model = new NhaKhoaModel();
            return model.HOADONs.ToList();
        }
        public List<HOADON> FindID(string id)
        {
            NhaKhoaModel model = new NhaKhoaModel();
            return model.HOADONs.Where(p => p.MAHOADON == id).ToList();
        }
        public List<HOADON> GetNoTrangThai()
        {
            NhaKhoaModel model = new NhaKhoaModel();
            return model.HOADONs.Where(p => p.TRANGTHAI == "Chưa thanh toán").ToList();
        }
    }
}
