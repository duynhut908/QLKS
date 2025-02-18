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
using DoAnCuoiKy.CUF;

namespace DoAnCuoiKy
{
    public partial class Form1 : Form
    {
        private ConnectDatabase db = new ConnectDatabase();

        public Form1()
        {
            InitializeComponent();
        }

        public void List_Room()
        {

            db.openConnection();
            SqlCommand command = new SqlCommand("select * from phong", db.getConnection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Phong ph = new Phong(reader.GetValue(0).ToString(), reader.GetValue(1).ToString(), reader.GetValue(2).ToString());
                ph.AutoSize = true;
                if(reader.GetValue(1).ToString().Trim() == "Đang thuê")
                    ph.BackColor = Color.IndianRed;
                else if(reader.GetValue(1).ToString().Trim() == "Đã đặt")
                    ph.BackColor= Color.YellowGreen;
                else
                    ph.BackColor = Color.White;
                pn_Main.Controls.Add(ph);
            }
            db.closeConnection();
        }
        private void btn_Phong_Click(object sender, EventArgs e)
        {
            uc_BangPhanCong.SendToBack();
            uc_DichVu.SendToBack();
            uc_KhachHang.SendToBack();
            uc_QuanLyNhanVien.SendToBack();
            uc_QuanLyHoaDon.SendToBack();
            uc_LichSuLamViec.SendToBack();
            uc_CaiDat.SendToBack();
            uc_ThongKe.SendToBack();
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            uc_KhachHang.BringToFront();

        }

        private void btn_DichVu_Click(object sender, EventArgs e)
        {
            uc_DichVu.BringToFront();
        }

        private void btn_PhanCong_Click(object sender, EventArgs e)
        {
            uc_BangPhanCong.BringToFront();
        }

        private void btn_LichSuLamViec_Click(object sender, EventArgs e)
        {
            uc_LichSuLamViec.BringToFront();
        }

        private void btn_QuanLyNhanVien_Click(object sender, EventArgs e)
        {
            uc_QuanLyNhanVien.BringToFront();
        }

        private void btn_QuanLyHoaDon_Click(object sender, EventArgs e)
        {
            uc_QuanLyHoaDon.BringToFront();
        }

        private void btn_CaiDat_Click(object sender, EventArgs e)
        {
            uc_CaiDat.BringToFront();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List_Room();
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            uc_ThongKe.BringToFront();
        }

        private void pn_Main_Enter(object sender, EventArgs e)
        {
            
        }

        private void pn_Main_MouseClick(object sender, MouseEventArgs e)
        {
            pn_Main.Controls.Clear();
            List_Room();
        }
    }
}
