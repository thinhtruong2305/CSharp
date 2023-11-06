
namespace WinformCoBan
{
    partial class FormTab
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePhuongTrinhBac1 = new System.Windows.Forms.TabPage();
            this.numericUpDownB = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownA = new System.Windows.Forms.NumericUpDown();
            this.textBoxKetQua = new System.Windows.Forms.TextBox();
            this.labelKetQua = new System.Windows.Forms.Label();
            this.buttonTinhToan = new System.Windows.Forms.Button();
            this.labelB = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.tabPagePhuongTrinhBacHai = new System.Windows.Forms.TabPage();
            this.textBoxKetQuaPhuongTrinhBac2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonTinhToanPhuongTrinhBac2 = new System.Windows.Forms.Button();
            this.numericUpDownCPhuongTrinhBac2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBPhuongTrinhBac2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAPhuongTrinhBac2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPagePhuongTrinhBac1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).BeginInit();
            this.tabPagePhuongTrinhBacHai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCPhuongTrinhBac2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBPhuongTrinhBac2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAPhuongTrinhBac2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePhuongTrinhBac1);
            this.tabControl1.Controls.Add(this.tabPagePhuongTrinhBacHai);
            this.tabControl1.Location = new System.Drawing.Point(85, 83);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(629, 308);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPagePhuongTrinhBac1
            // 
            this.tabPagePhuongTrinhBac1.Controls.Add(this.numericUpDownB);
            this.tabPagePhuongTrinhBac1.Controls.Add(this.numericUpDownA);
            this.tabPagePhuongTrinhBac1.Controls.Add(this.textBoxKetQua);
            this.tabPagePhuongTrinhBac1.Controls.Add(this.labelKetQua);
            this.tabPagePhuongTrinhBac1.Controls.Add(this.buttonTinhToan);
            this.tabPagePhuongTrinhBac1.Controls.Add(this.labelB);
            this.tabPagePhuongTrinhBac1.Controls.Add(this.labelA);
            this.tabPagePhuongTrinhBac1.Location = new System.Drawing.Point(4, 22);
            this.tabPagePhuongTrinhBac1.Name = "tabPagePhuongTrinhBac1";
            this.tabPagePhuongTrinhBac1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePhuongTrinhBac1.Size = new System.Drawing.Size(621, 282);
            this.tabPagePhuongTrinhBac1.TabIndex = 0;
            this.tabPagePhuongTrinhBac1.Text = "Phương trình bậc 1";
            this.tabPagePhuongTrinhBac1.UseVisualStyleBackColor = true;
            // 
            // numericUpDownB
            // 
            this.numericUpDownB.Location = new System.Drawing.Point(393, 78);
            this.numericUpDownB.Name = "numericUpDownB";
            this.numericUpDownB.Size = new System.Drawing.Size(45, 20);
            this.numericUpDownB.TabIndex = 8;
            // 
            // numericUpDownA
            // 
            this.numericUpDownA.Location = new System.Drawing.Point(149, 78);
            this.numericUpDownA.Name = "numericUpDownA";
            this.numericUpDownA.Size = new System.Drawing.Size(45, 20);
            this.numericUpDownA.TabIndex = 7;
            // 
            // textBoxKetQua
            // 
            this.textBoxKetQua.Location = new System.Drawing.Point(213, 147);
            this.textBoxKetQua.Name = "textBoxKetQua";
            this.textBoxKetQua.Size = new System.Drawing.Size(138, 20);
            this.textBoxKetQua.TabIndex = 6;
            // 
            // labelKetQua
            // 
            this.labelKetQua.AutoSize = true;
            this.labelKetQua.Location = new System.Drawing.Point(163, 150);
            this.labelKetQua.Name = "labelKetQua";
            this.labelKetQua.Size = new System.Drawing.Size(47, 13);
            this.labelKetQua.TabIndex = 5;
            this.labelKetQua.Text = "Kết quả:";
            // 
            // buttonTinhToan
            // 
            this.buttonTinhToan.Location = new System.Drawing.Point(228, 209);
            this.buttonTinhToan.Name = "buttonTinhToan";
            this.buttonTinhToan.Size = new System.Drawing.Size(75, 23);
            this.buttonTinhToan.TabIndex = 4;
            this.buttonTinhToan.Text = "Tính Toán";
            this.buttonTinhToan.UseVisualStyleBackColor = true;
            this.buttonTinhToan.Click += new System.EventHandler(this.buttonTinhToan_Click);
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(370, 80);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(17, 13);
            this.labelB.TabIndex = 3;
            this.labelB.Text = "B:";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(126, 80);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(17, 13);
            this.labelA.TabIndex = 2;
            this.labelA.Text = "A:";
            // 
            // tabPagePhuongTrinhBacHai
            // 
            this.tabPagePhuongTrinhBacHai.Controls.Add(this.textBoxKetQuaPhuongTrinhBac2);
            this.tabPagePhuongTrinhBacHai.Controls.Add(this.label4);
            this.tabPagePhuongTrinhBacHai.Controls.Add(this.buttonTinhToanPhuongTrinhBac2);
            this.tabPagePhuongTrinhBacHai.Controls.Add(this.numericUpDownCPhuongTrinhBac2);
            this.tabPagePhuongTrinhBacHai.Controls.Add(this.numericUpDownBPhuongTrinhBac2);
            this.tabPagePhuongTrinhBacHai.Controls.Add(this.numericUpDownAPhuongTrinhBac2);
            this.tabPagePhuongTrinhBacHai.Controls.Add(this.label3);
            this.tabPagePhuongTrinhBacHai.Controls.Add(this.label2);
            this.tabPagePhuongTrinhBacHai.Controls.Add(this.label1);
            this.tabPagePhuongTrinhBacHai.Location = new System.Drawing.Point(4, 22);
            this.tabPagePhuongTrinhBacHai.Name = "tabPagePhuongTrinhBacHai";
            this.tabPagePhuongTrinhBacHai.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePhuongTrinhBacHai.Size = new System.Drawing.Size(621, 282);
            this.tabPagePhuongTrinhBacHai.TabIndex = 1;
            this.tabPagePhuongTrinhBacHai.Text = "Phương trình bậc 2";
            this.tabPagePhuongTrinhBacHai.UseVisualStyleBackColor = true;
            // 
            // textBoxKetQuaPhuongTrinhBac2
            // 
            this.textBoxKetQuaPhuongTrinhBac2.Location = new System.Drawing.Point(255, 161);
            this.textBoxKetQuaPhuongTrinhBac2.Name = "textBoxKetQuaPhuongTrinhBac2";
            this.textBoxKetQuaPhuongTrinhBac2.Size = new System.Drawing.Size(138, 20);
            this.textBoxKetQuaPhuongTrinhBac2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kết quả:";
            // 
            // buttonTinhToanPhuongTrinhBac2
            // 
            this.buttonTinhToanPhuongTrinhBac2.Location = new System.Drawing.Point(270, 223);
            this.buttonTinhToanPhuongTrinhBac2.Name = "buttonTinhToanPhuongTrinhBac2";
            this.buttonTinhToanPhuongTrinhBac2.Size = new System.Drawing.Size(75, 23);
            this.buttonTinhToanPhuongTrinhBac2.TabIndex = 7;
            this.buttonTinhToanPhuongTrinhBac2.Text = "Tính Toán";
            this.buttonTinhToanPhuongTrinhBac2.UseVisualStyleBackColor = true;
            this.buttonTinhToanPhuongTrinhBac2.Click += new System.EventHandler(this.buttonTinhToanPhuongTrinhBac2_Click);
            // 
            // numericUpDownCPhuongTrinhBac2
            // 
            this.numericUpDownCPhuongTrinhBac2.Location = new System.Drawing.Point(486, 74);
            this.numericUpDownCPhuongTrinhBac2.Name = "numericUpDownCPhuongTrinhBac2";
            this.numericUpDownCPhuongTrinhBac2.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownCPhuongTrinhBac2.TabIndex = 5;
            // 
            // numericUpDownBPhuongTrinhBac2
            // 
            this.numericUpDownBPhuongTrinhBac2.Location = new System.Drawing.Point(275, 74);
            this.numericUpDownBPhuongTrinhBac2.Name = "numericUpDownBPhuongTrinhBac2";
            this.numericUpDownBPhuongTrinhBac2.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownBPhuongTrinhBac2.TabIndex = 4;
            // 
            // numericUpDownAPhuongTrinhBac2
            // 
            this.numericUpDownAPhuongTrinhBac2.Location = new System.Drawing.Point(84, 74);
            this.numericUpDownAPhuongTrinhBac2.Name = "numericUpDownAPhuongTrinhBac2";
            this.numericUpDownAPhuongTrinhBac2.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownAPhuongTrinhBac2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "C:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "B:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "A:";
            // 
            // FormTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormTab";
            this.Text = "FormTab";
            this.tabControl1.ResumeLayout(false);
            this.tabPagePhuongTrinhBac1.ResumeLayout(false);
            this.tabPagePhuongTrinhBac1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).EndInit();
            this.tabPagePhuongTrinhBacHai.ResumeLayout(false);
            this.tabPagePhuongTrinhBacHai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCPhuongTrinhBac2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBPhuongTrinhBac2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAPhuongTrinhBac2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePhuongTrinhBac1;
        private System.Windows.Forms.TabPage tabPagePhuongTrinhBacHai;
        private System.Windows.Forms.TextBox textBoxKetQua;
        private System.Windows.Forms.Label labelKetQua;
        private System.Windows.Forms.Button buttonTinhToan;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.NumericUpDown numericUpDownB;
        private System.Windows.Forms.NumericUpDown numericUpDownA;
        private System.Windows.Forms.TextBox textBoxKetQuaPhuongTrinhBac2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonTinhToanPhuongTrinhBac2;
        private System.Windows.Forms.NumericUpDown numericUpDownCPhuongTrinhBac2;
        private System.Windows.Forms.NumericUpDown numericUpDownBPhuongTrinhBac2;
        private System.Windows.Forms.NumericUpDown numericUpDownAPhuongTrinhBac2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}