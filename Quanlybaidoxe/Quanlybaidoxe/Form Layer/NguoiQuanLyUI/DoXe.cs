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
    public partial class DoXe : Form
    {
        public DoXe()
        {
            InitializeComponent();
        }
        DataTable dataTableDoXe = null;
        DataTable dataTableVehicleType = null;
        BLDoXe blDoXe = new BLDoXe();
        private void DoXe_Load(object sender, EventArgs e)
        {
            BLDoXe blDoXe = new BLDoXe();
            dataTableVehicleType = blDoXe.GetVehicleType().Tables[0];
            LoadData();
            dgvQLDX.Columns["DangKyThang"].ReadOnly = true;
            cboLoaiXe.Items.Clear();
            for (int dem = 0; dem < dataTableVehicleType.Rows.Count; dem++) //Thêm loại xe vào combobox
            {
                cboLoaiXe.Items.Add(dataTableVehicleType.Rows[dem]["TenLoaiXe"].ToString());
            }
        }
        private void LoadData()
        {
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
            cboMaVe.Enabled = true;
            dgvQLDX.Enabled = false;
        }

        public void ResetValue()
        {
            txtBienSo.ResetText();
            txtMaXe.ResetText();
            txtTenXe.ResetText();
            txtMauSac.ResetText();
            cboLoaiXe.SelectedIndex = -1;
            cboMaVe.SelectedIndex = -1;
            labelUudai.ResetText();
        }
    }
}
