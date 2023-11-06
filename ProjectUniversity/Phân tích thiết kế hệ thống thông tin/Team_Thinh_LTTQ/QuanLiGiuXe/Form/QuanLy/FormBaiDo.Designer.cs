
namespace QuanLiGiuXe
{
    partial class FormBaiDo
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
            this.dgvViTri = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbKhuVuc = new System.Windows.Forms.ComboBox();
            this.labelTrangThaiViTri = new System.Windows.Forms.Label();
            this.btnSuaViTri = new System.Windows.Forms.Button();
            this.btnXoaViTri = new System.Windows.Forms.Button();
            this.btnThemViTri = new System.Windows.Forms.Button();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.labelKhuVuc = new System.Windows.Forms.Label();
            this.txtTenViTri = new System.Windows.Forms.TextBox();
            this.labelTenViTri = new System.Windows.Forms.Label();
            this.txtMaViTri = new System.Windows.Forms.TextBox();
            this.labelMaViTri = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxLoaiXe = new System.Windows.Forms.ComboBox();
            this.buttonSuaKhuVuc = new System.Windows.Forms.Button();
            this.buttonXoaKhuVuc = new System.Windows.Forms.Button();
            this.buttonThemKhuVuc = new System.Windows.Forms.Button();
            this.labelTrangThaiKhuVuc = new System.Windows.Forms.Label();
            this.txtTenKhuVuc = new System.Windows.Forms.TextBox();
            this.labelTenKhuVuc = new System.Windows.Forms.Label();
            this.txtMaKhuVuc = new System.Windows.Forms.TextBox();
            this.labelMaKhuVuc = new System.Windows.Forms.Label();
            this.dataGridViewKhuVuc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViTri)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhuVuc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViTri
            // 
            this.dgvViTri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViTri.Location = new System.Drawing.Point(9, 204);
            this.dgvViTri.Margin = new System.Windows.Forms.Padding(2);
            this.dgvViTri.Name = "dgvViTri";
            this.dgvViTri.RowHeadersWidth = 51;
            this.dgvViTri.RowTemplate.Height = 24;
            this.dgvViTri.Size = new System.Drawing.Size(405, 201);
            this.dgvViTri.TabIndex = 3;
            this.dgvViTri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViTri_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbKhuVuc);
            this.groupBox1.Controls.Add(this.labelTrangThaiViTri);
            this.groupBox1.Controls.Add(this.btnSuaViTri);
            this.groupBox1.Controls.Add(this.btnXoaViTri);
            this.groupBox1.Controls.Add(this.btnThemViTri);
            this.groupBox1.Controls.Add(this.txtTrangThai);
            this.groupBox1.Controls.Add(this.labelKhuVuc);
            this.groupBox1.Controls.Add(this.txtTenViTri);
            this.groupBox1.Controls.Add(this.labelTenViTri);
            this.groupBox1.Controls.Add(this.txtMaViTri);
            this.groupBox1.Controls.Add(this.labelMaViTri);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(405, 154);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin vị trí";
            // 
            // cbbKhuVuc
            // 
            this.cbbKhuVuc.FormattingEnabled = true;
            this.cbbKhuVuc.Location = new System.Drawing.Point(294, 30);
            this.cbbKhuVuc.Margin = new System.Windows.Forms.Padding(2);
            this.cbbKhuVuc.Name = "cbbKhuVuc";
            this.cbbKhuVuc.Size = new System.Drawing.Size(94, 21);
            this.cbbKhuVuc.TabIndex = 31;
            // 
            // labelTrangThaiViTri
            // 
            this.labelTrangThaiViTri.AutoSize = true;
            this.labelTrangThaiViTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrangThaiViTri.Location = new System.Drawing.Point(212, 63);
            this.labelTrangThaiViTri.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTrangThaiViTri.Name = "labelTrangThaiViTri";
            this.labelTrangThaiViTri.Size = new System.Drawing.Size(78, 17);
            this.labelTrangThaiViTri.TabIndex = 30;
            this.labelTrangThaiViTri.Text = "Trạng Thái";
            // 
            // btnSuaViTri
            // 
            this.btnSuaViTri.Location = new System.Drawing.Point(307, 109);
            this.btnSuaViTri.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaViTri.Name = "btnSuaViTri";
            this.btnSuaViTri.Size = new System.Drawing.Size(63, 31);
            this.btnSuaViTri.TabIndex = 29;
            this.btnSuaViTri.Text = "Sửa";
            this.btnSuaViTri.UseVisualStyleBackColor = true;
            this.btnSuaViTri.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoaViTri
            // 
            this.btnXoaViTri.Location = new System.Drawing.Point(184, 109);
            this.btnXoaViTri.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaViTri.Name = "btnXoaViTri";
            this.btnXoaViTri.Size = new System.Drawing.Size(58, 31);
            this.btnXoaViTri.TabIndex = 28;
            this.btnXoaViTri.Text = "Xóa";
            this.btnXoaViTri.UseVisualStyleBackColor = true;
            this.btnXoaViTri.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThemViTri
            // 
            this.btnThemViTri.Location = new System.Drawing.Point(55, 109);
            this.btnThemViTri.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemViTri.Name = "btnThemViTri";
            this.btnThemViTri.Size = new System.Drawing.Size(61, 31);
            this.btnThemViTri.TabIndex = 27;
            this.btnThemViTri.Text = "Thêm";
            this.btnThemViTri.UseVisualStyleBackColor = true;
            this.btnThemViTri.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Enabled = false;
            this.txtTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrangThai.Location = new System.Drawing.Point(294, 61);
            this.txtTrangThai.Margin = new System.Windows.Forms.Padding(2);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(94, 23);
            this.txtTrangThai.TabIndex = 26;
            // 
            // labelKhuVuc
            // 
            this.labelKhuVuc.AutoSize = true;
            this.labelKhuVuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKhuVuc.Location = new System.Drawing.Point(212, 32);
            this.labelKhuVuc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelKhuVuc.Name = "labelKhuVuc";
            this.labelKhuVuc.Size = new System.Drawing.Size(59, 17);
            this.labelKhuVuc.TabIndex = 25;
            this.labelKhuVuc.Text = "Khu vực";
            // 
            // txtTenViTri
            // 
            this.txtTenViTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenViTri.Location = new System.Drawing.Point(86, 60);
            this.txtTenViTri.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenViTri.Name = "txtTenViTri";
            this.txtTenViTri.Size = new System.Drawing.Size(94, 23);
            this.txtTenViTri.TabIndex = 24;
            // 
            // labelTenViTri
            // 
            this.labelTenViTri.AutoSize = true;
            this.labelTenViTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenViTri.Location = new System.Drawing.Point(12, 63);
            this.labelTenViTri.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTenViTri.Name = "labelTenViTri";
            this.labelTenViTri.Size = new System.Drawing.Size(70, 17);
            this.labelTenViTri.TabIndex = 23;
            this.labelTenViTri.Text = "Tên Vị Trí";
            // 
            // txtMaViTri
            // 
            this.txtMaViTri.Enabled = false;
            this.txtMaViTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaViTri.Location = new System.Drawing.Point(86, 28);
            this.txtMaViTri.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaViTri.Name = "txtMaViTri";
            this.txtMaViTri.Size = new System.Drawing.Size(94, 23);
            this.txtMaViTri.TabIndex = 22;
            // 
            // labelMaViTri
            // 
            this.labelMaViTri.AutoSize = true;
            this.labelMaViTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaViTri.Location = new System.Drawing.Point(12, 32);
            this.labelMaViTri.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaViTri.Name = "labelMaViTri";
            this.labelMaViTri.Size = new System.Drawing.Size(64, 17);
            this.labelMaViTri.TabIndex = 21;
            this.labelMaViTri.Text = "Mã Vị Trí";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxLoaiXe);
            this.groupBox2.Controls.Add(this.buttonSuaKhuVuc);
            this.groupBox2.Controls.Add(this.buttonXoaKhuVuc);
            this.groupBox2.Controls.Add(this.buttonThemKhuVuc);
            this.groupBox2.Controls.Add(this.labelTrangThaiKhuVuc);
            this.groupBox2.Controls.Add(this.txtTenKhuVuc);
            this.groupBox2.Controls.Add(this.labelTenKhuVuc);
            this.groupBox2.Controls.Add(this.txtMaKhuVuc);
            this.groupBox2.Controls.Add(this.labelMaKhuVuc);
            this.groupBox2.Location = new System.Drawing.Point(418, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(428, 154);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Khu Vực";
            // 
            // comboBoxLoaiXe
            // 
            this.comboBoxLoaiXe.FormattingEnabled = true;
            this.comboBoxLoaiXe.Location = new System.Drawing.Point(289, 31);
            this.comboBoxLoaiXe.Name = "comboBoxLoaiXe";
            this.comboBoxLoaiXe.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLoaiXe.TabIndex = 30;
            // 
            // buttonSuaKhuVuc
            // 
            this.buttonSuaKhuVuc.Location = new System.Drawing.Point(328, 109);
            this.buttonSuaKhuVuc.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSuaKhuVuc.Name = "buttonSuaKhuVuc";
            this.buttonSuaKhuVuc.Size = new System.Drawing.Size(72, 31);
            this.buttonSuaKhuVuc.TabIndex = 29;
            this.buttonSuaKhuVuc.Text = "Sửa";
            this.buttonSuaKhuVuc.UseVisualStyleBackColor = true;
            this.buttonSuaKhuVuc.Click += new System.EventHandler(this.buttonSuaKhuVuc_Click);
            // 
            // buttonXoaKhuVuc
            // 
            this.buttonXoaKhuVuc.Location = new System.Drawing.Point(219, 109);
            this.buttonXoaKhuVuc.Margin = new System.Windows.Forms.Padding(2);
            this.buttonXoaKhuVuc.Name = "buttonXoaKhuVuc";
            this.buttonXoaKhuVuc.Size = new System.Drawing.Size(72, 31);
            this.buttonXoaKhuVuc.TabIndex = 28;
            this.buttonXoaKhuVuc.Text = "Xóa";
            this.buttonXoaKhuVuc.UseVisualStyleBackColor = true;
            this.buttonXoaKhuVuc.Click += new System.EventHandler(this.buttonXoaKhuVuc_Click);
            // 
            // buttonThemKhuVuc
            // 
            this.buttonThemKhuVuc.Location = new System.Drawing.Point(109, 109);
            this.buttonThemKhuVuc.Margin = new System.Windows.Forms.Padding(2);
            this.buttonThemKhuVuc.Name = "buttonThemKhuVuc";
            this.buttonThemKhuVuc.Size = new System.Drawing.Size(72, 31);
            this.buttonThemKhuVuc.TabIndex = 27;
            this.buttonThemKhuVuc.Text = "Thêm";
            this.buttonThemKhuVuc.UseVisualStyleBackColor = true;
            this.buttonThemKhuVuc.Click += new System.EventHandler(this.buttonThemKhuVuc_Click);
            // 
            // labelTrangThaiKhuVuc
            // 
            this.labelTrangThaiKhuVuc.AutoSize = true;
            this.labelTrangThaiKhuVuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrangThaiKhuVuc.Location = new System.Drawing.Point(231, 32);
            this.labelTrangThaiKhuVuc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTrangThaiKhuVuc.Name = "labelTrangThaiKhuVuc";
            this.labelTrangThaiKhuVuc.Size = new System.Drawing.Size(53, 17);
            this.labelTrangThaiKhuVuc.TabIndex = 25;
            this.labelTrangThaiKhuVuc.Text = "Loại xe";
            // 
            // txtTenKhuVuc
            // 
            this.txtTenKhuVuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhuVuc.Location = new System.Drawing.Point(109, 61);
            this.txtTenKhuVuc.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenKhuVuc.Name = "txtTenKhuVuc";
            this.txtTenKhuVuc.Size = new System.Drawing.Size(105, 23);
            this.txtTenKhuVuc.TabIndex = 24;
            // 
            // labelTenKhuVuc
            // 
            this.labelTenKhuVuc.AutoSize = true;
            this.labelTenKhuVuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenKhuVuc.Location = new System.Drawing.Point(12, 63);
            this.labelTenKhuVuc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTenKhuVuc.Name = "labelTenKhuVuc";
            this.labelTenKhuVuc.Size = new System.Drawing.Size(90, 17);
            this.labelTenKhuVuc.TabIndex = 23;
            this.labelTenKhuVuc.Text = "Tên Khu Vực";
            // 
            // txtMaKhuVuc
            // 
            this.txtMaKhuVuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhuVuc.Location = new System.Drawing.Point(109, 28);
            this.txtMaKhuVuc.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaKhuVuc.Name = "txtMaKhuVuc";
            this.txtMaKhuVuc.ReadOnly = true;
            this.txtMaKhuVuc.Size = new System.Drawing.Size(105, 23);
            this.txtMaKhuVuc.TabIndex = 22;
            // 
            // labelMaKhuVuc
            // 
            this.labelMaKhuVuc.AutoSize = true;
            this.labelMaKhuVuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaKhuVuc.Location = new System.Drawing.Point(12, 32);
            this.labelMaKhuVuc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaKhuVuc.Name = "labelMaKhuVuc";
            this.labelMaKhuVuc.Size = new System.Drawing.Size(84, 17);
            this.labelMaKhuVuc.TabIndex = 21;
            this.labelMaKhuVuc.Text = "Mã Khu Vực";
            // 
            // dataGridViewKhuVuc
            // 
            this.dataGridViewKhuVuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKhuVuc.Location = new System.Drawing.Point(418, 204);
            this.dataGridViewKhuVuc.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewKhuVuc.Name = "dataGridViewKhuVuc";
            this.dataGridViewKhuVuc.RowHeadersWidth = 51;
            this.dataGridViewKhuVuc.RowTemplate.Height = 24;
            this.dataGridViewKhuVuc.Size = new System.Drawing.Size(428, 201);
            this.dataGridViewKhuVuc.TabIndex = 5;
            this.dataGridViewKhuVuc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKhuVuc_CellClick);
            // 
            // FormBaiDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 429);
            this.Controls.Add(this.dataGridViewKhuVuc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvViTri);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(873, 468);
            this.MinimumSize = new System.Drawing.Size(873, 468);
            this.Name = "FormBaiDo";
            this.Text = "Bãi đổ";
            this.Load += new System.EventHandler(this.FormBaiDo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViTri)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhuVuc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViTri;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbKhuVuc;
        private System.Windows.Forms.Button btnSuaViTri;
        private System.Windows.Forms.Button btnXoaViTri;
        private System.Windows.Forms.Button btnThemViTri;
        private System.Windows.Forms.Label labelKhuVuc;
        private System.Windows.Forms.TextBox txtTenViTri;
        private System.Windows.Forms.Label labelTenViTri;
        private System.Windows.Forms.TextBox txtMaViTri;
        private System.Windows.Forms.Label labelMaViTri;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonSuaKhuVuc;
        private System.Windows.Forms.Button buttonXoaKhuVuc;
        private System.Windows.Forms.Button buttonThemKhuVuc;
        private System.Windows.Forms.Label labelTrangThaiKhuVuc;
        private System.Windows.Forms.TextBox txtTenKhuVuc;
        private System.Windows.Forms.Label labelTenKhuVuc;
        private System.Windows.Forms.TextBox txtMaKhuVuc;
        private System.Windows.Forms.Label labelMaKhuVuc;
        private System.Windows.Forms.DataGridView dataGridViewKhuVuc;
        private System.Windows.Forms.ComboBox comboBoxLoaiXe;
        private System.Windows.Forms.Label labelTrangThaiViTri;
        private System.Windows.Forms.TextBox txtTrangThai;
    }
}