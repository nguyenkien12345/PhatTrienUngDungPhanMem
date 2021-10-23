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
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }

        ProductBUS bus = new ProductBUS();

        List<Product> listProduct = null;

        private void frmProduct_Load(object sender, EventArgs e)
        {
            ShowList();
            LoadComboBoxCategory();
        }

        public void ShowList()
        {
            listProduct = bus.GetAll();
            lvProduct.Items.Clear();
            listProduct.ForEach(x =>
            {
                ListViewItem lvi = new ListViewItem(x.Id);
                lvi.SubItems.Add(x.Name);
                lvi.SubItems.Add(x.Price.ToString());
                lvi.SubItems.Add(x.Description);
                lvi.SubItems.Add(x.Unit);
                lvi.SubItems.Add(x.Origin);
                lvi.SubItems.Add(x.CategoryId.ToString());
                lvProduct.Items.Add(lvi);
            });
            txtMaSP.Enabled = false;
            btnSaveSP.Enabled = false;
            btnRefreshSP.Enabled = false;
        }

        private void LoadComboBoxCategory()
        {
            cboLoaiSP.ValueMember = "Id";
            cboLoaiSP.DisplayMember = "Name";
            cboLoaiSP.DataSource = bus.GetAllCategory();
        }

        private void lvProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnAddSP.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới", "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                txtMaSP.Focus();
                return;
            }
            if (lvProduct.SelectedItems.Count == 0)
            {
                return;
            }
            string id = lvProduct.SelectedItems[0].SubItems[0].Text;
            Product product = bus.GetDetail(id);
            if (product != null)
            {
                txtMaSP.Text = product.Id;
                txtTenSP.Text = product.Name;
                txtGiaSP.Text = product.Price.ToString();
                txtMoTaSP.Text = product.Description;
                txtDonViSP.Text = product.Unit;
                txtXuatXuSP.Text = product.Origin;
                cboLoaiSP.Text = product.Category.Name;
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            btnUpdateSP.Enabled = true;
            btnDeleteSP.Enabled = true;
            btnRefreshSP.Enabled = true;
        }

        private void RefreshData()
        {
            txtMaSP.Focus();
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtGiaSP.Clear();
            txtMoTaSP.Clear();
            txtDonViSP.Clear();
            txtXuatXuSP.Clear();
            cboLoaiSP.SelectedIndex = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmProduct_Load(sender, e);
        }

        private void btnCloseSP_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đóng form không ?", "Đóng Form !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnRefreshSP_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnAddSP_Click(object sender, EventArgs e)
        {
            btnUpdateSP.Enabled = false;
            btnDeleteSP.Enabled = false;
            btnAddSP.Enabled = false;
            btnRefreshSP.Enabled = true;
            btnSaveSP.Enabled = true;
            txtMaSP.Enabled = true;
            RefreshData();
        }

        private void btnSaveSP_Click(object sender, EventArgs e)
        {
            string id = "";
            if (txtMaSP.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSP.Focus();
                return;
            }
            else if (txtMaSP.Text.Trim().Length < 4 || txtMaSP.Text.Trim().Length > 255)
            {
                MessageBox.Show("Độ dài tối thiểu của mã sản phẩm là 4 và tối đa là 255", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSP.Focus();
                return;
            }
            else
            {
                id = txtMaSP.Text.Trim();
            };

            string name = "";
            if (txtTenSP.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenSP.Focus();
                return;
            }
            else if (txtTenSP.Text.Trim().Length < 3 || txtTenSP.Text.Trim().Length > 255)
            {
                MessageBox.Show("Độ dài tối thiểu của tên sản phẩm là 3 và tối đa là 255", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenSP.Focus();
                return;
            }
            else
            {
                name = txtTenSP.Text.Trim();
            };

            decimal price = 0;
            if (txtGiaSP.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập giá sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaSP.Focus();
                return;
            }
            else if (decimal.Parse(txtGiaSP.Text.Trim()) < 0)
            {
                MessageBox.Show("Giá của sản phẩm phải lớn hơn hoặc bằng 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaSP.Focus();
                return;
            }
            else
            {
                price = decimal.Parse(txtGiaSP.Text.Trim());
            };

            string description = "";
            if (txtMoTaSP.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mô tả của sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMoTaSP.Focus();
                return;
            }
            else if (txtMoTaSP.Text.Trim().Length < 1 || txtMoTaSP.Text.Trim().Length > 255)
            {
                MessageBox.Show("Độ dài tối thiểu của mô tả sản phẩm là 1 và tối đa là 255", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMoTaSP.Focus();
                return;
            }
            else
            {
                description = txtMoTaSP.Text.Trim();
            };

            string unit = "";
            if (txtDonViSP.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đơn vị tính của sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonViSP.Focus();
                return;
            }
            else if (txtDonViSP.Text.Trim().Length < 1 || txtDonViSP.Text.Trim().Length > 255)
            {
                MessageBox.Show("Độ dài tối thiểu của đơn vị tính sản phẩm là 1 và tối đa là 255", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMoTaSP.Focus();
                return;
            }
            else
            {
                unit = txtMoTaSP.Text.Trim();
            };

            string origin = "";
            if (txtXuatXuSP.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập xuất xứ của sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtXuatXuSP.Focus();
                return;
            }
            else if (txtXuatXuSP.Text.Trim().Length < 1 || txtXuatXuSP.Text.Trim().Length > 255)
            {
                MessageBox.Show("Độ dài tối thiểu của xuất xứ sản phẩm là 1 và tối đa là 255", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtXuatXuSP.Focus();
                return;
            }
            else
            {
                origin = txtXuatXuSP.Text.Trim();
            };

            int categoryId = int.Parse(cboLoaiSP.SelectedValue.ToString());

            if (bus.GetDetail(id) != null)
            {
                MessageBox.Show("Mã SP này đã tồn tại. Vui lòng nhập mã sản phẩm khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Product product = new Product();
                product.Id = id;
                product.Name = name;
                product.Price = price;
                product.Description = description;
                product.Unit = unit;
                product.Origin = origin;
                product.CategoryId = categoryId;

                try
                {
                    bool result = bus.InsertProduct(product);
                    if (result)
                    {
                        MessageBox.Show("Thêm sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        RefreshData();
                        frmProduct_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Thêm sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    btnUpdateSP.Enabled = true;
                    btnAddSP.Enabled = true;
                    btnDeleteSP.Enabled = true;
                    btnRefreshSP.Enabled = false;
                    btnSaveSP.Enabled = false;
                    txtMaSP.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnUpdateSP_Click(object sender, EventArgs e)
        {
            string name = "";
            if (txtTenSP.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenSP.Focus();
                return;
            }
            else if (txtTenSP.Text.Trim().Length < 3 || txtTenSP.Text.Trim().Length > 255)
            {
                MessageBox.Show("Độ dài tối thiểu của tên sản phẩm là 3 và tối đa là 255", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenSP.Focus();
                return;
            }
            else
            {
                name = txtTenSP.Text.Trim();
            };

            decimal price = 0;
            if (txtGiaSP.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập giá sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaSP.Focus();
                return;
            }
            else if (decimal.Parse(txtGiaSP.Text.Trim()) < 0)
            {
                MessageBox.Show("Giá của sản phẩm phải lớn hơn hoặc bằng 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaSP.Focus();
                return;
            }
            else
            {
                price = decimal.Parse(txtGiaSP.Text.Trim());
            };

            string description = "";
            if (txtMoTaSP.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mô tả của sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMoTaSP.Focus();
                return;
            }
            else if (txtMoTaSP.Text.Trim().Length < 1 || txtMoTaSP.Text.Trim().Length > 255)
            {
                MessageBox.Show("Độ dài tối thiểu của mô tả sản phẩm là 1 và tối đa là 255", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMoTaSP.Focus();
                return;
            }
            else
            {
                description = txtMoTaSP.Text.Trim();
            };

            string unit = "";
            if (txtDonViSP.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đơn vị tính của sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonViSP.Focus();
                return;
            }
            else if (txtDonViSP.Text.Trim().Length < 1 || txtDonViSP.Text.Trim().Length > 255)
            {
                MessageBox.Show("Độ dài tối thiểu của đơn vị tính sản phẩm là 1 và tối đa là 255", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonViSP.Focus();
                return;
            }
            else
            {
                unit = txtDonViSP.Text.Trim();
            };

            string origin = "";
            if (txtXuatXuSP.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập xuất xứ của sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtXuatXuSP.Focus();
                return;
            }
            else if (txtXuatXuSP.Text.Trim().Length < 1 || txtXuatXuSP.Text.Trim().Length > 255)
            {
                MessageBox.Show("Độ dài tối thiểu của xuất xứ sản phẩm là 1 và tối đa là 255", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtXuatXuSP.Focus();
                return;
            }
            else
            {
                origin = txtXuatXuSP.Text.Trim();
            };

            int categoryId = int.Parse(cboLoaiSP.SelectedValue.ToString());

            string id = lvProduct.SelectedItems[0].SubItems[0].Text;

            Product product = bus.GetDetail(id);

            if(product != null)
            {
                product.Name = name;
                product.Price = price;
                product.Description = description;
                product.Unit = unit;
                product.Origin = origin;
                product.CategoryId = categoryId;

                try
                {
                    DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn cập nhật sản phẩm này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.Yes)
                    {
                        bool result = bus.UpdateProduct(product);
                        if (result)
                        {
                            MessageBox.Show("Cập nhật sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            RefreshData();
                            frmProduct_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnDeleteSP_Click(object sender, EventArgs e)
        {
            try
            {
                string id = lvProduct.SelectedItems[0].SubItems[0].Text;
                DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xoá sản phẩm này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    bool result = bus.DeleteProduct(id);
                    if (result)
                    {
                        MessageBox.Show("Xoá sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        RefreshData();
                        frmProduct_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Xoá sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
