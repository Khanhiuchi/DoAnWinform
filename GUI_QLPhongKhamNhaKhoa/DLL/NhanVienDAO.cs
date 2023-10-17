using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class NhanVienDAO
    {
        public List<NHANVIEN> GetDoctor()
        {
            NhaKhoaModel model = new NhaKhoaModel();
            return model.NHANVIENs.Where(p => p.CHUCVU == "Lễ tân").ToList();
        }
    }
}
