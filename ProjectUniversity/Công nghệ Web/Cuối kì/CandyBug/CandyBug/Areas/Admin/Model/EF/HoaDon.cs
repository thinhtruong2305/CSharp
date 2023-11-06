using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace CandyBug.Areas.Admin.Model.EF
{
    public class HoaDon
    {
        [Display(Name = "Mã hóa đơn")]
        public int maHoaDon { get; set; }

        [Display(Name = "Tên hóa đơn")]
        public String tenSanPham { get; set; }

        [Display(Name = "Giá")]
        public Nullable<decimal> gia{ get; set; }

        [Display(Name = "Số lượng")]
        public Nullable<int> soLuong { get; set; }

        [Display(Name = "Tổng tiền")]
        public Nullable<decimal> tongTien { get; set; }
    }
}