using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLSV.Models
{
    public class SinhVien
    {
        [Key]
        public string MaSV { get; set; }
        [Required]
        [StringLength(50)]
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        [ForeignKey("Lop")]
        public string TenLop { get; set; }
        public virtual Lop Lop { get; set; }
    }
}