
namespace DeAnMaTran
{
    partial class UserControlMaTranCap2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox00 = new System.Windows.Forms.TextBox();
            this.textBox01 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox00
            // 
            this.textBox00.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox00.Location = new System.Drawing.Point(7, 10);
            this.textBox00.Name = "textBox00";
            this.textBox00.Size = new System.Drawing.Size(95, 29);
            this.textBox00.TabIndex = 0;
            this.textBox00.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox01
            // 
            this.textBox01.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox01.Location = new System.Drawing.Point(110, 10);
            this.textBox01.Name = "textBox01";
            this.textBox01.Size = new System.Drawing.Size(95, 29);
            this.textBox01.TabIndex = 1;
            this.textBox01.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(7, 45);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(95, 29);
            this.textBox10.TabIndex = 2;
            this.textBox10.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(110, 45);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(95, 29);
            this.textBox11.TabIndex = 3;
            this.textBox11.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // UserControlMaTranCap2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox01);
            this.Controls.Add(this.textBox00);
            this.Name = "UserControlMaTranCap2";
            this.Size = new System.Drawing.Size(214, 83);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox00;
        private System.Windows.Forms.TextBox textBox01;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
    }
}
