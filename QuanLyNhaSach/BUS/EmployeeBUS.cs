using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhaSach.DAO;

namespace QuanLyNhaSach.BUS
{
    class EmployeeBUS
    {
        EmployeeDAO dao = new EmployeeDAO();

        public List<Employee> GetAll()
        {
            List<Employee> employees = dao.SelectAll();
            return employees;
        }

        public Employee GetDetail(string id)
        {
            Employee employee = dao.SelectById(id);
            return employee;
        }

        public List<Employee> SearchByKeyword(string keyword)
        {
            List<Employee> employees = dao.SelectByKeyWord(keyword);
            return employees;
        }

        public bool InsertEmployee(Employee employee)
        {
            bool result = dao.Insert(employee);
            return result;
        }

        public bool UpdateEmployee(Employee employee)
        {
            bool result = dao.Update(employee);
            return result;
        }

        public bool DeleteEmployee(string id)
        {
            bool result = dao.Delete(id);
            return result;
        }
    }
}
