using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
namespace DLL
{
    public class BenhNhanDAO
    {
        public List<BENHNHAN> GetAll()
        {
            NhaKhoaModel context = new NhaKhoaModel();
            return context.BENHNHANs.ToList();
        }
        public BENHNHAN FindByID(int ID)
        {
            NhaKhoaModel context = new NhaKhoaModel();
            return context.BENHNHANs.Find(ID);
        }
        public void Add_Update(BENHNHAN benhNhan)
        {
            NhaKhoaModel context = new NhaKhoaModel();

            context.BENHNHANs.AddOrUpdate(b => b.MABENHNHAN, benhNhan);
            context.SaveChanges();
        }
        public void Delete(int maBenhNhan)
        {
            NhaKhoaModel context = new NhaKhoaModel();
            var benhNhan = context.BENHNHANs.Find(maBenhNhan);

            if (benhNhan != null)
            {
                context.BENHNHANs.Remove(benhNhan);
                context.SaveChanges();
            }
        }
    }
}

