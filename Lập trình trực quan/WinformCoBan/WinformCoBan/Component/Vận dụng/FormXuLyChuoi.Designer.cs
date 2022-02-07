
namespace WinformCoBan
{
    partial class FormXuLyChuoi
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.buttonDemSoKyTuTrongChuoi = new System.Windows.Forms.Button();
            this.buttonChuyenThuongThanhHoa = new System.Windows.Forms.Button();
            this.buttonChuyenHoaThanhThuong = new System.Windows.Forms.Button();
            this.buttonDemKyTuInThuong = new System.Windows.Forms.Button();
            this.buttonDemKyTuInHoa = new System.Windows.Forms.Button();
            this.buttonDemKyTuSo = new System.Windows.Forms.Button();
            this.buttonDaoNguocChuoi = new System.Windows.Forms.Button();
            this.buttonViTriXuatHienDauTien = new System.Windows.Forms.Button();
            this.buttonViTriXuatHienCuoiCung = new System.Windows.Forms.Button();
            this.buttonSoLanXuatHien = new System.Windows.Forms.Button();
            this.buttonChenChuoi = new System.Windows.Forms.Button();
            this.labelViTri = new System.Windows.Forms.Label();
            this.textBoxViTriXuatHienDauTien = new System.Windows.Forms.TextBox();
            this.textBoxViTriXuatHienCuoiCung = new System.Windows.Forms.TextBox();
            this.textBoxSoLanXuatHien = new System.Windows.Forms.TextBox();
            this.textBoxChenChuoi = new System.Windows.Forms.TextBox();
            this.numericUpDownViTri = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownViTri)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonDemKyTuSo);
            this.splitContainer1.Panel1.Controls.Add(this.buttonDemKyTuInHoa);
            this.splitContainer1.Panel1.Controls.Add(this.buttonDemKyTuInThuong);
            this.splitContainer1.Panel1.Controls.Add(this.buttonChuyenHoaThanhThuong);
            this.splitContainer1.Panel1.Controls.Add(this.buttonChuyenThuongThanhHoa);
            this.splitContainer1.Panel1.Controls.Add(this.buttonDemSoKyTuTrongChuoi);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.numericUpDownViTri);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxChenChuoi);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxSoLanXuatHien);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxViTriXuatHienCuoiCung);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxViTriXuatHienDauTien);
            this.splitContainer1.Panel2.Controls.Add(this.labelViTri);
            this.splitContainer1.Panel2.Controls.Add(this.buttonChenChuoi);
            this.splitContainer1.Panel2.Controls.Add(this.buttonSoLanXuatHien);
            this.splitContainer1.Panel2.Controls.Add(this.buttonViTriXuatHienCuoiCung);
            this.splitContainer1.Panel2.Controls.Add(this.buttonViTriXuatHienDauTien);
            this.splitContainer1.Panel2.Controls.Add(this.buttonDaoNguocChuoi);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(837, 564);
            this.splitContainer1.SplitterDistance = 429;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxInput);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(429, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxOutput);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(403, 123);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInput.Location = new System.Drawing.Point(3, 21);
            this.textBoxInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(423, 98);
            this.textBoxInput.TabIndex = 0;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutput.Location = new System.Drawing.Point(3, 21);
            this.textBoxOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(397, 98);
            this.textBoxOutput.TabIndex = 1;
            // 
            // buttonDemSoKyTuTrongChuoi
            // 
            this.buttonDemSoKyTuTrongChuoi.Location = new System.Drawing.Point(65, 164);
            this.buttonDemSoKyTuTrongChuoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDemSoKyTuTrongChuoi.Name = "buttonDemSoKyTuTrongChuoi";
            this.buttonDemSoKyTuTrongChuoi.Size = new System.Drawing.Size(338, 28);
            this.buttonDemSoKyTuTrongChuoi.TabIndex = 1;
            this.buttonDemSoKyTuTrongChuoi.Text = "Đếm số ký tự trong chuỗi";
            this.buttonDemSoKyTuTrongChuoi.UseVisualStyleBackColor = true;
            this.buttonDemSoKyTuTrongChuoi.Click += new System.EventHandler(this.buttonDemSoKyTuTrongChuoi_Click);
            // 
            // buttonChuyenThuongThanhHoa
            // 
            this.buttonChuyenThuongThanhHoa.Location = new System.Drawing.Point(65, 231);
            this.buttonChuyenThuongThanhHoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonChuyenThuongThanhHoa.Name = "buttonChuyenThuongThanhHoa";
            this.buttonChuyenThuongThanhHoa.Size = new System.Drawing.Size(338, 28);
            this.buttonChuyenThuongThanhHoa.TabIndex = 2;
            this.buttonChuyenThuongThanhHoa.Text = "Chuyển chuỗi thường thành hoa";
            this.buttonChuyenThuongThanhHoa.UseVisualStyleBackColor = true;
            this.buttonChuyenThuongThanhHoa.Click += new System.EventHandler(this.buttonChuyenThuongThanhHoa_Click);
            // 
            // buttonChuyenHoaThanhThuong
            // 
            this.buttonChuyenHoaThanhThuong.Location = new System.Drawing.Point(65, 302);
            this.buttonChuyenHoaThanhThuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonChuyenHoaThanhThuong.Name = "buttonChuyenHoaThanhThuong";
            this.buttonChuyenHoaThanhThuong.Size = new System.Drawing.Size(338, 28);
            this.buttonChuyenHoaThanhThuong.TabIndex = 3;
            this.buttonChuyenHoaThanhThuong.Text = "Chuyển chuỗi hoa thành thường";
            this.buttonChuyenHoaThanhThuong.UseVisualStyleBackColor = true;
            this.buttonChuyenHoaThanhThuong.Click += new System.EventHandler(this.buttonChuyenHoaThanhThuong_Click);
            // 
            // buttonDemKyTuInThuong
            // 
            this.buttonDemKyTuInThuong.Location = new System.Drawing.Point(65, 374);
            this.buttonDemKyTuInThuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDemKyTuInThuong.Name = "buttonDemKyTuInThuong";
            this.buttonDemKyTuInThuong.Size = new System.Drawing.Size(338, 28);
            this.buttonDemKyTuInThuong.TabIndex = 4;
            this.buttonDemKyTuInThuong.Text = "Đếm ký tự in thường";
            this.buttonDemKyTuInThuong.UseVisualStyleBackColor = true;
            this.buttonDemKyTuInThuong.Click += new System.EventHandler(this.buttonDemKyTuInThuong_Click);
            // 
            // buttonDemKyTuInHoa
            // 
            this.buttonDemKyTuInHoa.Location = new System.Drawing.Point(65, 450);
            this.buttonDemKyTuInHoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDemKyTuInHoa.Name = "buttonDemKyTuInHoa";
            this.buttonDemKyTuInHoa.Size = new System.Drawing.Size(338, 28);
            this.buttonDemKyTuInHoa.TabIndex = 5;
            this.buttonDemKyTuInHoa.Text = "Đếm ký tự in hoa";
            this.buttonDemKyTuInHoa.UseVisualStyleBackColor = true;
            this.buttonDemKyTuInHoa.Click += new System.EventHandler(this.buttonDemKyTuInHoa_Click);
            // 
            // buttonDemKyTuSo
            // 
            this.buttonDemKyTuSo.Location = new System.Drawing.Point(65, 519);
            this.buttonDemKyTuSo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDemKyTuSo.Name = "buttonDemKyTuSo";
            this.buttonDemKyTuSo.Size = new System.Drawing.Size(338, 28);
            this.buttonDemKyTuSo.TabIndex = 6;
            this.buttonDemKyTuSo.Text = "Đếm ký tự số";
            this.buttonDemKyTuSo.UseVisualStyleBackColor = true;
            this.buttonDemKyTuSo.Click += new System.EventHandler(this.buttonDemKyTuSo_Click);
            // 
            // buttonDaoNguocChuoi
            // 
            this.buttonDaoNguocChuoi.Location = new System.Drawing.Point(37, 164);
            this.buttonDaoNguocChuoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDaoNguocChuoi.Name = "buttonDaoNguocChuoi";
            this.buttonDaoNguocChuoi.Size = new System.Drawing.Size(338, 28);
            this.buttonDaoNguocChuoi.TabIndex = 7;
            this.buttonDaoNguocChuoi.Text = "Đảo ngược chuỗi";
            this.buttonDaoNguocChuoi.UseVisualStyleBackColor = true;
            this.buttonDaoNguocChuoi.Click += new System.EventHandler(this.buttonDaoNguocChuoi_Click);
            // 
            // buttonViTriXuatHienDauTien
            // 
            this.buttonViTriXuatHienDauTien.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViTriXuatHienDauTien.Location = new System.Drawing.Point(16, 231);
            this.buttonViTriXuatHienDauTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonViTriXuatHienDauTien.Name = "buttonViTriXuatHienDauTien";
            this.buttonViTriXuatHienDauTien.Size = new System.Drawing.Size(158, 28);
            this.buttonViTriXuatHienDauTien.TabIndex = 8;
            this.buttonViTriXuatHienDauTien.Text = "Vị trí xuất hiện đầu tiên";
            this.buttonViTriXuatHienDauTien.UseVisualStyleBackColor = true;
            this.buttonViTriXuatHienDauTien.Click += new System.EventHandler(this.buttonViTriXuatHienDauTien_Click);
            // 
            // buttonViTriXuatHienCuoiCung
            // 
            this.buttonViTriXuatHienCuoiCung.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViTriXuatHienCuoiCung.Location = new System.Drawing.Point(16, 302);
            this.buttonViTriXuatHienCuoiCung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonViTriXuatHienCuoiCung.Name = "buttonViTriXuatHienCuoiCung";
            this.buttonViTriXuatHienCuoiCung.Size = new System.Drawing.Size(158, 28);
            this.buttonViTriXuatHienCuoiCung.TabIndex = 9;
            this.buttonViTriXuatHienCuoiCung.Text = "Vị trí xuất hiện cuối cùng";
            this.buttonViTriXuatHienCuoiCung.UseVisualStyleBackColor = true;
            this.buttonViTriXuatHienCuoiCung.Click += new System.EventHandler(this.buttonViTriXuatHienCuoiCung_Click);
            // 
            // buttonSoLanXuatHien
            // 
            this.buttonSoLanXuatHien.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSoLanXuatHien.Location = new System.Drawing.Point(16, 374);
            this.buttonSoLanXuatHien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSoLanXuatHien.Name = "buttonSoLanXuatHien";
            this.buttonSoLanXuatHien.Size = new System.Drawing.Size(158, 28);
            this.buttonSoLanXuatHien.TabIndex = 10;
            this.buttonSoLanXuatHien.Text = "Số lần xuất hiện";
            this.buttonSoLanXuatHien.UseVisualStyleBackColor = true;
            this.buttonSoLanXuatHien.Click += new System.EventHandler(this.buttonSoLanXuatHien_Click);
            // 
            // buttonChenChuoi
            // 
            this.buttonChenChuoi.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChenChuoi.Location = new System.Drawing.Point(16, 450);
            this.buttonChenChuoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonChenChuoi.Name = "buttonChenChuoi";
            this.buttonChenChuoi.Size = new System.Drawing.Size(158, 28);
            this.buttonChenChuoi.TabIndex = 11;
            this.buttonChenChuoi.Text = "Chèn chuỗi";
            this.buttonChenChuoi.UseVisualStyleBackColor = true;
            this.buttonChenChuoi.Click += new System.EventHandler(this.buttonChenChuoi_Click);
            // 
            // labelViTri
            // 
            this.labelViTri.AutoSize = true;
            this.labelViTri.Location = new System.Drawing.Point(103, 508);
            this.labelViTri.Name = "labelViTri";
            this.labelViTri.Size = new System.Drawing.Size(34, 17);
            this.labelViTri.TabIndex = 12;
            this.labelViTri.Text = "Vị trí";
            // 
            // textBoxViTriXuatHienDauTien
            // 
            this.textBoxViTriXuatHienDauTien.Location = new System.Drawing.Point(221, 234);
            this.textBoxViTriXuatHienDauTien.Name = "textBoxViTriXuatHienDauTien";
            this.textBoxViTriXuatHienDauTien.Size = new System.Drawing.Size(154, 24);
            this.textBoxViTriXuatHienDauTien.TabIndex = 13;
            // 
            // textBoxViTriXuatHienCuoiCung
            // 
            this.textBoxViTriXuatHienCuoiCung.Location = new System.Drawing.Point(221, 305);
            this.textBoxViTriXuatHienCuoiCung.Name = "textBoxViTriXuatHienCuoiCung";
            this.textBoxViTriXuatHienCuoiCung.Size = new System.Drawing.Size(154, 24);
            this.textBoxViTriXuatHienCuoiCung.TabIndex = 14;
            // 
            // textBoxSoLanXuatHien
            // 
            this.textBoxSoLanXuatHien.Location = new System.Drawing.Point(221, 377);
            this.textBoxSoLanXuatHien.Name = "textBoxSoLanXuatHien";
            this.textBoxSoLanXuatHien.Size = new System.Drawing.Size(154, 24);
            this.textBoxSoLanXuatHien.TabIndex = 15;
            // 
            // textBoxChenChuoi
            // 
            this.textBoxChenChuoi.Location = new System.Drawing.Point(221, 453);
            this.textBoxChenChuoi.Name = "textBoxChenChuoi";
            this.textBoxChenChuoi.Size = new System.Drawing.Size(154, 24);
            this.textBoxChenChuoi.TabIndex = 16;
            // 
            // numericUpDownViTri
            // 
            this.numericUpDownViTri.Location = new System.Drawing.Point(221, 508);
            this.numericUpDownViTri.Name = "numericUpDownViTri";
            this.numericUpDownViTri.Size = new System.Drawing.Size(120, 24);
            this.numericUpDownViTri.TabIndex = 17;
            // 
            // FormXuLyChuoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 564);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormXuLyChuoi";
            this.Text = "FormXuLyChuoi";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownViTri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonDemKyTuSo;
        private System.Windows.Forms.Button buttonDemKyTuInHoa;
        private System.Windows.Forms.Button buttonDemKyTuInThuong;
        private System.Windows.Forms.Button buttonChuyenHoaThanhThuong;
        private System.Windows.Forms.Button buttonChuyenThuongThanhHoa;
        private System.Windows.Forms.Button buttonDemSoKyTuTrongChuoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.NumericUpDown numericUpDownViTri;
        private System.Windows.Forms.TextBox textBoxChenChuoi;
        private System.Windows.Forms.TextBox textBoxSoLanXuatHien;
        private System.Windows.Forms.TextBox textBoxViTriXuatHienCuoiCung;
        private System.Windows.Forms.TextBox textBoxViTriXuatHienDauTien;
        private System.Windows.Forms.Label labelViTri;
        private System.Windows.Forms.Button buttonChenChuoi;
        private System.Windows.Forms.Button buttonSoLanXuatHien;
        private System.Windows.Forms.Button buttonViTriXuatHienCuoiCung;
        private System.Windows.Forms.Button buttonViTriXuatHienDauTien;
        private System.Windows.Forms.Button buttonDaoNguocChuoi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxOutput;
    }
}