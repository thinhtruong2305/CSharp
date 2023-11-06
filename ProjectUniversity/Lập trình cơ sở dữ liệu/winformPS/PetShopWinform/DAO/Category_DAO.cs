using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShopWinform.Model;

namespace PetShopWinform.DAO
{
    class Category_DAO
    {
        private PetshopWinformEntities DBPetShop;

        public Category_DAO() { DBPetShop = new PetshopWinformEntities(); }
        
        public dynamic getDanhSachCategory()
        {
            var danhSach = DBPetShop.Categories.Select(c => new
            {
                c.Id,
                c.Name
            }).ToList();
            return danhSach;
        }

        public void addCategory(Category category)
        {
            DBPetShop.Categories.Add(category);
            DBPetShop.SaveChanges();
        }

        public void editCategory(Category category)
        {
            var categoryFind = findCategory(category);

            categoryFind.Name = category.Name;
            DBPetShop.SaveChanges();
        }

        public void deleteCategory(Category category)
        {
            var categoryFind = findCategory(category);

            var product = DBPetShop.Products.Where(c => c.Category1.Id == categoryFind.Id).ToList();

            foreach(var itemProduct in product)
            {
                var orderInfo = DBPetShop.OrderInfoes.Where(h => h.IdProduct == itemProduct.Id).ToList();

                foreach(var itemOrderInfo in orderInfo)
                {
                    var order = DBPetShop.Oders.Where(u => u.Id == itemOrderInfo.IdOrder).ToList();

                    foreach(var itemOrder in order)
                    {
                        DBPetShop.Oders.Remove(itemOrder);
                        DBPetShop.SaveChanges();
                    }

                    DBPetShop.OrderInfoes.Remove(itemOrderInfo);
                    DBPetShop.SaveChanges();
                }
                DBPetShop.Products.Remove(itemProduct);
                DBPetShop.SaveChanges();
            }

            DBPetShop.Categories.Remove(categoryFind);
            DBPetShop.SaveChanges();
        }

        public Category findCategory(Category category)
        {
            var categoryFind = DBPetShop.Categories.Find(category.Id);
            return categoryFind;
        }
    }
}
