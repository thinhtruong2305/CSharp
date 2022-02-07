
namespace WinformCoBan
{
    partial class FormDBHocSinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelTenHocSinh = new System.Windows.Forms.Label();
            this.labelDiemToan = new System.Windows.Forms.Label();
            this.labelDiemLy = new System.Windows.Forms.Label();
            this.labelDiemHoa = new System.Windows.Forms.Label();
            this.textBoxTenHocSinh = new System.Windows.Forms.TextBox();
            this.numericUpDownDiemToan = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDiemLy = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDiemHoa = new System.Windows.Forms.NumericUpDown();
            this.buttonThem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiemToan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiemLy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiemHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(58, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(680, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // labelTenHocSinh
            // 
            this.labelTenHocSinh.AutoSize = true;
            this.labelTenHocSinh.Location = new System.Drawing.Point(101, 38);
            this.labelTenHocSinh.Name = "labelTenHocSinh";
            this.labelTenHocSinh.Size = new System.Drawing.Size(69, 13);
            this.labelTenHocSinh.TabIndex = 1;
            this.labelTenHocSinh.Text = "Tên học sinh";
            // 
            // labelDiemToan
            // 
            this.labelDiemToan.AutoSize = true;
            this.labelDiemToan.Location = new System.Drawing.Point(101, 72);
            this.labelDiemToan.Name = "labelDiemToan";
            this.labelDiemToan.Size = new System.Drawing.Size(55, 13);
            this.labelDiemToan.TabIndex = 2;
            this.labelDiemToan.Text = "Điểm toán";
            // 
            // labelDiemLy
            // 
            this.labelDiemLy.AutoSize = true;
            this.labelDiemLy.Location = new System.Drawing.Point(101, 108);
            this.labelDiemLy.Name = "labelDiemLy";
            this.labelDiemLy.Size = new System.Drawing.Size(41, 13);
            this.labelDiemLy.TabIndex = 3;
            this.labelDiemLy.Text = "Điểm lý";
            // 
            // labelDiemHoa
            // 
            this.labelDiemHoa.AutoSize = true;
            this.labelDiemHoa.Location = new System.Drawing.Point(101, 146);
            this.labelDiemHoa.Name = "labelDiemHoa";
            this.labelDiemHoa.Size = new System.Drawing.Size(52, 13);
            this.labelDiemHoa.TabIndex = 4;
            this.labelDiemHoa.Text = "Điểm hóa";
            // 
            // textBoxTenHocSinh
            // 
            this.textBoxTenHocSinh.Location = new System.Drawing.Point(185, 35);
            this.textBoxTenHocSinh.Name = "textBoxTenHocSinh";
            this.textBoxTenHocSinh.Size = new System.Drawing.Size(193, 20);
            this.textBoxTenHocSinh.TabIndex = 5;
            // 
            // numericUpDownDiemToan
            // 
            this.numericUpDownDiemToan.Location = new System.Drawing.Point(185, 70);
            this.numericUpDownDiemToan.Name = "numericUpDownDiemToan";
            this.numericUpDownDiemToan.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownDiemToan.TabIndex = 6;
            // 
            // numericUpDownDiemLy
            // 
            this.numericUpDownDiemLy.Location = new System.Drawing.Point(185, 106);
            this.numericUpDownDiemLy.Name = "numericUpDownDiemLy";
            this.numericUpDownDiemLy.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownDiemLy.TabIndex = 7;
            // 
            // numericUpDownDiemHoa
            // 
            this.numericUpDownDiemHoa.Location = new System.Drawing.Point(185, 144);
            this.numericUpDownDiemHoa.Name = "numericUpDownDiemHoa";
            this.numericUpDownDiemHoa.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownDiemHoa.TabIndex = 8;
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(58, 185);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(75, 23);
            this.buttonThem.TabIndex = 9;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtTimKiem.Location = new System.Drawing.Point(104, 246);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(219, 20);
            this.txtTimKiem.TabIndex = 10;
            this.txtTimKiem.Text = "Tìm kiếm theo ID, Tên";
            // 
            // FormDBHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.numericUpDownDiemHoa);
            this.Controls.Add(this.numericUpDownDiemLy);
            this.Controls.Add(this.numericUpDownDiemToan);
            this.Controls.Add(this.textBoxTenHocSinh);
            this.Controls.Add(this.labelDiemHoa);
            this.Controls.Add(this.labelDiemLy);
            this.Controls.Add(this.labelDiemToan);
            this.Controls.Add(this.labelTenHocSinh);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormDBHocSinh";
            this.Text = "FormDBHocSinh";
            this.Load += new System.EventHandler(this.FormDBHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiemToan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiemLy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiemHoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelTenHocSinh;
        private System.Windows.Forms.Label labelDiemToan;
        private System.Windows.Forms.Label labelDiemLy;
        private System.Windows.Forms.Label labelDiemHoa;
        private System.Windows.Forms.TextBox textBoxTenHocSinh;
        private System.Windows.Forms.NumericUpDown numericUpDownDiemToan;
        private System.Windows.Forms.NumericUpDown numericUpDownDiemLy;
        private System.Windows.Forms.NumericUpDown numericUpDownDiemHoa;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.TextBox txtTimKiem;
    }
}