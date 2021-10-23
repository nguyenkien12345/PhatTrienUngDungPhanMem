using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DAO
{
    class ProductDAO
    {
        QLNSDataContext db = new QLNSDataContext();

        public List<Product> SelectAll()
        {
            List<Product> products = db.Products.ToList();
            return products;
        }

        public List<Category> SelectAllCategory()
        {
            List<Category> categories = db.Categories.ToList();
            return categories;
        }

        public Product SelectById(string id)
        {
            Product product = db.Products.Where(x => x.Id == id).FirstOrDefault();
            return product;
        }

        public List<Product> SelectProductsByCategoryID(Category category)
        {
            List<Product> products = db.Products.Where(x => x.CategoryId == category.Id).ToList();
            return products;
        }

        public List<Product> SelectByKeyWord(string keyword)
        {
            List<Product> products = db.Products.Where(x => x.Name.ToLower().Contains(keyword.ToLower())).ToList();
            return products;
        }

        public bool Insert(Product newProducts)
        {
            if (newProducts != null)
            {
                try
                {
                    db.Products.InsertOnSubmit(newProducts);
                    db.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool Update(Product newProducts)
        {
            Product product = db.Products.Where(x => x.Id == newProducts.Id).FirstOrDefault();
            if (product != null)
            {
                try
                {
                    product.Name = newProducts.Name;
                    product.Price = newProducts.Price;
                    product.Description = newProducts.Description;
                    product.Origin = newProducts.Origin;
                    product.Unit = newProducts.Unit;
                    product.CategoryId = newProducts.CategoryId;
                    db.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool Delete(string id)
        {
            Product product = db.Products.Where(x => x.Id == id).FirstOrDefault();
            if (product != null)
            {
                try
                {
                    db.Products.DeleteOnSubmit(product);
                    db.SubmitChanges();
                    return true;
                }
                catch
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
