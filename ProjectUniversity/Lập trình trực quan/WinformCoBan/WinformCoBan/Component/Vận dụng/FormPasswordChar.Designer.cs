
namespace WinformCoBan
{
    partial class FormPasswordChar
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
            this.textBoxPaswordChar = new System.Windows.Forms.TextBox();
            this.labelPasswordChar = new System.Windows.Forms.Label();
            this.labelShow = new System.Windows.Forms.Label();
            this.textBoxShow = new System.Windows.Forms.TextBox();
            this.buttonShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPaswordChar
            // 
            this.textBoxPaswordChar.Location = new System.Drawing.Point(285, 98);
            this.textBoxPaswordChar.Name = "textBoxPaswordChar";
            this.textBoxPaswordChar.PasswordChar = '~';
            this.textBoxPaswordChar.Size = new System.Drawing.Size(312, 20);
            this.textBoxPaswordChar.TabIndex = 0;
            // 
            // labelPasswordChar
            // 
            this.labelPasswordChar.AutoSize = true;
            this.labelPasswordChar.Location = new System.Drawing.Point(101, 101);
            this.labelPasswordChar.Name = "labelPasswordChar";
            this.labelPasswordChar.Size = new System.Drawing.Size(169, 13);
            this.labelPasswordChar.TabIndex = 1;
            this.labelPasswordChar.Text = "Viết điều bí mật của bạn vào đây:";
            // 
            // labelShow
            // 
            this.labelShow.AutoSize = true;
            this.labelShow.Location = new System.Drawing.Point(138, 172);
            this.labelShow.Name = "labelShow";
            this.labelShow.Size = new System.Drawing.Size(132, 13);
            this.labelShow.TabIndex = 2;
            this.labelShow.Text = "Chúng tôi sẽ trân trọng nó:";
            // 
            // textBoxShow
            // 
            this.textBoxShow.Location = new System.Drawing.Point(285, 169);
            this.textBoxShow.Name = "textBoxShow";
            this.textBoxShow.ReadOnly = true;
            this.textBoxShow.Size = new System.Drawing.Size(312, 20);
            this.textBoxShow.TabIndex = 3;
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(310, 254);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(75, 23);
            this.buttonShow.TabIndex = 4;
            this.buttonShow.Text = "Chia sẻ";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // FormPasswordChar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.textBoxShow);
            this.Controls.Add(this.labelShow);
            this.Controls.Add(this.labelPasswordChar);
            this.Controls.Add(this.textBoxPaswordChar);
            this.Name = "FormPasswordChar";
            this.Text = "FormPasswordChar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPaswordChar;
        private System.Windows.Forms.Label labelPasswordChar;
        private System.Windows.Forms.Label labelShow;
        private System.Windows.Forms.TextBox textBoxShow;
        private System.Windows.Forms.Button buttonShow;
    }
}