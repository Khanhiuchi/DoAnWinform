using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class PhieuKhamBenhDAO
    {
        public List<PHIEUKHAMBENH> GetAll()
        {
            NhaKhoaModel model = new NhaKhoaModel();
            return model.PHIEUKHAMBENHs.ToList();
        }
    }
}
