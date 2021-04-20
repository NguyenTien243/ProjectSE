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
    public partial class QLNhanVien : Form
    {
        public QLNhanVien()
        {
            InitializeComponent();
        }
        DataTable dtNV = null;
        DataSet dt = null;
        BLNhanVien dbNV = new BLNhanVien();
        bool Them;
        string err;
        private void LoadThongTin()
        {
            try
            {
                dtNV = new DataTable();
                dtNV.Clear();
                DataSet ds = dbNV.LayNV();
                dtNV = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvQLNV.DataSource = dtNV;
                // Thay đổi độ rộng cột
                dgvQLNV.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel
                ResetValue();
                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnLuu.Enabled = false;

                this.btnHuy.Enabled = false;
                this.pnlQuanLyNV.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                pntTaiKhoan.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                //if (SHAREVAR.ChonNV == true)
                //{
                //    this.btnSua.Enabled = false;
                //    this.btnXoa.Enabled = false;
                //    this.btnThem.Enabled = false;
                //}
                //else
                //{
                //    this.btnSua.Enabled = true;
                //    this.btnXoa.Enabled = true;
                //    this.btnThem.Enabled = true;
                //}
                // this.btnThoat.Enabled = true;
                ////
                dgvQLNV_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table Xe. Lỗi rồi!!!");
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            float luong = 0;
            try
            {
                luong = float.Parse(txtLuong.Text);
            }
            catch
            {
                MessageBox.Show("Lương phải là giá trị số và lớn hơn hoặc bằng 0!");
                return;
            }
            string Gioitinh;

            if (radNam.Checked == true)
                Gioitinh = "Nam";
            else Gioitinh = "Nữ";
            dbNV = new BLNhanVien();
            if (txtMaNV.Text.Trim().Length == 0 || txtTenNV.Text.Trim().Length == 0 || txtDiaChi.Text.Trim().Length == 0 || txtCMND.Text.Trim().Length == 0
                || txtSDT.Text.Trim().Length == 0 || txtTaiKhoan.Text.Trim().Length == 0 || txtMatKhau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đủ  các thông tin cần thiết");
                return;
            }

            if (Them == true)
            {
                try

                { //DataSet dsNV = dbNV.KiemTraTrungMaNV(txtMaNV.Text);
                    if (dbNV.KiemTraTrungMaNV(txtMaNV.Text).Tables[0].Rows.Count != 0)
                    {
                        MessageBox.Show("Mã nhân viên bị trùng, vui lòng nhập mã khác!");
                    }
                    else
                     if (dbNV.KiemTraTrungTaiKhoan(txtTaiKhoan.Text).Tables[0].Rows.Count != 0)
                    {
                        MessageBox.Show("Tài khoản đã có người sử dụng, vui lòng đổi tài khoảnc!");
                    }
                    else
                     if (txtMatKhau.Text != txtMatKhau2.Text)
                    {
                        MessageBox.Show("Việc xác nhận mật khẩu không trùng khớp. Vui lòng nhập lại!");
                    }

                    else
                    {
                        dbNV = new BLNhanVien();
                        if (dbNV.ThemNV(txtMaNV.Text, txtTenNV.Text, dateTimePickerNgay.Value, Gioitinh, txtCMND.Text, txtSDT.Text, txtDiaChi.Text, txtTaiKhoan.Text, txtMatKhau.Text,luong, ref err))
                            MessageBox.Show("Thêm thành công");
                        else
                            MessageBox.Show("Thêm thất bại!!");
                        btnThem.Enabled = true;
                        LoadThongTin();
                        pnlQuanLyNV.Enabled = false;
                    }
                }
                catch { MessageBox.Show("Không thể thêm được"); }
            }
            else
            {
                dbNV = new BLNhanVien();
                int r = dgvQLNV.CurrentCell.RowIndex;
                string MaNV = dgvQLNV.Rows[r].Cells[0].Value.ToString();
                if (dbNV.CapNhatNV(MaNV, txtTenNV.Text, dateTimePickerNgay.Value, Gioitinh, txtCMND.Text, txtSDT.Text, txtDiaChi.Text, txtTaiKhoan.Text, txtMatKhau.Text,luong, ref err) == true)
                {
                    MessageBox.Show("Sửa thành công!");
                    LoadThongTin();
                }
                else
                    MessageBox.Show("Sửa thất bại");

            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            pntTaiKhoan.Enabled = true;
            
            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong Panel

            ResetValue();
            //this.txtMaNV.ResetText();
            //this.txtTenNV.ResetText();
            //this.txtSDT.ResetText();
            //this.txtDiaChi.ResetText();
            //this.txtTaiKhoan.ResetText();
            //this.txtMatKhau.ResetText();
            txtLuong.Enabled = true;
            this.txtMaNV.Enabled = true;
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            //   this.btnHuy.Enabled = true;
            this.pnlQuanLyNV.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            // this.btnThoat.Enabled = false;
            // Đưa con trỏ đến TextField txtXe
            this.txtMaNV.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            pntTaiKhoan.Enabled = true;
            txtLuong.Enabled = true;
            // Kich hoạt biến Them
            Them = false;
            // Xóa trống các đối tượng trong Panel


            this.txtMaNV.Enabled = true;
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            //   this.btnHuy.Enabled = true;
            this.pnlQuanLyNV.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;

            txtMaNV.Enabled = false;
            // this.btnThoat.Enabled = false;
            // Đưa con trỏ đến TextField txtXe
            this.txtTenNV.Focus();
        }



        private void dgvQLNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Thứ tự dòng hiện hành
                int r;
                if (dgvQLNV.CurrentCell == null)
                    return;
                else
                    r = dgvQLNV.CurrentCell.RowIndex;
                // Chuyển thông tin lên panel
                //if (dgvNV.Rows[r].Cells[0].Value.ToString() == null)
                //    return;


                this.txtMaNV.Text =
                dgvQLNV.Rows[r].Cells[0].Value.ToString();
                this.txtTenNV.Text =
                dgvQLNV.Rows[r].Cells[1].Value.ToString();
                if (dgvQLNV.Rows[r].Cells[3].Value.ToString() == "Nam")
                    radNam.Checked = true;
                else
                    radNu.Checked = true;

                //if (dgvQLNV.Rows[r].Cells[2].Value.ToString() == "")
                //    this.cboCongViec.SelectedIndex = -1;
                //else
                //    this.cboCongViec.SelectedItem = dgvQLNV.Rows[r].Cells[2].Value.ToString(); // chọn hiển thị tên công việc
                try
                {
                    this.dateTimePickerNgay.Value = Convert.ToDateTime(dgvQLNV.Rows[r].Cells[2].Value.ToString());
                }
                catch
                {
                    
                }
                    this.txtCMND.Text =
                dgvQLNV.Rows[r].Cells[4].Value.ToString();
                this.txtSDT.Text =
                dgvQLNV.Rows[r].Cells[5].Value.ToString();
                this.txtDiaChi.Text =
                dgvQLNV.Rows[r].Cells[6].Value.ToString();
                this.txtTaiKhoan.Text =
                dgvQLNV.Rows[r].Cells[7].Value.ToString();
                this.txtMatKhau.Text =
                dgvQLNV.Rows[r].Cells[8].Value.ToString();
                this.txtLuong.Text = dgvQLNV.Rows[r].Cells["Luong"].Value.ToString();
            }
            catch
            {

            }
        }

        private void QLNhanVien_Load(object sender, EventArgs e)
        {
            LoadThongTin();
            dgvQLNV.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy"; // fomat dạng ngày đổ lên datagridview https://www.ddth.com/showthread.php/312166-H%E1%BB%8Fi-v%E1%BB%81-format-datatime-trong-datagridview-c%E1%BB%A7a-c

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh
                // Lấy thứ tự record hiện hành
                int r = dgvQLNV.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành
                string strNV =
                dgvQLNV.Rows[r].Cells[0].Value.ToString();
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
                    dbNV = new BLNhanVien();
                    if (dbNV.XoaNV(this.txtMaNV.Text, ref err))
                        // Thông báo
                        MessageBox.Show("Đã xóa xong!");
                    else
                        // Thông báo
                        MessageBox.Show("Xóa bị lỗi!");
                    // Cập nhật lại DataGridView
                    LoadThongTin();
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
        private void ResetValue()
        {
            txtMaNV.ResetText();
            txtTenNV.ResetText();
            txtCMND.ResetText();
            txtDiaChi.ResetText();
            txtSDT.ResetText();
            txtTaiKhoan.ResetText();
            txtMatKhau.ResetText();
            txtMatKhau2.ResetText();
            txtLuong.ResetText();
            txtLuong.Enabled = false;
            radNam.Checked = false;
            radNu.Checked = false;
            dateTimePickerNgay.Value = DateTime.Now;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel
            ResetValue();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            //this.btnThoat.Enabled = true;
            this.dgvQLNV.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            this.pnlQuanLyNV.Enabled = false;
            dgvQLNV_CellClick(null, null);
        }
        
    }
}
