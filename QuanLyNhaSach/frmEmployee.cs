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
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        EmployeeBUS bus = new EmployeeBUS();

        List<Employee> listEmployee = null;

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            ShowList();
        }

        public void ShowList()
        {
            listEmployee = bus.GetAll();
            dgvEmployee.DataSource = listEmployee;
            FormatDisplay();
        }

        public void FormatDisplay()
        {
            // Định dạng tên cột hiển thị
            dgvEmployee.Columns["Id"].HeaderText = "Mã";
            dgvEmployee.Columns["Name"].HeaderText = "Họ và tên";
            dgvEmployee.Columns["Gender"].HeaderText = "Giới tính";
            dgvEmployee.Columns["Age"].HeaderText = "Tuổi";
            dgvEmployee.Columns["Dob"].HeaderText = "Ngày sinh";
            dgvEmployee.Columns["Address"].HeaderText = "Địa chỉ";
            dgvEmployee.Columns["Phone"].HeaderText = "SĐT";

            // Định dạng độ rộng cột
            dgvEmployee.Columns["Id"].Width = 80;
            dgvEmployee.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvEmployee.Columns["Gender"].Width = 100;
            dgvEmployee.Columns["Age"].Width = 60;
            dgvEmployee.Columns["Dob"].Width = 100;
            dgvEmployee.Columns["Address"].Width = 180;
            dgvEmployee.Columns["Phone"].Width = 100;

            // Định dạng căn chỉnh cột
            dgvEmployee.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvEmployee.Columns["Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvEmployee.Columns["Gender"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvEmployee.Columns["Age"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvEmployee.Columns["Dob"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvEmployee.Columns["Address"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvEmployee.Columns["Phone"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Không cho phép người dùng thêm, sửa trực tiếp trên datagridView
            dgvEmployee.AllowUserToAddRows = false;
            dgvEmployee.EditMode = DataGridViewEditMode.EditProgrammatically;

            txtMaNV.Enabled = false;
            btnSaveNV.Enabled = false;
            btnRefreshNV.Enabled = false;
        }

        private void dgvEmployee_Click(object sender, EventArgs e)
        {
            if (btnAddNV.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới", "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                return;
            }
            if (dgvEmployee.Rows.Count == 0)
            {
                MessageBox.Show("Dữ liệu trống. Vui lòng thêm dữ liệu !", "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                return;
            }
            txtMaNV.Text = dgvEmployee.CurrentRow.Cells["Id"].Value.ToString();
            txtHoTenNV.Text = dgvEmployee.CurrentRow.Cells["Name"].Value.ToString();
            txtTuoiNV.Text = dgvEmployee.CurrentRow.Cells["Age"].Value.ToString();
            txtDiaChiNV.Text = dgvEmployee.CurrentRow.Cells["Address"].Value.ToString();
            if (dgvEmployee.CurrentRow.Cells["Gender"].Value.ToString() == "False")
            {
                cboGenderNV.Text = "Nữ";
            }
            else
            {
                cboGenderNV.Text = "Nam";
            }
            dtpDobNV.Value = (DateTime)dgvEmployee.CurrentRow.Cells["Dob"].Value;
            mtbSdtNV.Text = dgvEmployee.CurrentRow.Cells["Phone"].Value.ToString();
            btnUpdateNV.Enabled = true;
            btnDeleteNV.Enabled = true;
            btnRefreshNV.Enabled = true;
        }

        private void RefreshData()
        {
            txtMaNV.Focus();
            txtMaNV.Clear();
            txtHoTenNV.Clear();
            txtTuoiNV.Clear();
            txtDiaChiNV.Clear();
            cboGenderNV.SelectedIndex = 0;
            dtpDobNV.Value = DateTime.Now;
            mtbSdtNV.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmEmployee_Load(sender, e);
        }

        private void btnCloseNV_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đóng form không ?", "Đóng Form !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnRefreshNV_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnAddNV_Click(object sender, EventArgs e)
        {
            btnUpdateNV.Enabled = false;
            btnDeleteNV.Enabled = false;
            btnAddNV.Enabled = false;
            btnRefreshNV.Enabled = true;
            btnSaveNV.Enabled = true;
            txtMaNV.Enabled = true;
            RefreshData();
        }

        private void btnSaveNV_Click(object sender, EventArgs e)
        {
            string id = "";
            if (txtMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                return;
            }
            else if (txtMaNV.Text.Trim().Length < 4 || txtMaNV.Text.Trim().Length > 255)
            {
                MessageBox.Show("Độ dài tối thiểu của mã nhân viên là 4 và tối đa là 255", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                return;
            }
            else
            {
                id = txtMaNV.Text.Trim();
            };

            string name = "";
            if (txtHoTenNV.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập họ và tên nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTenNV.Focus();
                return;
            }
            else if (txtHoTenNV.Text.Trim().Length < 6 || txtHoTenNV.Text.Trim().Length > 255)
            {
                MessageBox.Show("Độ dài tối thiểu của họ và tên nhân viên là 6 và tối đa là 255", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTenNV.Focus();
                return;
            }
            else
            {
                name = txtHoTenNV.Text.Trim();
            };

            int age = 0;
            if (txtTuoiNV.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tuổi nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTuoiNV.Focus();
                return;
            }
            else if (int.Parse(txtTuoiNV.Text.Trim()) <= 0)
            {
                MessageBox.Show("Tuổi của nhân viên phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTuoiNV.Focus();
                return;
            }
            else
            {
                age = int.Parse(txtTuoiNV.Text.Trim());
            };

            string address = "";
            if (txtDiaChiNV.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChiNV.Focus();
                return;
            }
            else if (txtDiaChiNV.Text.Trim().Length < 6 || txtDiaChiNV.Text.Trim().Length > 255)
            {
                MessageBox.Show("Độ dài tối thiểu của địa chỉ nhân viên là 6 và tối đa là 255", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChiNV.Focus();
                return;
            }
            else
            {
                address = txtDiaChiNV.Text.Trim();
            };

            bool gender = false;
            if (cboGenderNV.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn giới tính phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboGenderNV.Focus();
                return;
            }
            else
            {
                if (cboGenderNV.Text.Trim() == "Nữ")
                {
                    gender = false;
                }
                else
                {
                    gender = true;
                };
            }

            DateTime dob = DateTime.Now;
            if (dtpDobNV.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Ngày sinh phải nhỏ hơn hoặc bằng ngày hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDobNV.Focus();
                return;
            }
            else
            {
                dob = dtpDobNV.Value;
            }

            int phone = 0;
            if (mtbSdtNV.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbSdtNV.Focus();
                return;
            }
            else
            {
                phone = int.Parse(mtbSdtNV.Text.Trim());
            };

            if (bus.GetDetail(id) != null)
            {
                MessageBox.Show("Mã NV này đã tồn tại. Vui lòng nhập mã nhân viên khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Employee employee = new Employee();
                employee.Id = id;
                employee.Name = name;
                employee.Age = age;
                employee.Dob = dob;
                employee.Gender = gender;
                employee.Address = address;
                employee.Phone = phone;

                try
                {
                    bool result = bus.InsertEmployee(employee);
                    if (result)
                    {
                        MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        RefreshData();
                        frmEmployee_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Thêm nhân viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    btnUpdateNV.Enabled = true;
                    btnAddNV.Enabled = true;
                    btnDeleteNV.Enabled = true;
                    btnRefreshNV.Enabled = false;
                    btnSaveNV.Enabled = false;
                    txtMaNV.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnUpdateNV_Click(object sender, EventArgs e)
        {
            string name = "";
            if (txtHoTenNV.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập họ và tên nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTenNV.Focus();
                return;
            }
            else if (txtHoTenNV.Text.Trim().Length < 6 || txtHoTenNV.Text.Trim().Length > 255)
            {
                MessageBox.Show("Độ dài tối thiểu của họ và tên nhân viên là 6 và tối đa là 255", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTenNV.Focus();
                return;
            }
            else
            {
                name = txtHoTenNV.Text.Trim();
            };

            int age = 0;
            if (txtTuoiNV.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tuổi nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTuoiNV.Focus();
                return;
            }
            else if (int.Parse(txtTuoiNV.Text.Trim()) <= 0)
            {
                MessageBox.Show("Tuổi của nhân viên phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTuoiNV.Focus();
                return;
            }
            else
            {
                age = int.Parse(txtTuoiNV.Text.Trim());
            };

            string address = "";
            if (txtDiaChiNV.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChiNV.Focus();
                return;
            }
            else if (txtDiaChiNV.Text.Trim().Length < 6 || txtDiaChiNV.Text.Trim().Length > 255)
            {
                MessageBox.Show("Độ dài tối thiểu của địa chỉ nhân viên là 6 và tối đa là 255", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChiNV.Focus();
                return;
            }
            else
            {
                address = txtDiaChiNV.Text.Trim();
            };

            bool gender = false;
            if (cboGenderNV.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn giới tính phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboGenderNV.Focus();
                return;
            }
            else
            {
                if (cboGenderNV.Text.Trim() == "Nữ")
                {
                    gender = false;
                }
                else
                {
                    gender = true;
                };
            }

            DateTime dob = DateTime.Now;
            if (dtpDobNV.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Ngày sinh phải nhỏ hơn hoặc bằng ngày hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDobNV.Focus();
                return;
            }
            else
            {
                dob = dtpDobNV.Value;
            }

            int phone = 0;
            if (mtbSdtNV.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbSdtNV.Focus();
                return;
            }
            else
            {
                phone = int.Parse(mtbSdtNV.Text.Trim());
            };

            string id = dgvEmployee.CurrentRow.Cells["Id"].Value.ToString();
           
            Employee employee = bus.GetDetail(id);

            if (employee != null)
            {
                employee.Name = name;
                employee.Age = age;
                employee.Gender = gender;
                employee.Address = address;
                employee.Dob = dob;
                employee.Phone = phone;

                try
                {
                    DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn cập nhật nhân viên này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.Yes)
                    {
                        bool result = bus.UpdateEmployee(employee);
                        if (result)
                        {
                            MessageBox.Show("Cập nhật nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            RefreshData();
                            frmEmployee_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật nhân viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnDeleteNV_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dgvEmployee.CurrentRow.Cells["Id"].Value.ToString();
                DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xoá nhân viên này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    bool result = bus.DeleteEmployee(id);
                    if (result)
                    {
                        MessageBox.Show("Xoá nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        RefreshData();
                        frmEmployee_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Xoá nhân viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtMaNV_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtHoTenNV_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtTuoiNV_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtDiaChiNV_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void cboGenderNV_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void dtpDobNV_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void mtbSdtNV_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
