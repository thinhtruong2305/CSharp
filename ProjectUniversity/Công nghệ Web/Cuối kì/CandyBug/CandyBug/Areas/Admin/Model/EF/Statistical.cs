using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CandyBug.Areas.Admin.Model.EF
{
    public class Statistical
    {
        [Display(Name = "Mã hóa đơn")]
        public int maHoaDon { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy}", ApplyFormatInEditMode = true)]// định dạng ngày tháng năm
        [Display(Name = "Ngày tạo")]
        public Nullable<DateTime> ngayTao { get; set; }

        [Display(Name = "Tổng tiền")]
        public Nullable<decimal> tongTien { get; set; }

        [Display(Name = "Trạng thái")]
        public String trangThai { get; set; }
    }
}