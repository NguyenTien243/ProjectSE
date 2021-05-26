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
                dgvQLBDX.Enabled = true;
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
                btnXoa.Enabled = true;
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
        private void AutocomleteSearch()
        {
            if (cboTimKiem.SelectedIndex == -1)
                return;
            AutoCompleteStringCollection autoSearchID = new AutoCompleteStringCollection(); // thu thập những mẫu gợi í
            AutoCompleteStringCollection autoSearchName = new AutoCompleteStringCollection();
            blViTri = new BLViTriXe();
            DataSet datasetPosition = blViTri.GetPosition();
            for ( int i = 0; i < datasetPosition.Tables[0].Rows.Count;i++)
                {
                autoSearchID.Add(datasetPosition.Tables[0].Rows[i]["MaViTri"].ToString().Trim()); // thêm gợi ý vào biến autoSearchID
                autoSearchName.Add(datasetPosition.Tables[0].Rows[i]["TenViTri"].ToString().Trim());
                }
            // tham khảo autocompletesearch từ http://vualaptrinh.blogspot.com/2015/07/chuc-nang-autocomplete-cua-textbox.html
           if(cboTimKiem.SelectedIndex == 0)
                txtTimKiem.AutoCompleteCustomSource = autoSearchID;
           else
                txtTimKiem.AutoCompleteCustomSource = autoSearchName;
            txtTimKiem.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtTimKiem.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
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
            dgvQLBDX.Enabled = false;
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
        private bool KiemTraKyTuToiDa()
        {
            bool check = true;
            string thongbaoloi = "";
            if(txtMaViTri.Text.Trim().Length > 10)
            {
                thongbaoloi += "\nMã vị trí tối đa 10 ký tự!!!";
                check = false;
            }
            if (txtTenViTri.Text.Trim().Length > 30)
            {
                thongbaoloi += "\nTên vị trí tối đa 30 ký tự!!!";
                check = false;
            }

            if(check == false)
            {
                MessageBox.Show(thongbaoloi);
            }    
            return check;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            if (txtMaViTri.Text.Trim().Length == 0 || txtTenViTri.Text.Trim().Length == 0)

            {
                MessageBox.Show("Vui lòng điền đủ thông tin!!");
                return;
            }
            if (KiemTraKyTuToiDa() == false)
                return;
            // kiểm tra Trùng Tên
            blViTri = new BLViTriXe();
            if (blViTri.CheckNamePosition(txtMaViTri.Text.Trim(), txtTenViTri.Text.Trim(), ref err) == false)
            {
                MessageBox.Show("Tên vị trí bị trùng vui lòng kiểm tra lại");
                return;
            }

            if (Add == true)
            {
                blViTri = new BLViTriXe();
              //  try 
                {
                    if (blViTri.CheckPositionId(txtMaViTri.Text).Tables[0].Rows.Count != 0)
                    {
                        MessageBox.Show("Mã vị trí này đã tồn tại, hãy nhập mã vị trí khác");
                        return;
                    }
                    if (blViTri.AddPosition(txtMaViTri.Text, txtTenViTri.Text, ref err) == true)
                    {

                        MessageBox.Show("Đã thêm vị trí mới cho bãi đỗ");
                        LoadData();
                    }
                    else MessageBox.Show("Có lỗi xảy ra, chưa thêm được!!");
                }
                //catch
                //{
                //    MessageBox.Show("Không thể thêm được");
                //    LoadData();
                //}
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel
            ResetValue();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.dgvQLBDX.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            this.pnlQuanLyNV.Enabled = false;
            dgvQLBDX_CellClick(null, null);
        }

        private void ResetValue()
        {
            txtMaViTri.ResetText();
            txtTenViTri.ResetText();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if(cboTimKiem.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại tìm kiếm");
                return;
            }    
            if (txtTimKiem.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập nội dung tìm kiếm");
                return;
            }    
            if(cboTimKiem.SelectedIndex == 0)
            {
                dgvQLBDX.DataSource = blViTri.SearchPositionbyID(txtTimKiem.Text).Tables[0];
                dgvQLBDX_CellClick(null, null);
            }   
            else
            {
                if (cboTimKiem.SelectedIndex == 1)
                {
                    dgvQLBDX.DataSource = blViTri.SearchPositionbyName(txtTimKiem.Text).Tables[0];
                    dgvQLBDX_CellClick(null, null);
                }
            }    
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh
                // Lấy thứ tự record hiện hành
                int row = dgvQLBDX.CurrentCell.RowIndex;
                blViTri = new BLViTriXe();
                // nếu mã vị trí hiện đang có xe thì không cho xóa
                if(blViTri.CheckDeletePosition(txtMaViTri.Text.Trim(), ref err) == false)
                {
                    MessageBox.Show("Vị trí hiện tại đang có xe, vui lòng cho xe ra khỏi vị trí trước khi xóa!");
                    return;
                }    
                // Viết câu lệnh SQL
                // Hiện thông báo xác nhận việc xóa mẫu t
                // Khai báo biến traloi
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không?
                if (traloi == DialogResult.Yes)
                {

                    blViTri = new BLViTriXe();
                    if (blViTri.DeletePosition(this.txtMaViTri.Text, ref err))
                        // Thông báo
                        MessageBox.Show("Đã xóa xong!");
                    else
                        // Thông báo
                        MessageBox.Show("Xóa bị lỗi!");
                    // Cập nhật lại DataGridView
                    LoadData();
                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cboTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTimKiem.ResetText();
            if (cboTimKiem.SelectedIndex == -1)
                return;
            else
                AutocomleteSearch();
        }
    }
}
