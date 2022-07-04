
namespace QuanLiGiuXe
{
    partial class FormTrangChinh
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanelMucDoanhThu = new System.Windows.Forms.TableLayoutPanel();
            this.panelTongDoanhThu = new System.Windows.Forms.Panel();
            this.labelSoTienTongDoanhThu = new System.Windows.Forms.Label();
            this.labelTongDoanhThu = new System.Windows.Forms.Label();
            this.panelTongDoanhThuTheoNam = new System.Windows.Forms.Panel();
            this.labelSoTienDoanhThuNam = new System.Windows.Forms.Label();
            this.labelTongDoanhThuTheoNam = new System.Windows.Forms.Label();
            this.comboBoxNam = new System.Windows.Forms.ComboBox();
            this.labelNam = new System.Windows.Forms.Label();
            this.buttonXacNhan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            this.tableLayoutPanelMucDoanhThu.SuspendLayout();
            this.panelTongDoanhThu.SuspendLayout();
            this.panelTongDoanhThuTheoNam.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartDoanhThu
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDoanhThu.ChartAreas.Add(chartArea1);
            this.chartDoanhThu.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Name = "Legend1";
            this.chartDoanhThu.Legends.Add(legend1);
            this.chartDoanhThu.Location = new System.Drawing.Point(0, 218);
            this.chartDoanhThu.Name = "chartDoanhThu";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "DoanhThu";
            this.chartDoanhThu.Series.Add(series1);
            this.chartDoanhThu.Size = new System.Drawing.Size(873, 350);
            this.chartDoanhThu.TabIndex = 0;
            this.chartDoanhThu.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            title1.Name = "Title1";
            title1.Text = "Tổng doanh thu";
            this.chartDoanhThu.Titles.Add(title1);
            // 
            // tableLayoutPanelMucDoanhThu
            // 
            this.tableLayoutPanelMucDoanhThu.ColumnCount = 2;
            this.tableLayoutPanelMucDoanhThu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMucDoanhThu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMucDoanhThu.Controls.Add(this.panelTongDoanhThu, 0, 0);
            this.tableLayoutPanelMucDoanhThu.Controls.Add(this.panelTongDoanhThuTheoNam, 1, 0);
            this.tableLayoutPanelMucDoanhThu.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelMucDoanhThu.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMucDoanhThu.Name = "tableLayoutPanelMucDoanhThu";
            this.tableLayoutPanelMucDoanhThu.RowCount = 1;
            this.tableLayoutPanelMucDoanhThu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMucDoanhThu.Size = new System.Drawing.Size(873, 100);
            this.tableLayoutPanelMucDoanhThu.TabIndex = 1;
            // 
            // panelTongDoanhThu
            // 
            this.panelTongDoanhThu.BackColor = System.Drawing.Color.PowderBlue;
            this.panelTongDoanhThu.Controls.Add(this.labelSoTienTongDoanhThu);
            this.panelTongDoanhThu.Controls.Add(this.labelTongDoanhThu);
            this.panelTongDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTongDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTongDoanhThu.Location = new System.Drawing.Point(3, 3);
            this.panelTongDoanhThu.Name = "panelTongDoanhThu";
            this.panelTongDoanhThu.Size = new System.Drawing.Size(430, 94);
            this.panelTongDoanhThu.TabIndex = 0;
            // 
            // labelSoTienTongDoanhThu
            // 
            this.labelSoTienTongDoanhThu.AutoSize = true;
            this.labelSoTienTongDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoTienTongDoanhThu.Location = new System.Drawing.Point(151, 57);
            this.labelSoTienTongDoanhThu.Name = "labelSoTienTongDoanhThu";
            this.labelSoTienTongDoanhThu.Size = new System.Drawing.Size(105, 25);
            this.labelSoTienTongDoanhThu.TabIndex = 1;
            this.labelSoTienTongDoanhThu.Text = "DoanhThu";
            // 
            // labelTongDoanhThu
            // 
            this.labelTongDoanhThu.AutoSize = true;
            this.labelTongDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongDoanhThu.Location = new System.Drawing.Point(153, 10);
            this.labelTongDoanhThu.Name = "labelTongDoanhThu";
            this.labelTongDoanhThu.Size = new System.Drawing.Size(109, 17);
            this.labelTongDoanhThu.TabIndex = 0;
            this.labelTongDoanhThu.Text = "Tổng doanh thu";
            // 
            // panelTongDoanhThuTheoNam
            // 
            this.panelTongDoanhThuTheoNam.BackColor = System.Drawing.Color.SpringGreen;
            this.panelTongDoanhThuTheoNam.Controls.Add(this.labelSoTienDoanhThuNam);
            this.panelTongDoanhThuTheoNam.Controls.Add(this.labelTongDoanhThuTheoNam);
            this.panelTongDoanhThuTheoNam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTongDoanhThuTheoNam.Location = new System.Drawing.Point(439, 3);
            this.panelTongDoanhThuTheoNam.Name = "panelTongDoanhThuTheoNam";
            this.panelTongDoanhThuTheoNam.Size = new System.Drawing.Size(431, 94);
            this.panelTongDoanhThuTheoNam.TabIndex = 1;
            // 
            // labelSoTienDoanhThuNam
            // 
            this.labelSoTienDoanhThuNam.AutoSize = true;
            this.labelSoTienDoanhThuNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoTienDoanhThuNam.Location = new System.Drawing.Point(176, 57);
            this.labelSoTienDoanhThuNam.Name = "labelSoTienDoanhThuNam";
            this.labelSoTienDoanhThuNam.Size = new System.Drawing.Size(102, 25);
            this.labelSoTienDoanhThuNam.TabIndex = 5;
            this.labelSoTienDoanhThuNam.Text = "Doanh thu";
            // 
            // labelTongDoanhThuTheoNam
            // 
            this.labelTongDoanhThuTheoNam.AutoSize = true;
            this.labelTongDoanhThuTheoNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongDoanhThuTheoNam.Location = new System.Drawing.Point(143, 10);
            this.labelTongDoanhThuTheoNam.Name = "labelTongDoanhThuTheoNam";
            this.labelTongDoanhThuTheoNam.Size = new System.Drawing.Size(172, 17);
            this.labelTongDoanhThuTheoNam.TabIndex = 1;
            this.labelTongDoanhThuTheoNam.Text = "Tổng doanh thu theo năm";
            // 
            // comboBoxNam
            // 
            this.comboBoxNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNam.FormattingEnabled = true;
            this.comboBoxNam.Location = new System.Drawing.Point(122, 148);
            this.comboBoxNam.Name = "comboBoxNam";
            this.comboBoxNam.Size = new System.Drawing.Size(121, 24);
            this.comboBoxNam.TabIndex = 2;
            // 
            // labelNam
            // 
            this.labelNam.AutoSize = true;
            this.labelNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNam.Location = new System.Drawing.Point(75, 151);
            this.labelNam.Name = "labelNam";
            this.labelNam.Size = new System.Drawing.Size(41, 17);
            this.labelNam.TabIndex = 3;
            this.labelNam.Text = "Năm:";
            // 
            // buttonXacNhan
            // 
            this.buttonXacNhan.Location = new System.Drawing.Point(295, 148);
            this.buttonXacNhan.Name = "buttonXacNhan";
            this.buttonXacNhan.Size = new System.Drawing.Size(75, 23);
            this.buttonXacNhan.TabIndex = 4;
            this.buttonXacNhan.Text = "Xác nhận";
            this.buttonXacNhan.UseVisualStyleBackColor = true;
            this.buttonXacNhan.Click += new System.EventHandler(this.buttonXacNhan_Click);
            // 
            // FormTrangChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 568);
            this.Controls.Add(this.buttonXacNhan);
            this.Controls.Add(this.labelNam);
            this.Controls.Add(this.comboBoxNam);
            this.Controls.Add(this.tableLayoutPanelMucDoanhThu);
            this.Controls.Add(this.chartDoanhThu);
            this.MaximumSize = new System.Drawing.Size(889, 607);
            this.MinimumSize = new System.Drawing.Size(889, 607);
            this.Name = "FormTrangChinh";
            this.Text = "FormTrangChinh";
            this.Load += new System.EventHandler(this.FormTrangChinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            this.tableLayoutPanelMucDoanhThu.ResumeLayout(false);
            this.panelTongDoanhThu.ResumeLayout(false);
            this.panelTongDoanhThu.PerformLayout();
            this.panelTongDoanhThuTheoNam.ResumeLayout(false);
            this.panelTongDoanhThuTheoNam.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMucDoanhThu;
        private System.Windows.Forms.Panel panelTongDoanhThu;
        private System.Windows.Forms.Panel panelTongDoanhThuTheoNam;
        private System.Windows.Forms.ComboBox comboBoxNam;
        private System.Windows.Forms.Label labelNam;
        private System.Windows.Forms.Label labelTongDoanhThu;
        private System.Windows.Forms.Label labelTongDoanhThuTheoNam;
        private System.Windows.Forms.Button buttonXacNhan;
        private System.Windows.Forms.Label labelSoTienTongDoanhThu;
        private System.Windows.Forms.Label labelSoTienDoanhThuNam;
    }
}