
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
            // FromTestToanHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 224);
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
    }
}

