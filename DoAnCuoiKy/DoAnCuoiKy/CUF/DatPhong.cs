using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DoAnCuoiKy.BLLayer;

namespace DoAnCuoiKy.CUF
{
    public partial class DatPhong : Form
    {
        ConnectDatabase db = new ConnectDatabase();
        private string Maphong;
        private string Trangthai;
        private string Loaiphong;
        BLDatPhong blDatPhong = new BLDatPhong();
        
        public DatPhong(string maphong, string trangthai, string loaiphong)
        {
            InitializeComponent();
            this.Maphong = maphong;
            this.Trangthai = trangthai;
            this.Loaiphong = loaiphong;
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void DatPhong_Load(object sender, EventArgs e)
        {
            txt_LoaiPhong.Enabled = false;
            txt_TenPhong.Enabled = false;
            txt_TrangThai.Enabled = false;
            txt_TenPhong.Text = Maphong;
            txt_TrangThai.Text = Trangthai;
            txt_LoaiPhong.Text = blDatPhong.LoadPhong(Maphong);
        }

        private void txt_TongChiPhi_Click(object sender, EventArgs e)
        {


        }

        private void dt_TimeOut_ValueChanged(object sender, EventArgs e)
        {
            #region tính chi phí
            TimeSpan time = Convert.ToDateTime(dt_TimeOut.Text) - Convert.ToDateTime(dt_timeIn.Text);
            db.openConnection();
            int giaphong = blDatPhong.loadTien(Loaiphong);
            txt_TongChiPhi.Text = (time.Days * giaphong).ToString();
            txt_TongChiPhi.Enabled = false;
            #endregion

        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.openConnection();
            string trangThaiThanhToan = "Chưa thanh toán";
            string timeIn = dt_timeIn.Text.ToString();
            string timeOut = dt_TimeOut.Text.ToString();
            int tongCP = Convert.ToInt32(txt_TongChiPhi.Text);
            blDatPhong.insetHoaDon(Maphong, timeIn, timeOut, trangThaiThanhToan, tongCP);

            string trangThaiThanhToan1 = "Đang thuê";
            string tenKhach = txt_TenKhach.Text;
            string cmnd = txt_cmnd.Text;
            string sdt = txt_SDt.Text;
            string ghichu = txt_ghiChu.Text;
            blDatPhong.insetKhachHang(tenKhach, cmnd, sdt, Maphong, ghichu, trangThaiThanhToan1);

            string trangthaiphong = "Đang thuê";
            blDatPhong.updatePhong(trangthaiphong,Maphong);
                
            this.Close();

        }
    }
}
