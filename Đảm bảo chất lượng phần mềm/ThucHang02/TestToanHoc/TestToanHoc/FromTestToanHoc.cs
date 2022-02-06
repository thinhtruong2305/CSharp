using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToanHoc;

namespace TestToanHoc
{
    public partial class FromTestToanHoc : Form
    {
        public FromTestToanHoc()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Phần này trả lời phần test điểm 3D trong word là dùng để trả lời câu 20 - 22
        /// </summary>
        private void testDiem3D()
        {
            Diem3D A = new Diem3D(1, 2, 3);
            Diem3D B = new Diem3D(-2, 5, 10);
            Diem3D C = new Diem3D(6, 11, 2);
            Diem3D D = new Diem3D(12, 3, -8);
            Diem3D I = Diem3D.TrungDiem(A, B);
            Diem3D G = Diem3D.TrongTam(A, B, C);
            Diem3D TTTD = Diem3D.TrongTam(new Diem3D[] { A, B, C, D });

            Console.WriteLine("{0}{1}", "A", A);
            Console.WriteLine("{0}{1}", "B", B);
            Console.WriteLine("{0}{1}", "C", C);
            Console.WriteLine("{0}{1}", "D", D);
            Console.WriteLine("{0}{1}", "I", I);
            Console.WriteLine("{0}{1}", "G", I);
            Console.WriteLine("{0}{1}", "TTTD", TTTD);

            // Các điểm tự tính lại một cách trực tiếp
            Diem3D I1 = new Diem3D((A.x + B.x) / 2, (A.y + B.y) / 2, (A.z + B.z) / 2);
            Diem3D G1 = new Diem3D((A.x + B.x + C.x) / 3, (A.y + B.y + C.y) / 3, (A.z + B.z + C.z) / 3);
            Diem3D TTTD1 = new Diem3D((A.x + B.x + C.x + D.x) / 4, (A.y + B.y + C.y + D.y) / 4, (A.z + B.z + C.z + D.z) / 4);

            // Các kiểm tra kết quả
            string s = "";
            if (I.Equals(I1))
                s += "Trung điểm I của AB tính đúng\n";
            else
                s += "Trung điểm I của AB tính sai\n";
            if (G.Equals(G1))
                s += "Điểm trọng tâm G của tam giác ABC tính đúng\n";
            else
                s += "Điểm trọng tâm G của tam giác ABC tính sai\n";
            if (TTTD.Equals(TTTD1))
                s += "Điểm trọng tâm tứ diện ABCD tính đúng\n";
            else
                s += "Điểm trọng tâm tứ diện ABCD tính sai\n";

            MessageBox.Show(s, this.Text);
        }

        private void testTamGiac()
        {
            Diem3D A = Diem3D.DiemNgauNhien();
            Diem3D B = Diem3D.DiemNgauNhien();
            Diem3D C = Diem3D.DiemNgauNhien();

            //Phần này để kiểm tra thông báo sai câu 40
            //Diem3D C = B;

            Console.WriteLine("{0}{1}", "A", A);
            Console.WriteLine("{0}{1}", "B", B);
            Console.WriteLine("{0}{1}", "C", C);

            string s = "";
            if (TamGiac.isTamGiac(A, B, C))
            {
                s += "ABC là tam giác\n";
                TamGiac ABC = new TamGiac(A, B, C);
                double AB = ABC.AB();
                double BC = ABC.BC();
                double AC = ABC.AC();
                double CV = ABC.ChuVi();
                double DT = ABC.DienTich();

                s += string.Format("AB={0}\n", AB);
                s += string.Format("BC={0}\n", BC);
                s += string.Format("AC={0}\n", AC);
                s += string.Format("Chu vi={0}\n", CV);
                s += string.Format("Diện tích={0}\n", DT);

                // Tính toán lại trực tiếp
                double AB1 = Diem3D.KhoangCach(A, B);
                double BC1 = Diem3D.KhoangCach(B, C);
                double AC1 = Diem3D.KhoangCach(A, C);

                double CV1 = AB1 + BC1 + AC1;
                double p1 = CV1 / 2;
                double DT1 = Math.Sqrt(p1 * (p1 - AB1) * (p1 - BC1) * (p1 - AC1));

                // So sánh kết quả
                s += "Tính AB " + ((AB == AB1) ? "đúng" : "sai") + "\n";
                s += "Tính BC " + ((BC == BC1) ? "đúng" : "sai") + "\n";
                s += "Tính AC " + ((AC == AC1) ? "đúng" : "sai") + "\n";
                s += "Tính chu vi tam giác ABC " + ((CV == CV1) ? "đúng" : "sai") + "\n";
                s += "Tính diện tích tam giác ABC " + ((DT == DT1) ? "đúng" : "sai") + "\n";
            }
            else
                s += "ABC không là tam giác";

            MessageBox.Show(s, this.Text);
        }

