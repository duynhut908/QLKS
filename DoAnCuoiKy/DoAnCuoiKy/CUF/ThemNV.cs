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
    public partial class ThemNV : Form
    {
        BLThemNV blTNV = new BLThemNV();
        ConnectDatabase db = new ConnectDatabase();
        public ThemNV()
        {
            InitializeComponent();
        }
        public ThemNV(int x)
        {
            InitializeComponent();
            label1.Text = "Sửa Nhân Viên";
            txtID.Text = x.ToString();
            txtHoVaTen.Text = blTNV.layHoTen(x);
            dateTimePicker1.Text = blTNV.layNgaySinh(x);
            cbbGioiTinh.Text = blTNV.layGioiTinh(x);
            txtCMND.Text = blTNV.layCMND(x);
            txtSoDT.Text = blTNV.laySDT(x);
            txtDiaChi.Text = blTNV.layDiaChi(x);
            cbbChucVu.Text = blTNV.layChucVu(x);
        }

        public ThemNV(int x,int y)
        {
            InitializeComponent();
            label1.Text = "Xóa Nhân Viên";
            txtID.Text = x.ToString();
            txtID.Enabled = false;

            txtHoVaTen.Text = blTNV.layHoTen(x);
            txtHoVaTen.Enabled = false;

            dateTimePicker1.Text = blTNV.layNgaySinh(x);
            dateTimePicker1.Enabled = false;

            cbbGioiTinh.Text = blTNV.layGioiTinh(x);
            cbbGioiTinh.Enabled = false;

            txtCMND.Text = blTNV.layCMND(x);
            txtCMND.Enabled = false;

            txtSoDT.Text = blTNV.laySDT(x);
            txtSoDT.Enabled = false;

            txtDiaChi.Text = blTNV.layDiaChi(x);
            txtDiaChi.Enabled = false;

            cbbChucVu.Text = blTNV.layChucVu(x);
            cbbChucVu.Enabled = false;

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void themNhanVien()
        {
            string Id = txtID.Text;
            int id = Convert.ToInt32(Id);

            string hoTen = txtHoVaTen.Text;
            string ngaySinh = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            string gioiTinh = cbbGioiTinh.Text;
            string cmnd = txtCMND.Text;
            string sdt = txtSoDT.Text;
            string diaChi = txtDiaChi.Text;
            string chucVu = cbbChucVu.Text;
            blTNV.insertNV(id, hoTen, ngaySinh, gioiTinh, cmnd, sdt, diaChi, chucVu);
        }
        private void suaNhanVien()
        {
            string Id = txtID.Text;
            txtID.Enabled = false;
            int id = Convert.ToInt32(Id);

            string hoTen = txtHoVaTen.Text;
            string ngaySinh = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            string gioiTinh = cbbGioiTinh.Text;
            string cmnd = txtCMND.Text;
            string sdt = txtSoDT.Text;
            string diaChi = txtDiaChi.Text;
            string chucVu = cbbChucVu.Text;

            blTNV.updateNV(id, hoTen, ngaySinh, gioiTinh, cmnd, sdt,diaChi, chucVu);

        }

        private void xoaNhanVien()
        {
            string Id = txtID.Text;
            txtID.Enabled = false;
            int id = Convert.ToInt32(Id);
            blTNV.xoaNV(id);

        }

        private void btnXong_Click(object sender, EventArgs e)
        {
            if(label1.Text == "Sửa Nhân Viên")
                {
                    suaNhanVien();
                }    
            else if(label1.Text == "Xóa Nhân Viên")
                {
                    xoaNhanVien();
                }
            else
            {
                themNhanVien();
            }
            this.Close();   
        }
    }
}
