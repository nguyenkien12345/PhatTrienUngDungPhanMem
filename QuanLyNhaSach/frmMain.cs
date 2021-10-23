using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class frnMain : Form
    {
        public frnMain()
        {
            InitializeComponent();
        }

        Library library = new Library();

        private void frnMain_Load(object sender, EventArgs e)
        {
            lblDate.Text = library.changeDate(DateTime.Now.DayOfWeek.ToString()) + " " + DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = "Bây giờ là: " + DateTime.Now.Hour.ToString() + " : " + DateTime.Now.Minute.ToString() + " : " + DateTime.Now.Second.ToString();
        }

        private void mnuCategoryProduct_Click(object sender, EventArgs e)
        {
            frmCategory frm = new frmCategory();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuHangHoa_Click(object sender, EventArgs e)
        {
            frmProduct frm = new frmProduct();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            frmEmployee frm = new frmEmployee();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            frmCustomer frm = new frmCustomer();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình không ?", "Thoát chương trình !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Thoát chương trình thành công !");
                Application.Exit();
            }
        }

        private void mnuTimDMHangHoa_Click(object sender, EventArgs e)
        {
            frmSearchCategory frm = new frmSearchCategory();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuTimHangHoa_Click(object sender, EventArgs e)
        {
            frmSearchProduct frm = new frmSearchProduct();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuTimKhachHang_Click(object sender, EventArgs e)
        {
            frmSearchCustomer frm = new frmSearchCustomer();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuTimNhanVien_Click(object sender, EventArgs e)
        {
            frmSearchEmpoyee frm = new frmSearchEmpoyee();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
