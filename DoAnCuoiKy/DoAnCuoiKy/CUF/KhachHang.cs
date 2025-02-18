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
    public partial class KhachHang : UserControl
    {
        ConnectDatabase db = new ConnectDatabase();
        public KhachHang()
        {
            InitializeComponent();
        }
        #region LoadDatagridview
        private void LoadDGVKhachHang()
        {
            db.openConnection();
            SqlCommand command = new SqlCommand("select * from khachhang", db.getConnection);
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Refresh();
            db.closeConnection();
        }
        #endregion


        #region LoadComboboxPhong
        private void LoadCbbPhong()
        {
            db.openConnection();
            SqlCommand command = new SqlCommand("select MaPhong from phong where TrangThai = N'Còn trống'", db.getConnection);
            var dr = command.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbbPhong.DisplayMember = "MaPhong";
            cbbPhong.DataSource = dt;
            db.closeConnection();
        }
        #endregion

        private void KhachHang_Load(object sender, EventArgs e)
        {
            LoadDGVKhachHang();
            LoadCbbPhong();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string hoTen = txtTenKhachHang.Text;
            string cmnd = txtCMND.Text;
            string sdt = txtSDT.Text;
            string soPhong = cbbPhong.Text.ToString();
            string trangThaiThanhToan = "Chưa thanh toán";
            db.openConnection();
            SqlCommand command = new SqlCommand("insert into hoadon values ('" + soPhong + "'," +
                                                "'" + dt_timeIn.Text.ToString() + "','" + dt_TimeOut.Text.ToString() + "','" + trangThaiThanhToan + "','" + Convert.ToInt32(txt_TongChiPhi.Text) + "')", db.getConnection);
            //MessageBox.Show(soPhong);
            command.ExecuteNonQuery();

            string trangThaiThanhToan1 = "Đã đặt";

            command = new SqlCommand("UPDATE phong SET TrangThai = N'"+trangThaiThanhToan1+"' WHERE MaPhong = '"+soPhong+"'; ", db.getConnection);
            command.ExecuteNonQuery();
            command = new SqlCommand("insert into khachhang values (N'" + txtTenKhachHang.Text + "'," +
                                                "'" + txtCMND.Text + "','" + txtSDT.Text + "','" + soPhong + "',N'" + txtGhicHu.Text + "',N'" + trangThaiThanhToan1 + "')", db.getConnection);
            command.ExecuteNonQuery();
            db.closeConnection();
            LoadDGVKhachHang();
            LoadCbbPhong();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dt_TimeOut_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan time = Convert.ToDateTime(dt_TimeOut.Text) - Convert.ToDateTime(dt_timeIn.Text);
            
            string soPhong = cbbPhong.Text.ToString();
            db.openConnection();
            SqlCommand command = new SqlCommand("select LoaiPhong from phong where MaPhong = '"+soPhong+"'", db.getConnection);
            string loaiPhong = (string)command.ExecuteScalar();
            
            command = new SqlCommand("select ChiPhi from typephong where TypePhong = '" + loaiPhong + "'", db.getConnection);
            int giaphong = Convert.ToInt32(command.ExecuteScalar());
            db.closeConnection();
            txt_TongChiPhi.Text = (time.Days * giaphong).ToString();
            txt_TongChiPhi.Enabled = false;
            
            
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            LoadCbbPhong();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int maBill = Convert.ToInt32( dataGridView1.CurrentRow.Cells[0].Value);
            //MessageBox.Show(maBill.ToString());
            txt_maHoaDon.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_maHoaDon.Enabled = false;
            cbbPhong.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtTenKhachHang.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtCMND.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtSDT.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtGhicHu.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            db.openConnection();
            SqlCommand sqlCommand = new SqlCommand("select ThanhToan from hoadon where ID = '"+maBill+"'", db.getConnection);
            int thanhToan = Convert.ToInt32(sqlCommand.ExecuteScalar().ToString());
            txt_TongChiPhi.Text = thanhToan.ToString();
            //MessageBox.Show(thanhToan.ToString());
            db.closeConnection();


        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void KhachHang_Click(object sender, EventArgs e)
        {

        }
    }
}
