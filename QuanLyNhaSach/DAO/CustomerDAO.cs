using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DAO
{
    class CustomerDAO
    {
        QLNSDataContext db = new QLNSDataContext();

        public List<Customer> SelectAll()
        {
            List<Customer> customers = db.Customers.ToList();
            return customers;
        }

        public Customer SelectById(string id)
        {
            Customer customer = db.Customers.Where(x => x.Id == id).FirstOrDefault();
            return customer;
        }

        public List<Customer> SelectByKeyWord(string keyword)
        {
            List<Customer> customers = db.Customers.Where(x => x.Name.ToLower().Contains(keyword.ToLower())).ToList();
            return customers;
        }

        public bool Insert(Customer newCustomer)
        {
            if(newCustomer != null)
            {
                try
                {
                    db.Customers.InsertOnSubmit(newCustomer);
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

        public bool Update(Customer newCustomer)
        {
            Customer customer = db.Customers.Where(x => x.Id == newCustomer.Id).FirstOrDefault();
            if(customer != null)
            {
                try
                {
                    customer.Name = newCustomer.Name;
                    customer.Age = newCustomer.Age;
                    customer.Gender = newCustomer.Gender;
                    customer.Dob = newCustomer.Dob;
                    customer.Address = newCustomer.Address;
                    customer.Phone = newCustomer.Phone;
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
            Customer customer = db.Customers.Where(x => x.Id == id).FirstOrDefault();
            if(customer != null)
            {
                try
                {
                    db.Customers.DeleteOnSubmit(customer);
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
