
namespace TestToanHoc
{
    partial class FromTestToanHoc
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
            this.buttonTestDiem3D = new System.Windows.Forms.Button();
            this.buttonTestTamGiac = new System.Windows.Forms.Button();
            this.buttonTestVector = new System.Windows.Forms.Button();
            this.buttonTestTuDien = new System.Windows.Forms.Button();
            this.buttonTestMatPhang = new System.Windows.Forms.Button();
            this.buttonHePTTT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTestDiem3D
            // 
            this.buttonTestDiem3D.Location = new System.Drawing.Point(77, 23);
            this.buttonTestDiem3D.Name = "buttonTestDiem3D";
            this.buttonTestDiem3D.Size = new System.Drawing.Size(95, 23);
            this.buttonTestDiem3D.TabIndex = 0;
            this.buttonTestDiem3D.Text = "Test Diem3D";
            this.buttonTestDiem3D.UseVisualStyleBackColor = true;
            this.buttonTestDiem3D.Click += new System.EventHandler(this.buttonTestDiem3D_Click);
            // 
            // buttonTestTamGiac
            // 
            this.buttonTestTamGiac.Location = new System.Drawing.Point(77, 61);
            this.buttonTestTamGiac.Name = "buttonTestTamGiac";
            this.buttonTestTamGiac.Size = new System.Drawing.Size(95, 23);
            this.buttonTestTamGiac.TabIndex = 1;
            this.buttonTestTamGiac.Text = "Test tam giác";
            this.buttonTestTamGiac.UseVisualStyleBackColor = true;
            this.buttonTestTamGiac.Click += new System.EventHandler(this.buttonTestTamGiac_Click);
            // 
            // buttonTestVector
            // 
            this.buttonTestVector.Location = new System.Drawing.Point(77, 101);
            this.buttonTestVector.Name = "buttonTestVector";
            this.buttonTestVector.Size = new System.Drawing.Size(95, 23);
            this.buttonTestVector.TabIndex = 2;
            this.buttonTestVector.Text = "Test vector";
            this.buttonTestVector.UseVisualStyleBackColor = true;
            this.buttonTestVector.Click += new System.EventHandler(this.buttonTestVector_Click);
            // 
            // buttonTestTuDien
            // 
            this.buttonTestTuDien.Location = new System.Drawing.Point(77, 139);
            this.buttonTestTuDien.Name = "buttonTestTuDien";
            this.buttonTestTuDien.Size = new System.Drawing.Size(95, 23);
            this.buttonTestTuDien.TabIndex = 3;
            this.buttonTestTuDien.Text = "Test tứ diện";
            this.buttonTestTuDien.UseVisualStyleBackColor = true;
            this.buttonTestTuDien.Click += new System.EventHandler(this.buttonTestTuDien_Click);
            // 
            // buttonTestMatPhang
            // 
            this.buttonTestMatPhang.Location = new System.Drawing.Point(77, 179);
            this.buttonTestMatPhang.Name = "buttonTestMatPhang";
            this.buttonTestMatPhang.Size = new System.Drawing.Size(95, 23);
            this.buttonTestMatPhang.TabIndex = 4;
            this.buttonTestMatPhang.Text = "Test mặt phẳng";
            this.buttonTestMatPhang.UseVisualStyleBackColor = true;
            this.buttonTestMatPhang.Click += new System.EventHandler(this.buttonTestMatPhang_Click);
            // 
            // buttonHePTTT
            // 
            this.buttonHePTTT.Location = new System.Drawing.Point(42, 216);
            this.buttonHePTTT.Name = "buttonHePTTT";
            this.buttonHePTTT.Size = new System.Drawing.Size(173, 23);
            this.buttonHePTTT.TabIndex = 5;
            this.buttonHePTTT.Text = "Test Hệ phương trình tuyến tính";
            this.buttonHePTTT.UseVisualStyleBackColor = true;
            this.buttonHePTTT.Click += new System.EventHandler(this.buttonHePTTT_Click);
            // 
            // FromTestToanHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 258);
            this.Controls.Add(this.buttonHePTTT);
            this.Controls.Add(this.buttonTestMatPhang);
            this.Controls.Add(this.buttonTestTuDien);
            this.Controls.Add(this.buttonTestVector);
            this.Controls.Add(this.buttonTestTamGiac);
            this.Controls.Add(this.buttonTestDiem3D);
            this.Name = "FromTestToanHoc";
            this.Text = "Form test toán học";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTestDiem3D;
        private System.Windows.Forms.Button buttonTestTamGiac;
        private System.Windows.Forms.Button buttonTestVector;
        private System.Windows.Forms.Button buttonTestTuDien;
        private System.Windows.Forms.Button buttonTestMatPhang;
        private System.Windows.Forms.Button buttonHePTTT;
    }
}

