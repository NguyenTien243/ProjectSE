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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        DataTable dataTableGiaVe = null;
        BLGiaVe blGiaVe = new BLGiaVe();
        int VeThang;
        float giave;
        int giotoithieu, giotoida, uudai;
        bool Add;
        string err;         
        private void LoadData()
        {
            try
            {
                dgvGiaVe.Enabled = true;
                dataTableGiaVe = new DataTable();
                dataTableGiaVe.Clear();
                DataSet ds = blGiaVe.GetAllTickets();
                dataTableGiaVe = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvGiaVe.DataSource = dataTableGiaVe;
                // Thay đổi độ rộng cột
                dgvGiaVe.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel
                //ResetValue();
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnHuy.Enabled = false;
                btnLuu.Enabled = false;
                cboLoaiXe.Items.Clear();
                for (int dem = 0; dem < blGiaVe.GetVehicleCategory().Tables[0].Rows.Count; dem++) //Thêm loại xe vào combobox
                {                   
                    cboLoaiXe.Items.Add(blGiaVe.GetVehicleCategory().Tables[0].Rows[dem][0].ToString());
                }
                pnlQuanLyGiaVe.Enabled = false;

                dgvGiaVe_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table Xe. Lỗi rồi!!!");
            }
        }

        /// <summary>
        /// Hàm kiểm tra trùng tên giá vé, giờ tối thiểu, giờ tối đa, ưu đãi, giá vé
        /// </summary>
        private bool CheckDaTa(ref float giave,ref int giotoithieu,ref int giotoida,ref int uudai)
        {
            bool check = true;
            // kiểm tra phải nhập đủ thông tin
            if (txtMaGiaVe.Text.Trim().Length == 0 || txtTenGiaVe.Text.Trim().Length == 0
                || txtGiaVe.Text.Trim().Length == 0 || cboLoaiXe.Text.Trim().Length == 0
                || txtGioToiThieu.Text.Trim().Length == 0 || txtGioToiDa.Text.Trim().Length == 0 || txtUuDai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng điền đủ thông tin!!");
                check = false;
            }

            // kiểm tra giá vé có nhập đúng hay không
            try
            {
                giave = float.Parse(txtGiaVe.Text.Trim());
                if (giave < 0) // nếu giá vé nhỏ hơn 0 thì chia 0 cho xảy ra lỗi để nhảy vào catch
                {
                    MessageBox.Show("Giá vé phải là kiểu số và lớn hơn hoặc bằng 0!");
                    check = false;
                }    
            }
            catch
            {
                MessageBox.Show("Giá vé phải là kiểu số và lớn hơn hoặc bằng 0!");
                check = false;
            }

            // kiểm tra giờ tối thiểu và giờ tối đa có phải là kiểu int không
            try
            {
                giotoithieu = int.Parse(txtGioToiThieu.Text.Trim());
                giotoida = int.Parse(txtGioToiDa.Text.Trim());
                if (giotoida < 0 || giotoida < 0) // nếu giờ tối thiểu hoặc giờ tối đa nhỏ hơn 0 thì chia 0 cho xảy ra lỗi để nhảy vào catch
                {
                    MessageBox.Show("Giờ tối thiểu và giờ tối đa phải là số nguyên và lớn hơn hoặc bằng 0!");
                    check = false;
                }    
            }
            catch
            {
                MessageBox.Show("Giờ tối thiểu và giờ tối đa phải là số nguyên và lớn hơn hoặc bằng 0!");
                check = false;
            }
            // kiểm tra giờ tối thiểu phải nhỏ hơn giờ tối đa
            if (giotoida < giotoithieu)
            {
                MessageBox.Show("Giờ tối thiểu phải nhỏ hơn giờ tối đa!");
                check = false;
            }
            // kiểm tra ưu đãi >=0
            try
            {
                uudai = int.Parse(txtUuDai.Text.Trim());
                if (uudai < 0) // nếu ưu đãi nhỏ hơn 0 thì chia 0 cho lỗi nhảy vào hàm catch để thông báo
                {
                    MessageBox.Show("Vui lòng nhập ưu đãi là số nguyên không âm!");
                    check = false;
                }    
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập ưu đãi là số nguyên không âm!");
                check = false;
            }
            return check;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (CheckDaTa(ref giave, ref giotoithieu, ref giotoida, ref uudai) == false)
                return;
            // kiểm tra Trùng Tên
            blGiaVe = new BLGiaVe();
            if (blGiaVe.CheckNameTicket(txtMaGiaVe.Text.Trim(), txtTenGiaVe.Text.Trim(), ref err) == false)
            {
                MessageBox.Show("Tên giá vé bị trùng vui lòng kiểm tra lại");
                return;
            }

            if (Add == true)
            {
                blGiaVe = new BLGiaVe();
                //  try 
                
                    if (blGiaVe.CheckType(txtGioToiThieu.Text, txtGioToiDa.Text,txtUuDai.Text) == true)
                    {
                        if (blGiaVe.CheckTime(txtGioToiThieu.Text, txtGioToiDa.Text) == true)
                       {
                        if (blGiaVe.CheckTicketId(txtMaGiaVe.Text).Tables[0].Rows.Count != 0)
                        {
                            MessageBox.Show("Vị trí này đã tồn tại, hãy nhập mã vị trí khác");
                        }
                        else if (blGiaVe.AddTicket(txtMaGiaVe.Text, txtTenGiaVe.Text, float.Parse(txtGiaVe.Text), blGiaVe.GetVechicleId(cboLoaiXe.Text).Tables[0].Rows[0][0].ToString(), txtGioToiThieu.Text, txtGioToiDa.Text, txtUuDai.Text, VeThang, ref err) == true)
                        {

                            MessageBox.Show("Đã thêm giá vé mới");
                            LoadData();
                        }
                        else MessageBox.Show("Có lỗi xảy ra, chưa thêm được!!");
                       }
                    }
              
         
            }
            else
            { 
                blGiaVe = new BLGiaVe();
                string maloaive = blGiaVe.GetVechicleId(cboLoaiXe.Text).Tables[0].Rows[0][0].ToString();
                int r = dgvGiaVe.CurrentCell.RowIndex;
                string MaViTri = dgvGiaVe.Rows[r].Cells[0].Value.ToString();
                blGiaVe = new BLGiaVe();
                if (blGiaVe.EditTicket(txtMaGiaVe.Text.Trim(), txtTenGiaVe.Text.Trim(), giave,maloaive, giotoithieu, giotoida, uudai, VeThang, ref err) == true)
                {
                    MessageBox.Show("Chỉnh sửa thành công, đã cập nhật lại thông tin");
                    LoadData();
                    txtMaGiaVe.Enabled = true;
                }
                else MessageBox.Show("Không thể chỉnh sửa!!");
            }
        }

        private void dgvGiaVe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Thứ tự dòng hiện hành
                int r;
                if (dgvGiaVe.CurrentCell == null)
                    return;
                else
                    r = dgvGiaVe.CurrentCell.RowIndex;               
                txtMaGiaVe.Text = dgvGiaVe.Rows[r].Cells[0].Value.ToString();
                txtTenGiaVe.Text = dgvGiaVe.Rows[r].Cells[1].Value.ToString();
                txtGiaVe.Text = dgvGiaVe.Rows[r].Cells[2].Value.ToString();
                txtGioToiThieu.Text = dgvGiaVe.Rows[r].Cells[4].Value.ToString();
                txtGioToiDa.Text = dgvGiaVe.Rows[r].Cells[5].Value.ToString();
                txtUuDai.Text = dgvGiaVe.Rows[r].Cells[6].Value.ToString();
                cboLoaiXe.Text  = blGiaVe.GetNameVehicle(dgvGiaVe.Rows[r].Cells[3].Value.ToString()).Tables[0].Rows[0][0].ToString();
                if (dgvGiaVe.Rows[r].Cells["VeThang"].Value.ToString() == "True")
                    checkBoxVeThang.Checked = true;
                else
                    checkBoxVeThang.Checked = false;
            }
            catch
            {

            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            LoadData();
            // không cho thay đỏi checkbox trên datagridview : https://www.codeproject.com/Questions/133512/Disable-checkbox-in-datagridview
            dgvGiaVe.Columns["VeThang"].ReadOnly = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            checkBoxVeThang.Checked = false;
            Add = true;
            //ResetValue();
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            ResetValue();
            pnlQuanLyGiaVe.Enabled = true;
            dgvGiaVe.Enabled = false;
            //  cboLoaiXe.Items.Add(blGiaVe.GetVehicleCategory());
            cboLoaiXe.Enabled = true;

            checkBoxVeThang.Enabled = true;
            dgvGiaVe.Enabled = false;
        }
        public void ResetValue()
        {
            txtMaGiaVe.ResetText();
            txtTenGiaVe.ResetText();
            txtGiaVe.ResetText();
            txtGioToiThieu.ResetText();
            txtGioToiDa.ResetText();
            txtUuDai.ResetText();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Add = false;
            pnlQuanLyGiaVe.Enabled = true;
            txtMaGiaVe.Enabled = true;
            ResetValue();
            LoadData();          
        }

        private void checkBoxVeThang_CheckedChanged(object sender, EventArgs e)
        {       
            if (checkBoxVeThang.Checked == true)
            {
                txtGioToiDa.Enabled = false;
                txtGioToiThieu.Enabled = false;
                txtGioToiDa.Text = "0";
                txtGioToiThieu.Text = "0";
                VeThang = 1;
            }
            else
            {
                txtGioToiDa.Enabled = true;
                txtGioToiThieu.Enabled = true;
                VeThang = 0;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(checkBoxVeThang.Checked ==true)
            {
                txtGioToiDa.Text = "0";
                txtGioToiThieu.Text = "0";
                VeThang = 1;
            }    
            dgvGiaVe.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            pnlQuanLyGiaVe.Enabled = true;
            txtMaGiaVe.Enabled = false;
            dgvGiaVe.Enabled = false;
            Add = false;
        }

    
        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh
                // Lấy thứ tự record hiện hành
                int row = dgvGiaVe.CurrentCell.RowIndex;
                blGiaVe = new BLGiaVe();
                // nếu mã vị trí hiện đang có xe thì không cho xóa
                if (blGiaVe.CheckDeleteTicket(txtMaGiaVe.Text.Trim(), ref err) == false)
                {
                    MessageBox.Show("Không cho phép xóa vé ngày!");
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

                    blGiaVe = new BLGiaVe();
                    if (blGiaVe.DeleteTicket(this.txtMaGiaVe.Text, ref err))
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
    }
}
