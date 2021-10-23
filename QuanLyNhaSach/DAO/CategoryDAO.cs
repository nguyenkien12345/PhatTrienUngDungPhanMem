using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DAO
{
    class CategoryDAO
    {
        QLNSDataContext db = new QLNSDataContext();

        public List<Category> SelectAll()
        {
            List<Category> categories = db.Categories.ToList();
            return categories;
        }

        public Category SelectById(int id)
        {
            Category category = db.Categories.Where(x => x.Id == id).FirstOrDefault();
            return category;
        }

        public List<Category> SelectByKeyWord(string keyword)
        {
            List<Category> categories = db.Categories.Where(x => x.Name.ToLower().Contains(keyword.ToLower())).ToList();
            return categories;
        }

        public bool Insert(Category newCategory)
        {
            if (newCategory != null)
            {
                try
                {
                    db.Categories.InsertOnSubmit(newCategory);
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

        public bool Update(Category newCategory)
        {
            Category category = db.Categories.Where(x => x.Id == newCategory.Id).FirstOrDefault();
            if (category != null)
            {
                try
                {
                    category.Name = newCategory.Name;
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

        public bool Delete(int id)
        {
            Category category = db.Categories.Where(x => x.Id == id).FirstOrDefault();
            if (category != null)
            {
                try
                {
                    db.Categories.DeleteOnSubmit(category);
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
