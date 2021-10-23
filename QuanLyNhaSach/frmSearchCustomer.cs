using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaSach.BUS;

namespace QuanLyNhaSach
{
    public partial class frmSearchCustomer : Form
    {

        CustomerBUS bus = new CustomerBUS();
        List<Customer> listCustomer = null;

        public frmSearchCustomer()
        {
            InitializeComponent();
        }

        private void frmSearchCustomer_Load(object sender, EventArgs e)
        {
            listCustomer = bus.GetAll();
            ShowList();
        }

        private void ShowList()
        {
            lvSearchCustomer.Items.Clear();
            listCustomer.ForEach(x =>
            {
                ListViewItem lvi = new ListViewItem(x.Id);
                lvi.SubItems.Add(x.Name);
                if(x.Gender == false)
                {
                    lvi.SubItems.Add("Nữ");
                }
                else
                {
                    lvi.SubItems.Add("Nam");
                };
                lvi.SubItems.Add(x.Age.ToString());
                lvi.SubItems.Add(x.Dob.ToString());
                lvi.SubItems.Add(x.Phone.ToString());
                lvSearchCustomer.Items.Add(lvi);
            });
        }

        private void RefreshData()
        {
            txtName.Clear();
            txtName.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtName.Text.Trim();
            listCustomer = bus.SearchByKeyword(keyword);
            RefreshData();
            ShowList();
        }
    }
}
