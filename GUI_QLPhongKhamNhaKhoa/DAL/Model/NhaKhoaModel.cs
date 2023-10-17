using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL.Model
{
    public partial class NhaKhoaModel : DbContext
    {
        public NhaKhoaModel()
            : base("name=NhaKhoaModel5")
        {
        }

        public virtual DbSet<ACCOUNT> ACCOUNTs { get; set; }
        public virtual DbSet<BENHNHAN> BENHNHANs { get; set; }
        public virtual DbSet<CHANDOAN> CHANDOANs { get; set; }
        public virtual DbSet<CTHD> CTHDs { get; set; }
        public virtual DbSet<DIEUTRI> DIEUTRIs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<LAMSAN> LAMSANs { get; set; }
        public virtual DbSet<LICHSUNHAPLIEUTHUOC> LICHSUNHAPLIEUTHUOCs { get; set; }
        public virtual DbSet<LICHSUNHAPLIEUVATTU> LICHSUNHAPLIEUVATTUs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<PHIEUKHAMBENH> PHIEUKHAMBENHs { get; set; }
        public virtual DbSet<THUOC> THUOCs { get; set; }
        public virtual DbSet<VATLIEUDUNGCUNHAKHOA> VATLIEUDUNGCUNHAKHOAs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.USERNAME)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.PASSWORD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BENHNHAN>()
                .Property(e => e.GIOITINH)
                .IsFixedLength();

            modelBuilder.Entity<BENHNHAN>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<BENHNHAN>()
                .HasMany(e => e.HOADONs)
                .WithRequired(e => e.BENHNHAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BENHNHAN>()
                .HasMany(e => e.LAMSANs)
                .WithRequired(e => e.BENHNHAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CHANDOAN>()
                .Property(e => e.MACHANDOAN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CHANDOAN>()
                .HasMany(e => e.DIEUTRIs)
                .WithRequired(e => e.CHANDOAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CHANDOAN>()
                .HasMany(e => e.LAMSANs)
                .WithRequired(e => e.CHANDOAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTHD>()
                .Property(e => e.MAHOADON)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTHD>()
                .Property(e => e.MADIEUTRI)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DIEUTRI>()
                .Property(e => e.MADIEUTRI)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DIEUTRI>()
                .Property(e => e.MACHANDOAN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DIEUTRI>()
                .HasMany(e => e.CTHDs)
                .WithRequired(e => e.DIEUTRI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIEUTRI>()
                .HasMany(e => e.LAMSANs)
                .WithRequired(e => e.DIEUTRI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MAHOADON)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MANV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .HasMany(e => e.CTHDs)
                .WithRequired(e => e.HOADON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LAMSAN>()
                .Property(e => e.MACHANDOAN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LAMSAN>()
                .Property(e => e.MADIEUTRI)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LICHSUNHAPLIEUTHUOC>()
                .Property(e => e.MATHUOC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LICHSUNHAPLIEUVATTU>()
                .Property(e => e.MADUNGCU)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MANV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.GIOITINH)
                .IsFixedLength();

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.HOADONs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEUKHAMBENH>()
                .Property(e => e.GIOITINH)
                .IsFixedLength();

            modelBuilder.Entity<PHIEUKHAMBENH>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<THUOC>()
                .Property(e => e.MATHUOC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VATLIEUDUNGCUNHAKHOA>()
                .Property(e => e.MADUNGCU)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