        private void testVector()
        {
            Diem3D A = Diem3D.DiemNgauNhien();
            Diem3D B = Diem3D.DiemNgauNhien();
            Diem3D C = Diem3D.DiemNgauNhien();
            Diem3D D = Diem3D.DiemNgauNhien();
            Diem3D O = new Diem3D();

            Vector3D OA = new Vector3D(A);
            Vector3D OB = new Vector3D(B);
            Vector3D AB = new Vector3D(A, B);
            Vector3D AC = new Vector3D(A, C);
            Vector3D AD = new Vector3D(A, D);

            // Các kết quả từ lớp Vector
            double moduleOA = OA.Module();
            double moduleOB = OB.Module();
            double moduleAB = AB.Module();
            double moduleAC = AC.Module();
            double moduleAD = AD.Module();

            double TVH_AB_AC = Vector3D.TichVoHuong(AB, AC);
            Vector3D TCH_AB_AC = Vector3D.TichCoHuong(AB, AC);
            double THT_AB_AC_AD = Vector3D.TichHonTap(AB, AC, AD);

            // Các tính toán trực tiếp
            double TVH_AB_AC_1 = AB.x * AC.x + AB.y * AC.y + AB.z * AC.z;
            Vector3D TCH_AB_AC_1 = new Vector3D(Vector3D.DinhThuc(AB.y, AB.z, AC.y, AC.z), Vector3D.DinhThuc(AB.z, AB.x, AC.z, AC.x), Vector3D.DinhThuc(AB.x, AB.y, AC.x, AC.y));
            double THT_AB_AC_AD_1 = TCH_AB_AC_1.x * AD.x + TCH_AB_AC_1.y * AD.y + TCH_AB_AC_1.z * AD.z;

            // So sánh kết quả
            string s = "";
            s += "Tính module OA " + ((moduleOA == Diem3D.KhoangCach(O, A)) ? "đúng" : "sai") + "\n";
            s += "Tính module OB " + ((moduleOB == Diem3D.KhoangCach(O, B)) ? "đúng" : "sai") + "\n";
            s += "Tính module AB " + ((moduleAB == Diem3D.KhoangCach(A, B)) ? "đúng" : "sai") + "\n";
            s += "Tính module AC " + ((moduleAC == Diem3D.KhoangCach(A, C)) ? "đúng" : "sai") + "\n";
            s += "Tính module AD " + ((moduleAD == Diem3D.KhoangCach(A, D)) ? "đúng" : "sai") + "\n";

            s += "Tính tích vô hướng AB.AC " + ((TVH_AB_AC == TVH_AB_AC_1) ? "đúng" : "sai") + "\n";
            s += "Tính tích có hướng [AB,AC] " + ((TCH_AB_AC == TCH_AB_AC_1) ? "đúng" : "sai") + "\n";
            s += "Tính tích hỗn tạp [AB, AC].AD " + ((THT_AB_AC_AD == THT_AB_AC_AD_1) ? "đúng" : "sai") + "\n";

            MessageBox.Show(s, this.Text);
        }

        private void buttonTestDiem3D_Click(object sender, EventArgs e)
        {
            testDiem3D();
        }

        private void buttonTestTamGiac_Click(object sender, EventArgs e)
        {
            testTamGiac();
        }

        private void buttonTestVector_Click(object sender, EventArgs e)
        {
            testVector();
        }
    }
}
