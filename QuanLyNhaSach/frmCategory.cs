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
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
        }

        CategoryBUS bus = new CategoryBUS();

        List<Category> listCategory = null;

        private void frmCategory_Load(object sender, EventArgs e)
        {
            ShowList();
        }

        public void ShowList()
        {
            listCategory = bus.GetAll();
            dgvCategory.DataSource = listCategory;
            FormatDisplay();
        }

        public void FormatDisplay()
        {
            // Định dạng tên cột hiển thị
            dgvCategory.Columns["Id"].HeaderText = "Mã";
            dgvCategory.Columns["Name"].HeaderText = "Danh mục";

            // Định dạng độ rộng cột
            dgvCategory.Columns["Id"].Width = 100;
            dgvCategory.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Định dạng căn chỉnh cột
            dgvCategory.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvCategory.Columns["Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;


            // Không cho phép người dùng thêm, sửa trực tiếp trên datagridView
            dgvCategory.AllowUserToAddRows = false;
            dgvCategory.EditMode = DataGridViewEditMode.EditProgrammatically;

            txtMaDM.Enabled = false;
            btnSaveDM.Enabled = false;
            btnRefreshDM.Enabled = false;
        }

        private void dgvCategory_Click(object sender, EventArgs e)
        {
            if (btnAddDM.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới", "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                txtTenDM.Focus();
                return;
            }
            if (dgvCategory.Rows.Count == 0)
            {
                MessageBox.Show("Dữ liệu trống. Vui lòng thêm dữ liệu !", "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                txtTenDM.Focus();
                return;
            }
            txtMaDM.Text = dgvCategory.CurrentRow.Cells["Id"].Value.ToString();
            txtTenDM.Text = dgvCategory.CurrentRow.Cells["Name"].Value.ToString();
            btnUpdateDM.Enabled = true;
            btnDeleteDM.Enabled = true;
            btnRefreshDM.Enabled = true;
        }

        private void RefreshData()
        {
            txtTenDM.Focus();
            txtMaDM.Clear();
            txtTenDM.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmCategory_Load(sender, e);
        }
       
        private void btnCloseDM_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đóng form không ?", "Đóng Form !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnRefreshDM_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnAddDM_Click(object sender, EventArgs e)
        {
            btnUpdateDM.Enabled = false;
            btnDeleteDM.Enabled = false;
            btnAddDM.Enabled = false;
            btnRefreshDM.Enabled = true;
            btnSaveDM.Enabled = true;
            RefreshData();
        }

        private void btnSaveDM_Click(object sender, EventArgs e)
        {
            string name = "";
            if (txtTenDM.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên danh mục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDM.Focus();
                return;
            }
            else if (txtTenDM.Text.Trim().Length < 2 || txtTenDM.Text.Trim().Length > 255)
            {
                MessageBox.Show("Độ dài tối thiểu của tên danh mục là 2 và tối đa là 255", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDM.Focus();
                return;
            }
            else
            {
                name = txtTenDM.Text.Trim();
            };

            Category category = new Category();
            category.Id = 0;
            category.Name = name;

            try
            {
                bool result = bus.InsertCategory(category);
                if (result)
                {
                    MessageBox.Show("Thêm danh mục sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    RefreshData();
                    frmCategory_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm danh mục sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                btnUpdateDM.Enabled = true;
                btnAddDM.Enabled = true;
                btnDeleteDM.Enabled = true;
                btnRefreshDM.Enabled = false;
                btnSaveDM.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdateDM_Click(object sender, EventArgs e)
        {
            string name = "";
            if (txtTenDM.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên danh mục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDM.Focus();
                return;
            }
            else if (txtTenDM.Text.Trim().Length < 2 || txtTenDM.Text.Trim().Length > 255)
            {
                MessageBox.Show("Độ dài tối thiểu của tên danh mục là 2 và tối đa là 255", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDM.Focus();
                return;
            }
            else
            {
                name = txtTenDM.Text.Trim();
            };

            int id = int.Parse(dgvCategory.CurrentRow.Cells["Id"].Value.ToString());
            
            Category category = bus.GetDetail(id);
            
            if(category != null)
            {
                category.Name = name;

                try
                {
                    DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn cập nhật danh mục sản phẩm này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.Yes)
                    {
                        bool result = bus.UpdateCategory(category);
                        if (result)
                        {
                            MessageBox.Show("Cập nhật danh mục sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            RefreshData();
                            frmCategory_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật danh mục sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnDeleteDM_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dgvCategory.CurrentRow.Cells["Id"].Value.ToString());
                DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xoá danh mục sản phẩm này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    bool result = bus.DeleteCategory(id);
                    if (result)
                    {
                        MessageBox.Show("Xoá danh mục sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        RefreshData();
                        frmCategory_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Xoá danh mục sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void txtMaDM_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtTenDM_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
