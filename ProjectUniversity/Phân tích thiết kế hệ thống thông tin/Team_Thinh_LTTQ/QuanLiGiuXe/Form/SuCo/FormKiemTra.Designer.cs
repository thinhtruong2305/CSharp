
namespace QuanLiGiuXe
{
    partial class FormKiemTra
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
            this.labelSoXeRa = new System.Windows.Forms.Label();
            this.labelSoXeVao = new System.Windows.Forms.Label();
            this.groupBoxTimKiem = new System.Windows.Forms.GroupBox();
            this.groupBoxLuaChonTimKiem = new System.Windows.Forms.GroupBox();
            this.radioButtonTheoNgay = new System.Windows.Forms.RadioButton();
            this.radioButtonTimBienSoVaBaiDo = new System.Windows.Forms.RadioButton();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.dateTimePickerNgayRa = new System.Windows.Forms.DateTimePicker();
            this.labelNgayRa = new System.Windows.Forms.Label();
            this.dateTimePickerNgayVao = new System.Windows.Forms.DateTimePicker();
            this.labelNgayVao = new System.Windows.Forms.Label();
            this.textBoxBaiDo = new System.Windows.Forms.TextBox();
            this.labelBaiDo = new System.Windows.Forms.Label();
            this.textBoxBienSoXe = new System.Windows.Forms.TextBox();
            this.labelBienSoXe = new System.Windows.Forms.Label();
            this.dataGridViewSoXeRa = new System.Windows.Forms.DataGridView();
            this.dataGridViewSoXeVao = new System.Windows.Forms.DataGridView();
            this.groupBoxTimKiem.SuspendLayout();
            this.groupBoxLuaChonTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoXeRa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoXeVao)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSoXeRa
            // 
            this.labelSoXeRa.AutoSize = true;
            this.labelSoXeRa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoXeRa.Location = new System.Drawing.Point(454, 169);
            this.labelSoXeRa.Name = "labelSoXeRa";
            this.labelSoXeRa.Size = new System.Drawing.Size(60, 17);
            this.labelSoXeRa.TabIndex = 10;
            this.labelSoXeRa.Text = "Sổ xe ra";
            // 
            // labelSoXeVao
            // 
            this.labelSoXeVao.AutoSize = true;
            this.labelSoXeVao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoXeVao.Location = new System.Drawing.Point(8, 169);
            this.labelSoXeVao.Name = "labelSoXeVao";
            this.labelSoXeVao.Size = new System.Drawing.Size(70, 17);
            this.labelSoXeVao.TabIndex = 9;
            this.labelSoXeVao.Text = "Sổ xe vào";
            // 
            // groupBoxTimKiem
            // 
            this.groupBoxTimKiem.Controls.Add(this.groupBoxLuaChonTimKiem);
            this.groupBoxTimKiem.Controls.Add(this.buttonTimKiem);
            this.groupBoxTimKiem.Controls.Add(this.dateTimePickerNgayRa);
            this.groupBoxTimKiem.Controls.Add(this.labelNgayRa);
            this.groupBoxTimKiem.Controls.Add(this.dateTimePickerNgayVao);
            this.groupBoxTimKiem.Controls.Add(this.labelNgayVao);
            this.groupBoxTimKiem.Controls.Add(this.textBoxBaiDo);
            this.groupBoxTimKiem.Controls.Add(this.labelBaiDo);
            this.groupBoxTimKiem.Controls.Add(this.textBoxBienSoXe);
            this.groupBoxTimKiem.Controls.Add(this.labelBienSoXe);
            this.groupBoxTimKiem.Location = new System.Drawing.Point(11, 8);
            this.groupBoxTimKiem.Name = "groupBoxTimKiem";
            this.groupBoxTimKiem.Size = new System.Drawing.Size(811, 154);
            this.groupBoxTimKiem.TabIndex = 8;
            this.groupBoxTimKiem.TabStop = false;
            this.groupBoxTimKiem.Text = "Tìm kiếm";
            // 
            // groupBoxLuaChonTimKiem
            // 
            this.groupBoxLuaChonTimKiem.Controls.Add(this.radioButtonTheoNgay);
            this.groupBoxLuaChonTimKiem.Controls.Add(this.radioButtonTimBienSoVaBaiDo);
            this.groupBoxLuaChonTimKiem.Location = new System.Drawing.Point(546, 26);
            this.groupBoxLuaChonTimKiem.Name = "groupBoxLuaChonTimKiem";
            this.groupBoxLuaChonTimKiem.Size = new System.Drawing.Size(245, 55);
            this.groupBoxLuaChonTimKiem.TabIndex = 9;
            this.groupBoxLuaChonTimKiem.TabStop = false;
            this.groupBoxLuaChonTimKiem.Text = "Lựa chọn tìm kiếm";
            // 
            // radioButtonTheoNgay
            // 
            this.radioButtonTheoNgay.AutoSize = true;
            this.radioButtonTheoNgay.Location = new System.Drawing.Point(144, 32);
            this.radioButtonTheoNgay.Name = "radioButtonTheoNgay";
            this.radioButtonTheoNgay.Size = new System.Drawing.Size(92, 17);
            this.radioButtonTheoNgay.TabIndex = 1;
            this.radioButtonTheoNgay.TabStop = true;
            this.radioButtonTheoNgay.Text = "Tìm theo ngày";
            this.radioButtonTheoNgay.UseVisualStyleBackColor = true;
            this.radioButtonTheoNgay.CheckedChanged += new System.EventHandler(this.radioButtonTheoNgay_CheckedChanged);
            // 
            // radioButtonTimBienSoVaBaiDo
            // 
            this.radioButtonTimBienSoVaBaiDo.AutoSize = true;
            this.radioButtonTimBienSoVaBaiDo.Location = new System.Drawing.Point(7, 32);
            this.radioButtonTimBienSoVaBaiDo.Name = "radioButtonTimBienSoVaBaiDo";
            this.radioButtonTimBienSoVaBaiDo.Size = new System.Drawing.Size(127, 17);
            this.radioButtonTimBienSoVaBaiDo.TabIndex = 0;
            this.radioButtonTimBienSoVaBaiDo.TabStop = true;
            this.radioButtonTimBienSoVaBaiDo.Text = "Tìm biển số và bãi đổ";
            this.radioButtonTimBienSoVaBaiDo.UseVisualStyleBackColor = true;
            this.radioButtonTimBienSoVaBaiDo.CheckedChanged += new System.EventHandler(this.radioButtonTimBienSoVaBaiDo_CheckedChanged);
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimKiem.Location = new System.Drawing.Point(615, 115);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(108, 33);
            this.buttonTimKiem.TabIndex = 8;
            this.buttonTimKiem.Text = "Tìm kiếm";
            this.buttonTimKiem.UseVisualStyleBackColor = true;
            this.buttonTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
            // 
            // dateTimePickerNgayRa
            // 
            this.dateTimePickerNgayRa.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dateTimePickerNgayRa.Enabled = false;
            this.dateTimePickerNgayRa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgayRa.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgayRa.Location = new System.Drawing.Point(308, 65);
            this.dateTimePickerNgayRa.Name = "dateTimePickerNgayRa";
            this.dateTimePickerNgayRa.Size = new System.Drawing.Size(139, 23);
            this.dateTimePickerNgayRa.TabIndex = 7;
            // 
            // labelNgayRa
            // 
            this.labelNgayRa.AutoSize = true;
            this.labelNgayRa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgayRa.Location = new System.Drawing.Point(240, 69);
            this.labelNgayRa.Name = "labelNgayRa";
            this.labelNgayRa.Size = new System.Drawing.Size(62, 17);
            this.labelNgayRa.TabIndex = 6;
            this.labelNgayRa.Text = "Ngày ra:";
            // 
            // dateTimePickerNgayVao
            // 
            this.dateTimePickerNgayVao.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dateTimePickerNgayVao.Enabled = false;
            this.dateTimePickerNgayVao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgayVao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgayVao.Location = new System.Drawing.Point(308, 26);
            this.dateTimePickerNgayVao.Name = "dateTimePickerNgayVao";
            this.dateTimePickerNgayVao.Size = new System.Drawing.Size(139, 23);
            this.dateTimePickerNgayVao.TabIndex = 5;
            // 
            // labelNgayVao
            // 
            this.labelNgayVao.AutoSize = true;
            this.labelNgayVao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgayVao.Location = new System.Drawing.Point(230, 30);
            this.labelNgayVao.Name = "labelNgayVao";
            this.labelNgayVao.Size = new System.Drawing.Size(72, 17);
            this.labelNgayVao.TabIndex = 4;
            this.labelNgayVao.Text = "Ngày vào:";
            // 
            // textBoxBaiDo
            // 
            this.textBoxBaiDo.Enabled = false;
            this.textBoxBaiDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBaiDo.Location = new System.Drawing.Point(91, 67);
            this.textBoxBaiDo.Name = "textBoxBaiDo";
            this.textBoxBaiDo.Size = new System.Drawing.Size(119, 23);
            this.textBoxBaiDo.TabIndex = 3;
            // 
            // labelBaiDo
            // 
            this.labelBaiDo.AutoSize = true;
            this.labelBaiDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaiDo.Location = new System.Drawing.Point(45, 69);
            this.labelBaiDo.Name = "labelBaiDo";
            this.labelBaiDo.Size = new System.Drawing.Size(40, 17);
            this.labelBaiDo.TabIndex = 2;
            this.labelBaiDo.Text = "Vị trí:";
            // 
            // textBoxBienSoXe
            // 
            this.textBoxBienSoXe.Enabled = false;
            this.textBoxBienSoXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBienSoXe.Location = new System.Drawing.Point(91, 26);
            this.textBoxBienSoXe.Name = "textBoxBienSoXe";
            this.textBoxBienSoXe.Size = new System.Drawing.Size(119, 23);
            this.textBoxBienSoXe.TabIndex = 1;
            // 
            // labelBienSoXe
            // 
            this.labelBienSoXe.AutoSize = true;
            this.labelBienSoXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienSoXe.Location = new System.Drawing.Point(9, 30);
            this.labelBienSoXe.Name = "labelBienSoXe";
            this.labelBienSoXe.Size = new System.Drawing.Size(77, 17);
            this.labelBienSoXe.TabIndex = 0;
            this.labelBienSoXe.Text = "Biển số xe:";
            // 
            // dataGridViewSoXeRa
            // 
            this.dataGridViewSoXeRa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSoXeRa.Location = new System.Drawing.Point(457, 195);
            this.dataGridViewSoXeRa.Name = "dataGridViewSoXeRa";
            this.dataGridViewSoXeRa.Size = new System.Drawing.Size(365, 229);
            this.dataGridViewSoXeRa.TabIndex = 7;
            // 
            // dataGridViewSoXeVao
            // 
            this.dataGridViewSoXeVao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSoXeVao.Location = new System.Drawing.Point(11, 195);
            this.dataGridViewSoXeVao.Name = "dataGridViewSoXeVao";
            this.dataGridViewSoXeVao.Size = new System.Drawing.Size(370, 229);
            this.dataGridViewSoXeVao.TabIndex = 6;
            // 
            // FormKiemTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 429);
            this.Controls.Add(this.labelSoXeRa);
            this.Controls.Add(this.labelSoXeVao);
            this.Controls.Add(this.groupBoxTimKiem);
            this.Controls.Add(this.dataGridViewSoXeRa);
            this.Controls.Add(this.dataGridViewSoXeVao);
            this.MaximumSize = new System.Drawing.Size(873, 468);
            this.MinimumSize = new System.Drawing.Size(873, 468);
            this.Name = "FormKiemTra";
            this.Text = "FormKiemTra";
            this.Load += new System.EventHandler(this.FormKiemTra_Load);
            this.groupBoxTimKiem.ResumeLayout(false);
            this.groupBoxTimKiem.PerformLayout();
            this.groupBoxLuaChonTimKiem.ResumeLayout(false);
            this.groupBoxLuaChonTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoXeRa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoXeVao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSoXeRa;
        private System.Windows.Forms.Label labelSoXeVao;
        private System.Windows.Forms.GroupBox groupBoxTimKiem;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayRa;
        private System.Windows.Forms.Label labelNgayRa;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayVao;
        private System.Windows.Forms.Label labelNgayVao;
        private System.Windows.Forms.TextBox textBoxBaiDo;
        private System.Windows.Forms.Label labelBaiDo;
        private System.Windows.Forms.TextBox textBoxBienSoXe;
        private System.Windows.Forms.Label labelBienSoXe;
        private System.Windows.Forms.DataGridView dataGridViewSoXeRa;
        private System.Windows.Forms.DataGridView dataGridViewSoXeVao;
        private System.Windows.Forms.GroupBox groupBoxLuaChonTimKiem;
        private System.Windows.Forms.RadioButton radioButtonTheoNgay;
        private System.Windows.Forms.RadioButton radioButtonTimBienSoVaBaiDo;
    }
}