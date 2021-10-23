using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhaSach.DAO;

namespace QuanLyNhaSach.BUS
{
    class ProductBUS
    {
        ProductDAO dao = new ProductDAO();

        public List<Product> GetAll()
        {
            List<Product> products = dao.SelectAll();
            return products;
        }

        public List<Category> GetAllCategory()
        {
            List<Category> categories = dao.SelectAllCategory();
            return categories;
        }

        public Product GetDetail(string id)
        {
            Product product = dao.SelectById(id);
            return product;
        }

        public List<Product> GetProductsByCategoryID(Category category)
        {
            List<Product> products = dao.SelectProductsByCategoryID(category);
            return products;
        }

        public List<Product> SearchByKeyword(string keyword)
        {
            List<Product> products = dao.SelectByKeyWord(keyword);
            return products;
        }

        public bool InsertProduct(Product product)
        {
            bool result = dao.Insert(product);
            return result;
        }

        public bool UpdateProduct(Product product)
        {
            bool result = dao.Update(product);
            return result;
        }

        public bool DeleteProduct(string id)
        {
            bool result = dao.Delete(id);
            return result;
        }
    }
}
