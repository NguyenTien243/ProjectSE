using Quanlybaidoxe.BS_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Quanlybaidoxe.Form_Layer.NguoiQuanLyUI
{
    public partial class QLPhieuThanhToan : Form
    {
        public QLPhieuThanhToan()
        {
            InitializeComponent();
        }
        DataTable datatablePhieuThanhToan = null;

        BLPhieuThanhToan blPhieuThanhToan = new BLPhieuThanhToan();
        bool Them;
        string err;
        string loaitimkiem;
        private void LoadThongTin()
        {
            dgvQLPhieuThanhToan.Enabled = true;
            try
            {
                datatablePhieuThanhToan = new DataTable();
                datatablePhieuThanhToan.Clear();
                DataSet ds = blPhieuThanhToan.GetReceipts();
                datatablePhieuThanhToan = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvQLPhieuThanhToan.DataSource = datatablePhieuThanhToan;
                // Thay đổi độ rộng cột
                dgvQLPhieuThanhToan.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                // Xóa trống các đối tượng trong Panel


                dgvQLPhieuThanhToan_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table Xe. Lỗi rồi!!!");
            }
        }
        private void QLPhieuThanhToan_Load(object sender, EventArgs e)
        {
            LoadThongTin();
            dateTimePickerNgay.Location = txtTimKiem.Location;
            dateTimePickerNgay.Visible = false;
            timerThoiGianThuc.Enabled = true;
            dgvQLPhieuThanhToan.Columns["TraTheoThang"].ReadOnly = true;
            dgvQLPhieuThanhToan.Columns["GioVao"].DefaultCellStyle.Format = "dd/MM/yyyy h:mm tt"; // fomat dạng ngày đổ lên datagridview https://www.ddth.com/showthread.php/312166-H%E1%BB%8Fi-v%E1%BB%81-format-datatime-trong-datagridview-c%E1%BB%A7a-c
            dgvQLPhieuThanhToan.Columns["GioRa"].DefaultCellStyle.Format = "dd/MM/yyyy h:mm tt"; // fomat dạng ngày đổ lên datagridview https://www.ddth.com/showthread.php/312166-H%E1%BB%8Fi-v%E1%BB%81-format-datatime-trong-datagridview-c%E1%BB%A7a-c
        }

        private void dgvQLPhieuThanhToan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Thứ tự dòng hiện hành
                int r;
                if (dgvQLPhieuThanhToan.CurrentCell == null)
                    return;
                else
                    r = dgvQLPhieuThanhToan.CurrentCell.RowIndex;

                this.txtBienSo.Text = dgvQLPhieuThanhToan.Rows[r].Cells["BienSo"].Value.ToString();
                this.txtMaPhieuThu.Text = dgvQLPhieuThanhToan.Rows[r].Cells["MaPhieu"].Value.ToString();


                this.txtMaXe.Text = dgvQLPhieuThanhToan.Rows[r].Cells["MaXe"].Value.ToString();
                this.txtTienThu.Text = dgvQLPhieuThanhToan.Rows[r].Cells["TienThu"].Value.ToString();
                this.txtGioVao.Text = dgvQLPhieuThanhToan.Rows[r].Cells["GioVao"].Value.ToString();
                this.txtGioRa.Text = dgvQLPhieuThanhToan.Rows[r].Cells["GioRa"].Value.ToString();
                this.txtMaNVThu.Text = dgvQLPhieuThanhToan.Rows[r].Cells["MaNV"].Value.ToString().Trim();
                this.txtLoaiVe.Text = dgvQLPhieuThanhToan.Rows[r].Cells["TraTheoThang"].Value.ToString().Trim() == "True" ? "Vé tháng": "Vé lượt";

            }
            catch
            {

            }
        }

        private void timerThoiGianThuc_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadThongTin();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (cboTimKiem.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại tìm kiếm");
                return;
            }
            if (txtTimKiem.Text.Trim().Length == 0 && cboTimKiem.SelectedIndex != 4 && cboTimKiem.SelectedIndex != 5) 
            {
                MessageBox.Show("Vui lòng nhập nội dung tìm kiếm");
                return;
            }

            int luachon = cboTimKiem.SelectedIndex;
            switch (luachon)
            {
                case 0:
                    loaitimkiem = "MaPhieu";
                    break;
                case 1:
                    loaitimkiem = "BienSo";
                    break;
                case 2:
                    loaitimkiem = "Xe.MaXe";
                    break;
                case 3:
                    loaitimkiem = "MaNV";
                    break;
                case 4:
                    loaitimkiem = "GioRa";
                    break;
                case 5:
                    loaitimkiem = "GioVao";
                    break;
                default:
                    MessageBox.Show("Loại tìm kiếm không hợp lệ, vui lòng kiểm tra lại!");
                    break;
            }
            if (cboTimKiem.SelectedIndex == 4 || cboTimKiem.SelectedIndex == 5)
            {
                string ngaytimkiem = dateTimePickerNgay.Value.ToString("MM/dd/yyyy");
                dgvQLPhieuThanhToan.DataSource = blPhieuThanhToan.SearchReceiceptByDate(loaitimkiem, ngaytimkiem).Tables[0];
            }    
            else
                dgvQLPhieuThanhToan.DataSource = blPhieuThanhToan.SearchReceicept(loaitimkiem, txtTimKiem.Text).Tables[0];
            dgvQLPhieuThanhToan_CellClick(null, null);
        }

        private void cboTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTimKiem.ResetText();
            dateTimePickerNgay.ResetText();
            if(cboTimKiem.SelectedIndex == 4 || cboTimKiem.SelectedIndex == 5)
            {
                dateTimePickerNgay.Visible = true;
                txtTimKiem.Visible = false;
                lbNoiDung.Text = "Chọn ngày :";

            } 
            else
            {
                dateTimePickerNgay.Location = txtTimKiem.Location;
                dateTimePickerNgay.Visible = false;
                txtTimKiem.Visible = true;
                lbNoiDung.Text = "Nhập nội dung :";
            }    
        }

        private void btnChiTietPhieuThu_Click(object sender, EventArgs e)
        {
            ChiTietPhieuThu ctpt = new ChiTietPhieuThu();
            SHAREVAR.sharevarMaPhieuThanhToan = txtMaPhieuThu.Text;
            ctpt.ShowDialog();
        }
    }

    
}

