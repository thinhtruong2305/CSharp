
namespace WinformCoBan
{
    partial class FormCheckBoxAndRadioButton
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
            this.checkBoxItalic = new System.Windows.Forms.CheckBox();
            this.checkBoxBlod = new System.Windows.Forms.CheckBox();
            this.labelShow = new System.Windows.Forms.Label();
            this.groupBoxRadioButton = new System.Windows.Forms.GroupBox();
            this.radioButtonRED = new System.Windows.Forms.RadioButton();
            this.radioButtonGreen = new System.Windows.Forms.RadioButton();
            this.groupBoxRadioButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxItalic
            // 
            this.checkBoxItalic.AutoSize = true;
            this.checkBoxItalic.Location = new System.Drawing.Point(138, 144);
            this.checkBoxItalic.Name = "checkBoxItalic";
            this.checkBoxItalic.Size = new System.Drawing.Size(48, 17);
            this.checkBoxItalic.TabIndex = 0;
            this.checkBoxItalic.Text = "Italic";
            this.checkBoxItalic.UseVisualStyleBackColor = true;
            this.checkBoxItalic.CheckedChanged += new System.EventHandler(this.checkBoxItalic_CheckedChanged);
            // 
            // checkBoxBlod
            // 
            this.checkBoxBlod.AutoSize = true;
            this.checkBoxBlod.Location = new System.Drawing.Point(505, 144);
            this.checkBoxBlod.Name = "checkBoxBlod";
            this.checkBoxBlod.Size = new System.Drawing.Size(47, 17);
            this.checkBoxBlod.TabIndex = 1;
            this.checkBoxBlod.Text = "Bold";
            this.checkBoxBlod.UseVisualStyleBackColor = true;
            this.checkBoxBlod.CheckedChanged += new System.EventHandler(this.checkBoxBlod_CheckedChanged);
            // 
            // labelShow
            // 
            this.labelShow.AutoSize = true;
            this.labelShow.Location = new System.Drawing.Point(322, 67);
            this.labelShow.Name = "labelShow";
            this.labelShow.Size = new System.Drawing.Size(127, 13);
            this.labelShow.TabIndex = 2;
            this.labelShow.Text = "Bạn tuyệt lắm Đừng từ bỏ";
            // 
            // groupBoxRadioButton
            // 
            this.groupBoxRadioButton.Controls.Add(this.radioButtonGreen);
            this.groupBoxRadioButton.Controls.Add(this.radioButtonRED);
            this.groupBoxRadioButton.Location = new System.Drawing.Point(116, 203);
            this.groupBoxRadioButton.Name = "groupBoxRadioButton";
            this.groupBoxRadioButton.Size = new System.Drawing.Size(486, 34);
            this.groupBoxRadioButton.TabIndex = 3;
            this.groupBoxRadioButton.TabStop = false;
            // 
            // radioButtonRED
            // 
            this.radioButtonRED.AutoSize = true;
            this.radioButtonRED.ForeColor = System.Drawing.Color.Red;
            this.radioButtonRED.Location = new System.Drawing.Point(22, 11);
            this.radioButtonRED.Name = "radioButtonRED";
            this.radioButtonRED.Size = new System.Drawing.Size(48, 17);
            this.radioButtonRED.TabIndex = 0;
            this.radioButtonRED.TabStop = true;
            this.radioButtonRED.Text = "RED";
            this.radioButtonRED.UseVisualStyleBackColor = true;
            this.radioButtonRED.CheckedChanged += new System.EventHandler(this.radioButtonRED_CheckedChanged);
            // 
            // radioButtonGreen
            // 
            this.radioButtonGreen.AutoSize = true;
            this.radioButtonGreen.ForeColor = System.Drawing.Color.Lime;
            this.radioButtonGreen.Location = new System.Drawing.Point(389, 11);
            this.radioButtonGreen.Name = "radioButtonGreen";
            this.radioButtonGreen.Size = new System.Drawing.Size(63, 17);
            this.radioButtonGreen.TabIndex = 1;
            this.radioButtonGreen.TabStop = true;
            this.radioButtonGreen.Text = "GREEN";
            this.radioButtonGreen.UseVisualStyleBackColor = true;
            this.radioButtonGreen.CheckedChanged += new System.EventHandler(this.radioButtonGreen_CheckedChanged);
            // 
            // FormCheckBoxAndRadioButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxRadioButton);
            this.Controls.Add(this.labelShow);
            this.Controls.Add(this.checkBoxBlod);
            this.Controls.Add(this.checkBoxItalic);
            this.Name = "FormCheckBoxAndRadioButton";
            this.Text = "FormCheckBoxAndRadioButton";
            this.groupBoxRadioButton.ResumeLayout(false);
            this.groupBoxRadioButton.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxItalic;
        private System.Windows.Forms.CheckBox checkBoxBlod;
        private System.Windows.Forms.Label labelShow;
        private System.Windows.Forms.GroupBox groupBoxRadioButton;
        private System.Windows.Forms.RadioButton radioButtonGreen;
        private System.Windows.Forms.RadioButton radioButtonRED;
    }
}