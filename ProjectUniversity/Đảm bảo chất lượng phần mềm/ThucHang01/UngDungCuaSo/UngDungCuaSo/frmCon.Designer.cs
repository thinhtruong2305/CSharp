
namespace UngDungCuaSo
{
    partial class frmCon
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
            this.labelX = new System.Windows.Forms.Label();
            this.labelExp = new System.Windows.Forms.Label();
            this.labelSin = new System.Windows.Forms.Label();
            this.labelCos = new System.Windows.Forms.Label();
            this.buttonTinhToan = new System.Windows.Forms.Button();
            this.buttonDong = new System.Windows.Forms.Button();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxExp = new System.Windows.Forms.TextBox();
            this.textBoxSin = new System.Windows.Forms.TextBox();
            this.textBoxCos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(12, 29);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(17, 13);
            this.labelX.TabIndex = 0;
            this.labelX.Text = "X:";
            // 
            // labelExp
            // 
            this.labelExp.AutoSize = true;
            this.labelExp.Location = new System.Drawing.Point(12, 71);
            this.labelExp.Name = "labelExp";
            this.labelExp.Size = new System.Drawing.Size(40, 13);
            this.labelExp.TabIndex = 1;
            this.labelExp.Text = "exp(X):";
            // 
            // labelSin
            // 
            this.labelSin.AutoSize = true;
            this.labelSin.Location = new System.Drawing.Point(12, 125);
            this.labelSin.Name = "labelSin";
            this.labelSin.Size = new System.Drawing.Size(36, 13);
            this.labelSin.TabIndex = 2;
            this.labelSin.Text = "sin(X):";
            // 
            // labelCos
            // 
            this.labelCos.AutoSize = true;
            this.labelCos.Location = new System.Drawing.Point(12, 168);
            this.labelCos.Name = "labelCos";
            this.labelCos.Size = new System.Drawing.Size(40, 13);
            this.labelCos.TabIndex = 3;
            this.labelCos.Text = "cos(X):";
            // 
            // buttonTinhToan
            // 
            this.buttonTinhToan.Enabled = false;
            this.buttonTinhToan.Location = new System.Drawing.Point(15, 229);
            this.buttonTinhToan.Name = "buttonTinhToan";
            this.buttonTinhToan.Size = new System.Drawing.Size(75, 23);
            this.buttonTinhToan.TabIndex = 4;
            this.buttonTinhToan.Text = "Tính toán";
            this.buttonTinhToan.UseVisualStyleBackColor = true;
            this.buttonTinhToan.Click += new System.EventHandler(this.buttonTinhToan_Click);
            // 
            // buttonDong
            // 
            this.buttonDong.Location = new System.Drawing.Point(195, 229);
            this.buttonDong.Name = "buttonDong";
            this.buttonDong.Size = new System.Drawing.Size(75, 23);
            this.buttonDong.TabIndex = 5;
            this.buttonDong.Text = "Đóng";
            this.buttonDong.UseVisualStyleBackColor = true;
            this.buttonDong.Click += new System.EventHandler(this.buttonDong_Click);
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(84, 26);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(151, 20);
            this.textBoxX.TabIndex = 6;
            this.textBoxX.TextChanged += new System.EventHandler(this.textBoxX_TextChanged);
            // 
            // textBoxExp
            // 
            this.textBoxExp.Enabled = false;
            this.textBoxExp.Location = new System.Drawing.Point(84, 68);
            this.textBoxExp.Name = "textBoxExp";
            this.textBoxExp.Size = new System.Drawing.Size(151, 20);
            this.textBoxExp.TabIndex = 7;
            // 
            // textBoxSin
            // 
            this.textBoxSin.Enabled = false;
            this.textBoxSin.Location = new System.Drawing.Point(84, 122);
            this.textBoxSin.Name = "textBoxSin";
            this.textBoxSin.Size = new System.Drawing.Size(151, 20);
            this.textBoxSin.TabIndex = 8;
            // 
            // textBoxCos
            // 
            this.textBoxCos.Enabled = false;
            this.textBoxCos.Location = new System.Drawing.Point(84, 165);
            this.textBoxCos.Name = "textBoxCos";
            this.textBoxCos.Size = new System.Drawing.Size(151, 20);
            this.textBoxCos.TabIndex = 9;
            // 
            // frmCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 288);
            this.Controls.Add(this.textBoxCos);
            this.Controls.Add(this.textBoxSin);
            this.Controls.Add(this.textBoxExp);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.buttonDong);
            this.Controls.Add(this.buttonTinhToan);
            this.Controls.Add(this.labelCos);
            this.Controls.Add(this.labelSin);
            this.Controls.Add(this.labelExp);
            this.Controls.Add(this.labelX);
            this.Name = "frmCon";
            this.Text = "Form Con";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelExp;
        private System.Windows.Forms.Label labelSin;
        private System.Windows.Forms.Label labelCos;
        private System.Windows.Forms.Button buttonTinhToan;
        private System.Windows.Forms.Button buttonDong;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxExp;
        private System.Windows.Forms.TextBox textBoxSin;
        private System.Windows.Forms.TextBox textBoxCos;
    }
}