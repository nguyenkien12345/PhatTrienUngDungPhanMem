using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DAO
{
    class EmployeeDAO
    {
        QLNSDataContext db = new QLNSDataContext();

        public List<Employee> SelectAll()
        {
            List<Employee> employees = db.Employees.ToList();
            return employees;
        }

        public Employee SelectById(string id)
        {
            Employee employee = db.Employees.Where(x => x.Id == id).FirstOrDefault();
            return employee;
        }

        public List<Employee> SelectByKeyWord(string keyword)
        {
            List<Employee> employees = db.Employees.Where(x => x.Name.ToLower().Contains(keyword.ToLower())).ToList();
            return employees;
        }

        public bool Insert(Employee newEmployee)
        {
            if (newEmployee != null)
            {
                try
                {
                    db.Employees.InsertOnSubmit(newEmployee);
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

        public bool Update(Employee newEmployee)
        {
            Employee employee = db.Employees.Where(x => x.Id == newEmployee.Id).FirstOrDefault();
            if (employee != null)
            {
                try
                {
                    employee.Name = newEmployee.Name;
                    employee.Age = newEmployee.Age;
                    employee.Gender = newEmployee.Gender;
                    employee.Dob = newEmployee.Dob;
                    employee.Address = newEmployee.Address;
                    employee.Phone = newEmployee.Phone;
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
            Employee employee = db.Employees.Where(x => x.Id == id).FirstOrDefault();
            if (employee != null)
            {
                try
                {
                    db.Employees.DeleteOnSubmit(employee);
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
