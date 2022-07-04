
namespace PetShopWinform.Forms
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
            this.dataGridViewCategory = new System.Windows.Forms.DataGridView();
            this.labelTenKho = new System.Windows.Forms.Label();
            this.textBoxTenKho = new System.Windows.Forms.TextBox();
            this.textBoxMaKho = new System.Windows.Forms.TextBox();
            this.labelMaKho = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCategory
            // 
            this.dataGridViewCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategory.Location = new System.Drawing.Point(273, 193);
            this.dataGridViewCategory.Name = "dataGridViewCategory";
            this.dataGridViewCategory.Size = new System.Drawing.Size(323, 246);
            this.dataGridViewCategory.TabIndex = 0;
            this.dataGridViewCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCategory_CellClick);
            // 
            // labelTenKho
            // 
            this.labelTenKho.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTenKho.AutoSize = true;
            this.labelTenKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenKho.Location = new System.Drawing.Point(86, 38);
            this.labelTenKho.Name = "labelTenKho";
            this.labelTenKho.Size = new System.Drawing.Size(51, 20);
            this.labelTenKho.TabIndex = 1;
            this.labelTenKho.Text = "Name";
            // 
            // textBoxTenKho
            // 
            this.textBoxTenKho.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxTenKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenKho.Location = new System.Drawing.Point(162, 35);
            this.textBoxTenKho.Name = "textBoxTenKho";
            this.textBoxTenKho.Size = new System.Drawing.Size(153, 26);
            this.textBoxTenKho.TabIndex = 2;
            // 
            // textBoxMaKho
            // 
            this.textBoxMaKho.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxMaKho.Enabled = false;
            this.textBoxMaKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaKho.Location = new System.Drawing.Point(617, 35);
            this.textBoxMaKho.Name = "textBoxMaKho";
            this.textBoxMaKho.Size = new System.Drawing.Size(123, 26);
            this.textBoxMaKho.TabIndex = 4;
            // 
            // labelMaKho
            // 
            this.labelMaKho.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelMaKho.AutoSize = true;
            this.labelMaKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaKho.Location = new System.Drawing.Point(546, 38);
            this.labelMaKho.Name = "labelMaKho";
            this.labelMaKho.Size = new System.Drawing.Size(23, 20);
            this.labelMaKho.TabIndex = 3;
            this.labelMaKho.Text = "Id";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(177, 136);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(98, 37);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(389, 136);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(98, 37);
            this.buttonEdit.TabIndex = 6;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(600, 136);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(98, 37);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // FormCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 474);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxMaKho);
            this.Controls.Add(this.labelMaKho);
            this.Controls.Add(this.textBoxTenKho);
            this.Controls.Add(this.labelTenKho);
            this.Controls.Add(this.dataGridViewCategory);
            this.Name = "FormCategory";
            this.Text = "Category";
            this.Load += new System.EventHandler(this.FormCategory_Load);
            this.SizeChanged += new System.EventHandler(this.FormCategory_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCategory;
        private System.Windows.Forms.Label labelTenKho;
        private System.Windows.Forms.TextBox textBoxTenKho;
        private System.Windows.Forms.TextBox textBoxMaKho;
        private System.Windows.Forms.Label labelMaKho;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
    }
}