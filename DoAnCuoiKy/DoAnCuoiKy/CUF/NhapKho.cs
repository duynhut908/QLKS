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

namespace DoAnCuoiKy.CUF
{
    public partial class NhapKho : Form
    {
        ConnectDatabase db = new ConnectDatabase();
        
        #region Load cbbTenHang
        private void LoadCbbTenHang()
        {
            db.openConnection();
            SqlCommand command = new SqlCommand("select * from dv", db.getConnection);
            var dr = command.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbb_TenHang.DisplayMember = "TenDv";
            //cbb_Phong.ValueMember = "MaPhong";
            cbb_TenHang.ValueMember = "MaDv";
            cbb_TenHang.DataSource = dt;
            db.closeConnection();
        }
        #endregion

        private void LoadDichVu()
        {
            db.openConnection();
            string maDv = cbb_TenHang.SelectedValue.ToString();
            int mDV = Convert.ToInt32(maDv);
            SqlCommand cmd = new SqlCommand("select GhiChu from dv WHERE MaDv = '" + maDv + "'; ", db.getConnection);
            string ghiChu = cmd.ExecuteScalar().ToString();
            label5.Text = ghiChu;
            db.closeConnection();
        }


        #region ppForm
        public NhapKho()
        {
            InitializeComponent();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            db.openConnection();
            string maDv = cbb_TenHang.SelectedValue.ToString();
            int mDV = Convert.ToInt32(maDv);
            SqlCommand cmd = new SqlCommand("select SoLuong from dv WHERE MaDv = '" + maDv + "'; ", db.getConnection);
            int soLuong = Convert.ToInt32(cmd.ExecuteScalar());
            decimal value = numericUpDown1.Value;
            int soLuongNew = (int)(value + soLuong);

            int donGia = Convert.ToInt32(txtGia.Text);

            
            //MessageBox.Show(soLuongNew.ToString());

            cmd = new SqlCommand("UPDATE dv SET SoLuong = '"+soLuongNew+ "',Gia = '" + donGia + "' WHERE MaDv = '" + maDv+"'; ", db.getConnection);
            cmd.ExecuteNonQuery();
            db.closeConnection();

            this.Close();
        }

        private void NhapKho_Load(object sender, EventArgs e)
        {
            LoadCbbTenHang();
        }
        #endregion

        private void NhapKho_MouseMove(object sender, MouseEventArgs e)
        {
            LoadDichVu();
        }
    }
}
