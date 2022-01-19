
namespace UngDungCuaSo
{
    partial class frmChinh
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
            this.btnThucThi = new System.Windows.Forms.Button();
            this.buttonGoiFormCon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnThucThi
            // 
            this.btnThucThi.Location = new System.Drawing.Point(151, 29);
            this.btnThucThi.Name = "btnThucThi";
            this.btnThucThi.Size = new System.Drawing.Size(75, 23);
            this.btnThucThi.TabIndex = 0;
            this.btnThucThi.Text = "Thực thi";
            this.btnThucThi.UseVisualStyleBackColor = true;
            this.btnThucThi.Click += new System.EventHandler(this.btnThucThi_Click);
            // 
            // buttonGoiFormCon
            // 
            this.buttonGoiFormCon.Location = new System.Drawing.Point(138, 75);
            this.buttonGoiFormCon.Name = "buttonGoiFormCon";
            this.buttonGoiFormCon.Size = new System.Drawing.Size(101, 23);
            this.buttonGoiFormCon.TabIndex = 1;
            this.buttonGoiFormCon.Text = "Gọi Form Con";
            this.buttonGoiFormCon.UseVisualStyleBackColor = true;
            this.buttonGoiFormCon.Click += new System.EventHandler(this.buttonGoiFormCon_Click);
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 123);
            this.Controls.Add(this.buttonGoiFormCon);
            this.Controls.Add(this.btnThucThi);
            this.Name = "frmChinh";
            this.Text = "Form Chính";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThucThi;
        private System.Windows.Forms.Button buttonGoiFormCon;
    }
}

