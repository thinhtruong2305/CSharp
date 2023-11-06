using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShopWinform.DAO;
using System.Windows.Forms;
using PetShopWinform.Model;

namespace PetShopWinform.BUS
{
    class Category_BUS
    {
        private Category_DAO category_DAO;

        public Category_BUS() { category_DAO = new Category_DAO(); }

        public void truyenDanhSachCategory(DataGridView danhSach)
        {
            danhSach.DataSource = category_DAO.getDanhSachCategory();
        }

        public bool addCategory(Category category)
        {
            try
            {
                category_DAO.addCategory(category);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool editCategory(Category category)
        {
            if (!category_DAO.findCategory(category).Equals(null))
            {
                try
                {
                    category_DAO.editCategory(category);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool deleteCategory(Category category)
        {
            if (!category_DAO.findCategory(category).Equals(null))
            {
                try
                {
                    category_DAO.deleteCategory(category);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
