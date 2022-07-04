using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiGiuXe.DTO
{
    class LoaiXe
    {
        private int id;
        private string tenloaixe;
        private decimal dongia;

        public LoaiXe(DataRow row)
        {
            this.id = Convert.ToInt32(row["IdLoaiXe"]);
            this.tenloaixe = row["TenLoaiXe"].ToString();
            this.dongia = (decimal)row["DonGia"];
        }


        public int Id { get => id; set => id = value; }
        public string Tenloaixe { get => tenloaixe; set => tenloaixe = value; }
        public decimal Dongia { get => dongia; set => dongia = value; }
    }
}
