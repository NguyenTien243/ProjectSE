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
    public partial class QLKhachHang : Form
    {
        public QLKhachHang()
        {
            InitializeComponent();
        }
        DataTable dataTableKhachHang = null;
        BLKhachHang blKhachHang = new BLKhachHang();
        
        
        bool Add;
        string err;
        private void LoadData()
        {
            try
            {
                btnReload.Enabled = true;
                dgvQLKhachHang.Enabled = true;
                dataTableKhachHang = new DataTable();
                dataTableKhachHang.Clear();
                DataSet ds = blKhachHang.GetAllCustomers();
                dataTableKhachHang = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvQLKhachHang.DataSource = dataTableKhachHang;
                // Thay đổi độ rộng cột
                dgvQLKhachHang.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel
                //ResetValue();
                btnDangKy.Enabled = true;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnHuy.Enabled = false;
                btnLuu.Enabled = false;
                cbVeThang.Items.Clear();
                for (int dem = 0; dem < blKhachHang.GetNameTicket().Tables[0].Rows.Count; dem++) //Thêm tên loại vé tháng vào combobox
                {
                    cbVeThang.Items.Add(blKhachHang.GetNameTicket().Tables[0].Rows[dem][0].ToString());
                }
                pnlQuanLyKH.Enabled = false;

                dgvQLKhachHang_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table Xe. Lỗi rồi!!!");
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void txtMaXe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaXe_Click(object sender, EventArgs e) //mở panel đăng ký xe cho khách hàng
        {
            //this.pnlQuanLyKH.Controls.Clear();

            FormDKyXe frmDkyXe = new FormDKyXe();
            frmDkyXe.TopLevel = false;

            // Gắn vào panel
            this.pnlQuanLyKH.Controls.Add(frmDkyXe);

            // Hiển thị form
            frmDkyXe.Show();

            btnLuu.Enabled = false;
        }
        public void ResetValues()
        {
            txtMaKH.ResetText();
            txtTenKH.ResetText();
            dateTimePickerKH.Value = DateTime.Now;
            radNam.Checked = false;
            radNu.Checked = false;
            txtCMND.ResetText();
            txtSDT.ResetText();
            txtDiaChi.ResetText();
            txtNgayHetHan.ResetText();
            txtMaXe.ResetText();
        }

        private void dgvQLKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Thứ tự dòng hiện hành
                int r;
                if (dgvQLKhachHang.CurrentCell == null)
                    return;
                else
                    r = dgvQLKhachHang.CurrentCell.RowIndex;
                txtMaKH.Text = dgvQLKhachHang.Rows[r].Cells[0].Value.ToString();
                txtTenKH.Text = dgvQLKhachHang.Rows[r].Cells[1].Value.ToString();
                dateTimePickerKH.Value = Convert.ToDateTime(dgvQLKhachHang.Rows[r].Cells[2].Value.ToString());
                if (dgvQLKhachHang.Rows[r].Cells[3].Value.ToString() == "Nam")
                    radNam.Checked = true;
                else
                    radNu.Checked = true;
                txtCMND.Text = dgvQLKhachHang.Rows[r].Cells[4].Value.ToString();
                txtSDT.Text = dgvQLKhachHang.Rows[r].Cells[5].Value.ToString();
                txtDiaChi.Text = dgvQLKhachHang.Rows[r].Cells[6].Value.ToString();
                txtNgayHetHan.Text = dgvQLKhachHang.Rows[r].Cells[7].Value.ToString();
                txtMaXe.Text = dgvQLKhachHang.Rows[r].Cells[8].Value.ToString();
                // cboLoaiXe.Text = blGiaVe.GetNameVehicle(dgvGiaVe.Rows[r].Cells[3].Value.ToString()).Tables[0].Rows[0][0].ToString();
               
                
            }
            catch
            {
                MessageBox.Show("Có lỗi");
            }
        }

        private void QLKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            dgvQLKhachHang.Enabled = false;
            btnGiaHan.Enabled = false;
            // Kich hoạt biến Them
            Add = true;
            // Xóa trống các đối tượng trong Panel
            ResetValues();
            
           
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            //   this.btnHuy.Enabled = true;
            this.pnlQuanLyKH.Enabled = true;
            txtNgayHetHan.Enabled = false;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnDangKy.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            // this.btnThoat.Enabled = false;
            // Đưa con trỏ đến TextField txtXe
            this.txtMaKH.Focus();
        }
    }
}
