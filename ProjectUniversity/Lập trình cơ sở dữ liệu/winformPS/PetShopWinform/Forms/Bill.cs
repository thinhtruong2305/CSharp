using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using PetShopWinform.Model;

namespace PetShopWinform.Forms
{
    public partial class Bill : Form
    {
        List<ItemOrder> list;
        string name, sdt, address, toTal, Discount;
        DateTime datecreate;
        public Bill(List<ItemOrder> list,string name,string sdt,string address,DateTime datecreate,string toTal, string Discount=null)
        {
            InitializeComponent();
            this.list = list;
            this.name = name;
            this.sdt = sdt;
            this.address = address;
            this.datecreate = datecreate;
            this.toTal = toTal;
            this.Discount = Discount;
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            var reportsource = new ReportDataSource("ItemOderBinding",list);
            ReportParameter[] para = new ReportParameter[]
            {
                new ReportParameter("Name",name),
                new ReportParameter("SDT",sdt),
                new ReportParameter("Address",address),
                new ReportParameter("DateCrate",datecreate.ToString()),
                new ReportParameter("ToTal",toTal),
                new ReportParameter("Discount",Discount)
            };
            this.reportViewer1.LocalReport.DataSources.Add(reportsource);
            this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.RefreshReport();
        }
    }
}
