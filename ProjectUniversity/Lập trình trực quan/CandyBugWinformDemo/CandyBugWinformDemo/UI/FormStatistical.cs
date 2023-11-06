using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel; //using vô
using App = Microsoft.Office.Interop.Excel.Application; //đây là gán giá trị luôn lấy lớp cho ngắn
using System.Data.SqlClient;
using CandyBugWinformDemo.Object;

namespace CandyBugWinformDemo.NewFolder1
{
    public partial class FormStatistical : Form
    {
        //dung account de phan quyen sta...
        public Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }

        void ChangeAccount(Account acc)
        {

        }
        //
        public FormStatistical(Account acc)
        {
            LoginAccount = acc;
            InitializeComponent();
        }
        public FormStatistical()
        {
            InitializeComponent();
        }

        //thuộc tính
        SqlConnection connection;
        String connectionString = "Data Source=nhomsix.database.windows.net;Initial Catalog=QLBK;User ID=nhom6;Password=123456789aA";
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        System.Data.DataTable dataTable = new System.Data.DataTable();

        //load dữ liệu lên data grid view
        public void load_data(String cmd)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            command = connection.CreateCommand();
            //cmd này là một câu lệnh query
            command.CommandText = cmd;
            //adapter sẽ chọn lệnh từ cmd để excute
            adapter.SelectCommand = command;
            //xóa bảng cũ
            dataTable.Clear();
            //đổ dữ liệu vào bảng
            adapter.Fill(dataTable);
            dataGridViewStatistical.DataSource = dataTable;
            connection.Close();
        }

        //Tính tổng tiền thu được
        public void load_data_tong_tien_so_lan_orders()
        {
            double payment = 0;
            for(int i = 0; i < dataGridViewStatistical.Rows.Count; i++)
            {
                payment += Convert.ToDouble(dataGridViewStatistical.Rows[i].Cells[4].Value);
            }
            textBoxTongTien.Text = String.Format(CultureInfo.CreateSpecificCulture("vi-vn"), "{0:c}", payment);
            textBoxTongOrder.Text = Convert.ToString(dataGridViewStatistical.Rows.Count - 1);
        }

        //chỉnh sửa bảng
        public void chinh_sua_bang()
        {
            //Chỉnh sửa header test
            dataGridViewStatistical.Columns[0].HeaderText = "ID sản phẩm";
            dataGridViewStatistical.Columns[1].HeaderText = "Sản phẩm";
            dataGridViewStatistical.Columns[2].HeaderText = "Số lượng";
            dataGridViewStatistical.Columns[3].HeaderText = "Giá sản phẩm";
            dataGridViewStatistical.Columns[4].HeaderText = "Tiền thanh toán";
            dataGridViewStatistical.Columns[5].HeaderText = "Ngày mua";
            //Chỉnh sửa width
            dataGridViewStatistical.Columns[0].Width = (int)(dataGridViewStatistical.Width * 0.15);
            dataGridViewStatistical.Columns[1].Width = (int)(dataGridViewStatistical.Width * 0.13);
            dataGridViewStatistical.Columns[2].Width = (int)(dataGridViewStatistical.Width * 0.14);
            dataGridViewStatistical.Columns[3].Width = (int)(dataGridViewStatistical.Width * 0.17);
            dataGridViewStatistical.Columns[4].Width = (int)(dataGridViewStatistical.Width * 0.17);
            dataGridViewStatistical.Columns[5].Width = (int)(dataGridViewStatistical.Width * 0.14);
        }

        //định dạng worksheet excel
        private void dinhDangWorksheet(Worksheet worksheet)
        {
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
            worksheet.Range["C1"].ColumnWidth = 15;
            worksheet.Range["D1"].ColumnWidth = 20;
            worksheet.Range["E1"].ColumnWidth = 20;
            worksheet.Range["F1"].ColumnWidth = 20;
            //định dạng font chữ
            worksheet.Range["A1", "F1048576"].Font.Name = "Times New Roman";
            worksheet.Range["A1", "F1048576"].Font.Size = 14;
            worksheet.Range["A1", "F1"].Font.Bold = true;
            //Kẻ bảng
            int soDong = dataGridViewStatistical.Rows.Count + 1;
            worksheet.Range["A1", "F" + soDong].Borders.LineStyle = 1;
            //Căn lề
            worksheet.Range["A1", "F1048576"].HorizontalAlignment = 3;
        }
        private void FormStatistical_Load(object sender, EventArgs e)
        {
            load_data("SELECT Product.idPro, Product.name, Orders.quantity, CONVERT(nvarchar(50), CAST(Product.price as money), 1), CONVERT(nvarchar(50), CAST(Product.price * Orders.quantity as money), 1), FORMAT(CAST(Orders.DateCheckOut as date), 'dd/MM/yyyy') FROM Orders INNER JOIN Product ON Orders.idProduct = Product.idPro");
            load_data_tong_tien_so_lan_orders();
            chinh_sua_bang();
        }

        /// <summary>
        /// Đây là phương thức truyền dữ liệu dùng cho sự kiện btn excel click
        /// Muốn làm được phương thức này trước hết phải add references Microsoft.Office.Interop.Exel
        /// Có hai cách một là sử dụng package manager console và và cho lệnh này vào trước PM> "Install-Package Microsoft.Office.Interop.Excel"
        /// Cách hai là vô add nuget tìm bên broswer cái này rồi add sao vô reference Microsoft.Office.Interop.Exel
        /// Xong được là ok rồi
        /// Tiếp phương thức này có tham số datagridview, đường dẫn tới file, tên tập tin
        /// lưu ý phải using vô đây mà tui using rồi
        /// </summary>
        /// <param name="view">Bảng dữ liệu hiển thị</param>
        /// <param name="duongDan">Đường dẫn tập tin. Lưu ý thêm một dấu \ phía sau cùng đường dẫn để khi ghép tên file vào thì nó tự tạo ko thì lỗi ấy (VD: @"C:\Folder\")</param>
        /// <param name="tenTapTin">Tên tập tin</param>
        public void exportToExcel(DataGridView view, String duongDan, String tenTapTin)
        {
            App app = new App();
            Workbook workbook = app.Workbooks.Add(Type.Missing);
            Worksheet worksheet = null;
            //Định vị sheet
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            //Định dạng sheet
            dinhDangWorksheet(worksheet);
            //cái i = 1 là vị trí cell 1 bên excel
            //columns.count + 1 là count đếm thiếu một số nên phải cộng 1
            for(int i = 1; i < view.Columns.Count + 1; i++)
            {
                app.Cells[1, i] = view.Columns[i - 1].HeaderText;
            }
            //hai vòng lặp
            //Vòng lặp một là số dòng
            //Vòng lặp hai là cell ô của excel lấy giá trị từ cell datagridview
            for(int i = 0; i < view.Rows.Count; i++)
            {
                for(int j = 0; j < view.Columns.Count; j++)
                {
                    if (view.Rows[i].Cells[j].Value != null)
                    {
                        //dòng và ô phải cộng 1 vì khởi tạo vòng lặp i và j đều bằng 0 có thể thay đổi nếu muốn
                        app.Cells[i + 2, j + 1] = view.Rows[i].Cells[j].Value.ToString();
                        if(j + 1 == 4 || j + 1 == 5)
                        {
                            //định dạng thêm tiền cho các cell excel D và E tương ứng là cell 4 và 5
                            app.Cells[i + 2, j + 1] = view.Rows[i].Cells[j].Value.ToString() + " VND";
                        }
                    }
                }
            }
            app.ActiveWorkbook.SaveCopyAs(duongDan + tenTapTin + ".xlsx");
            app.ActiveWorkbook.Saved = true;
            MessageBox.Show("Bạn đã truyền dữ liệu sáng excel thành công", "Thông báo");
        }

        //Khu TextBox
        //Khi người dùng click vào ô viết tìm kiếm thì sẽ làm mất chữ và đổi màu chữ sang đen
        private void textBoxTimKiem_Click(object sender, EventArgs e)
        {
            textBoxTimKiem.Text = null;
            textBoxTimKiem.ForeColor = Color.Black;
        }

        //Khi người dùng nhấn enter thì sẽ tìm kiếm kết quả theo id và name
        private void textBoxTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                char c = Convert.ToChar(textBoxTimKiem.Text.ElementAt(1));
                if (c >= 48 && c <= 57)
                {
                    load_data("SELECT Product.idPro, Product.name, Orders.quantity, CONVERT(nvarchar(50), CAST(Product.price as money),1), CONVERT(nvarchar(50), CAST(Product.price * Orders.quantity as money),1), FORMAT(CAST(Orders.DateCheckOut as date), 'dd/MM/yyyy') FROM Orders INNER JOIN Product ON Orders.idProduct = Product.idPro where Product.idPro = '" + Convert.ToInt32(textBoxTimKiem.Text) + "'");
                }
                else 
                {
                    load_data("SELECT Product.idPro, Product.name, Orders.quantity, CONVERT(nvarchar(50), CAST(Product.price as money),1), CONVERT(nvarchar(50), CAST(Product.price * Orders.quantity as money),1), FORMAT(FORMAT(CAST(Orders.DateCheckOut as date), 'dd/MM/yyyy'), 'dd/MM/yyyy') FROM Orders INNER JOIN Product ON Orders.idProduct = Product.idPro where Product.name = N'" + textBoxTimKiem.Text + "'");
                }
                textBoxTimKiem.Enabled = false;
                textBoxTimKiem.Enabled = true;
            }
        }

        //Khi người dùng xóa hay nhấn chữ nào đó thì sẽ làm mới bảng
        private void textBoxTimKiem_TextChanged(object sender, EventArgs e)
        { 
            FormStatistical_Load(sender,e);
        }

        //khu panel
        //Khi người dùng click phần ngoài trong khu phần thông tin thì sẽ đặt lại text cho ô tìm kiếm
        private void panelHienThiThongTIn_Click(object sender, EventArgs e)
        {
            textBoxTimKiem.Text = "Tìm kiếm theo id của item, name của item";
            textBoxTimKiem.ForeColor = Color.DarkGray;
        }
        //Khi người dùng click phần panel của date timepicker trong khu phần thông tin thì sẽ đặt lại text cho ô tìm kiếm
        private void panel1_Click(object sender, EventArgs e)
        {
            textBoxTimKiem.Text = "Tìm kiếm theo id của item, name của item";
            textBoxTimKiem.ForeColor = Color.DarkGray;
            textBoxTimKiem.Enabled = false;
            textBoxTimKiem.Enabled = true;
        }

        //Khu Button
        //Nhấn nút này sẽ làm mới dữ liệu bảng danh sách
        private void btnReset_Click(object sender, EventArgs e)
        {
            load_data("SELECT Product.idPro, Product.name, Orders.quantity, CONVERT(nvarchar(50), CAST(Product.price as money),1), CONVERT(nvarchar(50), CAST(Product.price * Orders.quantity as money),1), FORMAT(CAST(Orders.DateCheckOut as date), 'dd/MM/yyyy') FROM Orders INNER JOIN Product ON Orders.idProduct = Product.idPro");
            textBoxTimKiem.Text = "Tìm kiếm theo id của item, name của item";
            textBoxTimKiem.ForeColor = Color.DarkGray;
            textBoxTimKiem.Enabled = false;
            textBoxTimKiem.Enabled = true;
        }

        //Nhấn nút này sẽ truyền dữ liệu sang excel
        private void btnExcel_Click(object sender, EventArgs e)
        {
            exportToExcel(dataGridViewStatistical, @"C:\Tài liệu\", "CandyBugThongKe");
        }

        //Khu date tim picker
        //thay đổi dữ liệu trên chọn ngày from thì sẽ hiển thị kết quả lên bảng danh sách
        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            textBoxTimKiem.Text = "Tìm kiếm theo id của item, name của item";
            textBoxTimKiem.ForeColor = Color.DarkGray;
            load_data("SELECT Product.idPro, Product.name, Orders.quantity, CONVERT(nvarchar(50), CAST(Product.price as money),1), CONVERT(nvarchar(50), CAST(Product.price * Orders.quantity as money),1), FORMAT(CAST(Orders.DateCheckOut as date), 'dd/MM/yyyy') FROM Orders INNER JOIN Product ON Orders.idProduct = Product.idPro Where Orders.DateCheckOut >= '" + dateTimePickerFrom.Value + "' AND Orders.DateCheckOut <= '" + dateTimePickerTo.Value + "'");
            textBoxTongOrder.Text = Convert.ToString(dataGridViewStatistical.Rows.Count - 1);
            load_data_tong_tien_so_lan_orders();
        }
        //thay đổi dữ liệu trên chọn ngày to thì sẽ hiển thị kết quả lên bảng danh sách
        private void dateTimePickerTo_ValueChanged(object sender, EventArgs e)
        {
            textBoxTimKiem.Text = "Tìm kiếm theo id của item, name của item";
            textBoxTimKiem.ForeColor = Color.DarkGray;
            load_data("SELECT Product.idPro, Product.name, Orders.quantity, CONVERT(nvarchar(50), CAST(Product.price as money),1), CONVERT(nvarchar(50), CAST(Product.price * Orders.quantity as money),1), FORMAT(CAST(Orders.DateCheckOut as date), 'dd/MM/yyyy') FROM Orders INNER JOIN Product ON Orders.idProduct = Product.idPro Where Orders.DateCheckOut <= '" + dateTimePickerTo.Value + "' AND Orders.DateCheckOut >= '" + dateTimePickerFrom.Value + "'");
            textBoxTongOrder.Text = Convert.ToString(dataGridViewStatistical.Rows.Count - 1);
            load_data_tong_tien_so_lan_orders();
        }
    }
}
