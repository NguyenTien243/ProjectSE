using Quanlybaidoxe.BS_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quanlybaidoxe.Form_Layer.NguoiQuanLyUI
{
    public partial class DoXe : Form
    {
        public DoXe()
        {
            InitializeComponent();
        }
        DataTable dataTableDoXe = null;
        DataTable dataTableVehicleType = null;
        DataTable dataTableTicketAvailable = null;
        DataTable dataTablePositionAvailable = null;
        DataTable dataTableVehicles = null; // tham khảo lấy dữ liệu trong dataTable https://stackoverflow.com/questions/10703320/check-if-value-exists-in-datatable/10703369
        BLDoXe blDoXe = new BLDoXe();
        string err;
        string MaTheGui, MaViTri;
        private void DoXe_Load(object sender, EventArgs e)
        {
            BLDoXe blDoXe = new BLDoXe();
            dataTableVehicleType = blDoXe.GetVehicleType().Tables[0];


            cboLoaiXe.Items.Clear();
            foreach (DataRow row in dataTableVehicleType.Rows)
            {
                cboLoaiXe.Items.Add(row["TenLoaiXe"].ToString());
            }


            LoadData();
            dgvQLDX.Columns["DangKyThang"].ReadOnly = true;
        }
        private void UpdateVehicle()
        {
            blDoXe = new BLDoXe();
            dataTableVehicles = blDoXe.GetVihicles().Tables[0];
        }
        private void UpdateTicketAvailable()
        {
            cboTheGui.Items.Clear();
            cboTheGui.ResetText();
            BLDoXe blDoXe = new BLDoXe();
            dataTableTicketAvailable = blDoXe.GetTicketID().Tables[0];
            if (dataTableTicketAvailable.Rows.Count == 0)
            {
                MessageBox.Show("Thông báo hết thẻ gửi xe!");
                labelThongBaoHetThe.Text = "Hết thẻ!!!";
            }
            else
                labelThongBaoHetThe.Text = "";
            foreach (DataRow row in dataTableTicketAvailable.Rows)
            {
                cboTheGui.Items.Add(row["MaTheGuiXe"].ToString());
            }

        }
        private void UpdatePositionAvailable()
        {
            cboViTri.Items.Clear();
            BLDoXe blDoXe = new BLDoXe();
            dataTablePositionAvailable = blDoXe.GetPosition().Tables[0];
            if (dataTablePositionAvailable.Rows.Count == 0)
            {
                MessageBox.Show("Thông báo hết chỗ để xe!");
                labelThongBaoHetViTri.Text = "Hết chỗ để xe!!!!";
            }
            else
                labelThongBaoHetViTri.Text = "";
            foreach (DataRow row in dataTablePositionAvailable.Rows)
            {
                cboViTri.Items.Add(row["MaViTri"].ToString());
            }

        }
        private void LoadData()
        {
            UpdateVehicle();
            UpdatePositionAvailable();
            UpdateTicketAvailable();
            try
            {
                btnReload.Enabled = true;
                dgvQLDX.Enabled = true;
                dataTableDoXe = new DataTable();
                dataTableDoXe.Clear();
                BLDoXe blDoXe = new BLDoXe();
                DataSet ds = blDoXe.LoadData();
                dataTableDoXe = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvQLDX.DataSource = dataTableDoXe;
                // Thay đổi độ rộng cột
                dgvQLDX.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel
                //ResetValue();
                btnVaoBen.Enabled = true;
                btnXuatBen.Enabled = true;

                btnHuy.Enabled = false;
                btnLuu.Enabled = false;

                pnlQuanLyDoXe.Enabled = false;

                dgvQLDX_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table Xe. Lỗi rồi!!!");
            }
        }

        private void dgvQLDX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Thứ tự dòng hiện hành
                int r;
                if (dgvQLDX.CurrentCell == null)
                    return;
                else
                    r = dgvQLDX.CurrentCell.RowIndex;
                txtBienSo.Text = dgvQLDX.Rows[r].Cells["BienSo"].Value.ToString();
                txtMaXe.Text = dgvQLDX.Rows[r].Cells["MaXe"].Value.ToString();
                txtTenXe.Text = dgvQLDX.Rows[r].Cells["TenXe"].Value.ToString();
                txtMauSac.Text = dgvQLDX.Rows[r].Cells["MauSac"].Value.ToString();
                txtGioVao.Text = dgvQLDX.Rows[r].Cells["GioVao"].Value.ToString();

                cboLoaiXe.SelectedItem = dgvQLDX.Rows[r].Cells["TenLoaiXe"].Value.ToString();
                cboTheGui.Text = dgvQLDX.Rows[r].Cells["MaTheGuiXe"].Value.ToString();

            }
            catch
            {

            }
        }

        private void btnVaoBen_Click(object sender, EventArgs e)
        {
            //ResetValue();
            btnVaoBen.Enabled = false;
            btnXuatBen.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            ResetValue();
            pnlQuanLyDoXe.Enabled = true;
            dgvQLDX.Enabled = false;
            //  cboLoaiXe.Items.Add(blGiaVe.GetVehicleCategory());
            cboLoaiXe.Enabled = true;
            btnReload.Enabled = false;
            cboTheGui.Enabled = true;
            dgvQLDX.Enabled = false;
        }

        public void ResetValue()
        {
            txtVethang.ResetText();
            txtBienSo.ResetText();
            txtMaXe.ResetText();
            txtTenXe.ResetText();
            txtMauSac.ResetText();
            cboLoaiXe.SelectedIndex = -1;
            cboTheGui.SelectedIndex = -1;
            cboTheGui.ResetText();
            txtGioVao.ResetText();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            pnlQuanLyDoXe.Enabled = true;
            ResetValue();
            LoadData();
        }
        private bool CheckDaTa(string MaXe, string MaTheGui, string mavitri)
        {


            bool check = true;
            // kiểm tra phải nhập đủ thông tin
            if (txtBienSo.Text.Trim().Length == 0 || txtMaXe.Text.Trim().Length == 0
                || txtMauSac.Text.Trim().Length == 0 || cboLoaiXe.SelectedIndex == -1
                || cboTheGui.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng điền đủ thông tin!!");
                return false;
            }
            blDoXe = new BLDoXe();
            check = blDoXe.CheckType(MaXe, MaTheGui, mavitri);
            return check;
        }



        private void btnXeCoVeThang_Click(object sender, EventArgs e)
        {
            if (pnlQuanLyDoXe.Enabled == false)
            {
                MessageBox.Show("Vui lòng chọn chức năng Vào bến trước !");
                return;
            }
            if (txtVethang.Text.ToString().Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã vé tháng!");
                return;
            }
            blDoXe = new BLDoXe();
            DataTable seachVevicleInTicket = blDoXe.SearchMonthTicket(txtVethang.Text.Trim()).Tables[0];
            if (seachVevicleInTicket.Rows.Count == 0)
            {
                MessageBox.Show("Mã thẻ gửi xe không có trong danh sách đăng ký vé tháng!!!");
                return;
            }

            if (!seachVevicleInTicket.Rows[0]["GioVao"].ToString().Trim().Equals(""))
            {
                MessageBox.Show("Xe đã có trong bãi, vui lòng kiểm tra lại!!!");
            }
            else
            {
                fillData(seachVevicleInTicket.Rows[0]);
            }
        }
        private void fillData(DataRow dataRow)
        {
            txtBienSo.Text = dataRow["BienSo"].ToString().Trim();
            txtMaXe.Text = dataRow["MaXe"].ToString().Trim();
            txtTenXe.Text = dataRow["TenXe"].ToString().Trim();
            txtMauSac.Text = dataRow["MauSac"].ToString().Trim();
            txtGioVao.ResetText();
            cboTheGui.Items.Add(dataRow["MaTheGuiXe"].ToString().Trim());
            cboLoaiXe.SelectedItem = dataRow["TenLoaiXe"].ToString().Trim();
            cboTheGui.SelectedItem = dataRow["MaTheGuiXe"].ToString().Trim();
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtBienSo_Leave(object sender, EventArgs e)
        {
            DataRow rowVehicle = dataTableVehicles.AsEnumerable().FirstOrDefault(c => c.Field<string>("BienSo").Trim() == txtBienSo.Text.Trim());
            if (rowVehicle != null)
                fillData(rowVehicle);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {


            if (cboTheGui.SelectedIndex == -1)
                MaTheGui = "";
            else
                MaTheGui = cboTheGui.SelectedItem.ToString();

            if (cboViTri.SelectedIndex == -1)
                MaViTri = "";
            else
                MaViTri = cboViTri.SelectedItem.ToString();
            if (CheckDaTa(txtMaXe.Text, MaTheGui, MaViTri) == false)
                return;
            // kiểm tra Trùng Tên
            blDoXe = new BLDoXe();

            string maloaixe = dataTableVehicleType.Rows[cboViTri.SelectedIndex]["MaLoaiXe"].ToString();
            DataRow rowInfo = dataTableVehicles.AsEnumerable().FirstOrDefault(c => c.Field<string>("BienSo").Trim() == txtBienSo.Text.Trim());
            if (rowInfo != null) // xe này đã từng có thông tin rồi (đã từng vào bãi rồi, vẫn còn lưu lại thông tin --> cập nhật)
            {
                if(rowInfo["MaXe"].ToString().Trim() != txtMaXe.Text.Trim()) // nếu mã xe của xe có biển số này bị sửa đổi
                {
                    // Khai báo biến traloi
                    DialogResult traloi;
                    // Hiện hộp thoại hỏi đáp
                    traloi = MessageBox.Show("Mã xe không trùng với biển số, bạn muốn phục hồi lại mã xe không?", "Trả lời",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    // Kiểm tra có nhắp chọn nút Ok không?
                    if (traloi == DialogResult.OK)
                    {
                        txtMaXe.Text = rowInfo["MaXe"].ToString().Trim();
                        return;
                    }
                }    
            }
            else
            {
                if (blDoXe.VehicleGoIn(txtBienSo.Text, txtMaXe.Text, txtTenXe.Text, txtMauSac.Text, DateTime.Now, maloaixe, cboTheGui.SelectedItem.ToString(), cboViTri.SelectedItem.ToString(), ref err) == true)
                {
                    MessageBox.Show("Thêm xe vào bãi thành công");
                    LoadData();
                }
                else
                    MessageBox.Show("Có lỗi xảy ra, chưa thêm được!!");
            }


        }
    }
}
