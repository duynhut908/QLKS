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
    public partial class TraPhong : Form
    {
        ConnectDatabase db = new ConnectDatabase();
        private string Maphong;
        private string Trangthai;
        private string Loaiphong;
        public TraPhong(string maphong, string trangthai, string loaiphong)
        {
            InitializeComponent();
            this.Maphong = maphong;
            this.Trangthai = trangthai;
            this.Loaiphong = loaiphong;
        }

        private void LoadDGVTien()
        {
            db.openConnection();
            SqlCommand command = new SqlCommand("select MaBill from khachhang where phong = '" + Maphong + "'", db.getConnection);
            int maBill = (int)command.ExecuteScalar();

            command = new SqlCommand("select * from hoadonct where MaBill = '"+maBill+"'", db.getConnection);
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Refresh();
            db.closeConnection();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }



        private void TraPhong_Load(object sender, EventArgs e)
        {
            txtPhong.Text = Maphong;
            txtPhong.Enabled = false;
            db.openConnection();
            SqlCommand command = new SqlCommand("select HoTen from khachhang where phong = '"+Maphong+"'", db.getConnection);
            string hoTen = command.ExecuteScalar().ToString();
            txtTenKhachHang.Text = hoTen;
            txtTenKhachHang.Enabled = false;

            command = new SqlCommand("select CMND from khachhang where phong = '" + Maphong + "'", db.getConnection);
            string Cmnd = command.ExecuteScalar().ToString();
            txtCMND.Text = Cmnd;
            txtCMND.Enabled = false;

            command = new SqlCommand("select Checkin from hoadon where phong = '"+Maphong+"'", db.getConnection);
            string timeIn = command.ExecuteScalar().ToString(); 
            dateTimePicker1.Text = timeIn;
            dateTimePicker1.Enabled = false;

            command = new SqlCommand("select Checkout from hoadon where phong = '" + Maphong + "'", db.getConnection);
            string timeOut = command.ExecuteScalar().ToString();
            dateTimePicker2.Text = timeOut;
            dateTimePicker2.Enabled = false;

            command = new SqlCommand("select ChiPhi from typephong where TypePhong = '" + Loaiphong + "'", db.getConnection);
            int giaphong1 = Convert.ToInt32(command.ExecuteScalar());
            txtGia.Text = giaphong1.ToString();
            txtGia.Enabled = false;

            command = new SqlCommand("select ThanhToan from hoadon where Phong = '" + Maphong + "'", db.getConnection);
            int giaphong = Convert.ToInt32(command.ExecuteScalar());
            lbTongTien.Text = giaphong.ToString() +" VND";

            db.closeConnection();
            LoadDGVTien();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            db.openConnection();

            SqlCommand cmd = new SqlCommand("select ID from hoadon where phong = '" + Maphong + "' and TrangThai = 'Chưa thanh toán'", db.getConnection);
            int mahoadon = Convert.ToInt32(cmd.ExecuteScalar());
            //MessageBox.Show(mahoadon.ToString());

            string trangthai = "Đã thanh toán";
            cmd = new SqlCommand("UPDATE hoadon SET TrangThai = N'" + trangthai + "' WHERE ID = '" + mahoadon + "'; ", db.getConnection);
            cmd.ExecuteNonQuery();

            string trangthai1 = "Còn trống";
            cmd = new SqlCommand("UPDATE phong SET TrangThai = N'" + trangthai1 + "' WHERE MaPhong = '" + Maphong + "'; ", db.getConnection);
            cmd.ExecuteNonQuery();

            string trangthai2 = "Trả phòng";
            cmd = new SqlCommand("UPDATE khachhang SET TrangThai = N'"+trangthai2+"' WHERE MaBill = '"+ mahoadon + "'; ", db.getConnection);
            cmd.ExecuteNonQuery();

            db.closeConnection();
        }
    }
}
