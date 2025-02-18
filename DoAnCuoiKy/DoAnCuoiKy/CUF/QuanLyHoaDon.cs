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
    public partial class QuanLyHoaDon : UserControl
    {
        ConnectDatabase db = new ConnectDatabase();
        public QuanLyHoaDon()
        {
            InitializeComponent();
        }
        private void LoadCbbPhong()
        {
            db.openConnection();
            SqlCommand command = new SqlCommand("select MaPhong from phong where TrangThai = N'Đang thuê'", db.getConnection);
            var dr = command.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            comboBox1.DisplayMember = "MaPhong";
            comboBox1.DataSource = dt;
            db.closeConnection();
        }

        private void LoadDGVKhachHang1()
        {
            db.openConnection();
            int mabill = Convert.ToInt32(comboBox1.Text);
            //MessageBox.Show(mabill.ToString());
            SqlCommand command = new SqlCommand("select * from khachhang where Phong ='" + mabill + "'", db.getConnection);
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Refresh();
            db.closeConnection();
        }

        private void LoadDGVKhachHang2()
        {
            db.openConnection();
            string trangthai = comboBox2.Text;
            //MessageBox.Show(mabill.ToString());
            SqlCommand command = new SqlCommand("select * from khachhang where TrangThai =N'" + trangthai + "'", db.getConnection);
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Refresh();
            db.closeConnection();
        }




        private void QuanLyHoaDon_Load(object sender, EventArgs e)
        {
            LoadCbbPhong();
            //LoadDGVKhachHang();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadDGVKhachHang1();
        }

        private void btnHTTT_Click(object sender, EventArgs e)
        {
            LoadDGVKhachHang2();
        }
    }
}
