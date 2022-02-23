
namespace TrucQuan03
{
    partial class FormTrucQuan
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
            this.toánHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDiem3D = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTamGiac = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemVector3D = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTuDien = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemMatPhang = new System.Windows.Forms.ToolStripMenuItem();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemKetThuc = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBarTienDo = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabelSanSang = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripMenuItemHePTTT = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toánHọcToolStripMenuItem,
            this.hệThốngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toánHọcToolStripMenuItem
            // 
            this.toánHọcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDiem3D,
            this.toolStripMenuItemTamGiac,
            this.toolStripMenuItemVector3D,
            this.toolStripMenuItemTuDien,
            this.toolStripMenuItemMatPhang,
            this.toolStripMenuItemHePTTT});
            this.toánHọcToolStripMenuItem.Name = "toánHọcToolStripMenuItem";
            this.toánHọcToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.toánHọcToolStripMenuItem.Text = "Toán học";
            // 
            // toolStripMenuItemDiem3D
            // 
            this.toolStripMenuItemDiem3D.Name = "toolStripMenuItemDiem3D";
            this.toolStripMenuItemDiem3D.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemDiem3D.Text = "Điểm 3D";
            this.toolStripMenuItemDiem3D.Click += new System.EventHandler(this.toolStripMenuItemDiem3D_Click);
            // 
            // toolStripMenuItemTamGiac
            // 
            this.toolStripMenuItemTamGiac.Name = "toolStripMenuItemTamGiac";
            this.toolStripMenuItemTamGiac.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemTamGiac.Text = "Tam giác";
            this.toolStripMenuItemTamGiac.Click += new System.EventHandler(this.toolStripMenuItemTamGiac_Click);
            // 
            // toolStripMenuItemVector3D
            // 
            this.toolStripMenuItemVector3D.Name = "toolStripMenuItemVector3D";
            this.toolStripMenuItemVector3D.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemVector3D.Text = "Vector 3D";
            this.toolStripMenuItemVector3D.Click += new System.EventHandler(this.toolStripMenuItemVector3D_Click);
            // 
            // toolStripMenuItemTuDien
            // 
            this.toolStripMenuItemTuDien.Name = "toolStripMenuItemTuDien";
            this.toolStripMenuItemTuDien.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemTuDien.Text = "Tứ diện";
            this.toolStripMenuItemTuDien.Click += new System.EventHandler(this.toolStripMenuItemTuDien_Click);
            // 
            // toolStripMenuItemMatPhang
            // 
            this.toolStripMenuItemMatPhang.Name = "toolStripMenuItemMatPhang";
            this.toolStripMenuItemMatPhang.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemMatPhang.Text = "Mặt phẳng";
            this.toolStripMenuItemMatPhang.Click += new System.EventHandler(this.toolStripMenuItemMatPhang_Click);
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemKetThuc,
            this.toolStripMenuItemAbout});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // toolStripMenuItemKetThuc
            // 
            this.toolStripMenuItemKetThuc.Name = "toolStripMenuItemKetThuc";
            this.toolStripMenuItemKetThuc.Size = new System.Drawing.Size(125, 22);
            this.toolStripMenuItemKetThuc.Text = "Kết thúc";
            this.toolStripMenuItemKetThuc.Click += new System.EventHandler(this.toolStripMenuItemKetThuc_Click);
            // 
            // toolStripMenuItemAbout
            // 
            this.toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
            this.toolStripMenuItemAbout.Size = new System.Drawing.Size(125, 22);
            this.toolStripMenuItemAbout.Text = "Thông tin";
            this.toolStripMenuItemAbout.Click += new System.EventHandler(this.toolStripMenuItemAbout_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBarTienDo,
            this.toolStripStatusLabelSanSang});
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
            // toolStripStatusLabelSanSang
            // 
            this.toolStripStatusLabelSanSang.Name = "toolStripStatusLabelSanSang";
            this.toolStripStatusLabelSanSang.Size = new System.Drawing.Size(683, 17);
            this.toolStripStatusLabelSanSang.Spring = true;
            this.toolStripStatusLabelSanSang.Text = "Sẵn sàng";
            // 
            // toolStripMenuItemHePTTT
            // 
            this.toolStripMenuItemHePTTT.Name = "toolStripMenuItemHePTTT";
            this.toolStripMenuItemHePTTT.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemHePTTT.Text = "Hệ PTTT";
            this.toolStripMenuItemHePTTT.Click += new System.EventHandler(this.toolStripMenuItemHePTTT_Click);
            // 
            // FormTrucQuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormTrucQuan";
            this.Text = "Trực quan 03";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toánHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDiem3D;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTamGiac;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemVector3D;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTuDien;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemKetThuc;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBarTienDo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSanSang;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMatPhang;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHePTTT;
    }
}