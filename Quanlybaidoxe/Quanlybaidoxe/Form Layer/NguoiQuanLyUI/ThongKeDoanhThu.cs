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
    public partial class ThongKeDoanhThu : Form
    {


        public ThongKeDoanhThu()
        {
            InitializeComponent();
            LoadDateTimePickerBill();
            LoadListByDate(dtgiovao.Value.ToString("yyyy-MM-dd HH:mm:ss"), dtgiora.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            LoadSumByDate(dtgiovao.Value.ToString("yyyy-MM-dd HH:mm:ss"), dtgiora.Value.ToString("yyyy-MM-dd HH:mm:ss"));
        }

        BLDoanhThu blDoanhThu = new BLDoanhThu();
        #region methods
        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtgiovao.Value = new DateTime(today.Year, today.Month, 1);
            dtgiora.Value = dtgiovao.Value.AddMonths(1).AddDays(-1);
        }
        void LoadListByDate(string checkIn, string checkOut)
        {
            dgvDoanhThu.DataSource = blDoanhThu.GetBillListByDate(checkIn, checkOut).Tables[0];

        }
        void LoadSumByDate(string checkIn, string checkOut)
        {
            dgvTongThu.DataSource = blDoanhThu.GetSumBillByDate(checkIn, checkOut).Tables[0];
        }
        #endregion

        #region event
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string GioVao = dtgiovao.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string GioRa = dtgiora.Value.ToString("yyyy-MM-dd HH:mm:ss");
            LoadListByDate(GioVao, GioRa);
            LoadSumByDate(GioVao, GioRa);
        }
        #endregion


    }
}
