using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace QLSV.Models
{
    public class QuanLiSinhVien:DbContext
    {
        public QuanLiSinhVien() : base( "QuanLiSinhVien")
        {

        }
        public DbSet<SinhVien> SinhViens { get; set; }
        public DbSet<Lop> Lops { get; set; }
    }
}