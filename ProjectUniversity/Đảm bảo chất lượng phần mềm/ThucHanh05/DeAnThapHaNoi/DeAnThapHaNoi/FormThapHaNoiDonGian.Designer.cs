
namespace DeAnThapHaNoi
{
    partial class FormThapHaNoiDonGian
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
            this.listBoxDiChuyen = new System.Windows.Forms.ListBox();
            this.labelThap0 = new System.Windows.Forms.Label();
            this.labelThap1 = new System.Windows.Forms.Label();
            this.labelThap2 = new System.Windows.Forms.Label();
            this.numericUpDownDoCao = new System.Windows.Forms.NumericUpDown();
            this.buttonThucHien = new System.Windows.Forms.Button();
            this.buttonDong = new System.Windows.Forms.Button();
            this.userControlThapHaNoi2 = new DeAnThapHaNoi.UserControlThapHaNoi();
            this.userControlThapHaNoi1 = new DeAnThapHaNoi.UserControlThapHaNoi();
            this.userControlThapHaNoi0 = new DeAnThapHaNoi.UserControlThapHaNoi();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxDiChuyen
            // 
            this.listBoxDiChuyen.FormattingEnabled = true;
            this.listBoxDiChuyen.Location = new System.Drawing.Point(626, 12);
            this.listBoxDiChuyen.Name = "listBoxDiChuyen";
            this.listBoxDiChuyen.Size = new System.Drawing.Size(246, 342);
            this.listBoxDiChuyen.TabIndex = 3;
            // 
            // labelThap0
            // 
            this.labelThap0.AutoSize = true;
            this.labelThap0.Location = new System.Drawing.Point(67, 391);
            this.labelThap0.Name = "labelThap0";
            this.labelThap0.Size = new System.Drawing.Size(41, 13);
            this.labelThap0.TabIndex = 4;
            this.labelThap0.Text = "Tháp 0";
            // 
            // labelThap1
            // 
            this.labelThap1.AutoSize = true;
            this.labelThap1.Location = new System.Drawing.Point(281, 391);
            this.labelThap1.Name = "labelThap1";
            this.labelThap1.Size = new System.Drawing.Size(41, 13);
            this.labelThap1.TabIndex = 5;
            this.labelThap1.Text = "Tháp 1";
            // 
            // labelThap2
            // 
            this.labelThap2.AutoSize = true;
            this.labelThap2.Location = new System.Drawing.Point(482, 391);
            this.labelThap2.Name = "labelThap2";
            this.labelThap2.Size = new System.Drawing.Size(41, 13);
            this.labelThap2.TabIndex = 6;
            this.labelThap2.Text = "Tháp 2";
            // 
            // numericUpDownDoCao
            // 
            this.numericUpDownDoCao.Location = new System.Drawing.Point(624, 389);
            this.numericUpDownDoCao.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownDoCao.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDoCao.Name = "numericUpDownDoCao";
            this.numericUpDownDoCao.Size = new System.Drawing.Size(37, 20);
            this.numericUpDownDoCao.TabIndex = 7;
            this.numericUpDownDoCao.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDoCao.ValueChanged += new System.EventHandler(this.numericUpDownDoCao_ValueChanged);
            // 
            // buttonThucHien
            // 
            this.buttonThucHien.Location = new System.Drawing.Point(667, 386);
            this.buttonThucHien.Name = "buttonThucHien";
            this.buttonThucHien.Size = new System.Drawing.Size(119, 23);
            this.buttonThucHien.TabIndex = 8;
            this.buttonThucHien.Text = "Thực hiện 0 -> 2";
            this.buttonThucHien.UseVisualStyleBackColor = true;
            this.buttonThucHien.Click += new System.EventHandler(this.buttonThucHien_Click);
            // 
            // buttonDong
            // 
            this.buttonDong.Location = new System.Drawing.Point(797, 386);
            this.buttonDong.Name = "buttonDong";
            this.buttonDong.Size = new System.Drawing.Size(75, 23);
            this.buttonDong.TabIndex = 9;
            this.buttonDong.Text = "Đóng";
            this.buttonDong.UseVisualStyleBackColor = true;
            this.buttonDong.Click += new System.EventHandler(this.buttonDong_Click);
            // 
            // userControlThapHaNoi2
            // 
            this.userControlThapHaNoi2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.userControlThapHaNoi2.Location = new System.Drawing.Point(421, 12);
            this.userControlThapHaNoi2.Name = "userControlThapHaNoi2";
            this.userControlThapHaNoi2.Size = new System.Drawing.Size(166, 344);
            this.userControlThapHaNoi2.TabIndex = 2;
            // 
            // userControlThapHaNoi1
            // 
            this.userControlThapHaNoi1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.userControlThapHaNoi1.Location = new System.Drawing.Point(216, 12);
            this.userControlThapHaNoi1.Name = "userControlThapHaNoi1";
            this.userControlThapHaNoi1.Size = new System.Drawing.Size(166, 344);
            this.userControlThapHaNoi1.TabIndex = 1;
            // 
            // userControlThapHaNoi0
            // 
            this.userControlThapHaNoi0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.userControlThapHaNoi0.Location = new System.Drawing.Point(12, 12);
            this.userControlThapHaNoi0.Name = "userControlThapHaNoi0";
            this.userControlThapHaNoi0.Size = new System.Drawing.Size(166, 344);
            this.userControlThapHaNoi0.TabIndex = 0;
            // 
            // FormThapHaNoiDonGian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.buttonDong);
            this.Controls.Add(this.buttonThucHien);
            this.Controls.Add(this.numericUpDownDoCao);
            this.Controls.Add(this.labelThap2);
            this.Controls.Add(this.labelThap1);
            this.Controls.Add(this.labelThap0);
            this.Controls.Add(this.listBoxDiChuyen);
            this.Controls.Add(this.userControlThapHaNoi2);
            this.Controls.Add(this.userControlThapHaNoi1);
            this.Controls.Add(this.userControlThapHaNoi0);
            this.Name = "FormThapHaNoiDonGian";
            this.Text = "FormThapHaNoiDonGian";
            this.Activated += new System.EventHandler(this.FormThapHaNoiDonGian_Activated);
            this.Load += new System.EventHandler(this.FormThapHaNoiDonGian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDoCao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControlThapHaNoi userControlThapHaNoi0;
        private UserControlThapHaNoi userControlThapHaNoi1;
        private UserControlThapHaNoi userControlThapHaNoi2;
        private System.Windows.Forms.ListBox listBoxDiChuyen;
        private System.Windows.Forms.Label labelThap0;
        private System.Windows.Forms.Label labelThap1;
        private System.Windows.Forms.Label labelThap2;
        private System.Windows.Forms.NumericUpDown numericUpDownDoCao;
        private System.Windows.Forms.Button buttonThucHien;
        private System.Windows.Forms.Button buttonDong;
    }
}