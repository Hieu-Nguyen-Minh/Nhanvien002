using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Nhanvien002.Models
{
    [Table("NhanVien")]
    public class NhanVien
    {
        [Display(Name ="Mã nhân viên")]
        public int NhanVienId { get; set; }
        [Display(Name = "Họ tên")]
        [Required(ErrorMessage ="*")]
        [MaxLength(50,ErrorMessage ="tối đa 50 ký tự")]
        public string HoTen { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "*")]
        [MaxLength(50, ErrorMessage = "tối đa 50 ký tự")]
        public string Email { get; set; }
        [Display(Name = "Phòng ban")]
        [Required(ErrorMessage = "*")]
        [MaxLength(50, ErrorMessage = "tối đa 50 ký tự")]
        public string PhongBan { get; set; }
        [Display(Name = "Mức lương")]
        public double MucLuong { get; set; }

    }
}
