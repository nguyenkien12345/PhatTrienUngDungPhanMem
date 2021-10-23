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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        CustomerBUS bus = new CustomerBUS();

        List<Customer> listCustomer = null;

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            ShowList();
        }

        public void ShowList()
        {
            listCustomer = bus.GetAll();
            dgvCustomer.DataSource = listCustomer;
            FormatDisplay();
        }

        public void FormatDisplay()
        {
            // Định dạng tên cột hiển thị
            dgvCustomer.Columns["Id"].HeaderText = "Mã";
            dgvCustomer.Columns["Name"].HeaderText = "Họ và tên";
            dgvCustomer.Columns["Gender"].HeaderText = "Giới tính";
            dgvCustomer.Columns["Age"].HeaderText = "Tuổi";
            dgvCustomer.Columns["Dob"].HeaderText = "Ngày sinh";
            dgvCustomer.Columns["Address"].HeaderText = "Địa chỉ";
            dgvCustomer.Columns["Phone"].HeaderText = "SĐT";

            // Định dạng độ rộng cột
            dgvCustomer.Columns["Id"].Width = 80;
            dgvCustomer.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCustomer.Columns["Gender"].Width = 100;
            dgvCustomer.Columns["Age"].Width = 60;
            dgvCustomer.Columns["Dob"].Width = 100;
            dgvCustomer.Columns["Address"].Width = 180;
            dgvCustomer.Columns["Phone"].Width = 100;

            // Định dạng căn chỉnh cột
            dgvCustomer.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvCustomer.Columns["Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvCustomer.Columns["Gender"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvCustomer.Columns["Age"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvCustomer.Columns["Dob"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvCustomer.Columns["Address"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvCustomer.Columns["Phone"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            
            // Không cho phép người dùng thêm, sửa trực tiếp trên datagridView
            dgvCustomer.AllowUserToAddRows = false;
            dgvCustomer.EditMode = DataGridViewEditMode.EditProgrammatically;

            txtMaKH.Enabled = false;
            btnSaveKH.Enabled = false;
            btnRefreshKH.Enabled = false;
        }

        private void dgvCustomer_Click(object sender, EventArgs e)
        {
            if(btnAddKH.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới", "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                txtMaKH.Focus();
                return;
            }
            if(dgvCustomer.Rows.Count == 0)
            {
                MessageBox.Show("Dữ liệu trống. Vui lòng thêm dữ liệu !", "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                return;
            }
            txtMaKH.Text = dgvCustomer.CurrentRow.Cells["Id"].Value.ToString();
            txtHoTenKH.Text = dgvCustomer.CurrentRow.Cells["Name"].Value.ToString();
            txtTuoiKH.Text = dgvCustomer.CurrentRow.Cells["Age"].Value.ToString();
            txtDiaChiKH.Text = dgvCustomer.CurrentRow.Cells["Address"].Value.ToString();
            if (dgvCustomer.CurrentRow.Cells["Gender"].Value.ToString() == "False") 
            {
                cboGenderKH.Text = "Nữ";
            }
            else
            {
                cboGenderKH.Text = "Nam";
            }
            dtpDobKH.Value = (DateTime)dgvCustomer.CurrentRow.Cells["Dob"].Value;
            mtbSdtKH.Text = dgvCustomer.CurrentRow.Cells["Phone"].Value.ToString();
            btnUpdateKH.Enabled = true;
            btnDeleteKH.Enabled = true;
            btnRefreshKH.Enabled = true;
        }

        private void RefreshData()
        {
            txtMaKH.Focus();
            txtMaKH.Clear();
            txtHoTenKH.Clear();
            txtTuoiKH.Clear();
            txtDiaChiKH.Clear();
            cboGenderKH.SelectedIndex = 0;
            dtpDobKH.Value = DateTime.Now;
            mtbSdtKH.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmCustomer_Load(sender, e);
        }

        private void btnCloseKH_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đóng form không ?", "Đóng Form !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnRefreshKH_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnAddKH_Click(object sender, EventArgs e)
        {
            btnUpdateKH.Enabled = false;
            btnDeleteKH.Enabled = false;
            btnAddKH.Enabled = false;
            btnRefreshKH.Enabled = true;
            btnSaveKH.Enabled = true;
            txtMaKH.Enabled = true;
            RefreshData();
        }

        private void btnSaveKH_Click(object sender, EventArgs e)
        {
            string id = "";
            if (txtMaKH.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKH.Focus();
                return;
            }
            else if (txtMaKH.Text.Trim().Length < 4 || txtMaKH.Text.Trim().Length > 255)
            {
                MessageBox.Show("Độ dài tối thiểu của mã khách hàng là 4 và tối đa là 255", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKH.Focus();
                return;
            }
            else
            {
                id = txtMaKH.Text.Trim();
            };

            string name = "";
            if (txtHoTenKH.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập họ và tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTenKH.Focus();
                return;
            }
            else if (txtHoTenKH.Text.Trim().Length < 6 || txtHoTenKH.Text.Trim().Length > 255)
            {
                MessageBox.Show("Độ dài tối thiểu của họ và tên khách hàng là 6 và tối đa là 255", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTenKH.Focus();
                return;
            }
            else
            {
                name = txtHoTenKH.Text.Trim();
            };

            int age = 0;
            if (txtTuoiKH.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tuổi khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTuoiKH.Focus();
                return;
            }
            else if (int.Parse(txtTuoiKH.Text.Trim()) <= 0)
            {
                MessageBox.Show("Tuổi của khách hàng phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTuoiKH.Focus();
                return;
            }
            else
            {
                age = int.Parse(txtTuoiKH.Text.Trim());
            };

            string address = "";
            if (txtDiaChiKH.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChiKH.Focus();
                return;
            }
            else if (txtDiaChiKH.Text.Trim().Length < 6 || txtDiaChiKH.Text.Trim().Length > 255)
            {
                MessageBox.Show("Độ dài tối thiểu của địa chỉ khách hàng là 6 và tối đa là 255", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChiKH.Focus();
                return;
            }
            else
            {
                address = txtDiaChiKH.Text.Trim();
            };

            bool gender = false;
            if (cboGenderKH.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn giới tính phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboGenderKH.Focus();
                return;
            }
            else
            {
                if (cboGenderKH.Text.Trim() == "Nữ")
                {
                    gender = false;
                }
                else
                {
                    gender = true;
                };
            }

            DateTime dob = DateTime.Now;
            if (dtpDobKH.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Ngày sinh phải nhỏ hơn hoặc bằng ngày hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDobKH.Focus();
                return;
            }
            else
            {
                dob = dtpDobKH.Value;
            }

            int phone = 0;
            if (mtbSdtKH.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbSdtKH.Focus();
                return;
            }
            else
            {
                phone = int.Parse(mtbSdtKH.Text.Trim());
            };

            if (bus.GetDetail(id) != null)
            {
                MessageBox.Show("Mã KH này đã tồn tại. Vui lòng nhập mã khách hàng khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Customer customer = new Customer();
                customer.Id = id;
                customer.Name = name;
                customer.Age = age;
                customer.Dob = dob;
                customer.Gender = gender;
                customer.Address = address;
                customer.Phone = phone;

                try
                {
                    bool result = bus.InsertCustomer(customer);
                    if (result)
                    {
                        MessageBox.Show("Thêm khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        RefreshData();
                        frmCustomer_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Thêm khách hàng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    btnUpdateKH.Enabled = true;
                    btnAddKH.Enabled = true;
                    btnDeleteKH.Enabled = true;
                    btnRefreshKH.Enabled = false;
                    btnSaveKH.Enabled = false;
                    txtMaKH.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnUpdateKH_Click(object sender, EventArgs e)
        {
            string name = "";
            if (txtHoTenKH.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập họ và tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTenKH.Focus();
                return;
            }
            else if (txtHoTenKH.Text.Trim().Length < 6 || txtHoTenKH.Text.Trim().Length > 255)
            {
                MessageBox.Show("Độ dài tối thiểu của họ và tên khách hàng là 6 và tối đa là 255", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTenKH.Focus();
                return;
            }
            else
            {
                name = txtHoTenKH.Text.Trim();
            };

            int age = 0;
            if (txtTuoiKH.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tuổi khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTuoiKH.Focus();
                return;
            }
            else if (int.Parse(txtTuoiKH.Text.Trim()) <= 0)
            {
                MessageBox.Show("Tuổi của khách hàng phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTuoiKH.Focus();
                return;
            }
            else
            {
                age = int.Parse(txtTuoiKH.Text.Trim());
            };

            string address = "";
            if (txtDiaChiKH.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChiKH.Focus();
                return;
            }
            else if (txtDiaChiKH.Text.Trim().Length < 6 || txtDiaChiKH.Text.Trim().Length > 255)
            {
                MessageBox.Show("Độ dài tối thiểu của địa chỉ khách hàng là 6 và tối đa là 255", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChiKH.Focus();
                return;
            }
            else
            {
                address = txtDiaChiKH.Text.Trim();
            };

            bool gender = false;
            if (cboGenderKH.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn giới tính phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboGenderKH.Focus();
                return;
            }
            else
            {
                if (cboGenderKH.Text.Trim() == "Nữ")
                {
                    gender = false;
                }
                else
                {
                    gender = true;
                };
            }

            DateTime dob = DateTime.Now;
            if (dtpDobKH.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Ngày sinh phải nhỏ hơn hoặc bằng ngày hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDobKH.Focus();
                return;
            }
            else
            {
                dob = dtpDobKH.Value;
            }

            int phone = 0;
            if (mtbSdtKH.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbSdtKH.Focus();
                return;
            }
            else
            {
                phone = int.Parse(mtbSdtKH.Text.Trim());
            };

            string id = dgvCustomer.CurrentRow.Cells["Id"].Value.ToString();
            
            Customer customer = bus.GetDetail(id);
            
            if(customer != null)
            {
                customer.Name = name;
                customer.Age = age;
                customer.Gender = gender;
                customer.Address = address;
                customer.Dob = dob;
                customer.Phone = phone;

                try
                {
                    DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn cập nhật khách hàng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.Yes)
                    {
                        bool result = bus.UpdateCustomer(customer);
                        if (result)
                        {
                            MessageBox.Show("Cập nhật khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            RefreshData();
                            frmCustomer_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật khách hàng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnDeleteKH_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dgvCustomer.CurrentRow.Cells["Id"].Value.ToString();
                DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xoá khách hàng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(confirm == DialogResult.Yes)
                {
                    bool result = bus.DeleteCustomer(id);
                    if (result)
                    {
                        MessageBox.Show("Xoá khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        RefreshData();
                        frmCustomer_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Xoá khách hàng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtMaKH_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtHoTenKH_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtTuoiKH_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtDiaChiKH_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void cboGenderKH_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void dtpDobKH_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void mtbSdtKH_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
