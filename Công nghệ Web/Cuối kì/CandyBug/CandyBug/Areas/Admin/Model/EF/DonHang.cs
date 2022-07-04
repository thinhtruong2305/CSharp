using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CandyBug.Areas.Admin.Model.EF
{
    public class DonHang
    {
        [Display(Name = "Mã hóa đơn")]
        public int maHoaDon { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Ngày tạo")]
        public DateTime ngayTao { get; set; }

        [Display(Name = "Trạng thái")]
        [Required]
        public String trangThai { get; set; }

        [Display(Name = "Địa chỉ")]
        public String diaChi { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Ngày giao hàng")]
        [Required]
        public Nullable<DateTime> ngayGiao { get; set; }

        [Display(Name = "Số điện thoại")]
        public int soDienThoai { get; set; }

        [Display(Name = "Nhân viên")]
        public String tenNhanVien { get; set; }
    }
}