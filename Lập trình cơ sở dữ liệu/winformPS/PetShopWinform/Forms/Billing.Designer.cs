
namespace PetShopWinform.Forms
{
    partial class Billing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnPrintBill = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnSa = new System.Windows.Forms.Button();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.btnD = new System.Windows.Forms.Button();
            this.lbtotal1 = new System.Windows.Forms.Label();
            this.lbtotal = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.PriceUp = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.dgvCurrentOrder = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabProduct = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtNameCus = new System.Windows.Forms.TextBox();
            this.cbCustom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdAcc = new System.Windows.Forms.TextBox();
            this.txtNameAcc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbCate = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtIdPro = new System.Windows.Forms.TextBox();
            this.txtPro = new System.Windows.Forms.TextBox();
            this.btnAcept = new System.Windows.Forms.Button();
            this.lbtal = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentOrder)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabProduct.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 69);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(50, 69);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.Size = new System.Drawing.Size(88, 33);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPrintBill
            // 
            this.btnPrintBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrintBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintBill.Location = new System.Drawing.Point(19, 564);
            this.btnPrintBill.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrintBill.Name = "btnPrintBill";
            this.btnPrintBill.Size = new System.Drawing.Size(344, 41);
            this.btnPrintBill.TabIndex = 4;
            this.btnPrintBill.Text = "PRINT BILL";
            this.btnPrintBill.UseVisualStyleBackColor = false;
            this.btnPrintBill.Click += new System.EventHandler(this.btnPrintBill_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Location = new System.Drawing.Point(19, 519);
            this.btnClearAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(106, 41);
            this.btnClearAll.TabIndex = 4;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // panel13
            // 
            this.panel13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel13.BackColor = System.Drawing.Color.Black;
            this.panel13.Location = new System.Drawing.Point(3, 31);
            this.panel13.Margin = new System.Windows.Forms.Padding(2);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(300, 1);
            this.panel13.TabIndex = 1;
            // 
            // btnSa
            // 
            this.btnSa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSa.Location = new System.Drawing.Point(257, 519);
            this.btnSa.Margin = new System.Windows.Forms.Padding(2);
            this.btnSa.Name = "btnSa";
            this.btnSa.Size = new System.Drawing.Size(106, 41);
            this.btnSa.TabIndex = 4;
            this.btnSa.Text = "Save";
            this.btnSa.UseVisualStyleBackColor = false;
            this.btnSa.Click += new System.EventHandler(this.btnSa_Click);
            // 
            // lbDiscount
            // 
            this.lbDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiscount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbDiscount.Location = new System.Drawing.Point(257, 9);
            this.lbDiscount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(34, 20);
            this.lbDiscount.TabIndex = 0;
            this.lbDiscount.Text = "0.0";
            // 
            // btnD
            // 
            this.btnD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnD.BackColor = System.Drawing.Color.Transparent;
            this.btnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD.Location = new System.Drawing.Point(138, 519);
            this.btnD.Margin = new System.Windows.Forms.Padding(2);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(106, 41);
            this.btnD.TabIndex = 4;
            this.btnD.Text = "Delete";
            this.btnD.UseVisualStyleBackColor = false;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // lbtotal1
            // 
            this.lbtotal1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbtotal1.AutoSize = true;
            this.lbtotal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtotal1.ForeColor = System.Drawing.Color.Black;
            this.lbtotal1.Location = new System.Drawing.Point(256, 41);
            this.lbtotal1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbtotal1.Name = "lbtotal1";
            this.lbtotal1.Size = new System.Drawing.Size(45, 26);
            this.lbtotal1.TabIndex = 0;
            this.lbtotal1.Text = "0.0";
            // 
            // lbtotal
            // 
            this.lbtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbtotal.AutoSize = true;
            this.lbtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtotal.ForeColor = System.Drawing.Color.Black;
            this.lbtotal.Location = new System.Drawing.Point(0, 41);
            this.lbtotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbtotal.Name = "lbtotal";
            this.lbtotal.Size = new System.Drawing.Size(64, 26);
            this.lbtotal.TabIndex = 0;
            this.lbtotal.Text = "Total";
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label24.Location = new System.Drawing.Point(0, 9);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(80, 20);
            this.label24.TabIndex = 0;
            this.label24.Text = "Discount";
            // 
            // PriceUp
            // 
            this.PriceUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PriceUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceUp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PriceUp.Location = new System.Drawing.Point(212, 69);
            this.PriceUp.Margin = new System.Windows.Forms.Padding(2);
            this.PriceUp.Name = "PriceUp";
            this.PriceUp.Size = new System.Drawing.Size(61, 26);
            this.PriceUp.TabIndex = 9;
            this.PriceUp.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PriceUp.ValueChanged += new System.EventHandler(this.PriceUp_ValueChanged);
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(121, 9);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(139, 24);
            this.label21.TabIndex = 7;
            this.label21.Text = "Current Order";
            // 
            // dgvCurrentOrder
            // 
            this.dgvCurrentOrder.AllowUserToAddRows = false;
            this.dgvCurrentOrder.AllowUserToDeleteRows = false;
            this.dgvCurrentOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCurrentOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCurrentOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCurrentOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCurrentOrder.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCurrentOrder.Location = new System.Drawing.Point(19, 109);
            this.dgvCurrentOrder.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCurrentOrder.Name = "dgvCurrentOrder";
            this.dgvCurrentOrder.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCurrentOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCurrentOrder.RowHeadersWidth = 51;
            this.dgvCurrentOrder.RowTemplate.Height = 24;
            this.dgvCurrentOrder.Size = new System.Drawing.Size(344, 319);
            this.dgvCurrentOrder.TabIndex = 10;
            this.dgvCurrentOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCurrentOrder_CellClick);
            this.dgvCurrentOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCurrentOrder_CellClick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lbDiscount);
            this.panel2.Controls.Add(this.lbtotal1);
            this.panel2.Controls.Add(this.lbtotal);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.panel13);
            this.panel2.Location = new System.Drawing.Point(19, 437);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(344, 78);
            this.panel2.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.tabProduct);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 609);
            this.panel1.TabIndex = 12;
            // 
            // tabProduct
            // 
            this.tabProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabProduct.Controls.Add(this.tabPage1);
            this.tabProduct.Location = new System.Drawing.Point(8, 228);
            this.tabProduct.Margin = new System.Windows.Forms.Padding(2);
            this.tabProduct.Name = "tabProduct";
            this.tabProduct.SelectedIndex = 0;
            this.tabProduct.Size = new System.Drawing.Size(584, 377);
            this.tabProduct.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(576, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(10, 9);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(418, 212);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtAddress);
            this.panel4.Controls.Add(this.txtPhone);
            this.panel4.Controls.Add(this.txtNameCus);
            this.panel4.Controls.Add(this.cbCustom);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(211, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(193, 189);
            this.panel4.TabIndex = 22;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtAddress.Enabled = false;
            this.txtAddress.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.Red;
            this.txtAddress.Location = new System.Drawing.Point(77, 127);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(113, 59);
            this.txtAddress.TabIndex = 18;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtPhone.Enabled = false;
            this.txtPhone.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.Color.Red;
            this.txtPhone.Location = new System.Drawing.Point(77, 100);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(113, 21);
            this.txtPhone.TabIndex = 18;
            // 
            // txtNameCus
            // 
            this.txtNameCus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtNameCus.Enabled = false;
            this.txtNameCus.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameCus.ForeColor = System.Drawing.Color.Red;
            this.txtNameCus.Location = new System.Drawing.Point(63, 66);
            this.txtNameCus.Multiline = true;
            this.txtNameCus.Name = "txtNameCus";
            this.txtNameCus.ReadOnly = true;
            this.txtNameCus.Size = new System.Drawing.Size(127, 28);
            this.txtNameCus.TabIndex = 18;
            // 
            // cbCustom
            // 
            this.cbCustom.FormattingEnabled = true;
            this.cbCustom.Location = new System.Drawing.Point(92, 39);
            this.cbCustom.Name = "cbCustom";
            this.cbCustom.Size = new System.Drawing.Size(98, 21);
            this.cbCustom.TabIndex = 17;
            this.cbCustom.TextChanged += new System.EventHandler(this.cbCustom_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(46, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Customer";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(10, 38);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Id";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(10, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(10, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Phone:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(10, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Address:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.txtRole);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.txtIdAcc);
            this.panel5.Controls.Add(this.txtNameAcc);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Location = new System.Drawing.Point(12, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(193, 189);
            this.panel5.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(46, 2);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "Employee";
            // 
            // txtRole
            // 
            this.txtRole.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtRole.Enabled = false;
            this.txtRole.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRole.ForeColor = System.Drawing.Color.Red;
            this.txtRole.Location = new System.Drawing.Point(82, 99);
            this.txtRole.Multiline = true;
            this.txtRole.Name = "txtRole";
            this.txtRole.ReadOnly = true;
            this.txtRole.Size = new System.Drawing.Size(108, 21);
            this.txtRole.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(10, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Role:";
            // 
            // txtIdAcc
            // 
            this.txtIdAcc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtIdAcc.Enabled = false;
            this.txtIdAcc.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdAcc.ForeColor = System.Drawing.Color.Red;
            this.txtIdAcc.Location = new System.Drawing.Point(63, 38);
            this.txtIdAcc.Multiline = true;
            this.txtIdAcc.Name = "txtIdAcc";
            this.txtIdAcc.ReadOnly = true;
            this.txtIdAcc.Size = new System.Drawing.Size(34, 23);
            this.txtIdAcc.TabIndex = 18;
            // 
            // txtNameAcc
            // 
            this.txtNameAcc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtNameAcc.Enabled = false;
            this.txtNameAcc.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameAcc.ForeColor = System.Drawing.Color.Red;
            this.txtNameAcc.Location = new System.Drawing.Point(63, 65);
            this.txtNameAcc.Multiline = true;
            this.txtNameAcc.Name = "txtNameAcc";
            this.txtNameAcc.ReadOnly = true;
            this.txtNameAcc.Size = new System.Drawing.Size(127, 28);
            this.txtNameAcc.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(10, 66);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Name:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(10, 38);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "Id:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.Controls.Add(this.cbCate);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Controls.Add(this.txtSearch);
            this.panel6.Location = new System.Drawing.Point(433, 109);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(155, 114);
            this.panel6.TabIndex = 14;
            // 
            // cbCate
            // 
            this.cbCate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCate.FormattingEnabled = true;
            this.cbCate.Location = new System.Drawing.Point(13, 31);
            this.cbCate.Margin = new System.Windows.Forms.Padding(2);
            this.cbCate.Name = "cbCate";
            this.cbCate.Size = new System.Drawing.Size(128, 34);
            this.cbCate.TabIndex = 9;
            this.cbCate.TextChanged += new System.EventHandler(this.cbCate_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(17, 5);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Category";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gainsboro;
            this.panel7.Controls.Add(this.btnClearAll);
            this.panel7.Controls.Add(this.dgvCurrentOrder);
            this.panel7.Controls.Add(this.panel2);
            this.panel7.Controls.Add(this.btnPrintBill);
            this.panel7.Controls.Add(this.txtPrice);
            this.panel7.Controls.Add(this.txtIdPro);
            this.panel7.Controls.Add(this.txtPro);
            this.panel7.Controls.Add(this.btnD);
            this.panel7.Controls.Add(this.PriceUp);
            this.panel7.Controls.Add(this.btnAcept);
            this.panel7.Controls.Add(this.btnSa);
            this.panel7.Controls.Add(this.lbtal);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.label21);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(602, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(384, 609);
            this.panel7.TabIndex = 13;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtPrice.Enabled = false;
            this.txtPrice.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.Red;
            this.txtPrice.Location = new System.Drawing.Point(135, 69);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(72, 26);
            this.txtPrice.TabIndex = 18;
            // 
            // txtIdPro
            // 
            this.txtIdPro.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtIdPro.Enabled = false;
            this.txtIdPro.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPro.ForeColor = System.Drawing.Color.Red;
            this.txtIdPro.Location = new System.Drawing.Point(3, 69);
            this.txtIdPro.Multiline = true;
            this.txtIdPro.Name = "txtIdPro";
            this.txtIdPro.ReadOnly = true;
            this.txtIdPro.Size = new System.Drawing.Size(39, 26);
            this.txtIdPro.TabIndex = 18;
            this.txtIdPro.Visible = false;
            // 
            // txtPro
            // 
            this.txtPro.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtPro.Enabled = false;
            this.txtPro.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPro.ForeColor = System.Drawing.Color.Red;
            this.txtPro.Location = new System.Drawing.Point(24, 55);
            this.txtPro.Multiline = true;
            this.txtPro.Name = "txtPro";
            this.txtPro.ReadOnly = true;
            this.txtPro.Size = new System.Drawing.Size(106, 40);
            this.txtPro.TabIndex = 18;
            // 
            // btnAcept
            // 
            this.btnAcept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAcept.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcept.Location = new System.Drawing.Point(285, 36);
            this.btnAcept.Margin = new System.Windows.Forms.Padding(2);
            this.btnAcept.Name = "btnAcept";
            this.btnAcept.Size = new System.Drawing.Size(78, 31);
            this.btnAcept.TabIndex = 4;
            this.btnAcept.Text = "Accept";
            this.btnAcept.UseVisualStyleBackColor = false;
            this.btnAcept.Click += new System.EventHandler(this.btnAcept_Click);
            // 
            // lbtal
            // 
            this.lbtal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbtal.AutoSize = true;
            this.lbtal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtal.ForeColor = System.Drawing.Color.Red;
            this.lbtal.Location = new System.Drawing.Point(294, 74);
            this.lbtal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbtal.Name = "lbtal";
            this.lbtal.Size = new System.Drawing.Size(43, 16);
            this.lbtal.TabIndex = 7;
            this.lbtal.Text = "Total";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(209, 51);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 16);
            this.label12.TabIndex = 7;
            this.label12.Text = "Quantity";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(135, 51);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 16);
            this.label13.TabIndex = 7;
            this.label13.Text = "Price";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(23, 36);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "Product";
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(986, 609);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel7);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Billing";
            this.Text = "Billing";
            this.Load += new System.EventHandler(this.Billing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentOrder)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabProduct.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnPrintBill;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label lbtotal;
        private System.Windows.Forms.Button btnSa;
        private System.Windows.Forms.Label lbtotal1;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.NumericUpDown PriceUp;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView dgvCurrentOrder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabProduct;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtNameCus;
        private System.Windows.Forms.ComboBox cbCustom;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.TextBox txtNameAcc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cbCate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtPro;
        private System.Windows.Forms.Button btnAcept;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIdAcc;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lbtal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtIdPro;
    }
}