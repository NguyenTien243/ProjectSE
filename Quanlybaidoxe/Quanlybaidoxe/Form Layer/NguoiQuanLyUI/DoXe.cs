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
        string maloaixe;

        internal BLTheGuiXe BLTheGuiXe { get; private set; }

        private void DoXe_Load(object sender, EventArgs e)
        {
            lbTongSoThe.Text = CountSumTicket().ToString();
            lbTongViTri.Text = CountSumPosition().ToString();
            BLDoXe blDoXe = new BLDoXe();
            dataTableVehicleType = blDoXe.GetVehicleType().Tables[0];
            timerThoiGianThuc.Enabled = true;

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
                lbSLTheXeCon.Text = "Hết thẻ!!!";
            }
            else
                lbSLTheXeCon.Text = dataTableTicketAvailable.Rows.Count.ToString();
            foreach (DataRow row in dataTableTicketAvailable.Rows)
            {
                cboTheGui.Items.Add(row["MaTheGuiXe"].ToString());
            }

        }
        private void UpdatePositionAvailable()
        {
            cboViTri.ResetText();
            cboViTri.Items.Clear();
            BLDoXe blDoXe = new BLDoXe();
            dataTablePositionAvailable = blDoXe.GetPosition().Tables[0];
            if (dataTablePositionAvailable.Rows.Count == 0)
            {
                MessageBox.Show("Thông báo hết chỗ để xe!");
                lbSLViTriCon.Text = "Hết chỗ!";
            }
            else
                lbSLViTriCon.Text = dataTablePositionAvailable.Rows.Count.ToString();
            foreach (DataRow row in dataTablePositionAvailable.Rows)
            {
                cboViTri.Items.Add(row["MaViTri"].ToString());
            }

        }
        private int CountSumPosition()
        {
            int sum = 0;
            BLViTriXe blViTriXe= new BLViTriXe();
            sum = Convert.ToInt32(blViTriXe.CountVitrido().Tables[0].Rows[0][0].ToString());
            return sum;
        }
        private int CountSumTicket()
        {
            int sum = 0;
            BLTheGuiXe blTheGuiXe = new BLTheGuiXe();
            sum = Convert.ToInt32(blTheGuiXe.CountSumTicket().Tables[0].Rows[0][0].ToString());
            return sum;
        }
        private void LoadData()
        {
            foreach (Control ctr in pnlQuanLyDoXe.Controls)
            {
                if (ctr is TextBox || ctr is ComboBox)
                {
                    ctr.Enabled = true;
                }

            }
            //lbT
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
            txtGioVao.Enabled = false;
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
                foreach (Control ctr in pnlQuanLyDoXe.Controls)
                {
                    if (ctr is TextBox || ctr is ComboBox)
                    {
                        ctr.Enabled = false;
                    }
                    
                }
                cboViTri.Enabled = true;
            }
        }
        private void fillData(DataRow dataRow)
        {
            txtBienSo.Text = dataRow["BienSo"].ToString().Trim();
            txtMaXe.Text = dataRow["MaXe"].ToString().Trim();
            txtTenXe.Text = dataRow["TenXe"].ToString().Trim();
            txtMauSac.Text = dataRow["MauSac"].ToString().Trim();
            txtGioVao.ResetText();
            DataRow rowVehicle = dataTableVehicles.AsEnumerable().FirstOrDefault(c => c.Field<string>("MaXe").Trim() == txtMaXe.Text.Trim());
            if (rowVehicle != null && rowVehicle["DangKyThang"].ToString().Trim() != "False") // nếu xe này có đăng ký tháng
            {
                blDoXe = new BLDoXe();
                DataRow getMonthStickID = blDoXe.GetMonthStickIDByVehicleID(txtMaXe.Text).Tables[0].Rows[0];
                cboTheGui.Items.Add(getMonthStickID["MaTheGuiXe"].ToString().Trim());
                cboTheGui.SelectedItem = getMonthStickID["MaTheGuiXe"].ToString().Trim();
            }
            cboLoaiXe.SelectedItem = dataRow["TenLoaiXe"].ToString().Trim();

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
        private void AddVarForShareVar()
        {
            SHAREVAR.sharevarMaXe = txtMaXe.Text.Trim();
            SHAREVAR.sharevarBienSo = txtBienSo.Text.Trim();
            SHAREVAR.sharevarLoaiXe = cboLoaiXe.Text.Trim();
            SHAREVAR.sharevarTenXe = txtTenXe.Text.Trim();
            SHAREVAR.sharevarMauXe = txtMauSac.Text.Trim();
            SHAREVAR.sharevarTGVao = txtGioVao.Text.Trim();
            SHAREVAR.sharevarTGRa = DateTime.Now.ToString().Trim();
            SHAREVAR.sharevarThoiLuongGui = CountTimeInParking();
            blDoXe = new BLDoXe();
            DataRow rowVehicleType = dataTableVehicleType.AsEnumerable().FirstOrDefault(c => c.Field<string>("TenLoaiXe").Trim() == cboLoaiXe.Text.Trim());
            string maloaixe = rowVehicleType["MaLoaiXe"].ToString();
            DateTime stardate = Convert.ToDateTime(txtGioVao.Text.Trim());
           

            DataRow rowMonthTicket = dataTableDoXe.AsEnumerable().FirstOrDefault(c => c.Field<string>("MaXe").Trim() == txtMaXe.Text.Trim());
            if (rowMonthTicket["DangKyThang"].ToString().Trim() == "False") // khi vé này không phải là vé tháng
                SHAREVAR.sharevarVeThang = false;
            else
                SHAREVAR.sharevarVeThang = true;
            if (SHAREVAR.sharevarVeThang)
            {
                SHAREVAR.sharevarVeThanhToan = "Thanh Toán vé tháng";
                SHAREVAR.sharevarVeTienThu = "0";
               
            }
            else
            {

                TimeSpan Time = DateTime.Now - stardate;
                int TongSoNgay = Time.Days;
                
      
                if (TongSoNgay < 1) // chưa gửi qua ngày
                {
                    DataTable tableTicketFee = blDoXe.HourlParkingFee(maloaixe, stardate, DateTime.Now).Tables[0];
                    if(tableTicketFee.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy giá vé như quy định, vui lòng kiểm tra lại bên quy định!");
                        return;
                    }
                    SHAREVAR.sharevarVeThanhToan = tableTicketFee.Rows[0]["TenGiaVe"].ToString().Trim();
                    SHAREVAR.sharevarVeTienThu = tableTicketFee.Rows[0]["GiaTien"].ToString().Trim();
                }
                else
                {
                    DataTable tableTicketFee = blDoXe.HourlParkingFee(maloaixe, stardate, DateTime.Now.AddDays(-TongSoNgay)).Tables[0];
                    if (tableTicketFee.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy giá vé như quy định, vui lòng kiểm tra lại bên quy định!");
                        return;
                    }
                    blDoXe = new BLDoXe();
                    // lấy giá qua ngày 
                    DataTable dataTableFeeOverDay = blDoXe.GetFeeOverDay(maloaixe).Tables[0];
                    if(dataTableFeeOverDay.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy giá vé như quy định, vui lòng kiểm tra lại bên quy định!");
                        return;
                    }
                    float FeeOverDay = float.Parse(dataTableFeeOverDay.Rows[0]["GiaTien"].ToString().Trim());
                    float FeeNewDay = float.Parse(tableTicketFee.Rows[0]["GiaTien"].ToString().Trim());
                    float ToTalFee = (FeeOverDay * TongSoNgay) + FeeNewDay;
                    SHAREVAR.sharevarVeThanhToan = tableTicketFee.Rows[0]["TenGiaVe"].ToString().Trim() + " (Qua ngày)";
                    SHAREVAR.sharevarVeTienThu = ToTalFee.ToString().Trim();
                }    
            }


        }
        // tham khảo từ https://stackoverflow.com/questions/894461/how-can-i-convert-int-90-minutes-to-datetime-130
        private string CountTimeInParking()
        {
            blDoXe = new BLDoXe();
            DateTime stardate = Convert.ToDateTime(txtGioVao.Text.Trim());
            DataRow rowTime = blDoXe.CountTimeInParkingAtMinute(stardate, DateTime.Now).Tables[0].Rows[0];
            double minute = 0;
            if (rowTime != null)
            {
                try
                {
                    minute = Convert.ToDouble(rowTime["Time"].ToString());
                }
                catch
                {

                }


            }
            TimeSpan time = TimeSpan.FromMinutes(minute);
            string FomatShowTime = time.Days + " Ngày " + time.Hours + " Giờ " + time.Minutes + " Phút ";  
            return FomatShowTime;
        }
        private void btnXuatBen_Click(object sender, EventArgs e)
        {
            AddVarForShareVar();
            ThanhToanXeRa formthanhtoan = new ThanhToanXeRa();
            formthanhtoan.ShowDialog();

            LoadData();
        }

        private void timerThoiGianThuc_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString();
        }

        private bool KiemTraKyTuToiDa()
        {
            bool check = true;
            string thongbaoloi = "";
            if (txtBienSo.Text.Trim().Length > 20)
            {
                thongbaoloi += "\nBiến số tối đa 20 ký tự!!!";
                check = false;
            }
            if (txtMaXe.Text.Trim().Length > 10)
            {
                thongbaoloi += "\nMã xe tối đa 10 ký tự!!!";
                check = false;
            }
            if (txtTenXe.Text.Trim().Length > 30)
            {
                thongbaoloi += "\nTên xe tối đa 30 ký tự!!!";
                check = false;
            }
            if (txtMauSac.Text.Trim().Length > 20)
            {
                thongbaoloi += "\nMàu sắc tối đa 20 ký tự!!!";
                check = false;
            }
          

            if (check == false)
            {
                MessageBox.Show(thongbaoloi);
            }
            return check;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (KiemTraKyTuToiDa() == false)
                return;
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

            maloaixe = dataTableVehicleType.Rows[cboLoaiXe.SelectedIndex]["MaLoaiXe"].ToString();
            DataRow rowInfo = dataTableVehicles.AsEnumerable().FirstOrDefault(c => c.Field<string>("BienSo").Trim() == txtBienSo.Text.Trim());
            if (rowInfo != null) // xe này đã từng có thông tin rồi (đã từng vào bãi rồi, vẫn còn lưu lại thông tin --> cập nhật)
            {
                string matheguixe = "";
               // kiểm tra xe có biển số này có đk vé tháng không 
                if (rowInfo["DangKyThang"].ToString().Trim() != "False" && rowInfo["MaXe"].ToString().Trim() == txtMaXe.Text.Trim())
                {
                    DataTable tablegetMonthStickID = blDoXe.GetMonthStickIDByVehicleID(txtMaXe.Text).Tables[0];
                    if (tablegetMonthStickID.Rows.Count == 0)
                    {
                        MessageBox.Show("Vui lòng kiểm tra lại thẻ đăng ký cho khách hàng!");
                    }
                    else
                        matheguixe = tablegetMonthStickID.Rows[0]["MaTheGuiXe"].ToString().Trim();

                }    
                if (rowInfo["MaXe"].ToString().Trim() != txtMaXe.Text.Trim() || rowInfo["TenLoaiXe"].ToString().Trim() != cboLoaiXe.Text.Trim()) // nếu mã xe của xe có biển số này bị sửa đổi
                {
                    // Khai báo biến traloi
                    DialogResult traloi;
                    // Hiện hộp thoại hỏi đáp
                    traloi = MessageBox.Show("Mã xe hoặc loại xe không trùng với biển số đã lưu khi trước, bạn muốn phục hồi lại mã xe và loại xe không?", "Trả lời",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    // Kiểm tra có nhắp chọn nút Ok không?
                    if (traloi == DialogResult.OK)
                    {
                        txtMaXe.Text = rowInfo["MaXe"].ToString().Trim();
                        cboLoaiXe.SelectedItem = rowInfo["TenLoaiXe"].ToString().Trim();
                        cboTheGui.ResetText();
                        cboTheGui.SelectedItem = matheguixe;
                        return;
                    }
                }
                else
                {

                    DataRow rowVehicleInParking = dataTableDoXe.AsEnumerable().FirstOrDefault(c => c.Field<string>("MaXe").Trim() == txtMaXe.Text.Trim());
                    if (rowVehicleInParking != null) // kiểm tra xe đã có xong bãi chưa, != null là xe này hiện đang ở trong bãi rồi
                    {
                        MessageBox.Show("Xe đã ở trong bãi từ trước, vui lòng kiểm tra lại!");
                        return;
                    }

                    blDoXe = new BLDoXe();

                    if (blDoXe.UpdateVehicle(txtBienSo.Text, txtMaXe.Text, txtTenXe.Text, txtMauSac.Text, DateTime.Now, maloaixe, cboTheGui.SelectedItem.ToString(), cboViTri.SelectedItem.ToString(), ref err))
                    {
                        MessageBox.Show("Thêm xe vào bãi thành công");
                        LoadData();
                    }
                    else
                        MessageBox.Show("Có lỗi xảy ra, chưa thêm được!!");
                }
            }
            else
            {
                // "Mã xe bị trùng, vui lòng nhập mã xe khác!!!"
                if (blDoXe.VehicleGoIn(txtBienSo.Text, txtMaXe.Text, txtTenXe.Text, txtMauSac.Text, DateTime.Now, maloaixe, cboTheGui.SelectedItem.ToString(), cboViTri.SelectedItem.ToString(), ref err) == true)
                {
                    MessageBox.Show("Thêm xe vào bãi thành công");
                    txtGioVao.Enabled = true;
                    LoadData();
                }
                else
                    MessageBox.Show("Có lỗi xảy ra, chưa thêm được!!");
            }


        }
    }
}
