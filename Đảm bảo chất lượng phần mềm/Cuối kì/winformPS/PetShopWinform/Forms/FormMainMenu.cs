using PetShopWinform.BUS;
using PetShopWinform.Forms;
using PetShopWinform.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetShopWinform.Model;
namespace PetShopWinform
{
    public partial class FormMainMenu : Form
    {

        #region Khai báo biến
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        private Account account;
        private PetshopWinformEntities DBPetShop = new PetshopWinformEntities();
        #endregion

        #region Các hàm tạo
        public FormMainMenu(Account account)
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
            this.account = account;
            lbUser.Text = account.DisplayName;
            PhanQuyen();
        }
        #endregion

        #region Các xử lý
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                }
            }
        }


        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {

            OpenChildForm(new Forms.Products(), sender);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {

            OpenChildForm(new Forms.Admin(), sender);
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Billing(account), sender);

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Statistical(), sender);
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {

            if (activeForm != null)
                activeForm.Close();
            Reset();

        }
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Customers(), sender);
        }

        private void buttonCategory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCategory(), sender);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Các phương thức
        void PhanQuyen()
        {
            if (account.Role == 0)
            {
                btnAdmin.Enabled = false;
                btnProducts.Enabled = false;
                btnDashboard.Enabled = false;
                buttonCategory.Enabled = false;
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }
        #endregion
    }
}
