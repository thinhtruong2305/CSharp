
namespace DeAnMaTran
{
    partial class FormMaTranCap2
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
            this.buttonTinhCongTruNhanChia = new System.Windows.Forms.Button();
            this.buttonTinhNghichDaoA = new System.Windows.Forms.Button();
            this.buttonTinhNghichDaoB = new System.Windows.Forms.Button();
            this.buttonDong = new System.Windows.Forms.Button();
            this.labelMaTranA = new System.Windows.Forms.Label();
            this.labelMaTranB = new System.Windows.Forms.Label();
            this.labelTongAB = new System.Windows.Forms.Label();
            this.labelHieuAB = new System.Windows.Forms.Label();
            this.labelAxB = new System.Windows.Forms.Label();
            this.labelBxA = new System.Windows.Forms.Label();
            this.labelNghichDaoA = new System.Windows.Forms.Label();
            this.labelNghichDaoB = new System.Windows.Forms.Label();
            this.userControlMaTranNghichDaoB = new DeAnMaTran.UserControlMaTranCap2();
            this.userControlMaTranNghichDaoA = new DeAnMaTran.UserControlMaTranCap2();
            this.userControlMaTranTichBA = new DeAnMaTran.UserControlMaTranCap2();
            this.userControlMaTranTichAB = new DeAnMaTran.UserControlMaTranCap2();
            this.userControlMaTranHieuAB = new DeAnMaTran.UserControlMaTranCap2();
            this.userControlMaTranTongAB = new DeAnMaTran.UserControlMaTranCap2();
            this.userControlMaTranB = new DeAnMaTran.UserControlMaTranCap2();
            this.userControlMaTranA = new DeAnMaTran.UserControlMaTranCap2();
            this.SuspendLayout();
            // 
            // buttonTinhCongTruNhanChia
            // 
            this.buttonTinhCongTruNhanChia.Enabled = false;
            this.buttonTinhCongTruNhanChia.Location = new System.Drawing.Point(12, 472);
            this.buttonTinhCongTruNhanChia.Name = "buttonTinhCongTruNhanChia";
            this.buttonTinhCongTruNhanChia.Size = new System.Drawing.Size(89, 42);
            this.buttonTinhCongTruNhanChia.TabIndex = 8;
            this.buttonTinhCongTruNhanChia.Text = "Tính cộng, trừ, nhân, chia";
            this.buttonTinhCongTruNhanChia.UseVisualStyleBackColor = true;
            this.buttonTinhCongTruNhanChia.Click += new System.EventHandler(this.buttonTinhCongTruNhanChia_Click);
            // 
            // buttonTinhNghichDaoA
            // 
            this.buttonTinhNghichDaoA.Enabled = false;
            this.buttonTinhNghichDaoA.Location = new System.Drawing.Point(147, 472);
            this.buttonTinhNghichDaoA.Name = "buttonTinhNghichDaoA";
            this.buttonTinhNghichDaoA.Size = new System.Drawing.Size(89, 42);
            this.buttonTinhNghichDaoA.TabIndex = 9;
            this.buttonTinhNghichDaoA.Text = "Tính nghịch đảo A";
            this.buttonTinhNghichDaoA.UseVisualStyleBackColor = true;
            this.buttonTinhNghichDaoA.Click += new System.EventHandler(this.buttonTinhNghichDaoA_Click);
            // 
            // buttonTinhNghichDaoB
            // 
            this.buttonTinhNghichDaoB.Enabled = false;
            this.buttonTinhNghichDaoB.Location = new System.Drawing.Point(290, 472);
            this.buttonTinhNghichDaoB.Name = "buttonTinhNghichDaoB";
            this.buttonTinhNghichDaoB.Size = new System.Drawing.Size(89, 42);
            this.buttonTinhNghichDaoB.TabIndex = 10;
            this.buttonTinhNghichDaoB.Text = "Tính nghịch đảo B";
            this.buttonTinhNghichDaoB.UseVisualStyleBackColor = true;
            this.buttonTinhNghichDaoB.Click += new System.EventHandler(this.buttonTinhNghichDaoB_Click);
            // 
            // buttonDong
            // 
            this.buttonDong.Location = new System.Drawing.Point(425, 472);
            this.buttonDong.Name = "buttonDong";
            this.buttonDong.Size = new System.Drawing.Size(89, 42);
            this.buttonDong.TabIndex = 11;
            this.buttonDong.Text = "Đóng";
            this.buttonDong.UseVisualStyleBackColor = true;
            this.buttonDong.Click += new System.EventHandler(this.buttonDong_Click);
            // 
            // labelMaTranA
            // 
            this.labelMaTranA.AutoSize = true;
            this.labelMaTranA.Location = new System.Drawing.Point(92, 12);
            this.labelMaTranA.Name = "labelMaTranA";
            this.labelMaTranA.Size = new System.Drawing.Size(53, 13);
            this.labelMaTranA.TabIndex = 12;
            this.labelMaTranA.Text = "Ma trận A";
            // 
            // labelMaTranB
            // 
            this.labelMaTranB.AutoSize = true;
            this.labelMaTranB.Location = new System.Drawing.Point(384, 12);
            this.labelMaTranB.Name = "labelMaTranB";
            this.labelMaTranB.Size = new System.Drawing.Size(53, 13);
            this.labelMaTranB.TabIndex = 13;
            this.labelMaTranB.Text = "Ma trận B";
            // 
            // labelTongAB
            // 
            this.labelTongAB.AutoSize = true;
            this.labelTongAB.Location = new System.Drawing.Point(84, 129);
            this.labelTongAB.Name = "labelTongAB";
            this.labelTongAB.Size = new System.Drawing.Size(70, 13);
            this.labelTongAB.TabIndex = 14;
            this.labelTongAB.Text = "Tổng = A + B";
            // 
            // labelHieuAB
            // 
            this.labelHieuAB.AutoSize = true;
            this.labelHieuAB.Location = new System.Drawing.Point(374, 129);
            this.labelHieuAB.Name = "labelHieuAB";
            this.labelHieuAB.Size = new System.Drawing.Size(64, 13);
            this.labelHieuAB.TabIndex = 15;
            this.labelHieuAB.Text = "Hiệu = A - B";
            // 
            // labelAxB
            // 
            this.labelAxB.AutoSize = true;
            this.labelAxB.Location = new System.Drawing.Point(89, 245);
            this.labelAxB.Name = "labelAxB";
            this.labelAxB.Size = new System.Drawing.Size(57, 13);
            this.labelAxB.TabIndex = 16;
            this.labelAxB.Text = "AB = A * B";
            // 
            // labelBxA
            // 
            this.labelBxA.AutoSize = true;
            this.labelBxA.Location = new System.Drawing.Point(378, 245);
            this.labelBxA.Name = "labelBxA";
            this.labelBxA.Size = new System.Drawing.Size(57, 13);
            this.labelBxA.TabIndex = 17;
            this.labelBxA.Text = "BA = B * A";
            // 
            // labelNghichDaoA
            // 
            this.labelNghichDaoA.AutoSize = true;
            this.labelNghichDaoA.Location = new System.Drawing.Point(83, 358);
            this.labelNghichDaoA.Name = "labelNghichDaoA";
            this.labelNghichDaoA.Size = new System.Drawing.Size(73, 13);
            this.labelNghichDaoA.TabIndex = 18;
            this.labelNghichDaoA.Text = "Nghịch đảo A";
            // 
            // labelNghichDaoB
            // 
            this.labelNghichDaoB.AutoSize = true;
            this.labelNghichDaoB.Location = new System.Drawing.Point(371, 358);
            this.labelNghichDaoB.Name = "labelNghichDaoB";
            this.labelNghichDaoB.Size = new System.Drawing.Size(73, 13);
            this.labelNghichDaoB.TabIndex = 19;
            this.labelNghichDaoB.Text = "Nghịch đảo B";
            // 
            // userControlMaTranNghichDaoB
            // 
            this.userControlMaTranNghichDaoB.BackColor = System.Drawing.Color.Lime;
            this.userControlMaTranNghichDaoB.Enabled = false;
            this.userControlMaTranNghichDaoB.Location = new System.Drawing.Point(300, 377);
            this.userControlMaTranNghichDaoB.Name = "userControlMaTranNghichDaoB";
            this.userControlMaTranNghichDaoB.ReadOnly = false;
            this.userControlMaTranNghichDaoB.Size = new System.Drawing.Size(214, 83);
            this.userControlMaTranNghichDaoB.TabIndex = 7;
            // 
            // userControlMaTranNghichDaoA
            // 
            this.userControlMaTranNghichDaoA.BackColor = System.Drawing.Color.Lime;
            this.userControlMaTranNghichDaoA.Enabled = false;
            this.userControlMaTranNghichDaoA.Location = new System.Drawing.Point(12, 377);
            this.userControlMaTranNghichDaoA.Name = "userControlMaTranNghichDaoA";
            this.userControlMaTranNghichDaoA.ReadOnly = false;
            this.userControlMaTranNghichDaoA.Size = new System.Drawing.Size(214, 83);
            this.userControlMaTranNghichDaoA.TabIndex = 6;
            // 
            // userControlMaTranTichBA
            // 
            this.userControlMaTranTichBA.BackColor = System.Drawing.Color.Lime;
            this.userControlMaTranTichBA.Enabled = false;
            this.userControlMaTranTichBA.Location = new System.Drawing.Point(300, 264);
            this.userControlMaTranTichBA.Name = "userControlMaTranTichBA";
            this.userControlMaTranTichBA.ReadOnly = false;
            this.userControlMaTranTichBA.Size = new System.Drawing.Size(214, 83);
            this.userControlMaTranTichBA.TabIndex = 5;
            // 
            // userControlMaTranTichAB
            // 
            this.userControlMaTranTichAB.BackColor = System.Drawing.Color.Lime;
            this.userControlMaTranTichAB.Enabled = false;
            this.userControlMaTranTichAB.Location = new System.Drawing.Point(12, 264);
            this.userControlMaTranTichAB.Name = "userControlMaTranTichAB";
            this.userControlMaTranTichAB.ReadOnly = false;
            this.userControlMaTranTichAB.Size = new System.Drawing.Size(214, 83);
            this.userControlMaTranTichAB.TabIndex = 4;
            // 
            // userControlMaTranHieuAB
            // 
            this.userControlMaTranHieuAB.BackColor = System.Drawing.Color.Lime;
            this.userControlMaTranHieuAB.Enabled = false;
            this.userControlMaTranHieuAB.Location = new System.Drawing.Point(300, 148);
            this.userControlMaTranHieuAB.Name = "userControlMaTranHieuAB";
            this.userControlMaTranHieuAB.ReadOnly = false;
            this.userControlMaTranHieuAB.Size = new System.Drawing.Size(214, 83);
            this.userControlMaTranHieuAB.TabIndex = 3;
            // 
            // userControlMaTranTongAB
            // 
            this.userControlMaTranTongAB.BackColor = System.Drawing.Color.Lime;
            this.userControlMaTranTongAB.Enabled = false;
            this.userControlMaTranTongAB.Location = new System.Drawing.Point(12, 148);
            this.userControlMaTranTongAB.Name = "userControlMaTranTongAB";
            this.userControlMaTranTongAB.ReadOnly = false;
            this.userControlMaTranTongAB.Size = new System.Drawing.Size(214, 83);
            this.userControlMaTranTongAB.TabIndex = 2;
            // 
            // userControlMaTranB
            // 
            this.userControlMaTranB.BackColor = System.Drawing.Color.Lime;
            this.userControlMaTranB.Location = new System.Drawing.Point(300, 30);
            this.userControlMaTranB.Name = "userControlMaTranB";
            this.userControlMaTranB.ReadOnly = false;
            this.userControlMaTranB.Size = new System.Drawing.Size(214, 83);
            this.userControlMaTranB.TabIndex = 1;
            this.userControlMaTranB.MaTranChanged += new System.EventHandler<DeAnMaTran.MaTranEventArgs>(this.userControlMaTran_MaTranChanged);
            // 
            // userControlMaTranA
            // 
            this.userControlMaTranA.BackColor = System.Drawing.Color.Lime;
            this.userControlMaTranA.Location = new System.Drawing.Point(12, 30);
            this.userControlMaTranA.Name = "userControlMaTranA";
            this.userControlMaTranA.ReadOnly = false;
            this.userControlMaTranA.Size = new System.Drawing.Size(214, 83);
            this.userControlMaTranA.TabIndex = 0;
            this.userControlMaTranA.MaTranChanged += new System.EventHandler<DeAnMaTran.MaTranEventArgs>(this.userControlMaTran_MaTranChanged);
            // 
            // FormMaTranCap2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 521);
            this.Controls.Add(this.labelNghichDaoB);
            this.Controls.Add(this.labelNghichDaoA);
            this.Controls.Add(this.labelBxA);
            this.Controls.Add(this.labelAxB);
            this.Controls.Add(this.labelHieuAB);
            this.Controls.Add(this.labelTongAB);
            this.Controls.Add(this.labelMaTranB);
            this.Controls.Add(this.labelMaTranA);
            this.Controls.Add(this.buttonDong);
            this.Controls.Add(this.buttonTinhNghichDaoB);
            this.Controls.Add(this.buttonTinhNghichDaoA);
            this.Controls.Add(this.buttonTinhCongTruNhanChia);
            this.Controls.Add(this.userControlMaTranNghichDaoB);
            this.Controls.Add(this.userControlMaTranNghichDaoA);
            this.Controls.Add(this.userControlMaTranTichBA);
            this.Controls.Add(this.userControlMaTranTichAB);
            this.Controls.Add(this.userControlMaTranHieuAB);
            this.Controls.Add(this.userControlMaTranTongAB);
            this.Controls.Add(this.userControlMaTranB);
            this.Controls.Add(this.userControlMaTranA);
            this.Name = "FormMaTranCap2";
            this.Text = "Form ma trận cấp 2";
            this.Activated += new System.EventHandler(this.FormMaTranCap2_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControlMaTranCap2 userControlMaTranA;
        private UserControlMaTranCap2 userControlMaTranB;
        private UserControlMaTranCap2 userControlMaTranHieuAB;
        private UserControlMaTranCap2 userControlMaTranTongAB;
        private UserControlMaTranCap2 userControlMaTranTichBA;
        private UserControlMaTranCap2 userControlMaTranTichAB;
        private UserControlMaTranCap2 userControlMaTranNghichDaoB;
        private UserControlMaTranCap2 userControlMaTranNghichDaoA;
        private System.Windows.Forms.Button buttonTinhCongTruNhanChia;
        private System.Windows.Forms.Button buttonTinhNghichDaoA;
        private System.Windows.Forms.Button buttonTinhNghichDaoB;
        private System.Windows.Forms.Button buttonDong;
        private System.Windows.Forms.Label labelMaTranA;
        private System.Windows.Forms.Label labelMaTranB;
        private System.Windows.Forms.Label labelTongAB;
        private System.Windows.Forms.Label labelHieuAB;
        private System.Windows.Forms.Label labelAxB;
        private System.Windows.Forms.Label labelBxA;
        private System.Windows.Forms.Label labelNghichDaoA;
        private System.Windows.Forms.Label labelNghichDaoB;
    }
}