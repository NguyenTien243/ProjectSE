using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Quanlybaidoxe.BS_Layer;

namespace Quanlybaidoxe.Form_Layer.NguoiQuanLyUI
{
    public partial class BaiDoXe : Form
    {
        public BaiDoXe()
        {
            InitializeComponent();
        }
        DataTable datatableViTri = null;

        BLViTriXe blViTri = new BLViTriXe();
        bool Add;
        string err;
        private void LoadData()
        {
            try
            {
                datatableViTri = new DataTable();
                datatableViTri.Clear();
                DataSet ds = blViTri.GetPosition();
                datatableViTri = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvQLBDX.DataSource = datatableViTri;
                // Thay đổi độ rộng cột
                dgvQLBDX.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel
                //ResetValue();
                btnThem.Enabled = true;
                btnXoa.Enabled = false;
                btnSua.Enabled = true;
                btnHuy.Enabled = false;
                btnLuu.Enabled = false;
                txtTenViTri.Enabled = false;
                txtMaViTri.Enabled = false;
                //ĐẾM SỐ LƯỢNG XE
                lbTongBaiOto.Text = blViTri.CountCar().Tables[0].Rows[0][0].ToString();
                lbTongBaiXeMay.Text = blViTri.CountMotorbike().Tables[0].Rows[0][0].ToString();

                dgvQLBDX_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table Xe. Lỗi rồi!!!");
            }
        }
        private void BaiDoXe_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvQLBDX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Thứ tự dòng hiện hành
                int r;
                if (dgvQLBDX.CurrentCell == null)
                    return;
                else
                    r = dgvQLBDX.CurrentCell.RowIndex;

                this.txtMaViTri.Text = dgvQLBDX.Rows[r].Cells[0].Value.ToString();
                this.txtTenViTri.Text = dgvQLBDX.Rows[r].Cells[1].Value.ToString();                              
            }
            catch
            {

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            txtMaViTri.Enabled = true;
            txtTenViTri.Enabled = true;
            txtMaViTri.ResetText();
            txtTenViTri.ResetText();
            Add = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            txtMaViTri.Enabled = false;
            txtTenViTri.Enabled = true;
            txtTenViTri.ResetText();
            Add = false;
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaViTri.Text.Trim().Length == 0 || txtTenViTri.Text.Trim().Length == 0)

            {
                MessageBox.Show("Vui lòng điền đủ thông tin!!");
                return;
            }

            if(Add == true)
            {
                blViTri = new BLViTriXe();
                try {
                    if (blViTri.CheckPositionId(txtMaViTri.Text).Tables[0].Rows.Count != 0)
                    {
                        MessageBox.Show("Vị trí này đã tồn tại, hãy nhập mã vị trí khác");
                    }
                    if (blViTri.AddPosition(txtMaViTri.Text, txtTenViTri.Text, ref err) == true)
                    {

                        MessageBox.Show("Đã thêm vị trí mới cho bãi đỗ");
                        LoadData();
                    }
                    else MessageBox.Show("Có lỗi xảy ra, chưa thêm được!!");
                }
                catch
                {
                    MessageBox.Show("Không thể thêm được");
                    LoadData();
                }
            }   
            else
            {
                blViTri = new BLViTriXe();
                int r = dgvQLBDX.CurrentCell.RowIndex;
                string MaViTri = dgvQLBDX.Rows[r].Cells[0].Value.ToString();
                if (blViTri.EditPosition(MaViTri, txtTenViTri.Text, ref err) == true)
                {
                    MessageBox.Show("Chỉnh sửa thành công, đã cập nhật lại thông tin");
                    LoadData();
                }
                else MessageBox.Show("Không thể chỉnh sửa!!");
            }    
        }
    }
}
