
namespace DeAnThapHaNoi
{
    partial class FormKetQua
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.labelSoBuocThucHien = new System.Windows.Forms.Label();
            this.numericUpDownSoBuocThucHien = new System.Windows.Forms.NumericUpDown();
            this.listBoxKetQua = new System.Windows.Forms.ListBox();
            this.panelTop.SuspendLayout();
            this.panelCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoBuocThucHien)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.numericUpDownSoBuocThucHien);
            this.panelTop.Controls.Add(this.labelSoBuocThucHien);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(273, 42);
            this.panelTop.TabIndex = 0;
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.listBoxKetQua);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(0, 42);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(273, 434);
            this.panelCenter.TabIndex = 1;
            // 
            // labelSoBuocThucHien
            // 
            this.labelSoBuocThucHien.AutoSize = true;
            this.labelSoBuocThucHien.Location = new System.Drawing.Point(12, 15);
            this.labelSoBuocThucHien.Name = "labelSoBuocThucHien";
            this.labelSoBuocThucHien.Size = new System.Drawing.Size(94, 13);
            this.labelSoBuocThucHien.TabIndex = 0;
            this.labelSoBuocThucHien.Text = "Số bước thực hiện";
            // 
            // numericUpDownSoBuocThucHien
            // 
            this.numericUpDownSoBuocThucHien.Location = new System.Drawing.Point(138, 13);
            this.numericUpDownSoBuocThucHien.Name = "numericUpDownSoBuocThucHien";
            this.numericUpDownSoBuocThucHien.Size = new System.Drawing.Size(88, 20);
            this.numericUpDownSoBuocThucHien.TabIndex = 1;
            // 
            // listBoxKetQua
            // 
            this.listBoxKetQua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxKetQua.FormattingEnabled = true;
            this.listBoxKetQua.Location = new System.Drawing.Point(0, 0);
            this.listBoxKetQua.Name = "listBoxKetQua";
            this.listBoxKetQua.Size = new System.Drawing.Size(273, 434);
            this.listBoxKetQua.TabIndex = 0;
            // 
            // FormKetQua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 476);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelTop);
            this.Name = "FormKetQua";
            this.Text = "FormKetQua";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoBuocThucHien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        public System.Windows.Forms.NumericUpDown numericUpDownSoBuocThucHien;
        private System.Windows.Forms.Label labelSoBuocThucHien;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.ListBox listBoxKetQua;
    }
}