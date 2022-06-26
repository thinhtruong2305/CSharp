using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShopThoiTrang.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Link { get; set; }
        [Required]
        public string Type { get; set; }
        public int Table { get; set; }
        public int? ParentId { get; set; }
        public int? Orders { get; set; }
        public int Status { get; set; }
    }
}