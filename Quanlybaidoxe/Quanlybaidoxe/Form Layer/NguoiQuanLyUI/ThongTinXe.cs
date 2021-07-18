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
    public partial class ThongTinXe : Form
    {
        public ThongTinXe()
        {
            InitializeComponent();
        }
        DataTable dataTableXeDK = null;
        DataTable dataTableXeChuaDK = null;
        BLXe blXe = new BLXe();

        private void dgvXeDK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void ThongTinXe_Load(object sender, EventArgs e)
        {
            dgvXeDK.Enabled = true;
            dataTableXeDK = new DataTable();
            dataTableXeDK.Clear();
            DataSet dsXeDK = blXe.GetInfoVehicleRegistered();
            dataTableXeDK = dsXeDK.Tables[0];
            // Đưa dữ liệu lên DataGridView
            dgvXeDK.DataSource = dataTableXeDK;
            // Thay đổi độ rộng cột
            dgvXeDK.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
          //  dgvXeDK.AutoResizeColumns();

            dgvXeChuaDK.Enabled = true;
            dataTableXeChuaDK = new DataTable();
            dataTableXeChuaDK.Clear();
            DataSet dsXeChuaDK = blXe.GetInfoVehicleNotRegisted();
            dataTableXeChuaDK = dsXeChuaDK.Tables[0];
            // Đưa dữ liệu lên DataGridView
            dgvXeChuaDK.DataSource = dataTableXeChuaDK;
            // Thay đổi độ rộng cột
            dgvXeChuaDK.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

            //dgvXeChuaDK.AutoResizeColumns();
        }
    }
}
