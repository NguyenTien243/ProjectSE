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
        bool check = true;
        FormDKyXe frmDkyXe;
        bool Giahan = false;
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
                btnGiaHan.Enabled = true;
                dateTimePickerHetHan.Enabled = false;
                cbVeThang.Items.Clear();

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
            dgvQLKhachHang.Enabled = false;
            btnGiaHan.Enabled = false;
            // Kich hoạt biến Them
            SHAREVAR.Add = false;
            Giahan = false;
            int r = dgvQLKhachHang.CurrentCell.RowIndex;
            SHAREVAR.MaKH = dgvQLKhachHang.Rows[r].Cells[0].Value.ToString();
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            //   this.btnHuy.Enabled = true;
            this.pnlQuanLyKH.Enabled = true;
            foreach (Control ctr in pnlQuanLyKH.Controls)
            {
                ctr.Enabled = true;
            }
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnDangKy.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            txtMaKH.Enabled = false;
            cbVeThang.Enabled = false;
            dateTimePickerHetHan.Enabled = false;
            this.txtTenKH.Focus();
        }

        private void txtMaXe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaXe_Click(object sender, EventArgs e) //mở panel đăng ký xe cho khách hàng
        {
            //this.pnlQuanLyKH.Controls.Clear();
            foreach (Control control in pnlQuanLyKH.Controls)
            {
                control.Visible = false;
            }

            frmDkyXe = new FormDKyXe();
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
            txtMaXe.Enabled = true;

            dateTimePickerHetHan.ResetText();
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
                dateTimePickerHetHan.Text = dgvQLKhachHang.Rows[r].Cells[7].Value.ToString();
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
            //dgvQLKhachHang.Columns["NgayHetHanVeThang"].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm"; // fomat dạng ngày đổ lên datagridview https://www.ddth.com/showthread.php/312166-H%E1%BB%8Fi-v%E1%BB%81-format-datatime-trong-datagridview-c%E1%BB%A7a-c
            LoadData();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {

            dgvQLKhachHang.Enabled = false;
            btnGiaHan.Enabled = false;
            // Kich hoạt biến Them
            SHAREVAR.Add = true;
            Giahan = false;
            // Xóa trống các đối tượng trong Panel
            ResetValues();


            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            //   this.btnHuy.Enabled = true;
            this.pnlQuanLyKH.Enabled = true;
            foreach (Control ctr in pnlQuanLyKH.Controls)
            {
                ctr.Enabled = true;
            }
            dateTimePickerHetHan.Enabled = false;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnDangKy.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            // this.btnThoat.Enabled = false;
            // Đưa con trỏ đến TextField txtXe
            this.txtMaKH.Focus();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            //nguồn tham khảo xóa control https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control.controlcollection.remove?view=net-5.0
            if (pnlQuanLyKH.Controls.Contains(frmDkyXe))
            {
                pnlQuanLyKH.Controls.Remove(frmDkyXe);
            }
            foreach (Control ctr in pnlQuanLyKH.Controls)
            {
                ctr.Visible = true;
            }
            LoadData();
        }


        private void pnlQuanLyKH_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (pnlQuanLyKH.Controls.Contains(frmDkyXe) == false)
            {

                foreach (Control ctr in pnlQuanLyKH.Controls)
                {

                    //if (ctr.Name == "txtMaXe") ctr.Text = maxe;
                    ctr.Visible = true;
                }
                txtMaXe.Text = SHAREVAR.maxe;
                if (SHAREVAR.Add == true)
                    txtMaXe.Enabled = false;
                else txtMaXe.Enabled = true;
                cbVeThang.Items.Clear();   //cho tên vé tháng tương ứng với loại xe vào combobox
                for (int dem = 0; dem < blKhachHang.GetNameTicket(SHAREVAR.maloaixe).Tables[0].Rows.Count; dem++) //Thêm tên loại vé tháng vào combobox
                {
                    cbVeThang.Items.Add(blKhachHang.GetNameTicket(SHAREVAR.maloaixe).Tables[0].Rows[dem][0].ToString());
                }
                btnLuu.Enabled = true;
            }
        }

        private void cbVeThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string months = blKhachHang.GetDetailOfTicket(cbVeThang.GetItemText(cbVeThang.SelectedItem)).Tables[0].Rows[0][8].ToString();  ////
            float price = float.Parse(blKhachHang.GetDetailOfTicket(cbVeThang.GetItemText(cbVeThang.SelectedItem)).Tables[0].Rows[0][2].ToString());
            int uudai = int.Parse(blKhachHang.GetDetailOfTicket(cbVeThang.GetItemText(cbVeThang.SelectedItem)).Tables[0].Rows[0][6].ToString()); //LỖI
            SHAREVAR.PriceOfRegister = price - price * uudai / 100;

            //txtNgayHetHan.Text = now.AddMonths(Int32.Parse(months)).ToString();
            if (Giahan == false)
            {
                dateTimePickerHetHan.Text = now.AddMonths(Int32.Parse(months)).ToString();
            }
            else
            {
                int r = dgvQLKhachHang.CurrentCell.RowIndex;
                dateTimePickerHetHan.Text = dgvQLKhachHang.Rows[r].Cells[7].Value.ToString();
                dateTimePickerHetHan.Text = Convert.ToDateTime(dateTimePickerHetHan.Text).AddMonths(Int32.Parse(months)).ToString();
            }
        }
        private bool KiemTraKyTuToiDa()
        {
            bool check = true;
            string thongbaoloi = "";
            if (txtMaKH.Text.Trim().Length > 10)
            {
                thongbaoloi += "\nMã khách hàng tối đa 10 ký tự!!!";
                check = false;
            }
            if (txtTenKH.Text.Trim().Length > 30)
            {
                thongbaoloi += "\nTên khách hàng tối đa 30 ký tự!!!";
                check = false;
            }
            if (txtCMND.Text.Trim().Length > 20)
            {
                thongbaoloi += "\nCMND tối đa 30 ký tự!!!";
                check = false;
            }
            if (txtDiaChi.Text.Trim().Length > 50)
            {
                thongbaoloi += "\nĐịa chỉ tối đa 50 ký tự!!!";
                check = false;
            }
            if (txtSDT.Text.Trim().Length > 15)
            {
                thongbaoloi += "\nSố điện thoại tối đa 15 ký tự!!!";
                check = false;
            }
            if (txtMaXe.Text.Trim().Length > 10)
            {
                thongbaoloi += "\nMã xe tối đa 10 ký tự!!!";
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
            check = true;
            string Gioitinh;
            if (radNam.Checked) Gioitinh = "Nữ";
            else Gioitinh = "Nam";
            if (radNam.Checked == false && radNu.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn giới tính");
                check = false;
            }
            if (txtMaKH.Text.Trim().Length == 0 || txtTenKH.Text.Trim().Length == 0 || txtDiaChi.Text.Trim().Length == 0 || txtCMND.Text.Trim().Length == 0
               || txtSDT.Text.Trim().Length == 0)
            {

                MessageBox.Show("Bạn phải điền đủ tất cả thông tin");
                check = false;
                return;
            }

            // kiểm tra Trùng CMND
            blKhachHang = new BLKhachHang();

            if (check == true)
            {
                if (SHAREVAR.Add == true && Giahan == false)
                {
                    if (cbVeThang.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Chưa chọn vé tháng");
                        check = false;
                    }
                    //if (blKhachHang.CheckIdCustomer(txtMaKH.Text).Tables[0].Rows.Count != 0)
                    //{
                    //    MessageBox.Show("Mã khách hàng này đã tồn tại, hãy nhập mã khác!!");
                    //    check = false;
                    //}
                    else
                    {
                        blKhachHang = new BLKhachHang();
                        if (blKhachHang.CustomerRegister(txtMaKH.Text, txtTenKH.Text, dateTimePickerKH.Value, Gioitinh, txtCMND.Text, txtSDT.Text, txtDiaChi.Text, dateTimePickerHetHan.Value, txtMaXe.Text, DateTime.Now, DateTime.Now, SHAREVAR.PriceOfRegister, ref err) == true)
                        {

                            if (blKhachHang.GanTheXe(txtMaXe.Text, ref err) == true)
                            {
                                MessageBox.Show("Chúc mừng " + txtTenKH.Text + " đã đăng ký vé thành công! \nSố tiền vé của bạn là: " + SHAREVAR.PriceOfRegister.ToString() + " VNĐ \n Mã thẻ của quý khách là: " + blKhachHang.MaThe(txtMaXe.Text).Tables[0].Rows[0][0]);

                                LoadData();
                                SHAREVAR.Add = false;
                            }
                            else MessageBox.Show("Không còn mã thẻ trống");
                        }
                        else MessageBox.Show("Có lỗi xảy ra, chưa thêm được!!");
                    }
                }
                else if (SHAREVAR.Add == false && Giahan == false)
                {
                    blKhachHang = new BLKhachHang();
                    //string maloaive = blXe.GetVechicleId(cboLoaiXe.Text).Tables[0].Rows[0][0].ToString();
                    int r = dgvQLKhachHang.CurrentCell.RowIndex;
                    SHAREVAR.MaKH = dgvQLKhachHang.Rows[r].Cells[0].Value.ToString();
                    blKhachHang = new BLKhachHang();
                    if (blKhachHang.UpdateCustomer(txtMaKH.Text, txtTenKH.Text, dateTimePickerKH.Value, Gioitinh, txtCMND.Text, txtSDT.Text, txtDiaChi.Text, dateTimePickerHetHan.Value, txtMaXe.Text, ref err) == true)
                    {
                        MessageBox.Show("Chỉnh sửa thành công, đã cập nhật lại thông tin");
                        LoadData();
                        txtTenKH.Enabled = true;
                        cbVeThang.Enabled = true;
                    }
                    else MessageBox.Show("Không thể chỉnh sửa!!");
                }
                if (SHAREVAR.Add == false && Giahan == true)
                {
                    if (blKhachHang.extensionCustomer(txtMaKH.Text, dateTimePickerHetHan.Value, txtMaXe.Text, DateTime.Now, DateTime.Now, SHAREVAR.PriceOfRegister, ref err) == true)
                    {
                        MessageBox.Show("Gia hạn vé thành công! \nSố tiền vé của bạn là: " + SHAREVAR.PriceOfRegister.ToString() + " VNĐ");
                        LoadData();
                        cbVeThang.Enabled = false;
                        Giahan = false;

                    }
                    else MessageBox.Show("Bị lỗi gia hạn!!");

                }
            }
        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            SHAREVAR.Add = false;
            dgvQLKhachHang.Enabled = false;
            btnGiaHan.Enabled = false;
            // Kich hoạt biến Them
            Giahan = true;
            int r = dgvQLKhachHang.CurrentCell.RowIndex;
            //string MaKH = dgvQLKhachHang.Rows[r].Cells[0].Value.ToString();
            BLXe blXe = new BLXe();
            string MaLoaiXe = blXe.GetVehicleCategoryId(txtMaXe.Text).Tables[0].Rows[0][0].ToString();
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            //   this.btnHuy.Enabled = true;
            pnlQuanLyKH.Enabled = true;

            dateTimePickerHetHan.Enabled = false;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnDangKy.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;

            foreach (Control ctr in pnlQuanLyKH.Controls)
            {
                ctr.Enabled = false;
            }

            cbVeThang.Enabled = true;

            this.cbVeThang.Focus();

            cbVeThang.Items.Clear();   //cho tên vé tháng tương ứng với loại xe vào combobox
            for (int dem = 0; dem < blKhachHang.GetNameTicket(MaLoaiXe).Tables[0].Rows.Count; dem++) //Thêm tên loại vé tháng vào combobox
            {
                cbVeThang.Items.Add(blKhachHang.GetNameTicket(MaLoaiXe).Tables[0].Rows[dem][0].ToString());
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SHAREVAR.Add = false;
            if (pnlQuanLyKH.Controls.Contains(frmDkyXe) == true)
            {
                pnlQuanLyKH.Controls.Remove(frmDkyXe);
                foreach (Control ctr in pnlQuanLyKH.Controls)
                {

                    //if (ctr.Name == "txtMaXe") ctr.Text = maxe;
                    ctr.Visible = true;
                }
                txtMaXe.Enabled = true;
                cbVeThang.Items.Clear();   //cho tên vé tháng tương ứng với loại xe vào combobox
                for (int dem = 0; dem < blKhachHang.GetNameTicket(SHAREVAR.maloaixe).Tables[0].Rows.Count; dem++) //Thêm tên loại vé tháng vào combobox
                {
                    cbVeThang.Items.Add(blKhachHang.GetNameTicket(SHAREVAR.maloaixe).Tables[0].Rows[dem][0].ToString());
                }
                btnLuu.Enabled = true;
                return;
            }
            if (SHAREVAR.DkyXe == true)
            {
                BLXe blXe = new BLXe();
                try
                {
                    blXe.DeleteVehicle(SHAREVAR.maxe);
                    SHAREVAR.DkyXe = false;
                    SHAREVAR.maxe = null;
                    SHAREVAR.maloaixe = null;
                }
                catch { MessageBox.Show("Chưa thể hủy thông tin xe đã đăng ký"); };
            }
            ResetValues();

            //if (pnlQuanLyKH.Controls.Contains(frmDkyXe) == true)
            //{
            //    pnlQuanLyKH.Dispose();

            //    QLKhachHang frmQLKH = new QLKhachHang();
            //    frmQLKH.TopLevel = false;
            //    this.pnlQuanLyKH.Controls.Add(frmQLKH);

            //    foreach (Control ctr in pnlQuanLyKH.Controls)
            //    {
            //        ctr.Visible = true;
            //    }
            //}
            btnDangKy.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnGiaHan.Enabled = true;
            dateTimePickerHetHan.Enabled = false;
            cbVeThang.Items.Clear();
            dgvQLKhachHang.Enabled = true;

            pnlQuanLyKH.Enabled = false;

            dgvQLKhachHang_CellClick(null, null);
        }


        private void txtMaKH_Validating(object sender, CancelEventArgs e)
        {
            if (blKhachHang.CheckIdCustomer(txtMaKH.Text).Tables[0].Rows.Count != 0)
            {
                errorProvider1.SetError(txtMaKH, "Mã khách hàng này đã tồn tại");
                check = false;
            }
            else
            {
                errorProvider1.SetError(txtMaKH, null);
                check = true;
            }
        }

        private void dateTimePickerKH_Validating(object sender, CancelEventArgs e)
        {
            if (DateTime.Now.Year - dateTimePickerKH.Value.Year < 18)
            {
                errorProvider1.SetError(dateTimePickerKH, "Chưa đủ tuổi đăng ký xe");
                check = false;

            }
            else
            {
                errorProvider1.SetError(dateTimePickerKH, null);
                check = true;
            }
        }

        private void txtCMND_Validating(object sender, CancelEventArgs e)
        {

            if (blKhachHang.CheckCMND(txtMaKH.Text, txtCMND.Text).Tables[0].Rows.Count != 0)
            {
                errorProvider1.SetError(txtCMND, "CMND bị trùng vui lòng kiểm tra lại");
                check = false;
            }
            else
            {
                errorProvider1.SetError(txtCMND, null);
                check = true;
            }
        }

        private void cbVeThang_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtSDT_Validating(object sender, CancelEventArgs e)
        {
            double temp;
            string tam = txtSDT.Text.Trim();
            if (tam.Length > 0)
                tam.Substring(0, 1);//Lấy kí tự đầu của chuỗi
            if (txtSDT.Text.Trim().Length != 10)
            {
                errorProvider1.SetError(txtSDT, "Số điện thoại gồm 10 số");
                check = false;
            }
            else
            if (tam.Substring(0, 1) != "0")
            {
                errorProvider1.SetError(txtSDT, "Phải bắt đầu bằng số 0");
                check = false;
            }
            else if (double.TryParse(tam, out temp) != true)
            {
                errorProvider1.SetError(txtSDT, "Số điện thoại không chứa kí tự chữ");
                check = false;
            }
            else
            {
                errorProvider1.SetError(txtSDT, null);
                check = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh
                // Lấy thứ tự record hiện hành
                int row = dgvQLKhachHang.CurrentCell.RowIndex;

                BLXe blXe = new BLXe();
                // nếu mã vị trí hiện đang có xe thì không cho xóa
                if (blXe.CheckDeleteVehicle(txtMaXe.Text.Trim(), ref err) == true)
                {
                    MessageBox.Show("Khách hàng đang đỗ xe, không thể xóa!");
                    return;
                }
                // Viết câu lệnh SQL
                // Hiện thông báo xác nhận việc xóa mẫu t
                // Khai báo biến traloi
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp
                traloi = MessageBox.Show("Bạn có chắc xóa khách hàng này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không?
                if (traloi == DialogResult.Yes)
                {

                    blKhachHang = new BLKhachHang();
                    if (blKhachHang.DeleteCustomer(txtMaKH.Text, txtMaXe.Text, ref err) == true)
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
                    MessageBox.Show("Không thực hiện được việc xóa!");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }



        private void cboTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTimKiem.ResetText();
            if (cboTimKiem.SelectedIndex == -1)
                return;

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            switch (cboTimKiem.SelectedItem)
            {
                case "Mã Khách Hàng":
                    dgvQLKhachHang.DataSource = blKhachHang.GetInfo("MaKH", txtTimKiem.Text, ref err).Tables[0];
                    break;
                case "Tên Khách Hàng":
                    dgvQLKhachHang.DataSource = blKhachHang.GetInfo("TenKH", txtTimKiem.Text, ref err).Tables[0];

                    break;
                default:
                    break;
            }
        }

        private void cboTimKiem_Validating(object sender, CancelEventArgs e)
        {
        }
    }
}

       
   
