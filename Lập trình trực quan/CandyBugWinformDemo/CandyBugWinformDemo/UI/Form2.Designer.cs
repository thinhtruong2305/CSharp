
namespace CandyBugWinformDemo
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnAdmin = new FontAwesome.Sharp.IconButton();
            this.btnStatistical = new FontAwesome.Sharp.IconButton();
            this.btnProduct = new FontAwesome.Sharp.IconButton();
            this.btnOrder = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.lblTittleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.DarkOrange;
            this.panelMenu.Controls.Add(this.btnAdmin);
            this.panelMenu.Controls.Add(this.btnStatistical);
            this.panelMenu.Controls.Add(this.btnProduct);
            this.panelMenu.Controls.Add(this.btnOrder);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(224, 642);
            this.panelMenu.TabIndex = 0;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.btnAdmin.IconColor = System.Drawing.Color.White;
            this.btnAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Location = new System.Drawing.Point(0, 320);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAdmin.Size = new System.Drawing.Size(224, 61);
            this.btnAdmin.TabIndex = 6;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnStatistical
            // 
            this.btnStatistical.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStatistical.FlatAppearance.BorderSize = 0;
            this.btnStatistical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistical.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistical.IconChar = FontAwesome.Sharp.IconChar.Sellcast;
            this.btnStatistical.IconColor = System.Drawing.Color.White;
            this.btnStatistical.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStatistical.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistical.Location = new System.Drawing.Point(0, 259);
            this.btnStatistical.Name = "btnStatistical";
            this.btnStatistical.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnStatistical.Size = new System.Drawing.Size(224, 61);
            this.btnStatistical.TabIndex = 5;
            this.btnStatistical.Text = "Statistical";
            this.btnStatistical.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistical.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStatistical.UseVisualStyleBackColor = true;
            this.btnStatistical.Click += new System.EventHandler(this.btnMarketing_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            this.btnProduct.IconColor = System.Drawing.Color.White;
            this.btnProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(0, 201);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnProduct.Size = new System.Drawing.Size(224, 58);
            this.btnProduct.TabIndex = 3;
            this.btnProduct.Text = "Product";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnOrder.IconColor = System.Drawing.Color.White;
            this.btnOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.Location = new System.Drawing.Point(0, 140);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnOrder.Size = new System.Drawing.Size(224, 61);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "Order";
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 140);
            this.panel1.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(22, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(167, 140);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblTittleChildForm
            // 
            this.lblTittleChildForm.AutoSize = true;
            this.lblTittleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittleChildForm.Location = new System.Drawing.Point(56, 25);
            this.lblTittleChildForm.Name = "lblTittleChildForm";
            this.lblTittleChildForm.Size = new System.Drawing.Size(62, 24);
            this.lblTittleChildForm.TabIndex = 3;
            this.lblTittleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.DarkOrange;
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.Yellow;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.Yellow;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(18, 21);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 2;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.AutoSize = true;
            this.panelDesktop.BackColor = System.Drawing.Color.White;
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(224, 75);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1012, 567);
            this.panelDesktop.TabIndex = 3;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(119, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(803, 537);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.Common.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.Common.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.Common.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.Common.StateCommon.Border.Rounding = 16;
            this.kryptonPalette1.Common.StateCommon.Border.Width = 0;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.DarkOrange;
            this.panelTitleBar.Controls.Add(this.lblTittleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(224, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1012, 75);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1236, 642);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form2";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnAdmin;
        private FontAwesome.Sharp.IconButton btnStatistical;
        private FontAwesome.Sharp.IconButton btnProduct;
        private FontAwesome.Sharp.IconButton btnOrder;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Label lblTittleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel panelDesktop;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}