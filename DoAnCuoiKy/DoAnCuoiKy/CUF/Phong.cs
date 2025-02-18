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
    public partial class Phong : UserControl
    {
        BLPhong blPhong = new BLPhong();
        ConnectDatabase db = new ConnectDatabase();
        private string Maphong;
        private string Trangthai;
        private string Loaiphong;
        public Phong(string maphong, string trangthai, string loaiphong)
        {
            InitializeComponent();
            this.Maphong = maphong;
            this.Trangthai = trangthai;
            this.Loaiphong = loaiphong;  
        }
        public void LoadPhong()
        {
            lb_Loaiphong.Text = blPhong.LoadDuLieuPhong(Loaiphong);
            lb_maphong.Text = "Phòng " + Maphong;
            lb_trangthai.Text = Trangthai;
            if (lb_trangthai.Text.Trim() == "Đang thuê")
                btn_Dat.Enabled = false;
        }

        private void Phong_Load(object sender, EventArgs e)
        {
            LoadPhong();
        }

        private void btn_Dat_Click(object sender, EventArgs e)
        {
            DatPhong dat = new DatPhong(Maphong, Trangthai,Loaiphong) ;
            dat.ShowDialog();
            
        }

        private void btn_Tra_Click(object sender, EventArgs e)
        {
            TraPhong tra = new TraPhong(Maphong, Trangthai, Loaiphong);
            tra.Show();
        }

        
        private void thênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemPhong them = new ThemPhong();
            them.Show();
        }

        private void Phong_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Right)
            {
                ThemSuaXoa.Show(PointToScreen(e.Location));
            }    
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            db.openConnection();
            blPhong.XoaPhong(Maphong);
            db.closeConnection();
        }
    }
}
