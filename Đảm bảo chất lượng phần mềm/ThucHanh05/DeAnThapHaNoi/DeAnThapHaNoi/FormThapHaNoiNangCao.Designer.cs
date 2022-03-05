
namespace DeAnThapHaNoi
{
    partial class FormThapHaNoiNangCao
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
            this.labelDoCaoThap = new System.Windows.Forms.Label();
            this.labelSoBuocToiDa = new System.Windows.Forms.Label();
            this.numericUpDownDoCaoThap = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSoBuocToiDa = new System.Windows.Forms.NumericUpDown();
            this.buttonXuatPhat = new System.Windows.Forms.Button();
            this.buttonThucHien = new System.Windows.Forms.Button();
            this.buttonDichDen = new System.Windows.Forms.Button();
            this.buttonDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDoCaoThap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoBuocToiDa)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDoCaoThap
            // 
            this.labelDoCaoThap.AutoSize = true;
            this.labelDoCaoThap.Location = new System.Drawing.Point(13, 29);
            this.labelDoCaoThap.Name = "labelDoCaoThap";
            this.labelDoCaoThap.Size = new System.Drawing.Size(69, 13);
            this.labelDoCaoThap.TabIndex = 0;
            this.labelDoCaoThap.Text = "Độ cao tháp:";
            // 
            // labelSoBuocToiDa
            // 
            this.labelSoBuocToiDa.AutoSize = true;
            this.labelSoBuocToiDa.Location = new System.Drawing.Point(260, 29);
            this.labelSoBuocToiDa.Name = "labelSoBuocToiDa";
            this.labelSoBuocToiDa.Size = new System.Drawing.Size(80, 13);
            this.labelSoBuocToiDa.TabIndex = 1;
            this.labelSoBuocToiDa.Text = "Số bước tối đa:";
            // 
            // numericUpDownDoCaoThap
            // 
            this.numericUpDownDoCaoThap.Location = new System.Drawing.Point(86, 26);
            this.numericUpDownDoCaoThap.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownDoCaoThap.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDoCaoThap.Name = "numericUpDownDoCaoThap";
            this.numericUpDownDoCaoThap.Size = new System.Drawing.Size(79, 20);
            this.numericUpDownDoCaoThap.TabIndex = 2;
            this.numericUpDownDoCaoThap.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownDoCaoThap.ValueChanged += new System.EventHandler(this.numericUpDownDoCaoThap_ValueChanged);
            // 
            // numericUpDownSoBuocToiDa
            // 
            this.numericUpDownSoBuocToiDa.Location = new System.Drawing.Point(349, 26);
            this.numericUpDownSoBuocToiDa.Maximum = new decimal(new int[] {
            4095,
            0,
            0,
            0});
            this.numericUpDownSoBuocToiDa.Name = "numericUpDownSoBuocToiDa";
            this.numericUpDownSoBuocToiDa.Size = new System.Drawing.Size(79, 20);
            this.numericUpDownSoBuocToiDa.TabIndex = 3;
            this.numericUpDownSoBuocToiDa.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            // 
            // buttonXuatPhat
            // 
            this.buttonXuatPhat.Location = new System.Drawing.Point(16, 86);
            this.buttonXuatPhat.Name = "buttonXuatPhat";
            this.buttonXuatPhat.Size = new System.Drawing.Size(75, 40);
            this.buttonXuatPhat.TabIndex = 4;
            this.buttonXuatPhat.Text = "Xuất phát";
            this.buttonXuatPhat.UseVisualStyleBackColor = true;
            this.buttonXuatPhat.Click += new System.EventHandler(this.buttonXuatPhat_Click);
            // 
            // buttonThucHien
            // 
            this.buttonThucHien.Enabled = false;
            this.buttonThucHien.Location = new System.Drawing.Point(132, 86);
            this.buttonThucHien.Name = "buttonThucHien";
            this.buttonThucHien.Size = new System.Drawing.Size(75, 40);
            this.buttonThucHien.TabIndex = 5;
            this.buttonThucHien.Text = "Thực hiện";
            this.buttonThucHien.UseVisualStyleBackColor = true;
            this.buttonThucHien.Click += new System.EventHandler(this.buttonThucHien_Click);
            // 
            // buttonDichDen
            // 
            this.buttonDichDen.Location = new System.Drawing.Point(248, 86);
            this.buttonDichDen.Name = "buttonDichDen";
            this.buttonDichDen.Size = new System.Drawing.Size(75, 40);
            this.buttonDichDen.TabIndex = 6;
            this.buttonDichDen.Text = "Đích đến";
            this.buttonDichDen.UseVisualStyleBackColor = true;
            this.buttonDichDen.Click += new System.EventHandler(this.buttonDichDen_Click);
            // 
            // buttonDong
            // 
            this.buttonDong.Location = new System.Drawing.Point(353, 86);
            this.buttonDong.Name = "buttonDong";
            this.buttonDong.Size = new System.Drawing.Size(75, 40);
            this.buttonDong.TabIndex = 7;
            this.buttonDong.Text = "Đóng";
            this.buttonDong.UseVisualStyleBackColor = true;
            this.buttonDong.Click += new System.EventHandler(this.buttonDong_Click);
            // 
            // FormThapHaNoiNangCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 141);
            this.Controls.Add(this.buttonDong);
            this.Controls.Add(this.buttonDichDen);
            this.Controls.Add(this.buttonThucHien);
            this.Controls.Add(this.buttonXuatPhat);
            this.Controls.Add(this.numericUpDownSoBuocToiDa);
            this.Controls.Add(this.numericUpDownDoCaoThap);
            this.Controls.Add(this.labelSoBuocToiDa);
            this.Controls.Add(this.labelDoCaoThap);
            this.Name = "FormThapHaNoiNangCao";
            this.Text = "FormThapHaNoiNangCao";
            this.Activated += new System.EventHandler(this.FormThapHaNoiNangCao_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDoCaoThap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoBuocToiDa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDoCaoThap;
        private System.Windows.Forms.Label labelSoBuocToiDa;
        private System.Windows.Forms.NumericUpDown numericUpDownDoCaoThap;
        private System.Windows.Forms.NumericUpDown numericUpDownSoBuocToiDa;
        private System.Windows.Forms.Button buttonXuatPhat;
        private System.Windows.Forms.Button buttonThucHien;
        private System.Windows.Forms.Button buttonDichDen;
        private System.Windows.Forms.Button buttonDong;
    }
}