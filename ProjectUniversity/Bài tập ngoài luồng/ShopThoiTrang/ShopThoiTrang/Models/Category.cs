using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShopThoiTrang.Models
{
    [Table("Categories")]
    public class Category
    {
        [Key]
        [Display(Name = "ID")]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Tên loại sản phẩm")]
        public string Name { get; set; }
        [Display(Name = "Liên kết")]
        public string Slug { get; set; }
        [Display(Name = "Chủ đề cha")]
        public int? ParentId { get; set; }
        [Display(Name = "Sắp xếp")]
        public int? Orders { get; set; }
        [Required]
        [Display(Name = "Từ khóa SEO")]
        public string Metakey { get; set; }
        [Required]
        [Display(Name = "Mô tả SEO")]
        public string Metades { get; set; }
        [Display(Name = "Tạo bởi")]
        public int? CreateBy { get; set; }
        [Display(Name = "Ngày tạo")]
        public DateTime? CreateAt { get; set; }
        [Display(Name = "Sửa bởi")]
        public int? UpdateBy { get; set; }
        [Display(Name = "Ngày sửa")]
        public DateTime? UpdateAt { get; set; }
        [Display(Name = "Trạng thái")]
        public int Status { get; set; }
    }
}