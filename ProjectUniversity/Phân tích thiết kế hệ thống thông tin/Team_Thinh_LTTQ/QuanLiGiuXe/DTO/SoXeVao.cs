using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiGiuXe.DTO
{
    class SoXeVao
    {
        private int id;
        private string loaixe;
        private string bienSo;
        private int idBaiDo;
        private DateTime? thoiGianVao;
        public SoXeVao(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Loaixe = row["loaiXe"].ToString();
            this.BienSo = row["bienSo"].ToString();
            this.IdBaiDo = (int)row["idBaiDo"];
            this.ThoiGianVao = (DateTime)row["thoiGianVao"];
        }

        public int Id { get => id; set => id = value; }
        public string Loaixe { get => loaixe; set => loaixe = value; }
        public string BienSo { get => bienSo; set => bienSo = value; }
        public int IdBaiDo { get => idBaiDo; set => idBaiDo = value; }
        public DateTime? ThoiGianVao { get => thoiGianVao; set => thoiGianVao = value; }
    }
}
