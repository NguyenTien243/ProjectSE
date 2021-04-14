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
                this.txtMaNV.ResetText();
                this.txtTenNV.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnLuu.Enabled = false;
               
            //    this.btnHuy.Enabled = false;
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

            if (Them==true)
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
                        dbNV.ThemNV(txtMaNV.Text, txtTenNV.Text, dateTimePickerNgay.Value, Gioitinh, txtCMND.Text, txtSDT.Text, txtDiaChi.Text, txtTaiKhoan.Text, txtMatKhau.Text, ref err);
                        btnThem.Enabled = true;
                        LoadThongTin();
                        pnlQuanLyNV.Enabled = false;
                    }
                }
                catch { MessageBox.Show("Không thể thêm được"); }
            }
            else
            {
                
                int r = dgvQLNV.CurrentCell.RowIndex;
                string MaNV = dgvQLNV.Rows[r].Cells[0].Value.ToString();
                if (dbNV.CapNhatNV(MaNV, txtTenNV.Text, dateTimePickerNgay.Value, Gioitinh, txtCMND.Text, txtSDT.Text, txtDiaChi.Text, txtTaiKhoan.Text, txtMatKhau.Text, ref err) == true)
                {
                    MessageBox.Show("Thêm thành công!");
                    LoadThongTin();
                }
                else
                    MessageBox.Show("Thêm thất bại");
                
            }
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            pntTaiKhoan.Enabled = true;
            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong Panel
            this.txtMaNV.ResetText();
            this.txtTenNV.ResetText();
            this.txtSDT.ResetText();
            this.txtDiaChi.ResetText();
            this.txtTaiKhoan.ResetText();
            this.txtMatKhau.ResetText();

            this.txtMaNV.Enabled = true;
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
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
            // Kich hoạt biến Them
            Them = false;
            // Xóa trống các đối tượng trong Panel
           

            this.txtMaNV.Enabled = true;
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
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

        private void btnXoa_Click(object sender, EventArgs e)
        {

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
                this.dateTimePickerNgay.Value = Convert.ToDateTime(dgvQLNV.Rows[r].Cells[2].Value.ToString());
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

      
    }
}
