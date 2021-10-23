using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhaSach.DAO;

namespace QuanLyNhaSach.BUS
{
    class CustomerBUS
    {
        CustomerDAO dao = new CustomerDAO();

        public List<Customer> GetAll()
        {
            List<Customer> customers = dao.SelectAll();
            return customers;
        }
    
        public Customer GetDetail(string id)
        {
            Customer customer = dao.SelectById(id);
            return customer;
        }
    
        public List<Customer> SearchByKeyword(string keyword)
        {
            List<Customer> customers = dao.SelectByKeyWord(keyword);
            return customers;
        }
    
        public bool InsertCustomer(Customer customer)
        {
            bool result = dao.Insert(customer);
            return result;
        }

        public bool UpdateCustomer(Customer customer)
        {
            bool result = dao.Update(customer);
            return result;
        }

        public bool DeleteCustomer(string id)
        {
            bool result = dao.Delete(id);
            return result;
        }
    }
}
