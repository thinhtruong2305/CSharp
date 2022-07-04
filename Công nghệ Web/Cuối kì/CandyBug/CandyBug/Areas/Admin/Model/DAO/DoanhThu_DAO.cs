using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CandyBug.Models;
using CandyBug.Areas.Admin.Model.EF;

namespace CandyBug.Areas.Admin.Model.DAO
{
    public class DoanhThu_DAO
    {
        private CandybugOnlineEntities DBCandyBug = new CandybugOnlineEntities();

        public List<DoanhThu> getDoanhThu()
        {
            var report = (from u in DBCandyBug.Oders
                          select new DoanhThu
                          {
                              thang = u.DateCreate.Value.Month,
                              doanhThu = u.OrderInfoes.Select(c => c.Total).Sum()
                          }).ToList();
            return report;
        }

        public List<DoanhThu> getDoanhThuByYear(int year)
        {
            var report = (from u in DBCandyBug.Oders
                          where u.DateCreate.Value.Year == year
                          select new DoanhThu
                          {
                              thang = u.DateCreate.Value.Month,
                              doanhThu = u.OrderInfoes.Select(c => c.Total).Sum()
                          }).ToList();
            return report;
        }

        public dynamic getYear()
        {
            var report = DBCandyBug.Oders.Select(u => u.DateCreate.Value.Year).ToList();
            return report;
        }
    }
}