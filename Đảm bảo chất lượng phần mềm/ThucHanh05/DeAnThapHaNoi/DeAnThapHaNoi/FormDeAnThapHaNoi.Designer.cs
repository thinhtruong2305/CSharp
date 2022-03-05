
namespace DeAnThapHaNoi
{
    partial class FormDeAnThapHaNoi
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thápHaNoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDonGian = new System.Windows.Forms.ToolStripMenuItem();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemThongTin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemKetThuc = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBarTienDo = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripMenuItemNangCao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thápHaNoiToolStripMenuItem,
            this.hệThốngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thápHaNoiToolStripMenuItem
            // 
            this.thápHaNoiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDonGian,
            this.toolStripMenuItemNangCao});
            this.thápHaNoiToolStripMenuItem.Name = "thápHaNoiToolStripMenuItem";
            this.thápHaNoiToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.thápHaNoiToolStripMenuItem.Text = "Tháp HaNoi";
            // 
            // toolStripMenuItemDonGian
            // 
            this.toolStripMenuItemDonGian.Name = "toolStripMenuItemDonGian";
            this.toolStripMenuItemDonGian.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemDonGian.Text = "Đơn giản";
            this.toolStripMenuItemDonGian.Click += new System.EventHandler(this.toolStripMenuItemDonGian_Click);
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemThongTin,
            this.toolStripMenuItemKetThuc});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // toolStripMenuItemThongTin
            // 
            this.toolStripMenuItemThongTin.Name = "toolStripMenuItemThongTin";
            this.toolStripMenuItemThongTin.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemThongTin.Text = "Thông tin";
            this.toolStripMenuItemThongTin.Click += new System.EventHandler(this.toolStripMenuItemThongTin_Click);
            // 
            // toolStripMenuItemKetThuc
            // 
            this.toolStripMenuItemKetThuc.Name = "toolStripMenuItemKetThuc";
            this.toolStripMenuItemKetThuc.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemKetThuc.Text = "Kết thúc";
            this.toolStripMenuItemKetThuc.Click += new System.EventHandler(this.toolStripMenuItemKetThuc_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBarTienDo,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBarTienDo
            // 
            this.toolStripProgressBarTienDo.Name = "toolStripProgressBarTienDo";
            this.toolStripProgressBarTienDo.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(683, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "Sẵn sàng";
            // 
            // toolStripMenuItemNangCao
            // 
            this.toolStripMenuItemNangCao.Name = "toolStripMenuItemNangCao";
            this.toolStripMenuItemNangCao.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemNangCao.Text = "Nâng cao";
            this.toolStripMenuItemNangCao.Click += new System.EventHandler(this.toolStripMenuItemNangCao_Click);
            // 
            // FormDeAnThapHaNoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormDeAnThapHaNoi";
            this.Text = "Form đề án tháp HaNoi";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thápHaNoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDonGian;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemThongTin;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemKetThuc;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBarTienDo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem nângCaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNangCao;
    }
}

