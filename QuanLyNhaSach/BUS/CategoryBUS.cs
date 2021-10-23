using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhaSach.DAO;

namespace QuanLyNhaSach.BUS
{
    class CategoryBUS
    {
        CategoryDAO dao = new CategoryDAO();

        public List<Category> GetAll()
        {
            List<Category> categories = dao.SelectAll();
            return categories;
        }

        public Category GetDetail(int id)
        {
            Category category = dao.SelectById(id);
            return category;
        }

        public List<Category> SearchByKeyword(string keyword)
        {
            List<Category> categories = dao.SelectByKeyWord(keyword);
            return categories;
        }

        public bool InsertCategory(Category category)
        {
            bool result = dao.Insert(category);
            return result;
        }

        public bool UpdateCategory(Category category)
        {
            bool result = dao.Update(category);
            return result;
        }

        public bool DeleteCategory(int id)
        {
            bool result = dao.Delete(id);
            return result;
        }
    }
}
