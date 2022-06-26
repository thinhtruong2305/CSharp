
namespace CandyBugWinformDemo.UI
{
    partial class FormCategory
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
            this.labelCategory = new System.Windows.Forms.Label();
            this.txtCategory = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnCancelCategory = new System.Windows.Forms.Button();
            this.btnSaveCategory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.ForeColor = System.Drawing.Color.Black;
            this.labelCategory.Location = new System.Drawing.Point(159, 53);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(118, 29);
            this.labelCategory.TabIndex = 9;
            this.labelCategory.Text = "Category";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(318, 48);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(215, 39);
            this.txtCategory.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtCategory.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtCategory.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCategory.StateCommon.Border.Rounding = 18;
            this.txtCategory.TabIndex = 10;
            this.txtCategory.TextChanged += new System.EventHandler(this.txtCategory_TextChanged);
            // 
            // btnCancelCategory
            // 
            this.btnCancelCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelCategory.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCancelCategory.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelCategory.Location = new System.Drawing.Point(472, 146);
            this.btnCancelCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelCategory.Name = "btnCancelCategory";
            this.btnCancelCategory.Size = new System.Drawing.Size(120, 50);
            this.btnCancelCategory.TabIndex = 11;
            this.btnCancelCategory.Text = "Cancel";
            this.btnCancelCategory.UseVisualStyleBackColor = false;
            this.btnCancelCategory.Click += new System.EventHandler(this.btnCancelCategory_Click);
            // 
            // btnSaveCategory
            // 
            this.btnSaveCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSaveCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCategory.Location = new System.Drawing.Point(184, 146);
            this.btnSaveCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveCategory.Name = "btnSaveCategory";
            this.btnSaveCategory.Size = new System.Drawing.Size(120, 50);
            this.btnSaveCategory.TabIndex = 12;
            this.btnSaveCategory.Text = "Save";
            this.btnSaveCategory.UseVisualStyleBackColor = false;
            this.btnSaveCategory.Click += new System.EventHandler(this.btnSaveCategory_Click);
            // 
            // FormCategory
            // 
            this.AcceptButton = this.btnSaveCategory;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.CancelButton = this.btnCancelCategory;
            this.ClientSize = new System.Drawing.Size(795, 240);
            this.Controls.Add(this.btnCancelCategory);
            this.Controls.Add(this.btnSaveCategory);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.txtCategory);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCategory";
            this.Load += new System.EventHandler(this.FormNhapKhiChonOthersCuaCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCategory;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCategory;
        private System.Windows.Forms.Button btnCancelCategory;
        private System.Windows.Forms.Button btnSaveCategory;
    }
}