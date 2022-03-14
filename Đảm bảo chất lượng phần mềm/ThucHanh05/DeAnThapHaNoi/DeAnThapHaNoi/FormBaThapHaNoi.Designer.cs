
namespace DeAnThapHaNoi
{
    partial class FormBaThapHaNoi
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.panelCenterRight = new System.Windows.Forms.Panel();
            this.numericUpDownDoCao = new System.Windows.Forms.NumericUpDown();
            this.panelCenterFill = new System.Windows.Forms.Panel();
            this.userControlBaThapHaNoi = new DeAnThapHaNoi.UserControlBaThapHaNoi();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.panelCenter.SuspendLayout();
            this.panelCenterRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDoCao)).BeginInit();
            this.panelCenterFill.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.labelTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(707, 70);
            this.panelTop.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Crimson;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(707, 70);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.panelCenterRight);
            this.panelCenter.Controls.Add(this.panelCenterFill);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(0, 70);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(707, 363);
            this.panelCenter.TabIndex = 1;
            // 
            // panelCenterRight
            // 
            this.panelCenterRight.Controls.Add(this.numericUpDownDoCao);
            this.panelCenterRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelCenterRight.Location = new System.Drawing.Point(499, 0);
            this.panelCenterRight.Name = "panelCenterRight";
            this.panelCenterRight.Size = new System.Drawing.Size(208, 363);
            this.panelCenterRight.TabIndex = 1;
            // 
            // numericUpDownDoCao
            // 
            this.numericUpDownDoCao.Enabled = false;
            this.numericUpDownDoCao.Location = new System.Drawing.Point(68, 28);
            this.numericUpDownDoCao.Name = "numericUpDownDoCao";
            this.numericUpDownDoCao.Size = new System.Drawing.Size(81, 20);
            this.numericUpDownDoCao.TabIndex = 0;
            // 
            // panelCenterFill
            // 
            this.panelCenterFill.Controls.Add(this.userControlBaThapHaNoi);
            this.panelCenterFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenterFill.Location = new System.Drawing.Point(0, 0);
            this.panelCenterFill.Name = "panelCenterFill";
            this.panelCenterFill.Size = new System.Drawing.Size(707, 363);
            this.panelCenterFill.TabIndex = 0;
            // 
            // userControlBaThapHaNoi
            // 
            this.userControlBaThapHaNoi.BackColor = System.Drawing.Color.Lime;
            this.userControlBaThapHaNoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlBaThapHaNoi.Location = new System.Drawing.Point(0, 0);
            this.userControlBaThapHaNoi.Name = "userControlBaThapHaNoi";
            this.userControlBaThapHaNoi.Size = new System.Drawing.Size(707, 363);
            this.userControlBaThapHaNoi.TabIndex = 0;
            // 
            // panelBottom
            // 
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 433);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(707, 43);
            this.panelBottom.TabIndex = 1;
            // 
            // FormBaThapHaNoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 476);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Name = "FormBaThapHaNoi";
            this.Text = "FormBaThapHaNoi";
            this.panelTop.ResumeLayout(false);
            this.panelCenter.ResumeLayout(false);
            this.panelCenterRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDoCao)).EndInit();
            this.panelCenterFill.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelCenterRight;
        private System.Windows.Forms.Panel panelCenterFill;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.NumericUpDown numericUpDownDoCao;
        private UserControlBaThapHaNoi userControlBaThapHaNoi;
    }
}