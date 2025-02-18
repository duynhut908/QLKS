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
    public partial class ThemPhong : Form
    {
        ConnectDatabase db = new ConnectDatabase();
        BLThemPhong blDP = new BLThemPhong();
        public ThemPhong()
        {
            InitializeComponent();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string trangThai = "Còn trống";
            string tenPhong = txt_TenPhong.Text;
            string loaiPhong = cbb_Loai.Text;
            blDP.themPhong(tenPhong,trangThai,loaiPhong);
            this.Close();
        }
    }
}
