using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using 2 thư viện thiết kế metadata
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CandyBug.Models
{
    [MetadataTypeAttribute(typeof(ProductMetadata))]

    public partial class Product //class này là 1 phần của Product.cs
    {
        //internal - Chỉ dùng cho class này
        //sealed - ko cho kế thừa
        internal sealed class ProductMetadata
        {
            public int Id { get; set; }
     
            [Display(Name = "Loại SP")]//thuộc tính display dùng để đặt tên lại cho cột
            public Nullable<int> IdCategory { get; set; }
            
            [Display(Name = "Nhà SX")]
            public Nullable<int> IdProducer { get; set; }
            [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
            [Display(Name = "Giá bán")]
            public decimal Price { get; set; }
            [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
            [Display(Name = "Đơn vị")]
            public string Unit { get; set; }
            
            [Display(Name = "Ảnh")]
            public string Image { get; set; }
            public int Views { get; set; }
            [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
            [Display(Name = "Giảm giá")]
            public Nullable<int> Discount { get; set; }
            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy}", ApplyFormatInEditMode = true)]// định dạng ngày tháng năm
            [Display(Name = "Ngày tạo")]
            public Nullable<System.DateTime> DateCreate { get; set; }
            [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
            [Display(Name = "Mô tả")]
            public string Description { get; set; }
            [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
            [Display(Name = "Số lượng")]
            public Nullable<int> Quantity { get; set; }
            [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
            [Display(Name = "Tên SP")]
            public string Name { get; set; }
        }
    }
}