using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace DeAnThapHaNoi
{
    public partial class UserControlThapHaNoi : UserControl
    {
        const int CellHeight = 20;
        const int UnitWidth = 10;
        private Stack<int> ds;
        private ArrayList Points = new ArrayList();

        public UserControlThapHaNoi()
        {
            InitializeComponent();
            ds = new Stack<int>();
        }

        private void DrawShape(Graphics g, Rectangle shape)
        {
            Pen DrawingPen = new Pen(Color.Blue, 2);
            g.DrawRectangle(DrawingPen, shape);
        }
        public void XoaSach()
        {
            Points.Clear();
            ds.Clear();
            this.Refresh();
        }
        public void Them(int a)
        {
            //Thêm vào stack ngăn xếp
            ds.Push(a);

            //Tạo khối dựa trên chiều rộng và chiều cao của userControl (Chủ thể) và số lượng khối đã tạo
            Rectangle Point = new Rectangle((this.Width - UnitWidth * a) / 2, this.Height - ds.Count * CellHeight, UnitWidth * a, CellHeight);
            
            //Thêm vào danh sách ArrapList
            Points.Add(Point);

            //Khai báo Graphic
            Graphics g = this.CreateGraphics();
            
            //Vẽ hình
            DrawShape(g, Point);
            g.Dispose();
        }
        public void Bot()
        {
            if (ds.Count > 0)
            {
                int a = ds.Pop();
                Points.RemoveAt(ds.Count);
                this.Refresh();
            }
        }

        private void UserControlThapHaNoi_Paint(object sender, PaintEventArgs e)
        {
            Pen DrawingPen = new Pen(Color.Blue, 2);
            foreach (Rectangle Point in Points)
                e.Graphics.DrawRectangle(DrawingPen, Point);

            Application.DoEvents();
        }
    }
}
