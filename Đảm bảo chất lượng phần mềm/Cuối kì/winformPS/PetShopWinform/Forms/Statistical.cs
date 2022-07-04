using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetShopWinform.BUS;
using PetShopWinform.Forms;
using App = Microsoft.Office.Interop.Excel.Application;
using Microsoft.Office.Interop.Excel;


namespace PetShopWinform.Forms
{
    public partial class Statistical : Form
    {

        #region Khai báo biến
        Statistical_BUS busThongKe;
        #endregion

        #region Các hàm tạo
        public Statistical()
        {
            InitializeComponent();
            busThongKe = new Statistical_BUS();
        }
        #endregion

        #region Truyền và xử li dữ liệu
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(System.Windows.Forms.Button))
                {
                    System.Windows.Forms.Button btn = (System.Windows.Forms.Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.Black;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            label1.ForeColor = ThemeColor.SecondaryColor;
            label2.ForeColor = ThemeColor.PrimaryColor;
        }

        private void load_data()
        {
            busThongKe.truyenThongTinHoaDon(dataGridViewBangHienThi);
            doanhThuTongCong();
        }

        private void doanhThuTongCong()
        {
            double tongCong = 0;
            for (int i = 0; i < dataGridViewBangHienThi.RowCount; i++)
            {
                tongCong += Convert.ToDouble(dataGridViewBangHienThi.Rows[i].Cells[3].Value);
            }
            textBoxTongCong.Text = String.Format(CultureInfo.CreateSpecificCulture("vi-vn"), "{0:c}", tongCong);
        }

        public void exportToExcel(DataGridView view, String fileInfo)
        {
            App app = new App();
            Workbook workbook = app.Workbooks.Add(Type.Missing);
            Worksheet worksheet = null;
            //Định vị sheet
            worksheet = (Worksheet)workbook.Sheets["Sheet1"];
            worksheet = (Worksheet)workbook.ActiveSheet;
            //Định dạng sheet
            dinhDangWorksheet(worksheet);
            //cái i = 1 là vị trí cell 1 bên excel
            //columns.count + 1 là count đếm thiếu một số nên phải cộng 1
            for (int i = 1; i < view.Columns.Count + 1; i++)
            {
                app.Cells[1, i] = view.Columns[i - 1].HeaderText;
            }
            //hai vòng lặp
            //Vòng lặp một là số dòng
            //Vòng lặp hai là cell ô của excel lấy giá trị từ cell datagridview
            for (int i = 0; i < view.Rows.Count; i++)
            {
                for (int j = 0; j < view.Columns.Count; j++)
                {
                    if (view.Rows[i].Cells[j].Value != null)
                    {
                        //dòng và ô phải cộng 1 vì khởi tạo vòng lặp i và j đều bằng 0 có thể thay đổi nếu muốn
                        app.Cells[i + 2, j + 1] = view.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            app.ActiveWorkbook.SaveCopyAs(fileInfo);
            app.ActiveWorkbook.Saved = true;
            MessageBox.Show("Bạn đã truyền dữ liệu sang excel thành công", "Thông báo");
        }
        #endregion

        #region Định dạng
        private void dinhDangHeadertext()
        {
            dataGridViewBangHienThi.Columns[0].HeaderText = "Mã hóa đơn";
            dataGridViewBangHienThi.Columns[1].HeaderText = "Ngày tạo";
            dataGridViewBangHienThi.Columns[2].HeaderText = "Trạng thái";
            dataGridViewBangHienThi.Columns[3].HeaderText = "Tổng tiền";
            dataGridViewBangHienThi.Columns[4].HeaderText = "Mã Khách hàng";
        }

        private void dinhDangWorksheet(Worksheet worksheet)
        {
            int soDong = dataGridViewBangHienThi.Rows.Count + 1;
            //định dạng trang
            worksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlPortrait;
            worksheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA4;
            worksheet.PageSetup.TopMargin = 0;
            worksheet.PageSetup.LeftMargin = 0;
            worksheet.PageSetup.RightMargin = 0;
            worksheet.PageSetup.BottomMargin = 0;
            //định dạng cột
            worksheet.Range["A1"].ColumnWidth = 15;
            worksheet.Range["B1"].ColumnWidth = 20;
            worksheet.Range["C1"].ColumnWidth = 25;
            worksheet.Range["D1"].ColumnWidth = 20;
            worksheet.Range["E1"].ColumnWidth = 20;
            //định dạng font chữ
            worksheet.Range["A1", "E" + soDong].Font.Name = "Times New Roman";
            worksheet.Range["A1", "E" + soDong].Font.Size = 14;
            worksheet.Range["A1", "E1"].Font.Bold = true;
            //Kẻ bảng
            worksheet.Range["A1", "E" + soDong].Borders.LineStyle = 1;
            //Căn lề
            worksheet.Range["A1", "E" + soDong].HorizontalAlignment = 3;
        }

        private void dataGridViewBangHienThi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex.Equals(2))
            {
                String trangThai = e.Value.ToString();
                if (trangThai.Equals("CHƯA DUYỆT"))
                {
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.ForeColor = Color.White;
                }
                else
                {
                    e.CellStyle.BackColor = Color.Green;
                    e.CellStyle.ForeColor = Color.White;
                }
            }
            else if (e.ColumnIndex.Equals(1))
            {
                e.CellStyle.Format = "dd/MM/yyyy";
            }
            else if (e.ColumnIndex.Equals(3))
            {
                e.Value = String.Format(CultureInfo.CreateSpecificCulture("vi-vn"), "{0:c}", dataGridViewBangHienThi.Rows[e.RowIndex].Cells[3].Value);
            }
        }
        #endregion

        #region Sự kiện

        #region Load
        private void Statistical_Load(object sender, EventArgs e)
        {
            LoadTheme();
            load_data();
            dinhDangHeadertext();

        }
        #endregion

        #region changed
        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            DateTime giaTriNgay = dateTimePickerFrom.Value;
            if (dateTimePickerFrom.Value > dateTimePickerTo.Value)
            {
                MessageBox.Show("Không tìm thấy dữ liệu phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePickerFrom.Value = giaTriNgay;
            }
            else
            {
                busThongKe.truyenThongTinHoaDonTheoNgay(dataGridViewBangHienThi, dateTimePickerFrom.Value, dateTimePickerTo.Value);
                doanhThuTongCong();
            }
        }

        private void dateTimePickerTo_ValueChanged(object sender, EventArgs e)
        {
            DateTime giaTriNgay = DateTime.Today;
            if (dateTimePickerTo.Value < dateTimePickerFrom.Value)
            {
                MessageBox.Show("Không tìm thấy dữ liệu phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePickerTo.Value = giaTriNgay;
            }
            else
            {
                busThongKe.truyenThongTinHoaDonTheoNgay(dataGridViewBangHienThi, dateTimePickerFrom.Value, dateTimePickerTo.Value);
                doanhThuTongCong();
            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            Statistical_Load(sender, e);
        }
        #endregion

        #region Click
        private void txtFind_Click(object sender, EventArgs e)
        {
            txtFind.Text = null;
            txtFind.ForeColor = Color.Black;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Statistical_Load(sender, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtFind.Text != "")
            {
                //Phân biệt số và chữ nếu số sẽ tìm mã hóa đơn, chữ thì tìm tên khách hàng
                //lấy phần tử đầu tiên ra để xét
                char c = Convert.ToChar(txtFind.Text.ElementAt(0));
                //Ở đây có thể dùng char.isDigit
                if (c >= 48 && c <= 57)
                {
                    //Nếu mà tìm thấy thì ở này sẽ là true nếu không thì sẽ hiện một Messagebox
                    if (busThongKe.truyenThongTinHoaDonTheoMaHoaDon(dataGridViewBangHienThi, Convert.ToInt32(txtFind.Text)))
                    {
                        txtFind.Enabled = false;
                        txtFind.Enabled = true;
                        doanhThuTongCong();
                    }
                    else
                    {
                        MessageBox.Show("Xin lỗi! Chúng tôi không tìm thấy dữ liệu phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    //Nếu mà tìm thấy thì ở này sẽ là true nếu không thì sẽ hiện một Messagebox
                    if (busThongKe.truyenThongTinHoaDonTheoTen(dataGridViewBangHienThi, txtFind.Text))
                    {
                        txtFind.Enabled = false;
                        txtFind.Enabled = true;
                        doanhThuTongCong();
                    }
                    else
                    {
                        MessageBox.Show("Xin lỗi! Chúng tôi không tìm thấy dữ liệu phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
                MessageBox.Show("Xin lỗi! Yêu cầu bạn nhập thông tin trước khi tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Statistical_Click(object sender, EventArgs e)
        {

            txtFind.Text = "Nhập mã hóa đơn, tên khách hàng";
            txtFind.ForeColor = Color.DarkGray;

            txtFind.Enabled = false;
            txtFind.Enabled = true;
        }


        private void dataGridViewBangHienThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Statistcal_Info info;
            int maKhachHang = Convert.ToInt32(dataGridViewBangHienThi.CurrentRow.Cells[4].Value);
            int maHoaDon = Convert.ToInt32(dataGridViewBangHienThi.CurrentRow.Cells[0].Value.ToString());
            DateTime ngayTao = Convert.ToDateTime(dataGridViewBangHienThi.CurrentRow.Cells[1].Value.ToString());
            if (maKhachHang.Equals(null))
            {
                info = new Statistcal_Info(maHoaDon, ngayTao);
                info.Show();
            }
            else
            {
                info = new Statistcal_Info(maKhachHang, maHoaDon, ngayTao);
                info.Show();
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    exportToExcel(dataGridViewBangHienThi, saveFileDialog.FileName);
                }
            }
        }
        #endregion

        #region key press
        private void txtFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                pictureBox1_Click(sender, e);
            }
        }
        #endregion

        #endregion


    }
}
